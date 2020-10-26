namespace Infinity
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.toolTipDashboard = new System.Windows.Forms.ToolTip(this.components);
            this.btnMaximize = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.dragControlTop = new LimitlessUI.DragControl_WOC();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.elipseDashboard = new LimitlessUI.Elipse_WOC();
            this.animator = new LimitlessUI.Animator_WOC();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnPlaceHolder = new LimitlessUI.FlatButton_WOC();
            this.btnNavDefect = new LimitlessUI.FlatButton_WOC();
            this.btnNavProject = new LimitlessUI.FlatButton_WOC();
            this.btnNavUser = new LimitlessUI.FlatButton_WOC();
            this.btnNavHome = new LimitlessUI.FlatButton_WOC();
            this.btnNav = new LimitlessUI.FlatButton_WOC();
            this.btnNavLogout = new LimitlessUI.FlatButton_WOC();
            this.dragControlTopLabel = new LimitlessUI.DragControl_WOC();
            this.navAdapter = new LimitlessUI.TabsAdapter_WOC();
            this.panelTabs_Holder = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelTop2 = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelTop2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.AutoSize = true;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1139, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 10;
            this.btnMaximize.Text = "☐";
            this.toolTipDashboard.SetToolTip(this.btnMaximize, "Maximize");
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1108, -5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 32);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.Text = "-";
            this.toolTipDashboard.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1169, -5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "x";
            this.toolTipDashboard.SetToolTip(this.btnClose, "Close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dragControlTop
            // 
            this.dragControlTop.DraggableInnerControls = false;
            this.dragControlTop.Fixed = true;
            this.dragControlTop.MaximiseOnDoubleClick = true;
            this.dragControlTop.TargetControl = this.panelTop;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.btnMaximize);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 30);
            this.panelTop.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Image = global::Infinity.Properties.Resources.InfinitySM;
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTitle.Location = new System.Drawing.Point(12, 3);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(289, 21);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "        Infinity Defect Management System";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // elipseDashboard
            // 
            this.elipseDashboard.CornerRadius = 20;
            this.elipseDashboard.TargetControl = this;
            // 
            // animator
            // 
            this.animator.Animation = LimitlessUI.Animator_WOC.Animations.ChangeWidth;
            this.animator.CheckMonitorFps = false;
            this.animator.Control = this.panelLeft;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelLeft.Controls.Add(this.btnPlaceHolder);
            this.panelLeft.Controls.Add(this.btnNavDefect);
            this.panelLeft.Controls.Add(this.btnNavProject);
            this.panelLeft.Controls.Add(this.btnNavUser);
            this.panelLeft.Controls.Add(this.btnNavHome);
            this.panelLeft.Controls.Add(this.btnNav);
            this.panelLeft.Controls.Add(this.btnNavLogout);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 30);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(180, 620);
            this.panelLeft.TabIndex = 5;
            // 
            // btnPlaceHolder
            // 
            this.btnPlaceHolder.ActiveColor = System.Drawing.Color.Empty;
            this.btnPlaceHolder.ActiveImage = null;
            this.btnPlaceHolder.ActiveTextColor = System.Drawing.Color.Empty;
            this.btnPlaceHolder.DefaultBackColor = System.Drawing.Color.Empty;
            this.btnPlaceHolder.DefaultForeColor = System.Drawing.Color.Empty;
            this.btnPlaceHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlaceHolder.DrawImage = false;
            this.btnPlaceHolder.DrawText = true;
            this.btnPlaceHolder.Image = null;
            this.btnPlaceHolder.ImageSize = new System.Drawing.SizeF(20F, 20F);
            this.btnPlaceHolder.IsTab = true;
            this.btnPlaceHolder.Location = new System.Drawing.Point(0, 250);
            this.btnPlaceHolder.Name = "btnPlaceHolder";
            this.btnPlaceHolder.OnHoverColor = System.Drawing.Color.Empty;
            this.btnPlaceHolder.OnHoverTextColor = System.Drawing.Color.Empty;
            this.btnPlaceHolder.Selected = false;
            this.btnPlaceHolder.Size = new System.Drawing.Size(180, 320);
            this.btnPlaceHolder.TabIndex = 50;
            this.btnPlaceHolder.TextAligment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaceHolder.TextOffset = new System.Drawing.Point(0, 0);
            this.btnPlaceHolder.UseActiveImageWhileHovering = false;
            // 
            // btnNavDefect
            // 
            this.btnNavDefect.ActiveColor = System.Drawing.Color.Black;
            this.btnNavDefect.ActiveImage = global::Infinity.Properties.Resources.Defect2;
            this.btnNavDefect.ActiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavDefect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavDefect.DefaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavDefect.DefaultForeColor = System.Drawing.Color.White;
            this.btnNavDefect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDefect.DrawImage = true;
            this.btnNavDefect.DrawText = true;
            this.btnNavDefect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDefect.ForeColor = System.Drawing.Color.White;
            this.btnNavDefect.Image = global::Infinity.Properties.Resources.Defect;
            this.btnNavDefect.ImageSize = new System.Drawing.SizeF(20F, 20F);
            this.btnNavDefect.IsTab = true;
            this.btnNavDefect.Location = new System.Drawing.Point(0, 200);
            this.btnNavDefect.Name = "btnNavDefect";
            this.btnNavDefect.OnHoverColor = System.Drawing.Color.Empty;
            this.btnNavDefect.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavDefect.Selected = false;
            this.btnNavDefect.Size = new System.Drawing.Size(180, 50);
            this.btnNavDefect.TabIndex = 3;
            this.btnNavDefect.Text = "Defects";
            this.btnNavDefect.TextAligment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDefect.TextOffset = new System.Drawing.Point(20, 1);
            this.btnNavDefect.UseActiveImageWhileHovering = false;
            this.btnNavDefect.Click += new System.EventHandler(this.nav_click);
            this.btnNavDefect.MouseEnter += new System.EventHandler(this.nav_MouseEnter);
            this.btnNavDefect.MouseLeave += new System.EventHandler(this.nav_MouseLeave);
            // 
            // btnNavProject
            // 
            this.btnNavProject.ActiveColor = System.Drawing.Color.Black;
            this.btnNavProject.ActiveImage = global::Infinity.Properties.Resources.Project2;
            this.btnNavProject.ActiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavProject.DefaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavProject.DefaultForeColor = System.Drawing.Color.White;
            this.btnNavProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProject.DrawImage = true;
            this.btnNavProject.DrawText = true;
            this.btnNavProject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavProject.ForeColor = System.Drawing.Color.White;
            this.btnNavProject.Image = global::Infinity.Properties.Resources.Project;
            this.btnNavProject.ImageSize = new System.Drawing.SizeF(20F, 20F);
            this.btnNavProject.IsTab = true;
            this.btnNavProject.Location = new System.Drawing.Point(0, 150);
            this.btnNavProject.Name = "btnNavProject";
            this.btnNavProject.OnHoverColor = System.Drawing.Color.Empty;
            this.btnNavProject.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavProject.Selected = false;
            this.btnNavProject.Size = new System.Drawing.Size(180, 50);
            this.btnNavProject.TabIndex = 2;
            this.btnNavProject.Text = "Projects";
            this.btnNavProject.TextAligment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProject.TextOffset = new System.Drawing.Point(20, 1);
            this.btnNavProject.UseActiveImageWhileHovering = false;
            this.btnNavProject.Click += new System.EventHandler(this.nav_click);
            this.btnNavProject.MouseEnter += new System.EventHandler(this.nav_MouseEnter);
            this.btnNavProject.MouseLeave += new System.EventHandler(this.nav_MouseLeave);
            // 
            // btnNavUser
            // 
            this.btnNavUser.ActiveColor = System.Drawing.Color.Black;
            this.btnNavUser.ActiveImage = global::Infinity.Properties.Resources.User2;
            this.btnNavUser.ActiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavUser.DefaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavUser.DefaultForeColor = System.Drawing.Color.White;
            this.btnNavUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavUser.DrawImage = true;
            this.btnNavUser.DrawText = true;
            this.btnNavUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavUser.ForeColor = System.Drawing.Color.White;
            this.btnNavUser.Image = global::Infinity.Properties.Resources.User;
            this.btnNavUser.ImageSize = new System.Drawing.SizeF(20F, 20F);
            this.btnNavUser.IsTab = true;
            this.btnNavUser.Location = new System.Drawing.Point(0, 100);
            this.btnNavUser.Name = "btnNavUser";
            this.btnNavUser.OnHoverColor = System.Drawing.Color.Empty;
            this.btnNavUser.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavUser.Selected = false;
            this.btnNavUser.Size = new System.Drawing.Size(180, 50);
            this.btnNavUser.TabIndex = 1;
            this.btnNavUser.Text = "Users";
            this.btnNavUser.TextAligment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUser.TextOffset = new System.Drawing.Point(20, 1);
            this.btnNavUser.UseActiveImageWhileHovering = false;
            this.btnNavUser.Click += new System.EventHandler(this.nav_click);
            this.btnNavUser.MouseEnter += new System.EventHandler(this.nav_MouseEnter);
            this.btnNavUser.MouseLeave += new System.EventHandler(this.nav_MouseLeave);
            // 
            // btnNavHome
            // 
            this.btnNavHome.ActiveColor = System.Drawing.Color.Black;
            this.btnNavHome.ActiveImage = global::Infinity.Properties.Resources.Home2;
            this.btnNavHome.ActiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavHome.BackColor = System.Drawing.Color.Black;
            this.btnNavHome.DefaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavHome.DefaultForeColor = System.Drawing.Color.White;
            this.btnNavHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavHome.DrawImage = true;
            this.btnNavHome.DrawText = true;
            this.btnNavHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavHome.Image = ((System.Drawing.Image)(resources.GetObject("btnNavHome.Image")));
            this.btnNavHome.ImageSize = new System.Drawing.SizeF(20F, 20F);
            this.btnNavHome.IsTab = true;
            this.btnNavHome.Location = new System.Drawing.Point(0, 50);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.OnHoverColor = System.Drawing.Color.Empty;
            this.btnNavHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavHome.Selected = true;
            this.btnNavHome.Size = new System.Drawing.Size(180, 50);
            this.btnNavHome.TabIndex = 0;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.TextAligment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavHome.TextOffset = new System.Drawing.Point(20, 1);
            this.btnNavHome.UseActiveImageWhileHovering = false;
            this.btnNavHome.Click += new System.EventHandler(this.nav_click);
            this.btnNavHome.MouseEnter += new System.EventHandler(this.nav_MouseEnter);
            this.btnNavHome.MouseLeave += new System.EventHandler(this.nav_MouseLeave);
            // 
            // btnNav
            // 
            this.btnNav.ActiveColor = System.Drawing.Color.Empty;
            this.btnNav.ActiveImage = null;
            this.btnNav.ActiveTextColor = System.Drawing.Color.White;
            this.btnNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNav.DefaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNav.DefaultForeColor = System.Drawing.Color.White;
            this.btnNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNav.DrawImage = true;
            this.btnNav.DrawText = false;
            this.btnNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNav.ForeColor = System.Drawing.Color.White;
            this.btnNav.Image = global::Infinity.Properties.Resources.Menu;
            this.btnNav.ImageSize = new System.Drawing.SizeF(20F, 20F);
            this.btnNav.IsTab = false;
            this.btnNav.Location = new System.Drawing.Point(0, 0);
            this.btnNav.Name = "btnNav";
            this.btnNav.OnHoverColor = System.Drawing.Color.Empty;
            this.btnNav.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNav.Selected = false;
            this.btnNav.Size = new System.Drawing.Size(180, 50);
            this.btnNav.TabIndex = 4;
            this.btnNav.TextAligment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNav.TextOffset = new System.Drawing.Point(10, 1);
            this.btnNav.UseActiveImageWhileHovering = false;
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
            this.btnNav.MouseEnter += new System.EventHandler(this.nav_MouseEnter);
            this.btnNav.MouseLeave += new System.EventHandler(this.nav_MouseLeave);
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.ActiveColor = System.Drawing.Color.Black;
            this.btnNavLogout.ActiveImage = null;
            this.btnNavLogout.ActiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavLogout.DefaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNavLogout.DefaultForeColor = System.Drawing.Color.White;
            this.btnNavLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNavLogout.DrawImage = true;
            this.btnNavLogout.DrawText = true;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLogout.ForeColor = System.Drawing.Color.White;
            this.btnNavLogout.Image = global::Infinity.Properties.Resources.Logout;
            this.btnNavLogout.ImageSize = new System.Drawing.SizeF(20F, 20F);
            this.btnNavLogout.IsTab = false;
            this.btnNavLogout.Location = new System.Drawing.Point(0, 570);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.OnHoverColor = System.Drawing.Color.Empty;
            this.btnNavLogout.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnNavLogout.Selected = false;
            this.btnNavLogout.Size = new System.Drawing.Size(180, 50);
            this.btnNavLogout.TabIndex = 5;
            this.btnNavLogout.Text = "Logout";
            this.btnNavLogout.TextAligment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.TextOffset = new System.Drawing.Point(20, 1);
            this.btnNavLogout.UseActiveImageWhileHovering = false;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            this.btnNavLogout.MouseEnter += new System.EventHandler(this.nav_MouseEnter);
            this.btnNavLogout.MouseLeave += new System.EventHandler(this.nav_MouseLeave);
            // 
            // dragControlTopLabel
            // 
            this.dragControlTopLabel.DraggableInnerControls = false;
            this.dragControlTopLabel.Fixed = true;
            this.dragControlTopLabel.MaximiseOnDoubleClick = true;
            this.dragControlTopLabel.TargetControl = this.labelTitle;
            // 
            // navAdapter
            // 
            this.navAdapter.Control = this.panelTabs_Holder;
            // 
            // panelTabs_Holder
            // 
            this.panelTabs_Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabs_Holder.Location = new System.Drawing.Point(180, 80);
            this.panelTabs_Holder.Name = "panelTabs_Holder";
            this.panelTabs_Holder.Size = new System.Drawing.Size(1020, 570);
            this.panelTabs_Holder.TabIndex = 7;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.panelTabs_Holder);
            this.panelDashboard.Controls.Add(this.panelTop2);
            this.panelDashboard.Controls.Add(this.panelLeft);
            this.panelDashboard.Controls.Add(this.panelTop);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1200, 650);
            this.panelDashboard.TabIndex = 0;
            // 
            // panelTop2
            // 
            this.panelTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelTop2.Controls.Add(this.labelRole);
            this.panelTop2.Controls.Add(this.labelUser);
            this.panelTop2.Controls.Add(this.label3);
            this.panelTop2.Controls.Add(this.label2);
            this.panelTop2.Controls.Add(this.label1);
            this.panelTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2.Location = new System.Drawing.Point(180, 30);
            this.panelTop2.Name = "panelTop2";
            this.panelTop2.Size = new System.Drawing.Size(1020, 50);
            this.panelTop2.TabIndex = 6;
            // 
            // labelRole
            // 
            this.labelRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.labelRole.Location = new System.Drawing.Point(798, 27);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 20);
            this.labelRole.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.labelUser.Location = new System.Drawing.Point(798, 3);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 20);
            this.labelUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(750, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(750, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelTop2.ResumeLayout(false);
            this.panelTop2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipDashboard;
        private LimitlessUI.DragControl_WOC dragControlTop;
        private LimitlessUI.Elipse_WOC elipseDashboard;
        private LimitlessUI.Animator_WOC animator;
        private LimitlessUI.DragControl_WOC dragControlTopLabel;
        private LimitlessUI.TabsAdapter_WOC navAdapter;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelTabs_Holder;
        private System.Windows.Forms.Panel panelTop2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private LimitlessUI.FlatButton_WOC btnPlaceHolder;
        private LimitlessUI.FlatButton_WOC btnNavDefect;
        private LimitlessUI.FlatButton_WOC btnNavProject;
        private LimitlessUI.FlatButton_WOC btnNavUser;
        private LimitlessUI.FlatButton_WOC btnNavHome;
        private LimitlessUI.FlatButton_WOC btnNav;
        private LimitlessUI.FlatButton_WOC btnNavLogout;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label btnMaximize;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnClose;
    }
}