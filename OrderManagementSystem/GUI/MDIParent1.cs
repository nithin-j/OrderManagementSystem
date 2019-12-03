using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HiTech.Business;

namespace OrderManagementSystem.GUI
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userChoise = Convert.ToInt32(MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (userChoise == 6)
            {
                Login userlogin = new Login();
                this.Close();
                userlogin.Show();
            }

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            UserPermissions userPermissions = new UserPermissions();
            User user = new User();
            int usertypeID = user.GetUserType(user);

            LoadUserForms(usertypeID);

        }

        private void LoadUserForms(int userTypeID)
        {
            switch (userTypeID)
            {

                case 2:
                    menuManageEmployee.Visible = true;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }
        }

        private void menuManageEmployee_Click(object sender, EventArgs e)
        {
            ManageUser user = new ManageUser();
            user.Show();
            user.MdiParent = this;
        }

        private void menuManageAccount_Click(object sender, EventArgs e)
        {
            ManageAccount account = new ManageAccount();
            account.Show();
            account.MdiParent = this;
        }

        
    }
}
