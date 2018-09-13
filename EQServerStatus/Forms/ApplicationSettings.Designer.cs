namespace EQServerStatus.Forms
{
    partial class ApplicationSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.cancelSettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.setRefreshTimerMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.minimizeToTrayCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Note: Census only polls the \r\nEverQuest servers once every few \r\nminutes.  So se" +
    "tting a low refresh \r\nrate here won\'t necessarily give \r\nyou the absolute curren" +
    "t statuses. ";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(12, 189);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 2;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.Location = new System.Drawing.Point(115, 189);
            this.cancelSettingsButton.Name = "cancelSettingsButton";
            this.cancelSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSettingsButton.TabIndex = 3;
            this.cancelSettingsButton.Text = "Cancel";
            this.cancelSettingsButton.UseVisualStyleBackColor = true;
            this.cancelSettingsButton.Click += new System.EventHandler(this.cancelSettingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seconds:";
            // 
            // setRefreshTimerMaskedTextBox
            // 
            this.setRefreshTimerMaskedTextBox.Location = new System.Drawing.Point(94, 97);
            this.setRefreshTimerMaskedTextBox.Mask = "0000";
            this.setRefreshTimerMaskedTextBox.Name = "setRefreshTimerMaskedTextBox";
            this.setRefreshTimerMaskedTextBox.Size = new System.Drawing.Size(75, 20);
            this.setRefreshTimerMaskedTextBox.TabIndex = 5;
            // 
            // minimizeToTrayCheckbox
            // 
            this.minimizeToTrayCheckbox.AutoSize = true;
            this.minimizeToTrayCheckbox.Location = new System.Drawing.Point(155, 149);
            this.minimizeToTrayCheckbox.Name = "minimizeToTrayCheckbox";
            this.minimizeToTrayCheckbox.Size = new System.Drawing.Size(15, 14);
            this.minimizeToTrayCheckbox.TabIndex = 6;
            this.minimizeToTrayCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minimize to System Tray:";
            // 
            // ApplicationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minimizeToTrayCheckbox);
            this.Controls.Add(this.setRefreshTimerMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelSettingsButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button cancelSettingsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox setRefreshTimerMaskedTextBox;
        private System.Windows.Forms.CheckBox minimizeToTrayCheckbox;
        private System.Windows.Forms.Label label3;
    }
}