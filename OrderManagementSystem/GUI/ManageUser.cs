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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.AddEmployee(employee);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

            Login userLogin = new Login();
            userLogin.Show();
        }

        private void cmbRole_Click(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            User user = new User();

            List<string> UserTypes = new List<string>();

            UserTypes = user.GetAllUserTypes();
            foreach (var UserType in UserTypes)
            {
                cmbRole.Items.Add(UserType);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(cmbRole.SelectedIndex != 0)
            {
                User user = new User();
                List<User> userids = new List<User>();
                user.EmployeeID = txtEmployeeID.Text;
                user.UserTypeId = Convert.ToInt32(cmbRole.SelectedIndex) + 1;
                user = user.GenerateUserPassword(user);

                txtUserid.Text = user.UserID;
                txtPassword.Text = user.Password;


                
            }
        }
    }
}
