namespace OrderManagementSystem.GUI
{
    partial class ManageUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grpManageUser = new System.Windows.Forms.GroupBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpManageEmployees = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpManageUser.SuspendLayout();
            this.grpManageEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(151, 171);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(270, 27);
            this.txtLastName.TabIndex = 4;
            // 
            // grpManageUser
            // 
            this.grpManageUser.Controls.Add(this.btnRemoveUser);
            this.grpManageUser.Controls.Add(this.txtPassword);
            this.grpManageUser.Controls.Add(this.btnGenerate);
            this.grpManageUser.Controls.Add(this.txtUserid);
            this.grpManageUser.Controls.Add(this.label6);
            this.grpManageUser.Controls.Add(this.cmbRole);
            this.grpManageUser.Controls.Add(this.label7);
            this.grpManageUser.Controls.Add(this.label5);
            this.grpManageUser.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManageUser.Location = new System.Drawing.Point(1061, 71);
            this.grpManageUser.Name = "grpManageUser";
            this.grpManageUser.Size = new System.Drawing.Size(668, 245);
            this.grpManageUser.TabIndex = 6;
            this.grpManageUser.TabStop = false;
            this.grpManageUser.Text = "Manage User";
            this.grpManageUser.EnabledChanged += new System.EventHandler(this.grpManageUser_EnabledChanged);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(480, 146);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(128, 43);
            this.btnRemoveUser.TabIndex = 16;
            this.btnRemoveUser.Text = "Remove";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(168, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 27);
            this.txtPassword.TabIndex = 14;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(480, 68);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 43);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtUserid
            // 
            this.txtUserid.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserid.Location = new System.Drawing.Point(168, 116);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(270, 27);
            this.txtUserid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(168, 60);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(270, 30);
            this.cmbRole.TabIndex = 12;
            this.cmbRole.Click += new System.EventHandler(this.cmbRole_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1104, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Search:   (Enter a valid UserID)";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(1541, 334);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(128, 43);
            this.btnSearchUser.TabIndex = 17;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.Location = new System.Drawing.Point(1329, 343);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(183, 27);
            this.txtSearchUser.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(151, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "EmailID: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(151, 277);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(270, 27);
            this.txtPhone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(489, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 43);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(489, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(1411, 439);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(128, 43);
            this.btnList.TabIndex = 17;
            this.btnList.Text = "List All Employees";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(489, 319);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 43);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInput.Location = new System.Drawing.Point(294, 330);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(127, 27);
            this.txtSearchInput.TabIndex = 19;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "<select one>",
            "Employee ID",
            "User ID"});
            this.cmbSearchBy.Location = new System.Drawing.Point(151, 329);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(127, 30);
            this.cmbSearchBy.TabIndex = 20;
            // 
            // lvEmployees
            // 
            this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvEmployees.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployees.GridLines = true;
            this.lvEmployees.HideSelection = false;
            this.lvEmployees.Location = new System.Drawing.Point(300, 509);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(1239, 184);
            this.lvEmployees.TabIndex = 21;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee ID";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email ID";
            this.columnHeader4.Width = 149;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Role";
            this.columnHeader6.Width = 114;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "User ID";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1699, 807);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 49);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(151, 121);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(270, 27);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(151, 67);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(270, 27);
            this.txtEmployeeID.TabIndex = 25;
            this.txtEmployeeID.Tag = "l";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Employee ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Search: ";
            // 
            // grpManageEmployees
            // 
            this.grpManageEmployees.Controls.Add(this.btnDelete);
            this.grpManageEmployees.Controls.Add(this.label8);
            this.grpManageEmployees.Controls.Add(this.label9);
            this.grpManageEmployees.Controls.Add(this.label1);
            this.grpManageEmployees.Controls.Add(this.txtEmployeeID);
            this.grpManageEmployees.Controls.Add(this.label2);
            this.grpManageEmployees.Controls.Add(this.txtFirstName);
            this.grpManageEmployees.Controls.Add(this.txtLastName);
            this.grpManageEmployees.Controls.Add(this.label3);
            this.grpManageEmployees.Controls.Add(this.txtEmail);
            this.grpManageEmployees.Controls.Add(this.cmbSearchBy);
            this.grpManageEmployees.Controls.Add(this.label4);
            this.grpManageEmployees.Controls.Add(this.txtSearchInput);
            this.grpManageEmployees.Controls.Add(this.txtPhone);
            this.grpManageEmployees.Controls.Add(this.btnSearch);
            this.grpManageEmployees.Controls.Add(this.btnAdd);
            this.grpManageEmployees.Controls.Add(this.btnUpdate);
            this.grpManageEmployees.Location = new System.Drawing.Point(109, 38);
            this.grpManageEmployees.Name = "grpManageEmployees";
            this.grpManageEmployees.Size = new System.Drawing.Size(632, 390);
            this.grpManageEmployees.TabIndex = 27;
            this.grpManageEmployees.TabStop = false;
            this.grpManageEmployees.Text = "Manage Employee";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(489, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 43);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1003);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.grpManageEmployees);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lvEmployees);
            this.Controls.Add(this.grpManageUser);
            this.Controls.Add(this.btnList);
            this.DataBindings.Add(new System.Windows.Forms.Binding("WindowState", global::OrderManagementSystem.Properties.Settings.Default, "FormStartUp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ManageUser";
            this.Text = "Manage Employee";
            this.WindowState = global::OrderManagementSystem.Properties.Settings.Default.FormStartUp;
            this.Load += new System.EventHandler(this.ManageUser_Load);
            this.grpManageUser.ResumeLayout(false);
            this.grpManageUser.PerformLayout();
            this.grpManageEmployees.ResumeLayout(false);
            this.grpManageEmployees.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grpManageUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.ListView lvEmployees;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.GroupBox grpManageEmployees;
        private System.Windows.Forms.Button btnDelete;
    }
}