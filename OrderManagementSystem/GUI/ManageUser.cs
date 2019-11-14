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
            string input;

            input = txtFirstName.Text;
            if (!Validator.IsValidName(input, 0))
            {
                txtFirstName.Clear();
                txtFirstName.Focus();
                return;
            }
            input = txtLastName.Text;
            if (!Validator.IsValidName(input, 1))
            {
                txtLastName.Clear();
                txtLastName.Focus();
                return;
            }
            input = txtEmail.Text;
            if (!Validator.IsValidEmail(input))
            {
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }
            input = txtPhone.Text;
            if (!Validator.isValidPhone(input))
            {
                txtPhone.Clear();
                txtPhone.Focus();
                return;
            }

            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.AddEmployee(employee);

            foreach (Control ctr in grpManageEmployees.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

                else if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).SelectedIndex = 0;
                }
            }
            MessageBox.Show("New employee added to system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            int ch = Convert.ToInt32(MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (ch == 6)
            {
                this.Close();

                Login userLogin = new Login();
                userLogin.Show();
            }
        }

        private void cmbRole_Click(object sender, EventArgs e)
        {
            PopulateUserTypes();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string input = txtEmployeeID.Text;
            if (!Validator.CheckIfUserIDExists(input))
            {
                btnGenerate.Enabled = false;
                MessageBox.Show($"User ID already generated for the employee: {txtEmployeeID.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txtSearchInput.Clear();
                txtSearchInput.Focus();
                return;
            }
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

            string input = txtFirstName.Text;
            if (!Validator.IsValidName(input, 0))
            {
                txtFirstName.Clear();
                txtFirstName.Focus();
                return;
            }
            input = txtLastName.Text;
            if (!Validator.IsValidName(input, 1))
            {
                txtLastName.Clear();
                txtLastName.Focus();
                return;
            }
            input = txtEmail.Text;
            if (!Validator.IsValidEmail(input))
            {
                txtEmail.Clear();
                txtEmail.Focus();
                return;
            }
            input = txtPhone.Text;
            if (!Validator.isValidPhone(input))
            {
                txtPhone.Clear();
                txtPhone.Focus();
                return;
            }



            employee.EmployeeID = txtEmployeeID.Text;
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Email = txtEmail.Text;
            employee.Phone = txtPhone.Text;
            employee.UpdateEmployees(employee);

            MessageBox.Show("Employee details updated in the system", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string empID = txtEmployeeID.Text;

            if (!Validator.CheckIfUserIDExists(empID))
            {
                
                MessageBox.Show($"User ID already exists for the employee: {txtEmployeeID.Text}. \n" +
                    $"Please try removing the user ID and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnDelete.Enabled = false;
                txtSearchInput.Clear();
                txtSearchInput.Focus();
                return;
            }

            
            Employee employee = new Employee();
            employee.DeleteEmployees(empID);

            MessageBox.Show("Employee details are removed from the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (txtSearchUser.Text == "")
            {
                MessageBox.Show("Please enter the UserID you want to search.\n " +
                    "you can find the userID using the \"List All\" option","Empty",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtSearchUser.Focus();
                return;
            }

            if (user != null)
            {
                cmbRole.SelectedIndex = user.UserTypeId - 1;
                txtUserid.Text = user.UserID;
                txtPassword.Text = user.Password;

                grpManageUser.Enabled = true;
                btnRemoveUser.Enabled = true;
                btnGenerate.Enabled = false;
            }
            else
            {
                MessageBox.Show("The User ID you are looking foe is not present in the system. " +
                    "pleae make sure you enter the correct user ID", "Invalid User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchUser.Focus();
                return;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSearchInput.Clear();
            txtSearchUser.Clear();
            txtUserid.Clear();
            txtPassword.Clear();
            cmbSearchBy.SelectedIndex = 0;
            lvEmployees.Items.Clear();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            grpManageUser.Enabled = false;
            PopulateUserTypes();

        }
    }
}
