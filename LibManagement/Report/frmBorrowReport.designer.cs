namespace LibManagement.Report
{
    partial class frmBorrowReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrowReport));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.dgvAllBorrow = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::LibManagement.Properties.Resources.P0rint;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(492, 11);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(73, 32);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "چاپ";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::LibManagement.Properties.Resources.Back1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(20, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 32);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // stiReport
            // 
            this.stiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport.ReportAlias = "Report";
            this.stiReport.ReportGuid = "5da17ac1fb6a49a4a2a4f951dd029d3c";
            this.stiReport.ReportName = "Report";
            this.stiReport.ReportSource = resources.GetString("stiReport.ReportSource");
            this.stiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport.UseProgressInThread = false;
            // 
            // dgvAllBorrow
            // 
            this.dgvAllBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllBorrow.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvAllBorrow.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvAllBorrow.MasterTemplate.AllowAddNewRow = false;
            this.dgvAllBorrow.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.FieldName = "BookId";
            gridViewTextBoxColumn2.HeaderText = "شماره کتاب";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 121;
            gridViewTextBoxColumn3.FieldName = "BorrowerId";
            gridViewTextBoxColumn3.HeaderText = "شماره کاربر";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 121;
            gridViewTextBoxColumn4.FieldName = "Bookname";
            gridViewTextBoxColumn4.HeaderText = "نام کتاب";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 123;
            gridViewTextBoxColumn5.FieldName = "FName";
            gridViewTextBoxColumn5.HeaderText = "نام کاربر";
            gridViewTextBoxColumn5.Name = "column5";
            gridViewTextBoxColumn5.Width = 123;
            gridViewTextBoxColumn6.FieldName = "LName";
            gridViewTextBoxColumn6.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn6.Name = "column6";
            gridViewTextBoxColumn6.Width = 123;
            this.dgvAllBorrow.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dgvAllBorrow.MasterTemplate.EnableGrouping = false;
            this.dgvAllBorrow.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvAllBorrow.Name = "dgvAllBorrow";
            this.dgvAllBorrow.ReadOnly = true;
            this.dgvAllBorrow.Size = new System.Drawing.Size(631, 335);
            this.dgvAllBorrow.TabIndex = 3;
            this.dgvAllBorrow.Text = "radGridView1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnReport);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 351);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(607, 57);
            this.radGroupBox1.TabIndex = 4;
            // 
            // frmBorrowReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.dgvAllBorrow);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrowReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش گیری امانت ها";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmBorrowReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCancel;
        private Stimulsoft.Report.StiReport stiReport;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadGridView dgvAllBorrow;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
    }
}