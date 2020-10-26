using System;
using System.Windows.Forms;
using System.Diagnostics;
using Infinity.Tabs.Child_Tabs;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;

namespace Infinity.Tabs
{
    public partial class Projects_Tab : UserControl
    {
        private static Projects_Tab _instance;
        public Projects_Tab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populate the datagridview on load
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            populateDataGridView();
        }

        /// <summary>
        /// Get an instance of Projects_Tab usercontrol
        /// </summary>
        /// <returns></returns>
        public static Projects_Tab getInstance()
        {
            if (_instance == null)
                _instance = new Projects_Tab();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Projects_Tab");
        }

        /// <summary>
        /// Method for populating the DataDridView
        /// </summary>
        public void populateDataGridView()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                ProjectDataAccess project = new ProjectDataAccess();
                dgvProject.AutoGenerateColumns = false; // To only show the columns needed
                dgvProject.DataSource = project.GetAllProjects();
                txtSearchProjects.Text = "";
                Projects_Tab_Child.getInstance().clearProjectText();
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
        private void dgvProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Column = ((DataGridView)sender).Columns[e.ColumnIndex];

            if (Column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (Column.Index == 9) // Modules button
                {
                    Modules_Tab.getInstance().BringToFront();
                    Modules_Tab.getInstance().populateDataGridView(Convert.ToInt32(dgvProject.Rows[e.RowIndex].Cells[0].Value));
                }
                else if (Column.Index == 10) // Update button
                {
                    if (DbConnector.OpenSQLConnection()) // Open connection to the database
                    {
                        // Connection opened
                        ProjectDataAccess project = new ProjectDataAccess();
                        var result = project.FindProject(Convert.ToInt32(dgvProject.Rows[e.RowIndex].Cells[0].Value));
                        if (result != null)
                        {
                            Projects_Tab_Child.getInstance().BringToFront();
                            Projects_Tab_Child.getInstance().changeView(result);
                        }
                    }
                    else
                    {
                        // Connection could not be opened
                        MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DbConnector.CloseSQLConnection(); // Close connection to the database
                }
                else if (Column.Index == 11) // Delete button
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (DbConnector.OpenSQLConnection()) // Open connection to the database
                        {
                            // Connection opened
                            ProjectDataAccess project = new ProjectDataAccess();
                            if (project.DeleteProject(Convert.ToInt32(dgvProject.Rows[e.RowIndex].Cells[0].Value)))
                            {
                                // Record deleted successfully
                                MessageBox.Show("Record has been deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                populateDataGridView();
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
        /// Navigate to Add Project view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewProject_Click(object sender, EventArgs e)
        {
            Projects_Tab_Child.getInstance().BringToFront();
            Projects_Tab_Child.getInstance().changeView(null);
        }

        /// <summary>
        /// Populate the datagridview with search result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchProjects_Click(object sender, EventArgs e)
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                ProjectDataAccess project = new ProjectDataAccess();
                dgvProject.AutoGenerateColumns = false; // To only show the columns needed
                dgvProject.DataSource = project.SearchProjects(txtSearchProjects.Text.Trim());
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
