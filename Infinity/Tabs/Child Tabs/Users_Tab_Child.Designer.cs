namespace Infinity.Tabs.Child_Tabs
{
    partial class Users_Tab_Child
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUserAdd = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtConfirmPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.switchUserStatus = new LimitlessUI.Switch_WOC();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.switchAccStatus = new LimitlessUI.Switch_WOC();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.panelUserAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserAdd
            // 
            this.panelUserAdd.ColumnCount = 2;
            this.panelUserAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUserAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUserAdd.Controls.Add(this.panel1, 0, 1);
            this.panelUserAdd.Controls.Add(this.panel2, 1, 1);
            this.panelUserAdd.Controls.Add(this.panel3, 0, 2);
            this.panelUserAdd.Controls.Add(this.panel4, 1, 2);
            this.panelUserAdd.Controls.Add(this.panel5, 0, 3);
            this.panelUserAdd.Controls.Add(this.panel6, 1, 3);
            this.panelUserAdd.Controls.Add(this.panel7, 0, 4);
            this.panelUserAdd.Controls.Add(this.panel8, 1, 4);
            this.panelUserAdd.Controls.Add(this.labelTitle, 0, 0);
            this.panelUserAdd.Controls.Add(this.btnUserSave, 0, 5);
            this.panelUserAdd.Controls.Add(this.btnUserCancel, 1, 5);
            this.panelUserAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserAdd.Location = new System.Drawing.Point(0, 0);
            this.panelUserAdd.Name = "panelUserAdd";
            this.panelUserAdd.RowCount = 6;
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.panelUserAdd.Size = new System.Drawing.Size(1020, 570);
            this.panelUserAdd.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 85);
            this.panel1.TabIndex = 19;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Hint = "Username";
            this.txtUsername.Location = new System.Drawing.Point(37, 41);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(445, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TabStop = false;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 0, 25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username*";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxUserType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(513, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 85);
            this.panel2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Type*";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUserType.BackColor = System.Drawing.Color.Gray;
            this.comboBoxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserType.ForeColor = System.Drawing.Color.White;
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Tester",
            "Developer"});
            this.comboBoxUserType.Location = new System.Drawing.Point(22, 41);
            this.comboBoxUserType.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(445, 25);
            this.comboBoxUserType.TabIndex = 1;
            this.comboBoxUserType.DropDown += new System.EventHandler(this.comboBoxUserType_DropDown);
            this.comboBoxUserType.DropDownClosed += new System.EventHandler(this.comboBoxUserType_DropDownClosed);
            this.comboBoxUserType.Enter += new System.EventHandler(this.comboBoxUserType_Enter);
            this.comboBoxUserType.Leave += new System.EventHandler(this.comboBoxUserType_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 85);
            this.panel3.TabIndex = 21;
            // 
            // txtFName
            // 
            this.txtFName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFName.Depth = 0;
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Hint = "First Name";
            this.txtFName.Location = new System.Drawing.Point(37, 41);
            this.txtFName.MaxLength = 32767;
            this.txtFName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFName.Name = "txtFName";
            this.txtFName.PasswordChar = '\0';
            this.txtFName.SelectedText = "";
            this.txtFName.SelectionLength = 0;
            this.txtFName.SelectionStart = 0;
            this.txtFName.Size = new System.Drawing.Size(445, 23);
            this.txtFName.TabIndex = 2;
            this.txtFName.TabStop = false;
            this.txtFName.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "First Name*";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtLName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(513, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 85);
            this.panel4.TabIndex = 22;
            // 
            // txtLName
            // 
            this.txtLName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLName.Depth = 0;
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Hint = "Last Name";
            this.txtLName.Location = new System.Drawing.Point(22, 41);
            this.txtLName.MaxLength = 32767;
            this.txtLName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLName.Name = "txtLName";
            this.txtLName.PasswordChar = '\0';
            this.txtLName.SelectedText = "";
            this.txtLName.SelectionLength = 0;
            this.txtLName.SelectionStart = 0;
            this.txtLName.Size = new System.Drawing.Size(445, 23);
            this.txtLName.TabIndex = 3;
            this.txtLName.TabStop = false;
            this.txtLName.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 15, 40, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Name*";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtPass);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(504, 85);
            this.panel5.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(34, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Password*";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Hint = "Password";
            this.txtPass.Location = new System.Drawing.Point(37, 41);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(445, 23);
            this.txtPass.TabIndex = 4;
            this.txtPass.TabStop = false;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtConfirmPass);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(513, 281);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(504, 85);
            this.panel6.TabIndex = 24;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPass.Depth = 0;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Hint = "Confirm Password";
            this.txtConfirmPass.Location = new System.Drawing.Point(22, 41);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.SelectionLength = 0;
            this.txtConfirmPass.SelectionStart = 0;
            this.txtConfirmPass.Size = new System.Drawing.Size(445, 23);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.TabStop = false;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(19, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Confirm Password*";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.switchUserStatus);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 372);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(504, 85);
            this.panel7.TabIndex = 25;
            // 
            // switchUserStatus
            // 
            this.switchUserStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.switchUserStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchUserStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchUserStatus.ForeColor = System.Drawing.Color.White;
            this.switchUserStatus.IsOn = false;
            this.switchUserStatus.Location = new System.Drawing.Point(34, 42);
            this.switchUserStatus.Name = "switchUserStatus";
            this.switchUserStatus.OffColor = System.Drawing.Color.DarkGray;
            this.switchUserStatus.OffText = "Assigned";
            this.switchUserStatus.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.switchUserStatus.OnText = "Available";
            this.switchUserStatus.Size = new System.Drawing.Size(230, 23);
            this.switchUserStatus.TabIndex = 6;
            this.switchUserStatus.TextEnabled = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(34, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "User Status";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.switchAccStatus);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(513, 372);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 85);
            this.panel8.TabIndex = 26;
            // 
            // switchAccStatus
            // 
            this.switchAccStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.switchAccStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.switchAccStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchAccStatus.ForeColor = System.Drawing.Color.White;
            this.switchAccStatus.IsOn = false;
            this.switchAccStatus.Location = new System.Drawing.Point(22, 42);
            this.switchAccStatus.Name = "switchAccStatus";
            this.switchAccStatus.OffColor = System.Drawing.Color.DarkGray;
            this.switchAccStatus.OffText = "Inactive";
            this.switchAccStatus.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.switchAccStatus.OnText = "Active";
            this.switchAccStatus.Size = new System.Drawing.Size(230, 23);
            this.switchAccStatus.TabIndex = 7;
            this.switchAccStatus.TextEnabled = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(19, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Account Status";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 29);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(30, 0, 25, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(455, 37);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Add New User";
            // 
            // btnUserSave
            // 
            this.btnUserSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUserSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnUserSave.FlatAppearance.BorderSize = 0;
            this.btnUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSave.ForeColor = System.Drawing.Color.White;
            this.btnUserSave.Location = new System.Drawing.Point(40, 502);
            this.btnUserSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 25);
            this.btnUserSave.TabIndex = 8;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = false;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUserCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnUserCancel.FlatAppearance.BorderSize = 0;
            this.btnUserCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancel.ForeColor = System.Drawing.Color.White;
            this.btnUserCancel.Location = new System.Drawing.Point(905, 502);
            this.btnUserCancel.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(75, 25);
            this.btnUserCancel.TabIndex = 9;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = false;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // Users_Tab_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserAdd);
            this.Name = "Users_Tab_Child";
            this.Size = new System.Drawing.Size(1020, 570);
            this.panelUserAdd.ResumeLayout(false);
            this.panelUserAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelUserAdd;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirmPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private LimitlessUI.Switch_WOC switchUserStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private LimitlessUI.Switch_WOC switchAccStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserCancel;
    }
}
