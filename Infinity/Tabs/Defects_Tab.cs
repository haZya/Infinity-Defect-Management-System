using System;
using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;
using Infinity.Tabs.Child_Tabs;
using System.Drawing;

namespace Infinity.Tabs
{
    public partial class Defects_Tab : UserControl
    {
        private static Defects_Tab _instance;
        public Defects_Tab()
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

            dgvDefect.Columns[13].Visible = false;
            if (FormProvider.Dashboard.role == "Manager" || FormProvider.Dashboard.role == "Developer")
            {
                btnAddNewDefect.Enabled = false;
                btnAddNewDefect.BackColor = Color.Gray;
            }
            else
            {
                btnAddNewDefect.Enabled = true;
                btnAddNewDefect.BackColor = Color.FromArgb(238, 26, 64);
                if (FormProvider.Dashboard.role == "Admin")
                {
                    dgvDefect.Columns[13].Visible = true;
                }
            }
        }

        /// <summary>
        /// Get an instance of Defects_Tab usercontrol
        /// </summary>
        /// <returns></returns>
        public static Defects_Tab getInstance()
        {
            if (_instance == null)
                _instance = new Defects_Tab();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Defects_Tab");
        }

        /// <summary>
        /// Method for populating the DataDridView
        /// </summary>
        public void populateDataGridView()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                DefectDataAccess defect = new DefectDataAccess();
                dgvDefect.AutoGenerateColumns = false; // To only show the columns needed
                if (FormProvider.Dashboard.role == "Tester")
                {
                    dgvDefect.DataSource = defect.FindDefects(FormProvider.Dashboard.username, "Tester");
                }
                else if (FormProvider.Dashboard.role == "Developer")
                {
                    dgvDefect.DataSource = defect.FindDefects(FormProvider.Dashboard.username, "Dev");
                }
                else
                {
                    dgvDefect.DataSource = defect.GetAllDefects();
                }
                txtSearchDefects.Text = "";
                Defects_Tab_Child.getInstance().clearDefectText();
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
        private void dgvDefect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Column = ((DataGridView)sender).Columns[e.ColumnIndex];

            if (Column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (DbConnector.OpenSQLConnection()) // Open connection to the database
                {
                    // Connection opened
                    DefectDataAccess defect = new DefectDataAccess();
                    var result = defect.FindDefect(Convert.ToInt32(dgvDefect.Rows[e.RowIndex].Cells[0].Value));

                    if (Column.Index == 11) // Details button
                    {
                        if (result != null)
                        {
                            Defects_Tab_Child2.getInstance().BringToFront();
                            Defects_Tab_Child2.getInstance().populate(result);
                        }
                    }
                    else if (Column.Index == 12) // Update button
                    {
                        if (result != null)
                        {
                            Defects_Tab_Child.getInstance().BringToFront();
                            Defects_Tab_Child.getInstance().changeView(result);
                        }
                    }
                }
                else
                {
                    // Connection could not be opened
                    MessageBox.Show("Connection to the database could not be established", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DbConnector.CloseSQLConnection(); // Close connection to the database

                if (Column.Index == 13) // Delete button
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (DbConnector.OpenSQLConnection()) // Open connection to the database
                        {
                            // Connection opened
                            DefectDataAccess defect = new DefectDataAccess();
                            if (defect.DeleteDefect(Convert.ToInt32(dgvDefect.Rows[e.RowIndex].Cells[0].Value)))
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
        /// Navigate to Add Defect view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewDefect_Click(object sender, EventArgs e)
        {
            Defects_Tab_Child.getInstance().BringToFront();
            Defects_Tab_Child.getInstance().changeView(null);
        }

        /// <summary>
        /// Populate the datagridview with search result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchDefects_Click(object sender, EventArgs e)
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                DefectDataAccess defect = new DefectDataAccess();
                dgvDefect.AutoGenerateColumns = false; // To only show the columns needed
                if (FormProvider.Dashboard.role == "Tester")
                {
                    if (txtSearchDefects.Text != "")
                        dgvDefect.DataSource = defect.SearchDefects(FormProvider.Dashboard.username, txtSearchDefects.Text.Trim(), "Tester");
                    else
                        dgvDefect.DataSource = defect.FindDefects(FormProvider.Dashboard.username, "Tester");
                }
                else if (FormProvider.Dashboard.role == "Developer")
                {
                    if (txtSearchDefects.Text != "")
                        dgvDefect.DataSource = defect.SearchDefects(FormProvider.Dashboard.username, txtSearchDefects.Text.Trim(), "Dev");
                    else
                        dgvDefect.DataSource = defect.FindDefects(FormProvider.Dashboard.username, "Dev");
                }
                else
                {
                    dgvDefect.DataSource = defect.SearchDefects(txtSearchDefects.Text.Trim());
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
