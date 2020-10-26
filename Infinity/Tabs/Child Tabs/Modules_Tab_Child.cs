using System;
using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Models;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;

namespace Infinity.Tabs.Child_Tabs
{
    public partial class Modules_Tab_Child : UserControl
    {
        private int moduleId;
        private int projectId;
        private static Modules_Tab_Child _instance;
        public Modules_Tab_Child()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get an instance of Modules_Tab_Child usercontrol
        /// </summary>
        /// <returns></returns>
        public static Modules_Tab_Child getInstance()
        {
            if (_instance == null)
                _instance = new Modules_Tab_Child();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Modules_Tab_Child");
        }

        /// <summary>
        /// Navigate to the Modules List view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModulesCancel_Click(object sender, EventArgs e)
        {
            Modules_Tab.getInstance().BringToFront();
            Modules_Tab.getInstance().populateDataGridView(projectId);
        }

        /// <summary>
        /// Method for clearing the text fields
        /// </summary>
        public void clearModuleText()
        {
            txtProjectName.Text = "";
            txtModuleName.Text = "";
            txtModuleFunction.Text = "";
            txtAddedBy.Text = "";
        }

        /// <summary>
        /// Handle the function of adding a module to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModuleSave_Click(object sender, EventArgs e)
        {
            string moduleName = txtModuleName.Text.Trim();
            string moduleFunction = txtModuleFunction.Text.Trim();
            string addedBy = txtAddedBy.Text.Trim();

            if (moduleName != "" && moduleFunction != "" && addedBy != "") // Check if required fields are filled
            {
                if (DbConnector.OpenSQLConnection()) // Open connection to the database
                {
                    // Connection opened
                    ModuleDataAccess module = new ModuleDataAccess();

                    if (btnModuleSave.Text == "Save")
                    {
                        if (module.InsertModule(projectId, moduleName, moduleFunction, addedBy))
                        {
                            // Record inserted successfully
                            MessageBox.Show("Record has been inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Modules_Tab.getInstance().BringToFront();
                            Modules_Tab.getInstance().populateDataGridView(projectId);
                        }
                        else
                        {
                            // Record was not inserted
                            MessageBox.Show("The record could not be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (btnModuleSave.Text == "Update")
                    {
                        if (module.UpdateModule(moduleId, moduleName, moduleFunction, addedBy))
                        {
                            // Record updated successfully
                            MessageBox.Show("Record has been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Modules_Tab.getInstance().BringToFront();
                            Modules_Tab.getInstance().populateDataGridView(projectId);
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
        public void changeView(Module module, int projectId, string projectName)
        {
            this.projectId = projectId;
            txtProjectName.Text = projectName;
            txtAddedBy.Text = FormProvider.Dashboard.username;

            if (module == null)
            {
                // Button Add New clicked
                labelTitle.Text = "Add New Module";
                btnModuleSave.Text = "Save";
            }
            else
            {
                // Button Update clicked
                labelTitle.Text = "Update Module";
                btnModuleSave.Text = "Update";
                moduleId = module.ModuleId;
                txtModuleName.Text = module.ModuleName;
                txtModuleFunction.Text = module.ModuleFunction;
            }
        }
    }
}
