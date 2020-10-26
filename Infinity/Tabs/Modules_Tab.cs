using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;
using System;
using Infinity.Tabs.Child_Tabs;

namespace Infinity.Tabs
{
    public partial class Modules_Tab : UserControl
    {
        private int projectId;
        private string projectName;
        private static Modules_Tab _instance;

        public Modules_Tab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get an instance of Modules_Tab usercontrol
        /// </summary>
        /// <returns></returns>
        public static Modules_Tab getInstance()
        {
            if (_instance == null)
                _instance = new Modules_Tab();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Modules_Tab");
        }

        /// <summary>
        /// Method for populating the DataDridView
        /// </summary>
        public void populateDataGridView(int projectId)
        {
            this.projectId = projectId;
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                ModuleDataAccess module = new ModuleDataAccess();
                dgvModule.AutoGenerateColumns = false; // To only show the columns needed
                dgvModule.DataSource = module.GetAllModules(projectId);

                ProjectDataAccess project = new ProjectDataAccess();
                projectName = project.FindProject(projectId).ProjectName;
                for (int i = 0; i < dgvModule.RowCount; i++)
                {
                    dgvModule.Rows[i].Cells[2].Value = projectName;
                }
                txtSearchModules.Text = "";
                Modules_Tab_Child.getInstance().clearModuleText();
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        /// <summary>
        /// Handles DataGridView button click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Column = ((DataGridView)sender).Columns[e.ColumnIndex];

            if (Column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (Column.Index == 6) // Update button
                {
                    if (DbConnector.OpenSQLConnection()) // Open connection to the database
                    {
                        // Connection opened
                        ModuleDataAccess module = new ModuleDataAccess();
                        var result = module.FindModule(Convert.ToInt32(dgvModule.Rows[e.RowIndex].Cells[0].Value));
                        if (result != null)
                        {
                            Modules_Tab_Child.getInstance().BringToFront();
                            Modules_Tab_Child.getInstance().changeView(result, projectId, projectName);
                        }
                    }
                    else
                    {
                        // Connection could not be opened
                        MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DbConnector.CloseSQLConnection(); // Close connection to the database
                }
                else if (Column.Index == 7) // Delete button
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (DbConnector.OpenSQLConnection()) // Open connection to the database
                        {
                            // Connection opened
                            ModuleDataAccess module = new ModuleDataAccess();
                            if (module.DeleteModule(Convert.ToInt32(dgvModule.Rows[e.RowIndex].Cells[0].Value)))
                            {
                                // Record deleted successfully
                                MessageBox.Show("Record has been deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                populateDataGridView(Convert.ToInt32(dgvModule.Rows[e.RowIndex].Cells[1].Value));
                            }
                            else
                            {
                                // Record was not deleted
                                MessageBox.Show("The record could not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Connection could not be opened
                            MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        DbConnector.CloseSQLConnection(); // Close connection to the database
                    }
                }
            }
        }

        /// <summary>
        /// Navigate to Add Module view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewModule_Click(object sender, EventArgs e)
        {
            Modules_Tab_Child.getInstance().BringToFront();
            Modules_Tab_Child.getInstance().changeView(null, projectId, projectName);
        }

        /// <summary>
        /// Populate the datagridview with search result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchModules_Click(object sender, EventArgs e)
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                ModuleDataAccess module = new ModuleDataAccess();
                dgvModule.AutoGenerateColumns = false; // To only show the columns needed
                dgvModule.DataSource = module.SearchModules(txtSearchModules.Text.Trim());

                if (dgvModule.RowCount != 0)
                {
                    ProjectDataAccess project = new ProjectDataAccess();
                    var result = project.FindProject(Convert.ToInt32(dgvModule.Rows[0].Cells[1].Value)).ProjectName;
                    for (int i = 0; i < dgvModule.RowCount; i++)
                    {
                        dgvModule.Rows[i].Cells[2].Value = result;
                    }
                }
            }
            else
            {
                // Connection could not be opened
                MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnector.CloseSQLConnection(); // Close connection to the database
        }

        /// <summary>
        /// Go back to Projects List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Projects_Tab.getInstance().BringToFront();
            Projects_Tab.getInstance().populateDataGridView();
        }
    }
}
