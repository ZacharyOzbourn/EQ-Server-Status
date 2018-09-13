using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using EQServerStatus.Classes;
using EQServerStatus.Forms;

namespace EQServerStatus
{
    public partial class MainForm : Form
    {

        private int timeTillServerRefresh;
        private bool minimizeToTrayBool = Properties.Settings.Default.minimizeToTray;
        List<Triggers> userTriggers = Properties.Settings.Default.triggers;
        List<Servers> eqServers;

        public MainForm()
        {
            InitializeComponent();
            // setting up event handlers
            this.refreshServersToolStripMenuItem.Click += delegate { UpdateServerStatus(); };
            this.Resize += delegate { minimizeToTray(); };
            this.openToolStripMenuItem.Click += new System.EventHandler(this.showProgramFromTray);
            this.ServerTreeView.AfterSelect += delegate { refreshServerInformation(); };
            // if this is the first time the application has ran on this machine, 
            // our userTriggers will be null.
            if (userTriggers == null)
            {
                userTriggers = new List<Triggers>();
                Properties.Settings.Default.triggers = userTriggers;
                Properties.Settings.Default.Save();
            }
            // expanding all parent tree nodes
            ServerTreeView.ExpandAll();
            // creating an object for each server
            CreateServerObjects();
            // populating the triggersListView box with our saved triggers, if there are any.
            refreshTriggersListView();
            // get initial statuses for everquest servers
            UpdateServerStatus();
            // initialize the timer for server updates
            refreshTimerSetup(0);
        }

        //
        // create server objects
        //

        private void CreateServerObjects()
        {
            // looping through each childNode and creating a server object for each item
            eqServers = new List<Servers>();
            foreach (TreeNode rootNode in ServerTreeView.Nodes)
            {
                foreach (TreeNode childNode in rootNode.Nodes)
                {
                    Servers newServer = new Servers()
                    {
                        serverName = childNode.Tag.ToString()
                    };
                    eqServers.Add(newServer);
                }
            }
        }

        //
        // update server statuses
        //

        private void UpdateServerStatus()
        {
            string serverStatus;
            string serverType;

            WebClient wc = new WebClient();
            try
            {
                // downloading json data from daybreaks census server and creating an object 'pj' with the JSON data
                mainStatusLabel.Text = "Updating server statuses...";
                string jsondata = wc.DownloadString("https://census.daybreakgames.com/json/status/eq");
                JObject pj = JObject.Parse(jsondata);

                // looping through each childNode and updating the childNode properties based
                // on current server status.
                // also updating the properties of each Servers object for the corresponding server
                foreach (TreeNode rootNode in ServerTreeView.Nodes)
                {
                    foreach (TreeNode childNode in rootNode.Nodes)
                    {
                        //finding our Servers object for this particular server
                        Servers currentServer = eqServers.FirstOrDefault(x => x.serverName == childNode.Tag.ToString());

                        if (childNode.Tag.ToString() == "Beta")
                        {
                            serverType = "Beta";
                        }
                        else if (childNode.Tag.ToString() == "Test")
                        {
                            serverType = "Test";
                        }
                        else
                        {
                            serverType = "Live";
                        }

                        // pulling the status for the server in this loop from JSON 'pj' object
                        serverStatus = pj["eq"][serverType][childNode.Tag]["status"].ToString();

                        // updating properties for this specific Servers object
                        currentServer.lastUpdated = Int32.Parse(pj["eq"][serverType][childNode.Tag]["ageSeconds"].ToString());

                        // creating a ServerDataPoints object for this time/status/server combination
                        ServerDataPoints addCurrentDataPoint = new Classes.ServerDataPoints { historyTime = DateTime.Now, historyDataPoint = serverStatus };
                        currentServer.serverHistoryData.Insert(0, addCurrentDataPoint);

                        if (!string.IsNullOrWhiteSpace(serverStatus))
                        {

                            // looping through each Triggers object in userTriggers and checking 
                            // if we should fire the processTrigger event
                            foreach (Triggers t in userTriggers)
                            {
                                if (t.Server == childNode.Tag.ToString() && t.StatusFrom == childNode.ToolTipText && t.StatusTo == serverStatus)
                                {
                                    processTrigger(t);
                                    GeneralLogListBox.Items.Insert(0, getTimestamp() + "Trigger for server " + t.Server.ToString() + " processed.");
                                }
                            }

                            // updating the childNode based on what we found the server population/status to be
                            switch (serverStatus)
                            {
                                case "low":
                                    childNode.ToolTipText = "low";
                                    childNode.ImageIndex = 3;
                                    childNode.SelectedImageIndex = 3;
                                    break;
                                case "medium":
                                    childNode.ToolTipText = "medium";
                                    childNode.ImageIndex = 2;
                                    childNode.SelectedImageIndex = 2;
                                    break;
                                case "high":
                                    childNode.ToolTipText = "high";
                                    childNode.ImageIndex = 1;
                                    childNode.SelectedImageIndex = 1;
                                    break;
                                case "locked":
                                    childNode.ToolTipText = "locked";
                                    childNode.ImageIndex = 4;
                                    childNode.SelectedImageIndex = 4;
                                    break;
                                case "down":
                                    childNode.ToolTipText = "down";
                                    childNode.ImageIndex = 6;
                                    childNode.SelectedImageIndex = 6;
                                    break;
                                default:
                                    childNode.ToolTipText = "Can't locate server data...";
                                    childNode.ImageIndex = 5;
                                    childNode.SelectedImageIndex = 5;
                                    break;
                            }
                        }
                        else
                        {
                            ErrorLogListBox.Items.Insert(0, getTimestamp() + "Error with " + childNode.Tag);
                        }
                    }
                }
                mainStatusLabel.Text = "Idle";
                GeneralLogListBox.Items.Insert(0, getTimestamp() + "Server statuses successfully updated.");
            }
            catch (Exception e)
            {
                ErrorLogListBox.Items.Insert(0, getTimestamp() +  e.Message);
                mainStatusLabel.Text = "ERROR: Check error log for details.";
            }
        }

