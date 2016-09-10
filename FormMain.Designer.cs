namespace ADAS_D5
{
    partial class FormMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BugId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDASD5BugsContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ADAS_D5_BugsContextDataSet = new ADAS_D5._ADAS_D5_BugsContextDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new ADAS_D5._ADAS_D5_BugsContextDataSetTableAdapters.EmployeesTableAdapter();
            this.bugsTableAdapter = new ADAS_D5._ADAS_D5_BugsContextDataSetTableAdapters.BugsTableAdapter();
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkedListBoxStatus = new System.Windows.Forms.CheckedListBox();
            this.buttonReportNew = new System.Windows.Forms.Button();
            this.comboBoxAssigned = new System.Windows.Forms.ComboBox();
            this.labelAssignedTo = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDASD5BugsContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ADAS_D5_BugsContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BugId,
            this.titleDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(507, 177);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // BugId
            // 
            this.BugId.DataPropertyName = "BugId";
            this.BugId.HeaderText = "BugId";
            this.BugId.Name = "BugId";
            this.BugId.ReadOnly = true;
            this.BugId.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "Assigned to";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            this.employeeEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.aDASD5BugsContextDataSetBindingSource;
            // 
            // aDASD5BugsContextDataSetBindingSource
            // 
            this.aDASD5BugsContextDataSetBindingSource.DataSource = this._ADAS_D5_BugsContextDataSet;
            this.aDASD5BugsContextDataSetBindingSource.Position = 0;
            // 
            // _ADAS_D5_BugsContextDataSet
            // 
            this._ADAS_D5_BugsContextDataSet.DataSetName = "_ADAS_D5_BugsContextDataSet";
            this._ADAS_D5_BugsContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.aDASD5BugsContextDataSetBindingSource;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(312, 31);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status:";
            // 
            // checkedListBoxStatus
            // 
            this.checkedListBoxStatus.CheckOnClick = true;
            this.checkedListBoxStatus.FormattingEnabled = true;
            this.checkedListBoxStatus.Location = new System.Drawing.Point(315, 58);
            this.checkedListBoxStatus.Name = "checkedListBoxStatus";
            this.checkedListBoxStatus.Size = new System.Drawing.Size(102, 64);
            this.checkedListBoxStatus.TabIndex = 3;
            this.checkedListBoxStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxStatus_ItemCheck);
            // 
            // buttonReportNew
            // 
            this.buttonReportNew.Location = new System.Drawing.Point(447, 14);
            this.buttonReportNew.Name = "buttonReportNew";
            this.buttonReportNew.Size = new System.Drawing.Size(72, 42);
            this.buttonReportNew.TabIndex = 4;
            this.buttonReportNew.Text = "Report new bug";
            this.buttonReportNew.UseVisualStyleBackColor = true;
            this.buttonReportNew.Click += new System.EventHandler(this.buttonReportNew_Click);
            // 
            // comboBoxAssigned
            // 
            this.comboBoxAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAssigned.FormattingEnabled = true;
            this.comboBoxAssigned.Location = new System.Drawing.Point(6, 101);
            this.comboBoxAssigned.Name = "comboBoxAssigned";
            this.comboBoxAssigned.Size = new System.Drawing.Size(269, 21);
            this.comboBoxAssigned.TabIndex = 2;
            this.comboBoxAssigned.SelectedIndexChanged += new System.EventHandler(this.comboBoxAssigned_SelectedIndexChanged);
            // 
            // labelAssignedTo
            // 
            this.labelAssignedTo.AutoSize = true;
            this.labelAssignedTo.Location = new System.Drawing.Point(3, 82);
            this.labelAssignedTo.Name = "labelAssignedTo";
            this.labelAssignedTo.Size = new System.Drawing.Size(65, 13);
            this.labelAssignedTo.TabIndex = 12;
            this.labelAssignedTo.Text = "Assigned to:";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.textBoxTitle);
            this.groupBoxFilters.Controls.Add(this.labelTitle);
            this.groupBoxFilters.Controls.Add(this.checkedListBoxStatus);
            this.groupBoxFilters.Controls.Add(this.comboBoxAssigned);
            this.groupBoxFilters.Controls.Add(this.labelStatus);
            this.groupBoxFilters.Controls.Add(this.labelAssignedTo);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 9);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(429, 138);
            this.groupBoxFilters.TabIndex = 14;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(6, 47);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(269, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Title:";
            // 
            // buttonReports
            // 
            this.buttonReports.Location = new System.Drawing.Point(447, 62);
            this.buttonReports.Name = "buttonReports";
            this.buttonReports.Size = new System.Drawing.Size(72, 42);
            this.buttonReports.TabIndex = 15;
            this.buttonReports.Text = "Reports";
            this.buttonReports.UseVisualStyleBackColor = true;
            this.buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 338);
            this.Controls.Add(this.buttonReports);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.buttonReportNew);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Bugs";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDASD5BugsContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ADAS_D5_BugsContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aDASD5BugsContextDataSetBindingSource;
        private _ADAS_D5_BugsContextDataSet _ADAS_D5_BugsContextDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private _ADAS_D5_BugsContextDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private _ADAS_D5_BugsContextDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.CheckedListBox checkedListBoxStatus;
        private System.Windows.Forms.Button buttonReportNew;
        private System.Windows.Forms.ComboBox comboBoxAssigned;
        private System.Windows.Forms.Label labelAssignedTo;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BugId;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonReports;
    }
}