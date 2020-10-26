namespace Infinity.Tabs
{
    partial class Projects_Tab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnSearchProjects = new System.Windows.Forms.Button();
            this.txtSearchProjects = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddNewProject = new System.Windows.Forms.Button();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrontEndDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackEndDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modules = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProject
            // 
            this.dgvProject.AllowUserToAddRows = false;
            this.dgvProject.AllowUserToDeleteRows = false;
            this.dgvProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectId,
            this.ProjectName,
            this.Manager,
            this.FrontEndDev,
            this.BackEndDev,
            this.Tester,
            this.Priority,
            this.StartDate,
            this.EndDate,
            this.Modules,
            this.Action1,
            this.Action2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProject.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProject.EnableHeadersVisualStyles = false;
            this.dgvProject.Location = new System.Drawing.Point(0, 30);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProject.Size = new System.Drawing.Size(1020, 540);
            this.dgvProject.TabIndex = 3;
            this.dgvProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellContentClick);
            // 
            // panelBar
            // 
            this.panelBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBar.Controls.Add(this.btnSearchProjects);
            this.panelBar.Controls.Add(this.txtSearchProjects);
            this.panelBar.Controls.Add(this.btnAddNewProject);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1020, 30);
            this.panelBar.TabIndex = 2;
            // 
            // btnSearchProjects
            // 
            this.btnSearchProjects.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnSearchProjects.FlatAppearance.BorderSize = 0;
            this.btnSearchProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProjects.ForeColor = System.Drawing.Color.White;
            this.btnSearchProjects.Location = new System.Drawing.Point(941, 2);
            this.btnSearchProjects.Name = "btnSearchProjects";
            this.btnSearchProjects.Size = new System.Drawing.Size(75, 24);
            this.btnSearchProjects.TabIndex = 2;
            this.btnSearchProjects.Text = "Search";
            this.btnSearchProjects.UseVisualStyleBackColor = false;
            this.btnSearchProjects.Click += new System.EventHandler(this.btnSearchProjects_Click);
            // 
            // txtSearchProjects
            // 
            this.txtSearchProjects.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchProjects.Depth = 0;
            this.txtSearchProjects.Hint = "Search by Project Name or Username";
            this.txtSearchProjects.Location = new System.Drawing.Point(643, 3);
            this.txtSearchProjects.MaxLength = 32767;
            this.txtSearchProjects.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchProjects.Name = "txtSearchProjects";
            this.txtSearchProjects.PasswordChar = '\0';
            this.txtSearchProjects.SelectedText = "";
            this.txtSearchProjects.SelectionLength = 0;
            this.txtSearchProjects.SelectionStart = 0;
            this.txtSearchProjects.Size = new System.Drawing.Size(292, 23);
            this.txtSearchProjects.TabIndex = 1;
            this.txtSearchProjects.TabStop = false;
            this.txtSearchProjects.UseSystemPasswordChar = false;
            // 
            // btnAddNewProject
            // 
            this.btnAddNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnAddNewProject.FlatAppearance.BorderSize = 0;
            this.btnAddNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProject.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProject.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewProject.Name = "btnAddNewProject";
            this.btnAddNewProject.Size = new System.Drawing.Size(75, 24);
            this.btnAddNewProject.TabIndex = 0;
            this.btnAddNewProject.Text = "Add New";
            this.btnAddNewProject.UseVisualStyleBackColor = false;
            this.btnAddNewProject.Click += new System.EventHandler(this.btnAddNewProject_Click);
            // 
            // ProjectId
            // 
            this.ProjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectId.DataPropertyName = "ProjectId";
            this.ProjectId.HeaderText = "Project Id";
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.ReadOnly = true;
            this.ProjectId.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectName.DataPropertyName = "ProjectName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // Manager
            // 
            this.Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Manager.DataPropertyName = "Manager";
            this.Manager.HeaderText = "Manager";
            this.Manager.Name = "Manager";
            this.Manager.ReadOnly = true;
            // 
            // FrontEndDev
            // 
            this.FrontEndDev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FrontEndDev.DataPropertyName = "FrontEndDev";
            this.FrontEndDev.HeaderText = "Front-End Developer";
            this.FrontEndDev.Name = "FrontEndDev";
            this.FrontEndDev.ReadOnly = true;
            // 
            // BackEndDev
            // 
            this.BackEndDev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BackEndDev.DataPropertyName = "BackEndDev";
            this.BackEndDev.HeaderText = "Back-End Developer";
            this.BackEndDev.Name = "BackEndDev";
            this.BackEndDev.ReadOnly = true;
            // 
            // Tester
            // 
            this.Tester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tester.DataPropertyName = "Tester";
            this.Tester.HeaderText = "QA Lead";
            this.Tester.Name = "Tester";
            this.Tester.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Modules
            // 
            this.Modules.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.Modules.DefaultCellStyle = dataGridViewCellStyle5;
            this.Modules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modules.HeaderText = "";
            this.Modules.Name = "Modules";
            this.Modules.ReadOnly = true;
            this.Modules.Text = "Modules";
            this.Modules.UseColumnTextForButtonValue = true;
            // 
            // Action1
            // 
            this.Action1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.Action1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Action1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Action1.HeaderText = "";
            this.Action1.Name = "Action1";
            this.Action1.ReadOnly = true;
            this.Action1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action1.Text = "Update";
            this.Action1.UseColumnTextForButtonValue = true;
            // 
            // Action2
            // 
            this.Action2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.Action2.DefaultCellStyle = dataGridViewCellStyle7;
            this.Action2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Action2.HeaderText = "";
            this.Action2.Name = "Action2";
            this.Action2.ReadOnly = true;
            this.Action2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action2.Text = "Delete";
            this.Action2.UseColumnTextForButtonValue = true;
            // 
            // Projects_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProject);
            this.Controls.Add(this.panelBar);
            this.Name = "Projects_Tab";
            this.Size = new System.Drawing.Size(1020, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProject;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnSearchProjects;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchProjects;
        private System.Windows.Forms.Button btnAddNewProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrontEndDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackEndDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewButtonColumn Modules;
        private System.Windows.Forms.DataGridViewButtonColumn Action1;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
    }
}