        // create/update serverRefresh timer object
        private void refreshTimerSetup(int refreshTime)
        {
            serverRefreshTimer.Interval = 1000;
            serverRefreshTimer.Enabled = true;
            if (refreshTime > 29 && refreshTime < 10000)
            {
                timeTillServerRefresh = refreshTime;
                GeneralLogListBox.Items.Insert(0, getTimestamp() + "Set refresh timer to " + refreshTime + "s");
            }
            else
            {
                timeTillServerRefresh = Properties.Settings.Default.refreshTime;
                GeneralLogListBox.Items.Insert(0, getTimestamp() + "Set refresh timer to " + Properties.Settings.Default.refreshTime + "s");
            }
        }
        
        private void ServerRefreshTimer_Tick(object sender, EventArgs e)
        {
            int minutes;
            int seconds;

            // each 1 second tick of the timer, we are decreasing our timeTillServerRefresh property by 1
            // next, we are updating the status label in a readable format
            timeTillServerRefresh -= 1;
            minutes = timeTillServerRefresh / 60;
            seconds = timeTillServerRefresh % 60;
            nextUpdateStatusLabel.Text = minutes.ToString() + ":" + seconds.ToString("00");

            // if we've run out of time, updating the server statuses and refreshing the 
            // server information page for currently selected childNode
            if (timeTillServerRefresh == 0)
            {
                UpdateServerStatus();
                timeTillServerRefresh = Properties.Settings.Default.refreshTime;
                refreshServerInformation();
            }
        }

        private void serverTreeViewNodeClick(object sender, TreeViewCancelEventArgs e)
        {
            // when we click a node, if it's a parent node we are denying the selection
            if (e.Node == ServerTreeView.Nodes[0] || e.Node == ServerTreeView.Nodes[1] || e.Node == ServerTreeView.Nodes[2])
            {
                e.Cancel = true;
            } 
        }

        //
        // refresh objects subs
        //

