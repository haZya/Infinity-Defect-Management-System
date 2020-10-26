using Infinity.Tabs;
using Infinity.Tabs.Child_Tabs;
using InfinityLibrary.Models;
using LimitlessUI;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace Infinity
{
    public partial class Dashboard : Form
    {
        public string username;
        public string role;
        private bool _DrawerExpanded = false;
        private MaterialSkinManager materialSkinManager;
        public Dashboard()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            SetupNavigation();
        }

        /// <summary>
        /// Override OnLoad event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea; // Set the MaximumBounds to the screen size excluding the taskbar
            if (role == "Developer" || role == "Tester")
            {
                btnNavHome.Visible = false;
                btnNavUser.Visible = false;
                btnNavProject.Visible = false;
                btnNavHome.Selected = false;
                btnNavDefect.Selected = true;
                Defects_Tab.getInstance().BringToFront();
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }
            else if (role == "Manager")
            {
                btnNavHome.Visible = true;
                btnNavUser.Visible = false;
                btnNavProject.Visible = false;
                btnNavHome.Selected = true;
                btnNavDefect.Selected = false;
                Home_Tab.getInstance().BringToFront();
                btnNavUser.Selected = false;
                btnNavProject.Selected = false;
                btnNavDefect.Selected = false;
                Home_Tab.getInstance().populateCharts();
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }
            else
            {
                btnNavHome.Visible = true;
                btnNavUser.Visible = true;
                btnNavProject.Visible = true;
                btnNavHome.Selected = true;
                btnNavDefect.Selected = false;
                Home_Tab.getInstance().BringToFront();
                btnNavUser.Selected = false;
                btnNavProject.Selected = false;
                btnNavDefect.Selected = false;
                Home_Tab.getInstance().populateCharts();
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }
        }

        /// <summary>
        /// Override OnSizeChanged event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (Width == MaximizedBounds.Width && Height == MaximizedBounds.Height) // Check if the form is maximized
                elipseDashboard.CornerRadius = 0; // Change form corner radius to 0
            else
                elipseDashboard.CornerRadius = 20; // Change form corner radius to 20

        }

        /// <summary>
        /// Setup the Form functions and privileges according to the user type
        /// </summary>
        /// <param name="user"></param>
        public void SetUpDashboard(User user)
        {
            labelUser.Text = $"{ user.FName } { user.LName }";
            labelRole.Text = role = user.UserType;
            username = user.Username;
        }

        /// <summary>
        /// Setup navigation between tabs
        /// </summary>
        private void SetupNavigation()
        {
            navAdapter.AddTab(Home_Tab.getInstance(), true);
            navAdapter.AddTab(Users_Tab.getInstance(), false);          
            navAdapter.AddTab(Projects_Tab.getInstance(), false);
            navAdapter.AddTab(Defects_Tab.getInstance(), false);

            panelTabs_Holder.Controls.Add(Users_Tab_Child.getInstance());
            Users_Tab_Child.getInstance().Dock = DockStyle.Fill;
            panelTabs_Holder.Controls.Add(Projects_Tab_Child.getInstance());
            Projects_Tab_Child.getInstance().Dock = DockStyle.Fill;
            panelTabs_Holder.Controls.Add(Modules_Tab.getInstance());
            Modules_Tab.getInstance().Dock = DockStyle.Fill;
            panelTabs_Holder.Controls.Add(Modules_Tab_Child.getInstance());
            Modules_Tab_Child.getInstance().Dock = DockStyle.Fill;
            panelTabs_Holder.Controls.Add(Defects_Tab_Child.getInstance());
            Defects_Tab_Child.getInstance().Dock = DockStyle.Fill;
            panelTabs_Holder.Controls.Add(Defects_Tab_Child2.getInstance());
            Defects_Tab_Child2.getInstance().Dock = DockStyle.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close and dispose the application and its processes
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // Minimize the form to the task bar
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal; // Maximize or Normal
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            DrawerExpanded = !DrawerExpanded; // Change the boolean value on click event
        }

        private bool DrawerExpanded
        {
            get { return _DrawerExpanded; }
            set
            {
                _DrawerExpanded = value;
                animator.Animate(200, _DrawerExpanded ? 50 : 180); // Animate the navigation panel with transition property: width
            }
        }

        /// <summary>
        /// Handles navigation button click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nav_click(object sender, EventArgs e)
        {
            Control flatbtn = (FlatButton_WOC)sender;
            if (flatbtn.TabIndex == 0)
            {
                Home_Tab.getInstance().populateCharts();
                Home_Tab.getInstance().populateDataGridAgeAnalysis();
                Home_Tab.getInstance().populateDataGridDREAnalysis();
                Home_Tab.getInstance().populateDataGridDRRAnalysis();
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }
            if (flatbtn.TabIndex == 1)
            {
                Users_Tab.getInstance().populateDataGridView();
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }
            else if (flatbtn.TabIndex == 2)
            {
                Projects_Tab.getInstance().populateDataGridView();
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }
            else if (flatbtn.TabIndex == 3)
            {
                Defects_Tab.getInstance().populateDataGridView();
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
            }

            navAdapter.ShowTab((flatbtn).TabIndex);
        }

        /// <summary>
        /// Handles MouseEnter event of navigation buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nav_MouseEnter(object sender, EventArgs e)
        {
            var tabIndex = ((Control)sender).TabIndex;
            if (tabIndex == 0)
                btnNavHome.Image = Properties.Resources.Home2;
            else if (tabIndex == 1)
                btnNavUser.Image = Properties.Resources.User2;
            else if (tabIndex == 2)
                btnNavProject.Image = Properties.Resources.Project2;
            else if (tabIndex == 3)
                btnNavDefect.Image = Properties.Resources.Defect2;
            else if (tabIndex == 4)
            {
                if (_DrawerExpanded == true)
                    btnNav.Image = Properties.Resources.MenuInverse2;
                else
                    btnNav.Image = Properties.Resources.Menu2;
            }
            else if (tabIndex == 5)
                btnNavLogout.Image = Properties.Resources.Logout2;
        }

        /// <summary>
        /// Handles MouseLeave event of navigation buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nav_MouseLeave(object sender, EventArgs e)
        {
            var tabIndex = ((Control)sender).TabIndex;
            if (tabIndex == 0)
                btnNavHome.Image = Properties.Resources.Home;
            else if (tabIndex == 1)
                btnNavUser.Image = Properties.Resources.User;
            else if (tabIndex == 2)
                btnNavProject.Image = Properties.Resources.Project;
            else if (tabIndex == 3)
                btnNavDefect.Image = Properties.Resources.Defect;
            else if (tabIndex == 4)
            {
                if (_DrawerExpanded == true)
                    btnNav.Image = Properties.Resources.MenuInverse;
                else
                    btnNav.Image = Properties.Resources.Menu;
            }
            else if (tabIndex == 5)
                btnNavLogout.Image = Properties.Resources.Logout;
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            ActiveForm.Close(); // Close Dashboard
            FormProvider.Login.Show(); // Show LoginForm instance
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red700, Accent.Red700, TextShade.WHITE);
        }
    }
}
