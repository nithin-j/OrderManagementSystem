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

        private void ManageUser_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            grpManageUser.Enabled = false;
            cmbSearchBy.SelectedIndex = 0;

            PopulateUserTypes();
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
            PopulateUserTypes();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex != 0)
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

        private void btnList_Click(object sender, EventArgs e)
        {
            Employee empl = new Employee();
            List<Employee> employees = empl.ListEmployees();

            if (employees != null)
            {
                lvEmployees.Items.Clear();
                foreach (Employee emp in employees)
                {
                    ListViewItem employeelist = new ListViewItem(emp.EmployeeID);
                    employeelist.SubItems.Add(emp.FirstName);
                    employeelist.SubItems.Add(emp.LastName);
                    employeelist.SubItems.Add(emp.Email);
                    employeelist.SubItems.Add(emp.Phone);
                    employeelist.SubItems.Add(emp.Role);
                    employeelist.SubItems.Add(emp.UserID);

                    lvEmployees.Items.Add(employeelist);
                }

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                grpManageUser.Enabled = false;
                txtEmployeeID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                cmbRole.Items.Clear();
                txtUserid.Clear();
                txtPassword.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int userOption = Convert.ToInt16(cmbSearchBy.SelectedIndex);
            string userInput = txtSearchInput.Text;
            lvEmployees.Enabled = false;
            Employee employee = new Employee();

            if (userOption != 0)
            {
                employee = employee.SearchEmployee(userOption, userInput);
                if (employee != null)
                {
                    lvEmployees.Items.Clear();


                    txtEmployeeID.Text = employee.EmployeeID.ToString();
                    txtFirstName.Text = employee.FirstName.ToString();
                    txtLastName.Text = employee.LastName.ToString();
                    txtEmail.Text = employee.Email.ToString();
                    txtPhone.Text = employee.Phone.ToString();

                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    grpManageUser.Enabled = true;

                }
                else
                {
                    MessageBox.Show("The Employee ID you are looking is not present in the system.", "Invalid EmployeeID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearchInput.Clear();
                    txtSearchInput.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select one option from the drop down and try again.", "No option Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            //validation pending

            employee.EmployeeID = txtEmployeeID.Text;
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.UpdateEmployees(employee);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string empID = txtEmployeeID.Text;

            Employee employee = new Employee();
            employee.DeleteEmployees(empID);
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            string userID = txtUserid.Text;

            User user = new User();
            user.RemoveUser(userID);
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            PopulateUserTypes();
            string userInput = txtSearchUser.Text;
            User user = new User();
            user = user.SearchUser(userInput);

            if (user != null)
            {
                cmbRole.SelectedIndex = user.UserTypeId - 1;
                txtUserid.Text = user.UserID;
                txtPassword.Text = user.Password;

                grpManageUser.Enabled = true;
                btnRemoveUser.Enabled = true;
                btnGenerate.Enabled = false;
            }
        }

        private void grpManageUser_EnabledChanged(object sender, EventArgs e)
        {
            btnRemoveUser.Enabled = false;
            btnGenerate.Enabled = true;
        }

        private void PopulateUserTypes()
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
    }
}
