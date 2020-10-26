namespace Infinity.Tabs.Child_Tabs
{
    partial class Defects_Tab_Child
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
            this.panelDefectAdd = new System.Windows.Forms.TableLayoutPanel();
            this.panelProjectName = new System.Windows.Forms.Panel();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelModuleName = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxModule = new System.Windows.Forms.ComboBox();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSteps = new System.Windows.Forms.Panel();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRaisedBy = new System.Windows.Forms.Panel();
            this.txtRaisedBy = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label9 = new System.Windows.Forms.Label();
            this.panelAssignedTo = new System.Windows.Forms.Panel();
            this.comboBoxAssignedTo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnDefectCancel = new System.Windows.Forms.Button();
            this.btnDefectSave = new System.Windows.Forms.Button();
            this.panelPriority = new System.Windows.Forms.Panel();
            this.RadioButtonPriorityHigh = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonPriorityMed = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonPriorityLow = new MaterialSkin.Controls.MaterialRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDefectAdd.SuspendLayout();
            this.panelProjectName.SuspendLayout();
            this.panelModuleName.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.panelSteps.SuspendLayout();
            this.panelRaisedBy.SuspendLayout();
            this.panelAssignedTo.SuspendLayout();
            this.panelPriority.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDefectAdd
            // 
            this.panelDefectAdd.ColumnCount = 2;
            this.panelDefectAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDefectAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDefectAdd.Controls.Add(this.panelProjectName, 0, 1);
            this.panelDefectAdd.Controls.Add(this.panelModuleName, 1, 1);
            this.panelDefectAdd.Controls.Add(this.panelDescription, 0, 2);
            this.panelDefectAdd.Controls.Add(this.panelSteps, 1, 2);
            this.panelDefectAdd.Controls.Add(this.panelRaisedBy, 0, 3);
            this.panelDefectAdd.Controls.Add(this.panelAssignedTo, 1, 3);
            this.panelDefectAdd.Controls.Add(this.labelTitle, 0, 0);
            this.panelDefectAdd.Controls.Add(this.btnDefectCancel, 1, 5);
            this.panelDefectAdd.Controls.Add(this.btnDefectSave, 0, 5);
            this.panelDefectAdd.Controls.Add(this.panelPriority, 0, 4);
            this.panelDefectAdd.Controls.Add(this.panel8, 1, 4);
            this.panelDefectAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDefectAdd.Location = new System.Drawing.Point(0, 0);
            this.panelDefectAdd.Name = "panelDefectAdd";
            this.panelDefectAdd.RowCount = 6;
            this.panelDefectAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.panelDefectAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.panelDefectAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.panelDefectAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.panelDefectAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.panelDefectAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelDefectAdd.Size = new System.Drawing.Size(1020, 570);
            this.panelDefectAdd.TabIndex = 7;
            // 
            // panelProjectName
            // 
            this.panelProjectName.Controls.Add(this.comboBoxProject);
            this.panelProjectName.Controls.Add(this.label1);
            this.panelProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProjectName.Location = new System.Drawing.Point(3, 77);
            this.panelProjectName.Name = "panelProjectName";
            this.panelProjectName.Size = new System.Drawing.Size(504, 85);
            this.panelProjectName.TabIndex = 19;
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProject.BackColor = System.Drawing.Color.Gray;
            this.comboBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProject.ForeColor = System.Drawing.Color.White;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(37, 41);
            this.comboBoxProject.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(445, 25);
            this.comboBoxProject.TabIndex = 12;
            this.comboBoxProject.DropDown += new System.EventHandler(this.comboBoxProject_DropDown);
            this.comboBoxProject.SelectedIndexChanged += new System.EventHandler(this.comboBoxProject_SelectedIndexChanged);
            this.comboBoxProject.DropDownClosed += new System.EventHandler(this.comboBoxProject_DropDownClosed);
            this.comboBoxProject.Enter += new System.EventHandler(this.comboBoxProject_Enter);
            this.comboBoxProject.Leave += new System.EventHandler(this.comboBoxProject_Leave);
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
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Project Name*";
            // 
            // panelModuleName
            // 
            this.panelModuleName.Controls.Add(this.label2);
            this.panelModuleName.Controls.Add(this.comboBoxModule);
            this.panelModuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModuleName.Location = new System.Drawing.Point(513, 77);
            this.panelModuleName.Name = "panelModuleName";
            this.panelModuleName.Size = new System.Drawing.Size(504, 85);
            this.panelModuleName.TabIndex = 20;
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
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Module Name*";
            // 
            // comboBoxModule
            // 
            this.comboBoxModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxModule.BackColor = System.Drawing.Color.Gray;
            this.comboBoxModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxModule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModule.ForeColor = System.Drawing.Color.White;
            this.comboBoxModule.FormattingEnabled = true;
            this.comboBoxModule.Location = new System.Drawing.Point(22, 41);
            this.comboBoxModule.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxModule.Name = "comboBoxModule";
            this.comboBoxModule.Size = new System.Drawing.Size(445, 25);
            this.comboBoxModule.TabIndex = 1;
            this.comboBoxModule.DropDown += new System.EventHandler(this.comboBoxModule_DropDown);
            this.comboBoxModule.DropDownClosed += new System.EventHandler(this.comboBoxModule_DropDownClosed);
            this.comboBoxModule.Enter += new System.EventHandler(this.comboBoxModule_Enter);
            this.comboBoxModule.Leave += new System.EventHandler(this.comboBoxModule_Leave);
            // 
            // panelDescription
            // 
            this.panelDescription.Controls.Add(this.txtDescription);
            this.panelDescription.Controls.Add(this.label3);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDescription.Location = new System.Drawing.Point(3, 168);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(504, 130);
            this.panelDescription.TabIndex = 21;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(37, 46);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(445, 67);
            this.txtDescription.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description*";
            // 
            // panelSteps
            // 
            this.panelSteps.Controls.Add(this.txtSteps);
            this.panelSteps.Controls.Add(this.label4);
            this.panelSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSteps.Location = new System.Drawing.Point(513, 168);
            this.panelSteps.Name = "panelSteps";
            this.panelSteps.Size = new System.Drawing.Size(504, 130);
            this.panelSteps.TabIndex = 22;
            // 
            // txtSteps
            // 
            this.txtSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteps.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteps.Location = new System.Drawing.Point(22, 46);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(445, 67);
            this.txtSteps.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 15, 40, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Steps to Repeat";
            // 
            // panelRaisedBy
            // 
            this.panelRaisedBy.Controls.Add(this.txtRaisedBy);
            this.panelRaisedBy.Controls.Add(this.label9);
            this.panelRaisedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRaisedBy.Location = new System.Drawing.Point(3, 304);
            this.panelRaisedBy.Name = "panelRaisedBy";
            this.panelRaisedBy.Size = new System.Drawing.Size(504, 85);
            this.panelRaisedBy.TabIndex = 23;
            // 
            // txtRaisedBy
            // 
            this.txtRaisedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRaisedBy.Depth = 0;
            this.txtRaisedBy.Enabled = false;
            this.txtRaisedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaisedBy.Hint = "Raised By";
            this.txtRaisedBy.Location = new System.Drawing.Point(37, 43);
            this.txtRaisedBy.MaxLength = 32767;
            this.txtRaisedBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRaisedBy.Name = "txtRaisedBy";
            this.txtRaisedBy.PasswordChar = '\0';
            this.txtRaisedBy.SelectedText = "";
            this.txtRaisedBy.SelectionLength = 0;
            this.txtRaisedBy.SelectionStart = 0;
            this.txtRaisedBy.Size = new System.Drawing.Size(445, 23);
            this.txtRaisedBy.TabIndex = 16;
            this.txtRaisedBy.TabStop = false;
            this.txtRaisedBy.UseSystemPasswordChar = false;
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
            this.label9.Text = "Raised By*";
            // 
            // panelAssignedTo
            // 
            this.panelAssignedTo.Controls.Add(this.comboBoxAssignedTo);
            this.panelAssignedTo.Controls.Add(this.label10);
            this.panelAssignedTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignedTo.Enabled = false;
            this.panelAssignedTo.Location = new System.Drawing.Point(513, 304);
            this.panelAssignedTo.Name = "panelAssignedTo";
            this.panelAssignedTo.Size = new System.Drawing.Size(504, 85);
            this.panelAssignedTo.TabIndex = 24;
            // 
            // comboBoxAssignedTo
            // 
            this.comboBoxAssignedTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAssignedTo.BackColor = System.Drawing.Color.Gray;
            this.comboBoxAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAssignedTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAssignedTo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAssignedTo.ForeColor = System.Drawing.Color.White;
            this.comboBoxAssignedTo.FormattingEnabled = true;
            this.comboBoxAssignedTo.Items.AddRange(new object[] {
            "New"});
            this.comboBoxAssignedTo.Location = new System.Drawing.Point(22, 41);
            this.comboBoxAssignedTo.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxAssignedTo.Name = "comboBoxAssignedTo";
            this.comboBoxAssignedTo.Size = new System.Drawing.Size(445, 25);
            this.comboBoxAssignedTo.TabIndex = 14;
            this.comboBoxAssignedTo.DropDown += new System.EventHandler(this.comboBoxAssignedTo_DropDown);
            this.comboBoxAssignedTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssignedTo_SelectedIndexChanged);
            this.comboBoxAssignedTo.DropDownClosed += new System.EventHandler(this.comboBoxAssignedTo_DropDownClosed);
            this.comboBoxAssignedTo.Enter += new System.EventHandler(this.comboBoxAssignedTo_Enter);
            this.comboBoxAssignedTo.Leave += new System.EventHandler(this.comboBoxAssignedTo_Leave);
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
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Assigned To";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(30, 0, 25, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(455, 37);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Add New Defect";
            // 
            // btnDefectCancel
            // 
            this.btnDefectCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDefectCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnDefectCancel.FlatAppearance.BorderSize = 0;
            this.btnDefectCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefectCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefectCancel.ForeColor = System.Drawing.Color.White;
            this.btnDefectCancel.Location = new System.Drawing.Point(905, 514);
            this.btnDefectCancel.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.btnDefectCancel.Name = "btnDefectCancel";
            this.btnDefectCancel.Size = new System.Drawing.Size(75, 25);
            this.btnDefectCancel.TabIndex = 29;
            this.btnDefectCancel.Text = "Cancel";
            this.btnDefectCancel.UseVisualStyleBackColor = false;
            this.btnDefectCancel.Click += new System.EventHandler(this.btnDefectsCancel_Click);
            // 
            // btnDefectSave
            // 
            this.btnDefectSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDefectSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnDefectSave.FlatAppearance.BorderSize = 0;
            this.btnDefectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefectSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefectSave.ForeColor = System.Drawing.Color.White;
            this.btnDefectSave.Location = new System.Drawing.Point(40, 514);
            this.btnDefectSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnDefectSave.Name = "btnDefectSave";
            this.btnDefectSave.Size = new System.Drawing.Size(75, 25);
            this.btnDefectSave.TabIndex = 30;
            this.btnDefectSave.Text = "Save";
            this.btnDefectSave.UseVisualStyleBackColor = false;
            this.btnDefectSave.Click += new System.EventHandler(this.btnDefectSave_Click);
            // 
            // panelPriority
            // 
            this.panelPriority.Controls.Add(this.RadioButtonPriorityHigh);
            this.panelPriority.Controls.Add(this.RadioButtonPriorityMed);
            this.panelPriority.Controls.Add(this.RadioButtonPriorityLow);
            this.panelPriority.Controls.Add(this.label5);
            this.panelPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPriority.Location = new System.Drawing.Point(3, 395);
            this.panelPriority.Name = "panelPriority";
            this.panelPriority.Size = new System.Drawing.Size(504, 85);
            this.panelPriority.TabIndex = 31;
            // 
            // RadioButtonPriorityHigh
            // 
            this.RadioButtonPriorityHigh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonPriorityHigh.AutoSize = true;
            this.RadioButtonPriorityHigh.Depth = 0;
            this.RadioButtonPriorityHigh.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonPriorityHigh.Location = new System.Drawing.Point(232, 35);
            this.RadioButtonPriorityHigh.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonPriorityHigh.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonPriorityHigh.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonPriorityHigh.Name = "RadioButtonPriorityHigh";
            this.RadioButtonPriorityHigh.Ripple = true;
            this.RadioButtonPriorityHigh.Size = new System.Drawing.Size(58, 30);
            this.RadioButtonPriorityHigh.TabIndex = 7;
            this.RadioButtonPriorityHigh.TabStop = true;
            this.RadioButtonPriorityHigh.Text = "High";
            this.RadioButtonPriorityHigh.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPriorityMed
            // 
            this.RadioButtonPriorityMed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonPriorityMed.AutoSize = true;
            this.RadioButtonPriorityMed.Checked = true;
            this.RadioButtonPriorityMed.Depth = 0;
            this.RadioButtonPriorityMed.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonPriorityMed.Location = new System.Drawing.Point(120, 35);
            this.RadioButtonPriorityMed.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonPriorityMed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonPriorityMed.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonPriorityMed.Name = "RadioButtonPriorityMed";
            this.RadioButtonPriorityMed.Ripple = true;
            this.RadioButtonPriorityMed.Size = new System.Drawing.Size(79, 30);
            this.RadioButtonPriorityMed.TabIndex = 6;
            this.RadioButtonPriorityMed.TabStop = true;
            this.RadioButtonPriorityMed.Text = "Medium";
            this.RadioButtonPriorityMed.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPriorityLow
            // 
            this.RadioButtonPriorityLow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonPriorityLow.AutoSize = true;
            this.RadioButtonPriorityLow.Depth = 0;
            this.RadioButtonPriorityLow.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonPriorityLow.Location = new System.Drawing.Point(33, 35);
            this.RadioButtonPriorityLow.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonPriorityLow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonPriorityLow.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonPriorityLow.Name = "RadioButtonPriorityLow";
            this.RadioButtonPriorityLow.Ripple = true;
            this.RadioButtonPriorityLow.Size = new System.Drawing.Size(54, 30);
            this.RadioButtonPriorityLow.TabIndex = 5;
            this.RadioButtonPriorityLow.TabStop = true;
            this.RadioButtonPriorityLow.Text = "Low";
            this.RadioButtonPriorityLow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Priority*";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.comboBoxStatus);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(513, 395);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 85);
            this.panel8.TabIndex = 32;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.BackColor = System.Drawing.Color.Gray;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.ForeColor = System.Drawing.Color.White;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "New"});
            this.comboBoxStatus.Location = new System.Drawing.Point(22, 40);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(445, 25);
            this.comboBoxStatus.TabIndex = 12;
            this.comboBoxStatus.DropDown += new System.EventHandler(this.comboBoxStatus_DropDown);
            this.comboBoxStatus.DropDownClosed += new System.EventHandler(this.comboBoxStatus_DropDownClosed);
            this.comboBoxStatus.Enter += new System.EventHandler(this.comboBoxStatus_Enter);
            this.comboBoxStatus.Leave += new System.EventHandler(this.comboBoxStatus_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(19, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(40, 0, 25, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status*";
            // 
            // Defects_Tab_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDefectAdd);
            this.Name = "Defects_Tab_Child";
            this.Size = new System.Drawing.Size(1020, 570);
            this.panelDefectAdd.ResumeLayout(false);
            this.panelDefectAdd.PerformLayout();
            this.panelProjectName.ResumeLayout(false);
            this.panelProjectName.PerformLayout();
            this.panelModuleName.ResumeLayout(false);
            this.panelModuleName.PerformLayout();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.panelSteps.ResumeLayout(false);
            this.panelSteps.PerformLayout();
            this.panelRaisedBy.ResumeLayout(false);
            this.panelRaisedBy.PerformLayout();
            this.panelAssignedTo.ResumeLayout(false);
            this.panelAssignedTo.PerformLayout();
            this.panelPriority.ResumeLayout(false);
            this.panelPriority.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelDefectAdd;
        private System.Windows.Forms.Panel panelProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelModuleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModule;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSteps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelRaisedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelAssignedTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxProject;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRaisedBy;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.Button btnDefectCancel;
        private System.Windows.Forms.Button btnDefectSave;
        private System.Windows.Forms.Panel panelPriority;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPriorityHigh;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPriorityMed;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPriorityLow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxAssignedTo;
    }
}
