using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OrderManagementSystem.Business;

namespace OrderManagementSystem.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            bool isValid;

            user.UserID = txtUSerID.Text;
            user.Password = txtPassword.Text;

            isValid = user.GetUserDetails(user);

            if (isValid)
            {
                LoadForm(user);
            }
            else
            {
                MessageBox.Show("Invalid UserName/Password","Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadForm(User user)
        {
            int UserTypeID = user.GetUserType(user);
            switch (UserTypeID)
            {
                case 1:
                    MessageBox.Show("Normal user dont have any forms");
                    break;
                case 2:
                    this.Hide();
                    ManageUser manageUser = new ManageUser();
                    manageUser.Show();
                    break;
                case 3:
                    MessageBox.Show("Under Construction");
                    break;
                default:
                    break;
            }
        }
    }
}
