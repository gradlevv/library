namespace LibManagement.Report
{
    partial class frmReports
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbBorrowReport = new System.Windows.Forms.RadioButton();
            this.rdbBookReport = new System.Windows.Forms.RadioButton();
            this.rdbUserReport = new System.Windows.Forms.RadioButton();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.btnReportShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnReportShow);
            this.groupBox1.Controls.Add(this.rdbBorrowReport);
            this.groupBox1.Controls.Add(this.rdbBookReport);
            this.groupBox1.Controls.Add(this.rdbUserReport);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::LibManagement.Properties.Resources.Back1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(30, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbBorrowReport
            // 
            this.rdbBorrowReport.AutoSize = true;
            this.rdbBorrowReport.Location = new System.Drawing.Point(186, 60);
            this.rdbBorrowReport.Name = "rdbBorrowReport";
            this.rdbBorrowReport.Size = new System.Drawing.Size(96, 17);
            this.rdbBorrowReport.TabIndex = 2;
            this.rdbBorrowReport.TabStop = true;
            this.rdbBorrowReport.Text = "لیست امانت ها";
            this.rdbBorrowReport.UseVisualStyleBackColor = true;
            // 
            // rdbBookReport
            // 
            this.rdbBookReport.AutoSize = true;
            this.rdbBookReport.Location = new System.Drawing.Point(30, 20);
            this.rdbBookReport.Name = "rdbBookReport";
            this.rdbBookReport.Size = new System.Drawing.Size(92, 17);
            this.rdbBookReport.TabIndex = 1;
            this.rdbBookReport.TabStop = true;
            this.rdbBookReport.Text = "لیست کتاب ها";
            this.rdbBookReport.UseVisualStyleBackColor = true;
            // 
            // rdbUserReport
            // 
            this.rdbUserReport.AutoSize = true;
            this.rdbUserReport.Location = new System.Drawing.Point(199, 20);
            this.rdbUserReport.Name = "rdbUserReport";
            this.rdbUserReport.Size = new System.Drawing.Size(83, 17);
            this.rdbUserReport.TabIndex = 0;
            this.rdbUserReport.TabStop = true;
            this.rdbUserReport.Text = "لیست اعضاء";
            this.rdbUserReport.UseVisualStyleBackColor = true;
            // 
            // btnReportShow
            // 
            this.btnReportShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportShow.Image = global::LibManagement.Properties.Resources.Chart;
            this.btnReportShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportShow.Location = new System.Drawing.Point(199, 122);
            this.btnReportShow.Name = "btnReportShow";
            this.btnReportShow.Size = new System.Drawing.Size(78, 33);
            this.btnReportShow.TabIndex = 3;
            this.btnReportShow.Text = "نمایش";
            this.btnReportShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportShow.UseVisualStyleBackColor = true;
            this.btnReportShow.Click += new System.EventHandler(this.btnReportShow_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 187);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش گیری";
            this.ThemeName = "Windows8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReportShow;
        private System.Windows.Forms.RadioButton rdbBorrowReport;
        private System.Windows.Forms.RadioButton rdbBookReport;
        private System.Windows.Forms.RadioButton rdbUserReport;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
    }
}