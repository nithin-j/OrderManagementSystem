namespace OrderManagementSystem.GUI
{
    partial class MDIParent1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuMainMenu
            // 
            this.menuMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManageEmployee,
            this.menuManageAccount,
            this.menuLogout});
            this.menuMainMenu.Name = "menuMainMenu";
            this.menuMainMenu.Size = new System.Drawing.Size(58, 24);
            this.menuMainMenu.Text = "Menu";
            // 
            // menuManageEmployee
            // 
            this.menuManageEmployee.Name = "menuManageEmployee";
            this.menuManageEmployee.Size = new System.Drawing.Size(216, 26);
            this.menuManageEmployee.Text = "Manage Employee";
            this.menuManageEmployee.Visible = false;
            this.menuManageEmployee.Click += new System.EventHandler(this.menuManageEmployee_Click);
            // 
            // menuManageAccount
            // 
            this.menuManageAccount.Name = "menuManageAccount";
            this.menuManageAccount.Size = new System.Drawing.Size(216, 26);
            this.menuManageAccount.Text = "Manage Account";
            this.menuManageAccount.Click += new System.EventHandler(this.menuManageAccount_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(216, 26);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent1";
            this.Text = "HiTech Order Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuManageEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuManageAccount;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
    }
}



