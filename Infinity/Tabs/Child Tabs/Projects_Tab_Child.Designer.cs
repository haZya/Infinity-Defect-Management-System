namespace Infinity.Tabs.Child_Tabs
{
    partial class Projects_Tab_Child
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
            this.txtProjectName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxFrontEndDev = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxBackEndDev = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxTester = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RadioButtonPriorityHigh = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonPriorityMed = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonPriorityLow = new MaterialSkin.Controls.MaterialRadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnProjectSave = new System.Windows.Forms.Button();
            this.btnProjectCancel = new System.Windows.Forms.Button();
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
            this.panelUserAdd.Controls.Add(this.btnProjectSave, 0, 5);
            this.panelUserAdd.Controls.Add(this.btnProjectCancel, 1, 5);
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
            this.panelUserAdd.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProjectName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 85);
            this.panel1.TabIndex = 19;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Depth = 0;
            this.txtProjectName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.Hint = "Project Name";
            this.txtProjectName.Location = new System.Drawing.Point(37, 41);
            this.txtProjectName.MaxLength = 32767;
            this.txtProjectName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.Size = new System.Drawing.Size(445, 23);
            this.txtProjectName.TabIndex = 0;
            this.txtProjectName.TabStop = false;
            this.txtProjectName.UseSystemPasswordChar = false;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxManager);
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
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Project Manager*";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxManager.BackColor = System.Drawing.Color.Gray;
            this.comboBoxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxManager.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxManager.ForeColor = System.Drawing.Color.White;
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(22, 41);
            this.comboBoxManager.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(445, 25);
            this.comboBoxManager.TabIndex = 1;
            this.comboBoxManager.DropDown += new System.EventHandler(this.comboBoxManager_DropDown);
            this.comboBoxManager.DropDownClosed += new System.EventHandler(this.comboBoxManager_DropDownClosed);
            this.comboBoxManager.Enter += new System.EventHandler(this.comboBoxManager_Enter);
            this.comboBoxManager.Leave += new System.EventHandler(this.comboBoxManager_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxFrontEndDev);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 190);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 85);
            this.panel3.TabIndex = 21;
            // 
            // comboBoxFrontEndDev
            // 
            this.comboBoxFrontEndDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFrontEndDev.BackColor = System.Drawing.Color.Gray;
            this.comboBoxFrontEndDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrontEndDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFrontEndDev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFrontEndDev.ForeColor = System.Drawing.Color.White;
            this.comboBoxFrontEndDev.FormattingEnabled = true;
            this.comboBoxFrontEndDev.Location = new System.Drawing.Point(34, 39);
            this.comboBoxFrontEndDev.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxFrontEndDev.Name = "comboBoxFrontEndDev";
            this.comboBoxFrontEndDev.Size = new System.Drawing.Size(448, 25);
            this.comboBoxFrontEndDev.TabIndex = 2;
            this.comboBoxFrontEndDev.DropDown += new System.EventHandler(this.comboBoxFrontEndDev_DropDown);
            this.comboBoxFrontEndDev.DropDownClosed += new System.EventHandler(this.comboBoxFrontEndDev_DropDownClosed);
            this.comboBoxFrontEndDev.Enter += new System.EventHandler(this.comboBoxFrontEndDev_Enter);
            this.comboBoxFrontEndDev.Leave += new System.EventHandler(this.comboBoxFrontEndDev_Leave);
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
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Front-End Developer*";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxBackEndDev);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(513, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 85);
            this.panel4.TabIndex = 22;
            // 
            // comboBoxBackEndDev
            // 
            this.comboBoxBackEndDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBackEndDev.BackColor = System.Drawing.Color.Gray;
            this.comboBoxBackEndDev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackEndDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBackEndDev.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBackEndDev.ForeColor = System.Drawing.Color.White;
            this.comboBoxBackEndDev.FormattingEnabled = true;
            this.comboBoxBackEndDev.Location = new System.Drawing.Point(22, 39);
            this.comboBoxBackEndDev.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxBackEndDev.Name = "comboBoxBackEndDev";
            this.comboBoxBackEndDev.Size = new System.Drawing.Size(445, 25);
            this.comboBoxBackEndDev.TabIndex = 3;
            this.comboBoxBackEndDev.DropDown += new System.EventHandler(this.comboBoxBackEndDev_DropDown);
            this.comboBoxBackEndDev.DropDownClosed += new System.EventHandler(this.comboBoxBackEndDev_DropDownClosed);
            this.comboBoxBackEndDev.Enter += new System.EventHandler(this.comboBoxBackEndDev_Enter);
            this.comboBoxBackEndDev.Leave += new System.EventHandler(this.comboBoxBackEndDev_Leave);
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
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Back-End Developer*";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBoxTester);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 281);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(504, 85);
            this.panel5.TabIndex = 23;
            // 
            // comboBoxTester
            // 
            this.comboBoxTester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTester.BackColor = System.Drawing.Color.Gray;
            this.comboBoxTester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTester.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTester.ForeColor = System.Drawing.Color.White;
            this.comboBoxTester.FormattingEnabled = true;
            this.comboBoxTester.Location = new System.Drawing.Point(34, 39);
            this.comboBoxTester.Margin = new System.Windows.Forms.Padding(25, 0, 40, 10);
            this.comboBoxTester.Name = "comboBoxTester";
            this.comboBoxTester.Size = new System.Drawing.Size(448, 25);
            this.comboBoxTester.TabIndex = 4;
            this.comboBoxTester.DropDown += new System.EventHandler(this.comboBoxTester_DropDown);
            this.comboBoxTester.DropDownClosed += new System.EventHandler(this.comboBoxTester_DropDownClosed);
            this.comboBoxTester.Enter += new System.EventHandler(this.comboBoxTester_Enter);
            this.comboBoxTester.Leave += new System.EventHandler(this.comboBoxTester_Leave);
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
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Quality Assurance Lead*";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.RadioButtonPriorityHigh);
            this.panel6.Controls.Add(this.RadioButtonPriorityMed);
            this.panel6.Controls.Add(this.RadioButtonPriorityLow);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(513, 281);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(504, 85);
            this.panel6.TabIndex = 24;
            // 
            // RadioButtonPriorityHigh
            // 
            this.RadioButtonPriorityHigh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonPriorityHigh.AutoSize = true;
            this.RadioButtonPriorityHigh.Depth = 0;
            this.RadioButtonPriorityHigh.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonPriorityHigh.Location = new System.Drawing.Point(219, 36);
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
            this.RadioButtonPriorityMed.Location = new System.Drawing.Point(106, 36);
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
            this.RadioButtonPriorityLow.Location = new System.Drawing.Point(18, 36);
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(19, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Priority*";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateTimePickerStart);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 372);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(504, 85);
            this.panel7.TabIndex = 25;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(34, 40);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(215, 25);
            this.dateTimePickerStart.TabIndex = 8;
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
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Start Date*";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dateTimePickerEnd);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(513, 372);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 85);
            this.panel8.TabIndex = 26;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerEnd.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(22, 40);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(215, 25);
            this.dateTimePickerEnd.TabIndex = 9;
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
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "End Date*";
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
            this.labelTitle.Text = "Add New Project";
            // 
            // btnProjectSave
            // 
            this.btnProjectSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnProjectSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnProjectSave.FlatAppearance.BorderSize = 0;
            this.btnProjectSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectSave.ForeColor = System.Drawing.Color.White;
            this.btnProjectSave.Location = new System.Drawing.Point(40, 502);
            this.btnProjectSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnProjectSave.Name = "btnProjectSave";
            this.btnProjectSave.Size = new System.Drawing.Size(75, 25);
            this.btnProjectSave.TabIndex = 10;
            this.btnProjectSave.Text = "Save";
            this.btnProjectSave.UseVisualStyleBackColor = false;
            this.btnProjectSave.Click += new System.EventHandler(this.btnProjectSave_Click);
            // 
            // btnProjectCancel
            // 
            this.btnProjectCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProjectCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnProjectCancel.FlatAppearance.BorderSize = 0;
            this.btnProjectCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectCancel.ForeColor = System.Drawing.Color.White;
            this.btnProjectCancel.Location = new System.Drawing.Point(905, 502);
            this.btnProjectCancel.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.btnProjectCancel.Name = "btnProjectCancel";
            this.btnProjectCancel.Size = new System.Drawing.Size(75, 25);
            this.btnProjectCancel.TabIndex = 11;
            this.btnProjectCancel.Text = "Cancel";
            this.btnProjectCancel.UseVisualStyleBackColor = false;
            this.btnProjectCancel.Click += new System.EventHandler(this.btnProjectCancel_Click);
            // 
            // Projects_Tab_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserAdd);
            this.Name = "Projects_Tab_Child";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnProjectSave;
        private System.Windows.Forms.Button btnProjectCancel;
        private System.Windows.Forms.ComboBox comboBoxFrontEndDev;
        private System.Windows.Forms.ComboBox comboBoxBackEndDev;
        private System.Windows.Forms.ComboBox comboBoxTester;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPriorityHigh;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPriorityMed;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonPriorityLow;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}
