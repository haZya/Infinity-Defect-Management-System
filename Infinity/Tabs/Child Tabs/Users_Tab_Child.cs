using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Models;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;

namespace Infinity.Tabs.Child_Tabs
{
    public partial class Users_Tab_Child : UserControl
    {
        private static Users_Tab_Child _instance;
        public Users_Tab_Child()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get an instance of Users_Tab_Child usercontrol
        /// </summary>
        /// <returns></returns>
        public static Users_Tab_Child getInstance()
        {
            if (_instance == null)
                _instance = new Users_Tab_Child();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Users_Tab_Child");
        }

        #region comboBoxUserType events
        private void comboBoxUserType_Enter(object sender, EventArgs e)
        {
            comboBoxUserType.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxUserType_Leave(object sender, EventArgs e)
        {
            comboBoxUserType.BackColor = Color.Gray;
        }

        private void comboBoxUserType_DropDown(object sender, EventArgs e)
        {
            comboBoxUserType.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxUserType_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxUserType.BackColor = Color.Gray;
        }
        #endregion

        /// <summary>
        /// Navigate to the Users List view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            Users_Tab.getInstance().BringToFront();
            Users_Tab.getInstance().populateDataGridView();
        }

        /// <summary>
        /// Method for clearing the text fields
        /// </summary>
        public void clearUserText()
        {
            txtUsername.Text = "";
            comboBoxUserType.SelectedItem = null;
            txtFName.Text = "";
            txtLName.Text = "";
            txtPass.Text = "";
            txtConfirmPass.Text = "";
            switchUserStatus.IsOn = false;
            switchAccStatus.IsOn = false;
        }

        /// <summary>
        /// Handle the function of adding an user to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string userType = comboBoxUserType.Text;
            string fname = txtFName.Text.Trim();
            string lname = txtLName.Text.Trim();

            if (username != "" && userType != "" && fname != "" && lname != "" && txtPass.Text != "") // Check if required fields are filled
            {
                if (txtPass.Text == txtConfirmPass.Text) // Check whether the password and confirm password matches
                {
                    if (txtPass.Text.Length >= 8) // Check whether the password length is at least 8 characters
                    {
                        if (DbConnector.OpenSQLConnection()) // Open connection to the database
                        {
                            // Connection opened
                            UserAdminDataAccess user = new UserAdminDataAccess();

                            if (btnUserSave.Text == "Save")
                            {
                                if (user.IsUsernameExist(username)) // Check if the username already taken
                                {
                                    // Username exists
                                    MessageBox.Show("Username entered already exists in the database", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                if (user.InsertUser(username, userType, fname, lname, txtPass.Text,
                                    switchUserStatus.IsOn ? "Available" : "Assigned", switchAccStatus.IsOn ? "Active" : "Inactive"))
                                {
                                    // Record inserted successfully
                                    MessageBox.Show("Record has been inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Users_Tab.getInstance().BringToFront();
                                    Users_Tab.getInstance().populateDataGridView();
                                }
                                else
                                {
                                    // Record was not inserted
                                    MessageBox.Show("The record could not be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (btnUserSave.Text == "Update")
                            {
                                if (user.UpdateUser(username, userType, fname, lname, txtPass.Text,
                                    switchUserStatus.IsOn ? "Available" : "Assigned", switchAccStatus.IsOn ? "Active" : "Inactive"))
                                {
                                    // Record updated successfully
                                    MessageBox.Show("Record has been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Users_Tab.getInstance().BringToFront();
                                    Users_Tab.getInstance().populateDataGridView();
                                }
                                else
                                {
                                    // Record was not updated
                                    MessageBox.Show("The record could not be updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            // Connection could not be opened
                            MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Password length less than 8 characters
                        MessageBox.Show("Password should at least contain 8 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Password and Confirm Password do not match
                    MessageBox.Show("Password and Confirm Password do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Fields not filled correctly
                MessageBox.Show("Please fill all the required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Changing the view for insert or update
        /// </summary>
        /// <param name="viewType"></param>
        public void changeView(User user)
        {
            if (user == null)
            {
                // Button Add New clicked
                labelTitle.Text = "Add New User";
                btnUserSave.Text = "Save";
                txtUsername.Enabled = true;
            }
            else
            {
                // Button Update clicked
                labelTitle.Text = "Update User";
                btnUserSave.Text = "Update";
                txtUsername.Text = user.Username;
                txtUsername.Enabled = false;
                comboBoxUserType.Text = user.UserType;
                txtFName.Text = user.FName;
                txtLName.Text = user.LName;
                if (user.IsUserActive == "Available")
                    switchUserStatus.IsOn = true;
                else
                    switchUserStatus.IsOn = false;

                if (user.IsAccActive == "Active")
                    switchAccStatus.IsOn = true;
                else
                    switchAccStatus.IsOn = false;
            }
        }
    }
}