        private void refreshTriggersListView()
        {
            // clears all items from the list view
            triggersListView.Items.Clear();

            // ensuring our userTriggers list is current
            userTriggers = Properties.Settings.Default.triggers;

            // if there are objects in the userTriggers list, populationg the triggersListView object
            if (userTriggers != null && userTriggers.Count > 0)
            {
                foreach (Triggers t in userTriggers)
                {
                    var lvi = new ListViewItem();
                    lvi.Text = t.Server;
                    lvi.SubItems.Add(t.StatusFrom);
                    lvi.SubItems.Add(t.StatusTo);
                    lvi.SubItems.Add(t.AlertRepeating.ToString());

                    triggersListView.Items.Insert(0, lvi);
                }
            }
        }

        // refreshes the server information tab for currently selected childNode
        private void refreshServerInformation()
        {
            TreeNode tn = ServerTreeView.SelectedNode;
            if (tn != null)
            {
                int minutes;
                int seconds;

                Servers currentServer = eqServers.FirstOrDefault(x => x.serverName == tn.Tag.ToString());
                serverNameLabel.Text = tn.Text;
                minutes = currentServer.lastUpdated / 60;
                seconds = currentServer.lastUpdated % 60;
                serverLastUpdatedLabel.Text = "This servers data was updated " + minutes.ToString() + "m " + seconds.ToString() + "s before last server refresh.";
                serverHistoryListView.Items.Clear();

                // populating the serverHistoryListView with each ServerDataPoints object for the current server
                foreach (ServerDataPoints sdp in currentServer.serverHistoryData)
                {
                    var lvi = new ListViewItem();
                    lvi.Text = sdp.historyTime.ToString();
                    lvi.SubItems.Add(sdp.historyDataPoint);

                    serverHistoryListView.Items.Insert(0, lvi);
                }
            }
        }

        //
        // trigger creation/deletion/execution subs
        //

        private void triggerCreationCreateButton_Click(object sender, EventArgs e)
        {
            // ensuring each user has made a selection in each combo box
            if (!string.IsNullOrWhiteSpace(triggerCreationServerSelectComboBox.Text) && !string.IsNullOrWhiteSpace(triggerCreationStatusFromComboBox.Text) && !string.IsNullOrWhiteSpace(triggerCreationStatusToComboBox.Text) && !string.IsNullOrWhiteSpace(triggerCreationAlertOnceComboBox.Text) && !string.IsNullOrWhiteSpace(triggerCreationAlertOnceComboBox.Text))
            {
                bool alertRepeatingSetting;

                if (triggerCreationAlertOnceComboBox.Text == "Always")
                {
                    alertRepeatingSetting = true;
                }
                else
                {
                    alertRepeatingSetting = false;
                }

                // creating a new Triggers object based on users input
                Triggers newTrigger = new Triggers()
                {
                    Server = triggerCreationServerSelectComboBox.Text,
                    StatusFrom = triggerCreationStatusFromComboBox.Text,
                    StatusTo = triggerCreationStatusToComboBox.Text,
                    AlertRepeating = alertRepeatingSetting
                };

                // ensuring the new Triggers object is free of errors
                // if no errors, add the object to the userTriggers list and save updated list in settings
                if (!checkTriggerForErrors(newTrigger))
                {
                    userTriggers.Add(newTrigger);
                    Properties.Settings.Default.triggers = userTriggers;
                    Properties.Settings.Default.Save();
                    refreshTriggersListView();
                    clearCreateTriggerForm();
                }
            }
            else
            {
                MessageBox.Show("Error: You must fill in all values to create an alert trigger!");
            }
        }

        private bool checkTriggerForErrors(Triggers newTrigger)
        {

            // looping through each trigger in userTriggers to ensure the trigger we 
            // are trying to create is not a duplicate
                foreach (Triggers t in userTriggers)
                {
                    if (t.Server == newTrigger.Server && t.StatusFrom == newTrigger.StatusFrom && t.StatusTo == newTrigger.StatusTo)
                    {
                        MessageBox.Show("Error: Duplicate trigger!" + Environment.NewLine + Environment.NewLine + "If you are trying to change your Alert method or frequency, please delete the previous trigger for Server " + t.Server + " with Status From of " + t.StatusFrom + " and Status To of " + t.StatusTo + " and create a new trigger.");
                        return true;
                    }
                }

            // ensuring the status to and status from properties are not the same
            if (newTrigger.StatusFrom == newTrigger.StatusTo)
            {
                MessageBox.Show("Your trigger cannot have the same Status From and Status To properties!");
                return true;
            }

            // if we reach this point, the new Triggers object is valid and will be created
            return false;
        }

