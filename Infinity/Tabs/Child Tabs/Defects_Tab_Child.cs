using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;
using InfinityLibrary.Models;

namespace Infinity.Tabs.Child_Tabs
{
    public partial class Defects_Tab_Child : UserControl
    {
        private int defectId;
        private string currentAssigned = "";
        private int drr, dre;
        private string defectStatus = "";
        private static Defects_Tab_Child _instance;
        public Defects_Tab_Child()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get an instance of Defects_Tab_Child usercontrol
        /// </summary>
        /// <returns></returns>
        public static Defects_Tab_Child getInstance()
        {
            if (_instance == null)
                _instance = new Defects_Tab_Child();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Defects_Tab_Child");
        }

        #region comboBox events
        private void comboBoxProject_Enter(object sender, EventArgs e)
        {
            comboBoxProject.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxProject_Leave(object sender, EventArgs e)
        {
            comboBoxProject.BackColor = Color.Gray;
        }

        private void comboBoxProject_DropDown(object sender, EventArgs e)
        {
            comboBoxProject.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxProject_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxProject.BackColor = Color.Gray;
        }

        private void comboBoxModule_Enter(object sender, EventArgs e)
        {
            comboBoxModule.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxModule_Leave(object sender, EventArgs e)
        {
            comboBoxModule.BackColor = Color.Gray;
        }

        private void comboBoxModule_DropDown(object sender, EventArgs e)
        {
            comboBoxModule.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxModule_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxModule.BackColor = Color.Gray;
        }

        private void comboBoxStatus_Enter(object sender, EventArgs e)
        {
            comboBoxStatus.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxStatus_Leave(object sender, EventArgs e)
        {
            comboBoxStatus.BackColor = Color.Gray;
        }

        private void comboBoxStatus_DropDown(object sender, EventArgs e)
        {
            comboBoxStatus.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxStatus_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxStatus.BackColor = Color.Gray;
        }

        private void comboBoxAssignedTo_Enter(object sender, EventArgs e)
        {
            comboBoxAssignedTo.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxAssignedTo_Leave(object sender, EventArgs e)
        {
            comboBoxAssignedTo.BackColor = Color.Gray;
        }

        private void comboBoxAssignedTo_DropDown(object sender, EventArgs e)
        {
            comboBoxAssignedTo.BackColor = Color.FromArgb(238, 26, 64);
        }

        private void comboBoxAssignedTo_DropDownClosed(object sender, EventArgs e)
        {
            comboBoxAssignedTo.BackColor = Color.Gray;
        }
        #endregion

        /// <summary>
        /// Navigate to the Defects List view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefectsCancel_Click(object sender, EventArgs e)
        {
            Defects_Tab.getInstance().BringToFront();
            Defects_Tab.getInstance().populateDataGridView();
        }

        /// <summary>
        /// Method for clearing the text fields
        /// </summary>
        public void clearDefectText()
        {
            comboBoxProject.Items.Clear();
            comboBoxModule.Items.Clear();
            txtDescription.Text = "";
            txtSteps.Text = "";
            txtRaisedBy.Text = "";
            comboBoxAssignedTo.Items.Clear();
            RadioButtonPriorityMed.Checked = true;
            comboBoxStatus.Items.Clear();
        }

        /// <summary>
        /// Handle the function of adding a defect to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefectSave_Click(object sender, EventArgs e)
        {
            string projectName = comboBoxProject.Text;
            string moduleName = comboBoxModule.Text;
            string description = txtDescription.Text.Trim();
            string steps = txtSteps.Text.Trim();
            string raisedBy = txtRaisedBy.Text.Trim();
            string assignedTo = comboBoxAssignedTo.Text;
            string status = comboBoxStatus.Text;
            string priority = "";
            if (RadioButtonPriorityLow.Checked == true) priority = "Low";
            else if (RadioButtonPriorityMed.Checked == true) priority = "Medium";
            else priority = "High";

            if (projectName != "" && moduleName != "" && description != "" && raisedBy != "" && status != "") // Check if required fields are filled
            {
                if (DbConnector.OpenSQLConnection()) // Open connection to the database
                {
                    // Connection opened
                    DefectDataAccess defect = new DefectDataAccess();

                    if (btnDefectSave.Text == "Save")
                    {
                        if (defect.InsertDefect(projectName, moduleName, description, steps, raisedBy, priority))
                        {
                            // Record inserted successfully
                            MessageBox.Show("Record has been inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Defects_Tab.getInstance().BringToFront();
                            Defects_Tab.getInstance().populateDataGridView();
                        }
                        else
                        {
                            // Record was not inserted
                            MessageBox.Show("The record could not be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (btnDefectSave.Text == "Update")
                    {
                        UserDataAccess user = new UserDataAccess();
                        DateTime? dateClosed;
                        if (defect.UpdateDefect(defectId, projectName, moduleName, description, steps, assignedTo, status, priority,
                        comboBoxStatus.Text == "Closed" ? dateClosed = DateTime.Now.Date : null, comboBoxStatus.Text != defectStatus && (comboBoxStatus.Text == "Rejected" ||
                        comboBoxStatus.Text == "Duplicate") ? drr - 1 : drr, comboBoxStatus.Text != defectStatus && (comboBoxStatus.Text == "Rejected" || 
                        comboBoxStatus.Text == "Duplicate") ? dre - 1 : comboBoxStatus.Text != defectStatus && comboBoxStatus.Text == "Re-Opened" ? dre + 1 : dre)
                        && user.UpdateUserStatus(currentAssigned, "Available")
                        && (user.UpdateUserStatus(comboBoxStatus.Text == "Closed" || comboBoxStatus.Text == "Rejected" || comboBoxStatus.Text == "Duplicate" ? 
                        assignedTo = null : comboBoxAssignedTo.Text, "Assigned")))
                        {
                            // Record updated successfully
                            MessageBox.Show("Record has been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Defects_Tab.getInstance().BringToFront();
                            Defects_Tab.getInstance().populateDataGridView();
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
        public void changeView(Defect defect)
        {
            #region Populating the comboBoxProject
            List<Project> projects = new List<Project>();

            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                ProjectDataAccess project = new ProjectDataAccess();
                projects = project.GetAllProjects();
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (projects != null)
            {
                // Populate comboBoxes with data
                foreach (Project p in projects)
                {
                    comboBoxProject.Items.Add(p.ProjectName);
                }
            }
            #endregion

            if (defect == null)
            {
                // Button Add New clicked
                labelTitle.Text = "Add New Defect";
                btnDefectSave.Text = "Save";
                panelAssignedTo.Enabled = false;
                comboBoxStatus.Items.Add("New");
                txtRaisedBy.Text = FormProvider.Dashboard.username;
                if (FormProvider.Dashboard.role == "Manager" || FormProvider.Dashboard.role == "Developer")
                {
                    Enabled = false;
                }
            }
            else
            {
                // Button Update clicked
                #region Populating comboBoxAssignedTo
                List<User> developers = new List<User>();

                if (DbConnector.OpenSQLConnection()) // Open connection to the database
                {
                    // Connection opened
                    UserDataAccess user = new UserDataAccess();
                    developers = user.GetActiveDevelopers();
                }
                else
                {
                    // Connection could not be opened
                    MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (developers != null)
                {
                    comboBoxAssignedTo.Items.Clear();

                    // Populate comboBoxes with data
                    foreach (User u in developers)
                    {
                        comboBoxAssignedTo.Items.Add(u.Username);
                    }
                }
                #endregion

                #region Change the view depending on the Action, User and Defect Status
                labelTitle.Text = "Update Module";
                btnDefectSave.Text = "Update";
                Enabled = true;
                if (FormProvider.Dashboard.role == "Manager")
                {
                    panelProjectName.Enabled = false;
                    panelModuleName.Enabled = false;
                    panelDescription.Enabled = false;
                    panelSteps.Enabled = false;
                    panelRaisedBy.Enabled = false;
                    panelAssignedTo.Enabled = true;
                    panelPriority.Enabled = true;
                }
                else if (FormProvider.Dashboard.role == "Developer")
                {
                    panelProjectName.Enabled = false;
                    panelModuleName.Enabled = false;
                    panelDescription.Enabled = false;
                    panelSteps.Enabled = false;
                    panelRaisedBy.Enabled = false;
                    panelAssignedTo.Enabled = false;
                    panelPriority.Enabled = false;
                }
                else if (FormProvider.Dashboard.role == "Tester")
                {
                    panelAssignedTo.Enabled = false;
                    panelProjectName.Enabled = true;
                    panelModuleName.Enabled = true;
                    panelDescription.Enabled = true;
                    panelSteps.Enabled = true;
                    panelRaisedBy.Enabled = true;
                    panelPriority.Enabled = true;
                }
                else
                {
                    panelProjectName.Enabled = true;
                    panelModuleName.Enabled = true;
                    panelDescription.Enabled = true;
                    panelSteps.Enabled = true;
                    panelRaisedBy.Enabled = true;
                    panelAssignedTo.Enabled = true;
                    panelPriority.Enabled = true;
                } 
                defectId = defect.DefectId;
                comboBoxProject.Text = defect.ProjectName;
                comboBoxModule.Text = defect.ModuleName;
                txtDescription.Text = defect.Description;
                txtSteps.Text = defect.StepsToRepeat;
                txtRaisedBy.Text = defect.RaisedBy;
                defectStatus = defect.Status;
                if (defect.Priority == "Low")
                    RadioButtonPriorityLow.Checked = true;
                else if (defect.Priority == "Medium")
                    RadioButtonPriorityMed.Checked = true;
                else
                    RadioButtonPriorityHigh.Checked = true;
                drr = defect.DRR;
                dre = defect.DRE;
                
                if (defect.AssignedTo != null)
                {
                    comboBoxAssignedTo.Items.Add(defect.AssignedTo);
                }
                comboBoxAssignedTo.Text = currentAssigned = defect.AssignedTo;

                if (defect.Status == "New")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("New");
                    if (FormProvider.Dashboard.role != "Tester")
                    {
                        comboBoxStatus.Items.Add("Open");
                        comboBoxStatus.Items.Add("Rejected");
                        comboBoxStatus.Items.Add("Duplicate");
                    }
                    comboBoxStatus.Text = defect.Status;
                }
                else if (defect.Status == "Open")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Open");
                    comboBoxStatus.Text = defect.Status;
                    if (FormProvider.Dashboard.role != "Tester")
                    {
                        comboBoxStatus.Items.Add("Rejected");
                        comboBoxStatus.Items.Add("Duplicate");
                    }
                }
                else if (defect.Status == "Assigned")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Assigned");
                    comboBoxStatus.Text = defect.Status;
                    if (FormProvider.Dashboard.role != "Developer" && FormProvider.Dashboard.role != "Tester")
                    {
                        comboBoxStatus.Items.Add("Rejected");
                        comboBoxStatus.Items.Add("Duplicate");
                        comboBoxStatus.Items.Add("Postponed");
                    }
                    if (FormProvider.Dashboard.role != "Manager" && FormProvider.Dashboard.role != "Tester")
                    {
                        comboBoxStatus.Items.Add("Not Reproducible");
                        comboBoxStatus.Items.Add("Need More Information");
                        comboBoxStatus.Items.Add("Known Defect");
                        comboBoxStatus.Items.Add("Fixed");
                        comboBoxStatus.Items.Add("Ready for Retest");
                    }
                }
                else if (defect.Status == "Rejected")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Rejected");
                    comboBoxStatus.Text = defect.Status;
                    if (FormProvider.Dashboard.role != "Developer")
                    {
                        comboBoxStatus.Items.Add("Closed");
                        comboBoxStatus.Items.Add("Re-Opened");
                    }
                }
                else if (defect.Status == "Duplicate")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Duplicate");
                    comboBoxStatus.Text = defect.Status;
                    if (FormProvider.Dashboard.role != "Developer")
                    {
                        comboBoxStatus.Items.Add("Closed");
                        comboBoxStatus.Items.Add("Re-Opened");
                    }
                }
                else if (defect.Status == "Closed")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Closed");
                    comboBoxStatus.Text = defect.Status;
                }
                else if (defect.Status == "Re-Opened")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Re-Opened");
                    comboBoxStatus.Text = defect.Status;
                    if (FormProvider.Dashboard.role != "Developer" && FormProvider.Dashboard.role != "Tester")
                    {
                        if (comboBoxAssignedTo.Text != "")
                        {
                            comboBoxStatus.Items.Add("Assigned");
                        }
                        comboBoxStatus.Items.Add("Rejected");
                        comboBoxStatus.Items.Add("Duplicate");
                    }
                }
                else if (defect.Status == "Postponed")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Postponed");
                    comboBoxStatus.Text = defect.Status;
                    if (FormProvider.Dashboard.role != "Manager" && FormProvider.Dashboard.role != "Tester")
                    {
                        comboBoxStatus.Items.Add("Not Reproducible");
                        comboBoxStatus.Items.Add("Need More Information");
                        comboBoxStatus.Items.Add("Known Defect");
                        comboBoxStatus.Items.Add("Fixed");
                        comboBoxStatus.Items.Add("Ready for Retest");
                    }
                    if (FormProvider.Dashboard.role != "Developer")
                    {
                        if (FormProvider.Dashboard.role != "Tester")
                        {
                            comboBoxStatus.Items.Add("Rejected");
                            comboBoxStatus.Items.Add("Duplicate");
                        }
                        comboBoxStatus.Items.Add("Closed");
                    }
                }
                else if (defect.Status == "Ready for Retest")
                {
                    comboBoxStatus.Items.Clear();
                    comboBoxStatus.Items.Add("Ready for Retest");
                    comboBoxStatus.Text = defect.Status;
                    if (FormProvider.Dashboard.role != "Developer")
                    {
                        comboBoxStatus.Items.Add("Closed");
                        comboBoxStatus.Items.Add("Re-Opened");
                    }
                }
                else
                {
                    comboBoxStatus.Items.Clear();
                    if (FormProvider.Dashboard.role != "Manager" && FormProvider.Dashboard.role != "Tester")
                    {
                        comboBoxStatus.Items.Add("Not Reproducible");
                        comboBoxStatus.Items.Add("Need More Information");
                        comboBoxStatus.Items.Add("Known Defect");
                        comboBoxStatus.Items.Add("Fixed");
                        comboBoxStatus.Items.Add("Ready for Retest");
                    }
                    if (FormProvider.Dashboard.role != "Developer")
                    {
                        comboBoxStatus.Items.Add("Closed");
                        comboBoxStatus.Items.Add("Re-Opened");
                    }
                    comboBoxStatus.Text = defect.Status;
                }
                #endregion

                if (comboBoxStatus.Text == "Closed")
                {
                    panelDefectAdd.Enabled = false;
                }
                else
                {
                    panelDefectAdd.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Populate comboBoxModule depending on the selected project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModule.Items.Clear();
            List<Module> modules = new List<Module>();

            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                ProjectDataAccess project = new ProjectDataAccess();
                int projectId = project.FindProjectByProjectName(comboBoxProject.Text);
                ModuleDataAccess module = new ModuleDataAccess();
                modules = module.FindModuleByProject(Convert.ToInt32(projectId));
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (modules != null)
            {
                // Populate comboBoxes with data
                foreach (Module m in modules)
                {
                    comboBoxModule.Items.Add(m.ModuleName);
                }
            }
        }

        /// <summary>
        /// Change comboBoxStatus items when index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Clear();
            if (comboBoxAssignedTo.Text == "")
            {
                if (comboBoxStatus.Text != "Re-Opened")
                    comboBoxStatus.Items.Add("Open");
            }
            else
            {
                comboBoxStatus.Items.Add("Assigned");                
            }
            comboBoxStatus.Items.Add("Rejected");
            comboBoxStatus.Items.Add("Duplicate");
        }
    }
}
