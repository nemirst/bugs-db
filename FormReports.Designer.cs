namespace ADAS_D5
{
    partial class FormReports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ViewCombinedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._ADAS_D5_BugsContextDataSetReports = new ADAS_D5._ADAS_D5_BugsContextDataSetReports();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewCombinedTableAdapter = new ADAS_D5._ADAS_D5_BugsContextDataSetReportsTableAdapters.ViewCombinedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCombinedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ADAS_D5_BugsContextDataSetReports)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCombinedBindingSource
            // 
            this.ViewCombinedBindingSource.DataMember = "ViewCombined";
            this.ViewCombinedBindingSource.DataSource = this._ADAS_D5_BugsContextDataSetReports;
            // 
            // _ADAS_D5_BugsContextDataSetReports
            // 
            this._ADAS_D5_BugsContextDataSetReports.DataSetName = "_ADAS_D5_BugsContextDataSetReports";
            this._ADAS_D5_BugsContextDataSetReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReports";
            reportDataSource1.Value = this.ViewCombinedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ADAS_D5.ReportBugsAssigned.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(731, 340);
            this.reportViewer1.TabIndex = 0;
            // 
            // ViewCombinedTableAdapter
            // 
            this.ViewCombinedTableAdapter.ClearBeforeFill = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 340);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCombinedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ADAS_D5_BugsContextDataSetReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewCombinedBindingSource;
        private _ADAS_D5_BugsContextDataSetReports _ADAS_D5_BugsContextDataSetReports;
        private _ADAS_D5_BugsContextDataSetReportsTableAdapters.ViewCombinedTableAdapter ViewCombinedTableAdapter;
    }
}