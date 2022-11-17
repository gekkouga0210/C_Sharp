namespace SE1634_Group1_Project.GUI
{
    partial class MainGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ongoingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quizzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accomplishedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.ongoingToolStripMenuItem,
            this.quizzesToolStripMenuItem,
            this.accomplishedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.listToolStripMenuItem.Text = "Home";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // ongoingToolStripMenuItem
            // 
            this.ongoingToolStripMenuItem.Name = "ongoingToolStripMenuItem";
            this.ongoingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ongoingToolStripMenuItem.Text = "On-going";
            this.ongoingToolStripMenuItem.Click += new System.EventHandler(this.ongoingToolStripMenuItem_Click);
            // 
            // quizzesToolStripMenuItem
            // 
            this.quizzesToolStripMenuItem.Name = "quizzesToolStripMenuItem";
            this.quizzesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.quizzesToolStripMenuItem.Text = "Quizzes";
            this.quizzesToolStripMenuItem.Click += new System.EventHandler(this.quizzesToolStripMenuItem_Click);
            // 
            // accomplishedToolStripMenuItem
            // 
            this.accomplishedToolStripMenuItem.Name = "accomplishedToolStripMenuItem";
            this.accomplishedToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.accomplishedToolStripMenuItem.Text = "Accomplished";
            this.accomplishedToolStripMenuItem.Click += new System.EventHandler(this.accomplishedToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(886, 304);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 23);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(886, 329);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(886, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(358, 17);
            this.toolStripStatusLabel1.Text = "SE1634, Group1, Đặng Công Kiên, Đinh Thanh Hà, Trần Hồng Quân";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 373);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainGUI";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.MainGUI_Activated);
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem ongoingToolStripMenuItem;
        private ToolStripMenuItem quizzesToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem accomplishedToolStripMenuItem;
    }
}