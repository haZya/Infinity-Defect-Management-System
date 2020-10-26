namespace Infinity.Tabs.Child_Tabs
{
    partial class Modules_Tab_Child
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
            this.btnModuleSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProjectName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtModuleName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtModuleFunction = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddedBy = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnModuleCancel = new System.Windows.Forms.Button();
            this.panelUserAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserAdd
            // 
            this.panelUserAdd.ColumnCount = 2;
            this.panelUserAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUserAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelUserAdd.Controls.Add(this.btnModuleSave, 0, 3);
            this.panelUserAdd.Controls.Add(this.panel1, 0, 1);
            this.panelUserAdd.Controls.Add(this.panel2, 1, 1);
            this.panelUserAdd.Controls.Add(this.panel3, 0, 2);
            this.panelUserAdd.Controls.Add(this.panel4, 1, 2);
            this.panelUserAdd.Controls.Add(this.labelTitle, 0, 0);
            this.panelUserAdd.Controls.Add(this.btnModuleCancel, 1, 3);
            this.panelUserAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserAdd.Location = new System.Drawing.Point(0, 0);
            this.panelUserAdd.Name = "panelUserAdd";
            this.panelUserAdd.RowCount = 4;
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.20202F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.25253F));
            this.panelUserAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelUserAdd.Size = new System.Drawing.Size(1020, 570);
            this.panelUserAdd.TabIndex = 7;
            // 
            // btnModuleSave
            // 
            this.btnModuleSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModuleSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnModuleSave.FlatAppearance.BorderSize = 0;
            this.btnModuleSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleSave.ForeColor = System.Drawing.Color.White;
            this.btnModuleSave.Location = new System.Drawing.Point(40, 485);
            this.btnModuleSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.btnModuleSave.Name = "btnModuleSave";
            this.btnModuleSave.Size = new System.Drawing.Size(75, 25);
            this.btnModuleSave.TabIndex = 28;
            this.btnModuleSave.Text = "Save";
            this.btnModuleSave.UseVisualStyleBackColor = false;
            this.btnModuleSave.Click += new System.EventHandler(this.btnModuleSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtProjectName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 149);
            this.panel1.TabIndex = 19;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Depth = 0;
            this.txtProjectName.Enabled = false;
            this.txtProjectName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.Hint = "Project Name";
            this.txtProjectName.Location = new System.Drawing.Point(37, 73);
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
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 0, 25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Project Name*";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtModuleName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(513, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 149);
            this.panel2.TabIndex = 20;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModuleName.Depth = 0;
            this.txtModuleName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleName.Hint = "Module Name";
            this.txtModuleName.Location = new System.Drawing.Point(22, 73);
            this.txtModuleName.MaxLength = 32767;
            this.txtModuleName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.PasswordChar = '\0';
            this.txtModuleName.SelectedText = "";
            this.txtModuleName.SelectionLength = 0;
            this.txtModuleName.SelectionStart = 0;
            this.txtModuleName.Size = new System.Drawing.Size(445, 23);
            this.txtModuleName.TabIndex = 13;
            this.txtModuleName.TabStop = false;
            this.txtModuleName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Module Name*";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtModuleFunction);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 149);
            this.panel3.TabIndex = 21;
            // 
            // txtModuleFunction
            // 
            this.txtModuleFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModuleFunction.Depth = 0;
            this.txtModuleFunction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleFunction.Hint = "Module Function";
            this.txtModuleFunction.Location = new System.Drawing.Point(37, 71);
            this.txtModuleFunction.MaxLength = 32767;
            this.txtModuleFunction.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtModuleFunction.Name = "txtModuleFunction";
            this.txtModuleFunction.PasswordChar = '\0';
            this.txtModuleFunction.SelectedText = "";
            this.txtModuleFunction.SelectionLength = 0;
            this.txtModuleFunction.SelectionStart = 0;
            this.txtModuleFunction.Size = new System.Drawing.Size(445, 23);
            this.txtModuleFunction.TabIndex = 14;
            this.txtModuleFunction.TabStop = false;
            this.txtModuleFunction.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 15, 25, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Module Function*";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAddedBy);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(513, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 149);
            this.panel4.TabIndex = 22;
            // 
            // txtAddedBy
            // 
            this.txtAddedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddedBy.Depth = 0;
            this.txtAddedBy.Enabled = false;
            this.txtAddedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddedBy.Hint = "Added By";
            this.txtAddedBy.Location = new System.Drawing.Point(22, 71);
            this.txtAddedBy.MaxLength = 32767;
            this.txtAddedBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddedBy.Name = "txtAddedBy";
            this.txtAddedBy.PasswordChar = '\0';
            this.txtAddedBy.SelectedText = "";
            this.txtAddedBy.SelectionLength = 0;
            this.txtAddedBy.SelectionStart = 0;
            this.txtAddedBy.Size = new System.Drawing.Size(445, 23);
            this.txtAddedBy.TabIndex = 15;
            this.txtAddedBy.TabStop = false;
            this.txtAddedBy.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(19, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 15, 40, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Added By*";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(30, 39);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(30, 0, 25, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(455, 37);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Add New Module";
            // 
            // btnModuleCancel
            // 
            this.btnModuleCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModuleCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnModuleCancel.FlatAppearance.BorderSize = 0;
            this.btnModuleCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleCancel.ForeColor = System.Drawing.Color.White;
            this.btnModuleCancel.Location = new System.Drawing.Point(905, 485);
            this.btnModuleCancel.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.btnModuleCancel.Name = "btnModuleCancel";
            this.btnModuleCancel.Size = new System.Drawing.Size(75, 25);
            this.btnModuleCancel.TabIndex = 11;
            this.btnModuleCancel.Text = "Cancel";
            this.btnModuleCancel.UseVisualStyleBackColor = false;
            this.btnModuleCancel.Click += new System.EventHandler(this.btnModulesCancel_Click);
            // 
            // Modules_Tab_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserAdd);
            this.Name = "Modules_Tab_Child";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelUserAdd;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTitle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtModuleName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtModuleFunction;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddedBy;
        private System.Windows.Forms.Button btnModuleSave;
        private System.Windows.Forms.Button btnModuleCancel;
    }
}
