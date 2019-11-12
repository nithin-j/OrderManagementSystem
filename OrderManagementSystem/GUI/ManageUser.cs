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
    }
}
