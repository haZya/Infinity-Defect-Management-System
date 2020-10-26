using InfinityLibrary.DataAccess;
using InfinityLibrary.Helpers;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace Infinity
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close and dispose the application and its processes
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimize the form to the task bar
        }

        private void labelRememberMe_Click(object sender, EventArgs e)
        {
            if (checkBoxRemember.Checked == true)
                checkBoxRemember.Checked = false;
            else
                checkBoxRemember.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DbConnector.OpenSQLConnection()) // Open connection to the database
            {
                // Connection opened
                UserDataAccess user = new UserDataAccess();
                var result = user.Login(txtUsername.Text, txtPass.Text);
                if (result == null)
                {
                    // No user found for the input credentials
                    MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result.IsAccActive == "Inactive")
                {
                    // User's account is deactivated
                    MessageBox.Show("Account is not active", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // User found
                    FormProvider.Dashboard.SetUpDashboard(result);
                    if (checkBoxRemember.Checked == false)
                    {
                        txtUsername.Text = "";
                        txtPass.Text = "";
                    }
                    Hide(); // Hide LoginForm instance
                    FormProvider.Dashboard.ShowDialog(); // Open Dashboard instance
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
