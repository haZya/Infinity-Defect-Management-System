namespace Infinity.Tabs
{
    partial class Defects_Tab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDefect = new System.Windows.Forms.DataGridView();
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnSearchDefect = new System.Windows.Forms.Button();
            this.txtSearchDefects = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddNewDefect = new System.Windows.Forms.Button();
            this.DefectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaisedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRaised = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefect)).BeginInit();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDefect
            // 
            this.dgvDefect.AllowUserToAddRows = false;
            this.dgvDefect.AllowUserToDeleteRows = false;
            this.dgvDefect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DefectId,
            this.ProjectName,
            this.ModuleName,
            this.RaisedBy,
            this.AssignedTo,
            this.Status,
            this.Priority,
            this.DateRaised,
            this.DateClosed,
            this.DRR,
            this.DRE,
            this.Details,
            this.Action1,
            this.Action2});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDefect.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDefect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDefect.EnableHeadersVisualStyles = false;
            this.dgvDefect.Location = new System.Drawing.Point(0, 30);
            this.dgvDefect.Name = "dgvDefect";
            this.dgvDefect.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefect.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDefect.Size = new System.Drawing.Size(1020, 540);
            this.dgvDefect.TabIndex = 5;
            this.dgvDefect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefect_CellContentClick);
            // 
            // panelBar
            // 
            this.panelBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBar.Controls.Add(this.btnSearchDefect);
            this.panelBar.Controls.Add(this.txtSearchDefects);
            this.panelBar.Controls.Add(this.btnAddNewDefect);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1020, 30);
            this.panelBar.TabIndex = 4;
            // 
            // btnSearchDefect
            // 
            this.btnSearchDefect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchDefect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnSearchDefect.FlatAppearance.BorderSize = 0;
            this.btnSearchDefect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDefect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDefect.ForeColor = System.Drawing.Color.White;
            this.btnSearchDefect.Location = new System.Drawing.Point(941, 2);
            this.btnSearchDefect.Name = "btnSearchDefect";
            this.btnSearchDefect.Size = new System.Drawing.Size(75, 24);
            this.btnSearchDefect.TabIndex = 2;
            this.btnSearchDefect.Text = "Search";
            this.btnSearchDefect.UseVisualStyleBackColor = false;
            this.btnSearchDefect.Click += new System.EventHandler(this.btnSearchDefects_Click);
            // 
            // txtSearchDefects
            // 
            this.txtSearchDefects.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchDefects.Depth = 0;
            this.txtSearchDefects.Hint = "Search";
            this.txtSearchDefects.Location = new System.Drawing.Point(643, 3);
            this.txtSearchDefects.MaxLength = 32767;
            this.txtSearchDefects.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchDefects.Name = "txtSearchDefects";
            this.txtSearchDefects.PasswordChar = '\0';
            this.txtSearchDefects.SelectedText = "";
            this.txtSearchDefects.SelectionLength = 0;
            this.txtSearchDefects.SelectionStart = 0;
            this.txtSearchDefects.Size = new System.Drawing.Size(292, 23);
            this.txtSearchDefects.TabIndex = 1;
            this.txtSearchDefects.TabStop = false;
            this.txtSearchDefects.UseSystemPasswordChar = false;
            // 
            // btnAddNewDefect
            // 
            this.btnAddNewDefect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnAddNewDefect.FlatAppearance.BorderSize = 0;
            this.btnAddNewDefect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewDefect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewDefect.ForeColor = System.Drawing.Color.White;
            this.btnAddNewDefect.Location = new System.Drawing.Point(2, 2);
            this.btnAddNewDefect.Name = "btnAddNewDefect";
            this.btnAddNewDefect.Size = new System.Drawing.Size(75, 24);
            this.btnAddNewDefect.TabIndex = 0;
            this.btnAddNewDefect.Text = "Add New";
            this.btnAddNewDefect.UseVisualStyleBackColor = false;
            this.btnAddNewDefect.Click += new System.EventHandler(this.btnAddNewDefect_Click);
            // 
            // DefectId
            // 
            this.DefectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DefectId.DataPropertyName = "DefectId";
            this.DefectId.HeaderText = "Defect Id";
            this.DefectId.Name = "DefectId";
            this.DefectId.ReadOnly = true;
            this.DefectId.Visible = false;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectName.DataPropertyName = "ProjectName";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // ModuleName
            // 
            this.ModuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModuleName.DataPropertyName = "ModuleName";
            this.ModuleName.HeaderText = "Module Name";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.ReadOnly = true;
            // 
            // RaisedBy
            // 
            this.RaisedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RaisedBy.DataPropertyName = "RaisedBy";
            this.RaisedBy.HeaderText = "Raised By";
            this.RaisedBy.Name = "RaisedBy";
            this.RaisedBy.ReadOnly = true;
            // 
            // AssignedTo
            // 
            this.AssignedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssignedTo.DataPropertyName = "AssignedTo";
            this.AssignedTo.HeaderText = "Assigned To";
            this.AssignedTo.Name = "AssignedTo";
            this.AssignedTo.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // DateRaised
            // 
            this.DateRaised.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateRaised.DataPropertyName = "DateRaised";
            dataGridViewCellStyle12.NullValue = null;
            this.DateRaised.DefaultCellStyle = dataGridViewCellStyle12;
            this.DateRaised.HeaderText = "Date Raised";
            this.DateRaised.Name = "DateRaised";
            this.DateRaised.ReadOnly = true;
            // 
            // DateClosed
            // 
            this.DateClosed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateClosed.DataPropertyName = "DateClosed";
            dataGridViewCellStyle13.NullValue = null;
            this.DateClosed.DefaultCellStyle = dataGridViewCellStyle13;
            this.DateClosed.HeaderText = "Date Closed";
            this.DateClosed.Name = "DateClosed";
            this.DateClosed.ReadOnly = true;
            // 
            // DRR
            // 
            this.DRR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DRR.DataPropertyName = "DRR";
            this.DRR.HeaderText = "DRR";
            this.DRR.Name = "DRR";
            this.DRR.ReadOnly = true;
            // 
            // DRE
            // 
            this.DRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DRE.DataPropertyName = "DRE";
            this.DRE.HeaderText = "DRE";
            this.DRE.Name = "DRE";
            this.DRE.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            this.Details.DefaultCellStyle = dataGridViewCellStyle14;
            this.Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Details.HeaderText = "";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Details.Text = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // Action1
            // 
            this.Action1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            this.Action1.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.Action2.DefaultCellStyle = dataGridViewCellStyle16;
            this.Action2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Action2.HeaderText = "";
            this.Action2.Name = "Action2";
            this.Action2.ReadOnly = true;
            this.Action2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action2.Text = "Delete";
            this.Action2.UseColumnTextForButtonValue = true;
            // 
            // Defects_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDefect);
            this.Controls.Add(this.panelBar);
            this.Name = "Defects_Tab";
            this.Size = new System.Drawing.Size(1020, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefect)).EndInit();
            this.panelBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDefect;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnSearchDefect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchDefects;
        private System.Windows.Forms.Button btnAddNewDefect;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaisedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRaised;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRE;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Action1;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
    }
}
