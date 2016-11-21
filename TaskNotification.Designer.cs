namespace Reminder_desktop_application
{
    partial class TaskNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskNotification));
            this.doneLink = new MetroFramework.Controls.MetroLink();
            this.notificationBox = new MetroFramework.Controls.MetroTextBox();
            this.laterLabel = new MetroFramework.Controls.MetroLabel();
            this.laterCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.laterGroupBox = new System.Windows.Forms.GroupBox();
            this.minutesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.laterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneLink
            // 
            this.doneLink.Image = ((System.Drawing.Image)(resources.GetObject("doneLink.Image")));
            this.doneLink.ImageSize = 45;
            this.doneLink.Location = new System.Drawing.Point(198, 17);
            this.doneLink.Name = "doneLink";
            this.doneLink.Size = new System.Drawing.Size(64, 48);
            this.doneLink.TabIndex = 4;
            this.doneLink.UseSelectable = true;
            this.doneLink.Click += new System.EventHandler(this.doneLink_Click);
            // 
            // notificationBox
            // 
            // 
            // 
            // 
            this.notificationBox.CustomButton.Image = null;
            this.notificationBox.CustomButton.Location = new System.Drawing.Point(132, 2);
            this.notificationBox.CustomButton.Name = "";
            this.notificationBox.CustomButton.Size = new System.Drawing.Size(101, 101);
            this.notificationBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.notificationBox.CustomButton.TabIndex = 1;
            this.notificationBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.notificationBox.CustomButton.UseSelectable = true;
            this.notificationBox.CustomButton.Visible = false;
            this.notificationBox.Enabled = false;
            this.notificationBox.Lines = new string[0];
            this.notificationBox.Location = new System.Drawing.Point(26, 83);
            this.notificationBox.MaxLength = 32767;
            this.notificationBox.Multiline = true;
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.PasswordChar = '\0';
            this.notificationBox.ReadOnly = true;
            this.notificationBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.notificationBox.SelectedText = "";
            this.notificationBox.SelectionLength = 0;
            this.notificationBox.SelectionStart = 0;
            this.notificationBox.ShortcutsEnabled = true;
            this.notificationBox.Size = new System.Drawing.Size(236, 106);
            this.notificationBox.TabIndex = 6;
            this.notificationBox.UseSelectable = true;
            this.notificationBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.notificationBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // laterLabel
            // 
            this.laterLabel.AutoSize = true;
            this.laterLabel.Location = new System.Drawing.Point(6, 31);
            this.laterLabel.Name = "laterLabel";
            this.laterLabel.Size = new System.Drawing.Size(94, 19);
            this.laterLabel.TabIndex = 7;
            this.laterLabel.Text = "Remind me in:";
            // 
            // laterCheckBox
            // 
            this.laterCheckBox.AutoSize = true;
            this.laterCheckBox.Location = new System.Drawing.Point(26, 195);
            this.laterCheckBox.Name = "laterCheckBox";
            this.laterCheckBox.Size = new System.Drawing.Size(110, 15);
            this.laterCheckBox.TabIndex = 8;
            this.laterCheckBox.Text = "Remind me later";
            this.laterCheckBox.UseSelectable = true;
            this.laterCheckBox.CheckedChanged += new System.EventHandler(this.laterCheckBox_CheckedChanged);
            // 
            // laterGroupBox
            // 
            this.laterGroupBox.Controls.Add(this.metroLabel1);
            this.laterGroupBox.Controls.Add(this.minutesComboBox);
            this.laterGroupBox.Controls.Add(this.laterLabel);
            this.laterGroupBox.Enabled = false;
            this.laterGroupBox.Location = new System.Drawing.Point(26, 215);
            this.laterGroupBox.Name = "laterGroupBox";
            this.laterGroupBox.Size = new System.Drawing.Size(236, 53);
            this.laterGroupBox.TabIndex = 9;
            this.laterGroupBox.TabStop = false;
            // 
            // minutesComboBox
            // 
            this.minutesComboBox.FormattingEnabled = true;
            this.minutesComboBox.ItemHeight = 23;
            this.minutesComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "30"});
            this.minutesComboBox.Location = new System.Drawing.Point(106, 19);
            this.minutesComboBox.Name = "minutesComboBox";
            this.minutesComboBox.Size = new System.Drawing.Size(63, 29);
            this.minutesComboBox.TabIndex = 8;
            this.minutesComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "min.";
            // 
            // TaskNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 291);
            this.Controls.Add(this.laterGroupBox);
            this.Controls.Add(this.laterCheckBox);
            this.Controls.Add(this.notificationBox);
            this.Controls.Add(this.doneLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskNotification";
            this.Resizable = false;
            this.Text = "Reminder";
            this.laterGroupBox.ResumeLayout(false);
            this.laterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink doneLink;
        private MetroFramework.Controls.MetroTextBox notificationBox;
        private MetroFramework.Controls.MetroLabel laterLabel;
        private MetroFramework.Controls.MetroCheckBox laterCheckBox;
        private System.Windows.Forms.GroupBox laterGroupBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox minutesComboBox;
    }
}