        // clears the combo boxes for our create new trigger tab
        private void clearCreateTriggerForm()
        {
            triggerCreationServerSelectComboBox.ResetText();
            triggerCreationStatusFromComboBox.ResetText();
            triggerCreationStatusToComboBox.ResetText();
            triggerCreationAlertOnceComboBox.ResetText();
        }

        private void triggerRemoveSelectedTriggerButton_Click(object sender, EventArgs e)
        {
            // if user clicks remove trigger button while no trigger is selected, throwing
            // an error.  if a trigger is selected, calling the reoveTriggerFromList sub
            if (triggersListView.SelectedItems.Count > 0)
            {
                removeTriggerFromList(null);
            }
            else
            {
                MessageBox.Show("Error: You must select a trigger from the 'My Triggers' box in order to remove a trigger!");
            }
        }

        private void removeTriggerFromList(Triggers t)
        {
            // if the call came from the processTrigger sub, we passed the trigger to remove to this sub
            // otherwise, the call came from the delete trigger button, in which case we need to locate the trigger selected
            if (t == null)
            {
                ListViewItem itemToRemove = triggersListView.SelectedItems[0];
                userTriggers.RemoveAll(x => x.Server == itemToRemove.Text && x.StatusFrom == itemToRemove.SubItems[1].Text && x.StatusTo == itemToRemove.SubItems[2].Text);
                GeneralLogListBox.Items.Insert(0, getTimestamp() + "The trigger for " + itemToRemove.Text + " from " + itemToRemove.SubItems[1].Text + " to " + itemToRemove.SubItems[2].Text + " has been removed!");
            }
            else
            {
                userTriggers.Remove(t);
                GeneralLogListBox.Items.Insert(0, getTimestamp() + "The trigger for " + t.Server + " from " + t.StatusFrom + " to " + t.StatusTo + " has been removed!");
            }

            // updating our settings, and calling the refreshTriggersListView sub to update the serverTreeView
            Properties.Settings.Default.triggers = userTriggers;
            Properties.Settings.Default.Save();
            refreshTriggersListView();
        }

        private void processTrigger(Triggers t)
        {
            // a trigger has fired, let's show an alert!
            programNotifyIcon.ShowBalloonTip(1000, t.Server, t.Server + " has moved from a status of " + t.StatusFrom + " to a status of " + t.StatusTo + ".", ToolTipIcon.Info);

            // if the trigger isn't set to repeat, we need to remove from listView and userTriggers list
            if (t.AlertRepeating == false)
            {
                removeTriggerFromList(t);
            }
        }

        //
        // get formatted timestamp
        //

        private string getTimestamp()
        {
            return DateTime.Now.ToString("[MM/dd/yyyy hh:mm:ss] ");
        }

        //
        // minimize to system tray subs
        //

        private void minimizeToTraySetup(bool minimize)
        {
            if (minimize == true)
            {
                minimizeToTrayBool = minimize;
                Properties.Settings.Default.minimizeToTray = minimize;
                Properties.Settings.Default.Save();
            } else
            {
                minimizeToTrayBool = minimize;
                Properties.Settings.Default.minimizeToTray = minimize;
                Properties.Settings.Default.Save();
            }
        }

        private void minimizeToTray()
        {
            if (this.WindowState == FormWindowState.Minimized && minimizeToTrayBool == true)
            {
                Hide();
                programNotifyIcon.Visible = true;
            }
        }

        private void showProgramFromTray(object sender, EventArgs e)
        {
            this.Show();
            programNotifyIcon.Visible = false;
        }

        //
        // application settings form
        //

        private void setRefreshTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ApplicationSettings apps = new ApplicationSettings())
            {
                var result = apps.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int refreshValue = apps.returnRefreshTimer;
                    refreshTimerSetup(refreshValue);
                    bool minimizeValue = apps.returnMinimizeToTray;
                    minimizeToTraySetup(minimizeValue);
                }
            }
        }

        //
        // various menu click subs
        //

        private void eQResourcecomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.eqresource.com");
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TriggerNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void RefreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateServerStatus();
        }
    }
}
