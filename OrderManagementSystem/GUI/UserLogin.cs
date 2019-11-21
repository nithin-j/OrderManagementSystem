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
using HiTech.Validation;

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
            string input = txtUSerID.Text;
            if (!Validator.IsValidID(input))
            {
                txtUSerID.Clear();
                txtPassword.Clear();
                txtUSerID.Focus();
                return;
            }

            input = txtPassword.Text;
            if (!Validator.IsValidPassword(input))
            {
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }
            User user = new User();
            bool isValid;

            user.UserID = txtUSerID.Text;
            user.Password = txtPassword.Text;

            isValid = user.GetUserDetails(user);

            if (isValid)
            {
                this.Hide();
                MDIParent1 mDIParent = new MDIParent1();
                mDIParent.Show();
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
        
    }
}
