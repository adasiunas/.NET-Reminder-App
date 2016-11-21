namespace Reminder_desktop_application
{
    partial class Reminder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.reminderTabControl = new MetroFramework.Controls.MetroTabControl();
            this.homeTab = new MetroFramework.Controls.MetroTabPage();
            this.reminderDateTime = new MetroFramework.Controls.MetroDateTime();
            this.deleteLink = new MetroFramework.Controls.MetroLink();
            this.addLink = new MetroFramework.Controls.MetroLink();
            this.doneLink = new MetroFramework.Controls.MetroLink();
            this.reminderTasksView = new System.Windows.Forms.ListView();
            this.stratingTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reminderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskDetailsTab = new MetroFramework.Controls.MetroTabPage();
            this.editButton = new MetroFramework.Controls.MetroLink();
            this.timeLabel = new MetroFramework.Controls.MetroLabel();
            this.startLabel = new MetroFramework.Controls.MetroLabel();
            this.detailsLabel = new MetroFramework.Controls.MetroLabel();
            this.detailsBox = new MetroFramework.Controls.MetroTextBox();
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reminderTabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.taskDetailsTab.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reminderTabControl
            // 
            this.reminderTabControl.Controls.Add(this.homeTab);
            this.reminderTabControl.Controls.Add(this.taskDetailsTab);
            this.reminderTabControl.Location = new System.Drawing.Point(23, 63);
            this.reminderTabControl.Name = "reminderTabControl";
            this.reminderTabControl.SelectedIndex = 0;
            this.reminderTabControl.Size = new System.Drawing.Size(234, 377);
            this.reminderTabControl.TabIndex = 0;
            this.reminderTabControl.UseSelectable = true;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.reminderDateTime);
            this.homeTab.Controls.Add(this.deleteLink);
            this.homeTab.Controls.Add(this.addLink);
            this.homeTab.Controls.Add(this.doneLink);
            this.homeTab.Controls.Add(this.reminderTasksView);
            this.homeTab.HorizontalScrollbarBarColor = true;
            this.homeTab.HorizontalScrollbarHighlightOnWheel = false;
            this.homeTab.HorizontalScrollbarSize = 10;
            this.homeTab.Location = new System.Drawing.Point(4, 38);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(226, 335);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Tasks";
            this.homeTab.VerticalScrollbarBarColor = true;
            this.homeTab.VerticalScrollbarHighlightOnWheel = false;
            this.homeTab.VerticalScrollbarSize = 10;
            // 
            // reminderDateTime
            // 
            this.reminderDateTime.Location = new System.Drawing.Point(3, 18);
            this.reminderDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.reminderDateTime.Name = "reminderDateTime";
            this.reminderDateTime.Size = new System.Drawing.Size(209, 29);
            this.reminderDateTime.TabIndex = 5;
            this.reminderDateTime.ValueChanged += new System.EventHandler(this.reminderDateTime_ValueChanged);
            this.reminderDateTime.Enter += new System.EventHandler(this.reminderDateTime_Enter);
            // 
            // deleteLink
            // 
            this.deleteLink.Image = ((System.Drawing.Image)(resources.GetObject("deleteLink.Image")));
            this.deleteLink.ImageSize = 45;
            this.deleteLink.Location = new System.Drawing.Point(107, 287);
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.Size = new System.Drawing.Size(51, 48);
            this.deleteLink.TabIndex = 2;
            this.deleteLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.deleteLink.UseSelectable = true;
            this.deleteLink.Click += new System.EventHandler(this.deleteLink_Click);
            // 
            // addLink
            // 
            this.addLink.Image = ((System.Drawing.Image)(resources.GetObject("addLink.Image")));
            this.addLink.ImageSize = 45;
            this.addLink.Location = new System.Drawing.Point(58, 287);
            this.addLink.Name = "addLink";
            this.addLink.Size = new System.Drawing.Size(51, 48);
            this.addLink.TabIndex = 1;
            this.addLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addLink.UseSelectable = true;
            this.addLink.Click += new System.EventHandler(this.addLink_Click);
            // 
            // doneLink
            // 
            this.doneLink.Image = ((System.Drawing.Image)(resources.GetObject("doneLink.Image")));
            this.doneLink.ImageSize = 45;
            this.doneLink.Location = new System.Drawing.Point(155, 287);
            this.doneLink.Name = "doneLink";
            this.doneLink.Size = new System.Drawing.Size(51, 48);
            this.doneLink.TabIndex = 3;
            this.doneLink.UseSelectable = true;
            this.doneLink.Click += new System.EventHandler(this.doneLink_Click);
            // 
            // reminderTasksView
            // 
            this.reminderTasksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stratingTimeColumn,
            this.reminderColumn});
            this.reminderTasksView.FullRowSelect = true;
            this.reminderTasksView.Location = new System.Drawing.Point(3, 60);
            this.reminderTasksView.MultiSelect = false;
            this.reminderTasksView.Name = "reminderTasksView";
            this.reminderTasksView.Size = new System.Drawing.Size(210, 221);
            this.reminderTasksView.TabIndex = 3;
            this.reminderTasksView.UseCompatibleStateImageBehavior = false;
            this.reminderTasksView.View = System.Windows.Forms.View.Details;
            this.reminderTasksView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.reminderTasksView_MouseDoubleClick);
            // 
            // stratingTimeColumn
            // 
            this.stratingTimeColumn.Text = "Time";
            this.stratingTimeColumn.Width = 50;
            // 
            // reminderColumn
            // 
            this.reminderColumn.Text = "Reminder";
            this.reminderColumn.Width = 153;
            // 
            // taskDetailsTab
            // 
            this.taskDetailsTab.Controls.Add(this.editButton);
            this.taskDetailsTab.Controls.Add(this.timeLabel);
            this.taskDetailsTab.Controls.Add(this.startLabel);
            this.taskDetailsTab.Controls.Add(this.detailsLabel);
            this.taskDetailsTab.Controls.Add(this.detailsBox);
            this.taskDetailsTab.HorizontalScrollbarBarColor = true;
            this.taskDetailsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.taskDetailsTab.HorizontalScrollbarSize = 10;
            this.taskDetailsTab.Location = new System.Drawing.Point(4, 38);
            this.taskDetailsTab.Name = "taskDetailsTab";
            this.taskDetailsTab.Size = new System.Drawing.Size(226, 335);
            this.taskDetailsTab.TabIndex = 1;
            this.taskDetailsTab.VerticalScrollbarBarColor = true;
            this.taskDetailsTab.VerticalScrollbarHighlightOnWheel = false;
            this.taskDetailsTab.VerticalScrollbarSize = 10;
            // 
            // editButton
            // 
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageSize = 45;
            this.editButton.Location = new System.Drawing.Point(173, 250);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 48);
            this.editButton.TabIndex = 6;
            this.editButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editButton.UseSelectable = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(96, 214);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 0);
            this.timeLabel.TabIndex = 5;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(3, 216);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(85, 19);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "Task starts at:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(0, 12);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(50, 19);
            this.detailsLabel.TabIndex = 3;
            this.detailsLabel.Text = "Details:";
            // 
            // detailsBox
            // 
            // 
            // 
            // 
            this.detailsBox.CustomButton.Image = null;
            this.detailsBox.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.detailsBox.CustomButton.Name = "";
            this.detailsBox.CustomButton.Size = new System.Drawing.Size(167, 167);
            this.detailsBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.detailsBox.CustomButton.TabIndex = 1;
            this.detailsBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.detailsBox.CustomButton.UseSelectable = true;
            this.detailsBox.CustomButton.Visible = false;
            this.detailsBox.Enabled = false;
            this.detailsBox.Lines = new string[0];
            this.detailsBox.Location = new System.Drawing.Point(1, 34);
            this.detailsBox.MaxLength = 32767;
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.PasswordChar = '\0';
            this.detailsBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.detailsBox.SelectedText = "";
            this.detailsBox.SelectionLength = 0;
            this.detailsBox.SelectionStart = 0;
            this.detailsBox.ShortcutsEnabled = true;
            this.detailsBox.Size = new System.Drawing.Size(222, 169);
            this.detailsBox.TabIndex = 2;
            this.detailsBox.UseSelectable = true;
            this.detailsBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.detailsBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // notificationIcon
            // 
            this.notificationIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Visible = true;
            this.notificationIcon.BalloonTipClicked += new System.EventHandler(this.notificationIcon_BalloonTipClicked);
            this.notificationIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notificationIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(273, 445);
            this.Controls.Add(this.reminderTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reminder";
            this.Resizable = false;
            this.Text = "Reminder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reminder_FormClosing);
            this.Resize += new System.EventHandler(this.Reminder_Resize);
            this.reminderTabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.taskDetailsTab.ResumeLayout(false);
            this.taskDetailsTab.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTabControl reminderTabControl;
        private MetroFramework.Controls.MetroTabPage homeTab;
        private MetroFramework.Controls.MetroLink addLink;
        private MetroFramework.Controls.MetroLink deleteLink;
        private MetroFramework.Controls.MetroLink doneLink;
        private System.Windows.Forms.ListView reminderTasksView;
        private System.Windows.Forms.ColumnHeader stratingTimeColumn;
        private System.Windows.Forms.ColumnHeader reminderColumn;
        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroDateTime reminderDateTime;
        private MetroFramework.Controls.MetroTabPage taskDetailsTab;
        private MetroFramework.Controls.MetroLabel startLabel;
        private MetroFramework.Controls.MetroLabel detailsLabel;
        private MetroFramework.Controls.MetroTextBox detailsBox;
        private MetroFramework.Controls.MetroLabel timeLabel;
        private MetroFramework.Controls.MetroLink editButton;
    }
}

