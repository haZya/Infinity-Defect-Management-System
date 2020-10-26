using System;
using System.Windows.Forms;
using System.Diagnostics;
using InfinityLibrary.Helpers;
using InfinityLibrary.DataAccess;
using Infinity.Tabs.Child_Tabs;

namespace Infinity.Tabs
{
    public partial class Users_Tab : UserControl
    {
        private static Users_Tab _instance;
        public Users_Tab()
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
        /// Get an instance of the Users_Tab usercontrol
        /// </summary>
        /// <returns></returns>
        public static Users_Tab getInstance()
        {
            if (_instance == null)
                _instance = new Users_Tab();
            return _instance;
        }

        /// <summary>
        /// Show on debug console
        /// </summary>
        public void OnShowTab()
        {
            Debug.WriteLine("Showing Users_Tab");
        }

        /// <summary>
        /// Method for populating the DataDridView
        /// </summary>
        public void populateDataGridView()
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                UserAdminDataAccess user = new UserAdminDataAccess();
                dgvUser.AutoGenerateColumns = false; // To only show the columns needed
                dgvUser.DataSource = user.GetAllUsers();
                txtSearchUsers.Text = "";
                Users_Tab_Child.getInstance().clearUserText();
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
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Column = ((DataGridView)sender).Columns[e.ColumnIndex];

            if (Column is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (Column.Index == 6) // Update button
                {
                    if (DbConnector.OpenSQLConnection()) // Open connection to the database
                    {
                        // Connection opened
                        UserAdminDataAccess user = new UserAdminDataAccess();
                        var result = user.FindUser(dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (result != null)
                        {
                            Users_Tab_Child.getInstance().BringToFront();
                            Users_Tab_Child.getInstance().changeView(result);
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
                            UserAdminDataAccess user = new UserAdminDataAccess();
                            if (user.DeleteUser(dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString()))
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
        /// Navigate to Add User view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Users_Tab_Child.getInstance().BringToFront();
            Users_Tab_Child.getInstance().changeView(null);
        }

        /// <summary>
        /// Populate the datagridview with search result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                UserAdminDataAccess user = new UserAdminDataAccess();
                dgvUser.AutoGenerateColumns = false; // To only show the columns needed
                dgvUser.DataSource = user.SearchUsers(txtSearchUsers.Text.Trim());
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
