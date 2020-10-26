namespace Infinity.Tabs
{
    partial class Modules_Tab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBar = new System.Windows.Forms.Panel();
            this.btnAddNewModule = new System.Windows.Forms.Button();
            this.btnSearchModules = new System.Windows.Forms.Button();
            this.txtSearchModules = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.ModuleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBar.Controls.Add(this.btnAddNewModule);
            this.panelBar.Controls.Add(this.btnSearchModules);
            this.panelBar.Controls.Add(this.txtSearchModules);
            this.panelBar.Controls.Add(this.btnBack);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(1020, 30);
            this.panelBar.TabIndex = 4;
            // 
            // btnAddNewModule
            // 
            this.btnAddNewModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnAddNewModule.FlatAppearance.BorderSize = 0;
            this.btnAddNewModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewModule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewModule.ForeColor = System.Drawing.Color.White;
            this.btnAddNewModule.Location = new System.Drawing.Point(106, 2);
            this.btnAddNewModule.Name = "btnAddNewModule";
            this.btnAddNewModule.Size = new System.Drawing.Size(75, 24);
            this.btnAddNewModule.TabIndex = 3;
            this.btnAddNewModule.Text = "Add New";
            this.btnAddNewModule.UseVisualStyleBackColor = false;
            this.btnAddNewModule.Click += new System.EventHandler(this.btnAddNewModule_Click);
            // 
            // btnSearchModules
            // 
            this.btnSearchModules.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchModules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnSearchModules.FlatAppearance.BorderSize = 0;
            this.btnSearchModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchModules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchModules.ForeColor = System.Drawing.Color.White;
            this.btnSearchModules.Location = new System.Drawing.Point(941, 2);
            this.btnSearchModules.Name = "btnSearchModules";
            this.btnSearchModules.Size = new System.Drawing.Size(75, 24);
            this.btnSearchModules.TabIndex = 2;
            this.btnSearchModules.Text = "Search";
            this.btnSearchModules.UseVisualStyleBackColor = false;
            this.btnSearchModules.Click += new System.EventHandler(this.btnSearchModules_Click);
            // 
            // txtSearchModules
            // 
            this.txtSearchModules.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchModules.Depth = 0;
            this.txtSearchModules.Hint = "Search by Module, Function or Username";
            this.txtSearchModules.Location = new System.Drawing.Point(643, 3);
            this.txtSearchModules.MaxLength = 32767;
            this.txtSearchModules.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchModules.Name = "txtSearchModules";
            this.txtSearchModules.PasswordChar = '\0';
            this.txtSearchModules.SelectedText = "";
            this.txtSearchModules.SelectionLength = 0;
            this.txtSearchModules.SelectionStart = 0;
            this.txtSearchModules.Size = new System.Drawing.Size(292, 23);
            this.txtSearchModules.TabIndex = 1;
            this.txtSearchModules.TabStop = false;
            this.txtSearchModules.UseSystemPasswordChar = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 24);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back to Projects";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvModule
            // 
            this.dgvModule.AllowUserToAddRows = false;
            this.dgvModule.AllowUserToDeleteRows = false;
            this.dgvModule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleId,
            this.ProjectIdentity,
            this.Project,
            this.ModuleName,
            this.ModuleFunction,
            this.AddedBy,
            this.Action1,
            this.Action2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModule.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModule.EnableHeadersVisualStyles = false;
            this.dgvModule.Location = new System.Drawing.Point(0, 30);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModule.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvModule.Size = new System.Drawing.Size(1020, 540);
            this.dgvModule.TabIndex = 5;
            this.dgvModule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModule_CellContentClick);
            // 
            // ModuleId
            // 
            this.ModuleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModuleId.DataPropertyName = "ModuleId";
            this.ModuleId.HeaderText = "Module Id";
            this.ModuleId.Name = "ModuleId";
            this.ModuleId.ReadOnly = true;
            this.ModuleId.Visible = false;
            // 
            // ProjectIdentity
            // 
            this.ProjectIdentity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectIdentity.DataPropertyName = "ProjectId";
            this.ProjectIdentity.HeaderText = "ProjectId";
            this.ProjectIdentity.Name = "ProjectIdentity";
            this.ProjectIdentity.ReadOnly = true;
            this.ProjectIdentity.Visible = false;
            // 
            // Project
            // 
            this.Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Project.HeaderText = "Project Name";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            // 
            // ModuleName
            // 
            this.ModuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModuleName.DataPropertyName = "ModuleName";
            this.ModuleName.HeaderText = "Module Name";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.ReadOnly = true;
            // 
            // ModuleFunction
            // 
            this.ModuleFunction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModuleFunction.DataPropertyName = "ModuleFunction";
            this.ModuleFunction.HeaderText = "Module Function";
            this.ModuleFunction.Name = "ModuleFunction";
            this.ModuleFunction.ReadOnly = true;
            // 
            // AddedBy
            // 
            this.AddedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddedBy.DataPropertyName = "AddedBy";
            dataGridViewCellStyle2.NullValue = null;
            this.AddedBy.DefaultCellStyle = dataGridViewCellStyle2;
            this.AddedBy.HeaderText = "Added By";
            this.AddedBy.Name = "AddedBy";
            this.AddedBy.ReadOnly = true;
            // 
            // Action1
            // 
            this.Action1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.Action1.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.Action2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Action2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Action2.HeaderText = "";
            this.Action2.Name = "Action2";
            this.Action2.ReadOnly = true;
            this.Action2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action2.Text = "Delete";
            this.Action2.UseColumnTextForButtonValue = true;
            // 
            // Modules_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvModule);
            this.Controls.Add(this.panelBar);
            this.Name = "Modules_Tab";
            this.Size = new System.Drawing.Size(1020, 570);
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Button btnSearchModules;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchModules;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNewModule;
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedBy;
        private System.Windows.Forms.DataGridViewButtonColumn Action1;
        private System.Windows.Forms.DataGridViewButtonColumn Action2;
    }
}
