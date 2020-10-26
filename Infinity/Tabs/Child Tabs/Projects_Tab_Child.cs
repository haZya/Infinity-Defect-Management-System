using System.Windows.Forms;
using System.Diagnostics;
using System;
using InfinityLibrary.Models;
using System.Drawing;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;
using System.Collections.Generic;

namespace Infinity.Tabs.Child_Tabs
{
    public partial class Projects_Tab_Child : UserControl
    {
        private int projectId;
        private static Projects_Tab_Child _instance;
        public Projects_Tab_Child()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get an instance of Projects_Tab_Child usercontrol
        /// </summary>
        /// <returns></returns>
        public static Projects_Tab_Child getInstance()
        {
            if (_instance == null)
                _instance = new Projects_Tab_Child();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Projects_Tab_Child");
        }

        #region comboBox events
        private void comboBoxManager_Enter(object sender, EventArgs e)
        {
            comboBoxManager.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxManager_Leave(object sender, EventArgs e)
        {
            comboBoxManager.BackColor = Color.Gray;
        }

        private void comboBoxManager_DropDown(object sender, EventArgs e)
        {
            comboBoxManager.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxManager_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxManager.BackColor = Color.Gray;
        }

        private void comboBoxFrontEndDev_Enter(object sender, EventArgs e)
        {
            comboBoxFrontEndDev.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxFrontEndDev_Leave(object sender, EventArgs e)
        {
            comboBoxFrontEndDev.BackColor = Color.Gray;
        }

        private void comboBoxFrontEndDev_DropDown(object sender, EventArgs e)
        {
            comboBoxFrontEndDev.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxFrontEndDev_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxFrontEndDev.BackColor = Color.Gray;
        }

        private void comboBoxBackEndDev_Enter(object sender, EventArgs e)
        {
            comboBoxBackEndDev.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxBackEndDev_Leave(object sender, EventArgs e)
        {
            comboBoxBackEndDev.BackColor = Color.Gray;
        }

        private void comboBoxBackEndDev_DropDown(object sender, EventArgs e)
        {
            comboBoxBackEndDev.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxBackEndDev_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxBackEndDev.BackColor = Color.Gray;
        }

        private void comboBoxTester_Enter(object sender, EventArgs e)
        {
            comboBoxTester.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxTester_Leave(object sender, EventArgs e)
        {
            comboBoxTester.BackColor = Color.Gray;
        }

        private void comboBoxTester_DropDown(object sender, EventArgs e)
        {
            comboBoxTester.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxTester_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxTester.BackColor = Color.Gray;
        }
        #endregion

        /// <summary>
        /// Navigate to the Projects List view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProjectCancel_Click(object sender, EventArgs e)
        {
            Projects_Tab.getInstance().BringToFront();
            Projects_Tab.getInstance().populateDataGridView();
        }

        /// <summary>
        /// Method for clearing the text fields
        /// </summary>
        public void clearProjectText()
        {
            txtProjectName.Text = "";
            comboBoxManager.Items.Clear();
            comboBoxFrontEndDev.Items.Clear();
            comboBoxBackEndDev.Items.Clear();
            comboBoxTester.Items.Clear();
            RadioButtonPriorityMed.Checked = true;
            dateTimePickerStart.ResetText();
            dateTimePickerEnd.ResetText();
        }

        /// <summary>
        /// Handle the function of adding a project to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProjectSave_Click(object sender, EventArgs e)
        {
            string projectName = txtProjectName.Text.Trim();
            string manager = comboBoxManager.Text;
            string frontEndDev = comboBoxFrontEndDev.Text;
            string backEndDev = comboBoxBackEndDev.Text;
            string tester = comboBoxTester.Text;
            string priority = "";
            if (RadioButtonPriorityLow.Checked == true) priority = "Low";
            else if (RadioButtonPriorityMed.Checked == true) priority = "Medium";
            else priority = "High";

            if (projectName != "" && manager != "" && frontEndDev != "" && backEndDev != "" && tester != "") // Check if required fields are filled
            {
                if (DbConnector.OpenSQLConnection()) // Open connection to the database
                {
                    // Connection opened
                    ProjectDataAccess project = new ProjectDataAccess();

                    if (btnProjectSave.Text == "Save")
                    {
                        if (!project.IsProjectNameExist(projectName))
                        {
                            if (project.InsertProject(projectName, manager, frontEndDev, backEndDev, tester, priority, dateTimePickerStart.Value.Date, dateTimePickerEnd.Value.Date))
                            {
                                // Record inserted successfully
                                MessageBox.Show("Record has been inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Projects_Tab.getInstance().BringToFront();
                                Projects_Tab.getInstance().populateDataGridView();
                            }
                            else
                            {
                                // Record was not inserted
                                MessageBox.Show("The record could not be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Project Name already exists
                            MessageBox.Show("The Project Name entered already exists in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (btnProjectSave.Text == "Update")
                    {
                        if (project.UpdateProject(projectId, projectName, manager, frontEndDev, backEndDev, tester, priority, dateTimePickerStart.Value.Date, dateTimePickerEnd.Value.Date))
                        {
                            // Record updated successfully
                            MessageBox.Show("Record has been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Projects_Tab.getInstance().BringToFront();
                            Projects_Tab.getInstance().populateDataGridView();
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
                // Fields not filled correctly
                MessageBox.Show("Please fill all the required fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Changing the view for insert or update
        /// </summary>
        /// <param name="viewType"></param>
        public void changeView(Project project)
        {
            List<User> users = new List<User>();

            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                UserAdminDataAccess user = new UserAdminDataAccess();
                users = user.GetActiveUsers();
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (users != null)
            {
                // Populate comboBoxes with data
                foreach (User u in users)
                {
                    if (u.UserType == "Manager")
                    {
                        comboBoxManager.Items.Add(u.Username);
                    }
                    else if (u.UserType == "Tester")
                    {
                        comboBoxTester.Items.Add(u.Username);
                    }
                    else
                    {
                        comboBoxFrontEndDev.Items.Add(u.Username);
                        comboBoxBackEndDev.Items.Add(u.Username);
                    }
                }
            }

            if (project == null)
            {
                // Button Add New clicked
                labelTitle.Text = "Add New Project";
                btnProjectSave.Text = "Save";
                txtProjectName.Enabled = true;
            }
            else
            {
                // Button Update clicked
                labelTitle.Text = "Update Project";
                btnProjectSave.Text = "Update";
                projectId = project.ProjectId;
                txtProjectName.Text = project.ProjectName;
                txtProjectName.Enabled = false;
                comboBoxManager.Text = project.Manager;
                comboBoxFrontEndDev.Text = project.FrontEndDev;
                comboBoxBackEndDev.Text = project.BackEndDev;
                comboBoxTester.Text = project.Tester;
                if (project.Priority == "Low")
                    RadioButtonPriorityLow.Checked = true;
                else if (project.Priority == "Medium")
                    RadioButtonPriorityMed.Checked = true;
                else
                    RadioButtonPriorityHigh.Checked = true;
                dateTimePickerStart.Value = project.StartDate;
                dateTimePickerEnd.Value = project.EndDate;
            }
        }
    }
}
