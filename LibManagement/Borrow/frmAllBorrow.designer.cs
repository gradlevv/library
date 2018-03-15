namespace LibManagement.Borrow
{
    partial class frmAllBorrow
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbBookId = new System.Windows.Forms.RadioButton();
            this.rdbUserId = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.dgvAllBorrow = new Telerik.WinControls.UI.RadGridView();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.rdbBookId);
            this.groupBox1.Controls.Add(this.rdbUserId);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.highlighter1.SetHighlightOnFocus(this.txtSearch, true);
            this.txtSearch.Location = new System.Drawing.Point(227, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(96, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // rdbBookId
            // 
            this.rdbBookId.AutoSize = true;
            this.highlighter1.SetHighlightOnFocus(this.rdbBookId, true);
            this.rdbBookId.Location = new System.Drawing.Point(338, 58);
            this.rdbBookId.Name = "rdbBookId";
            this.rdbBookId.Size = new System.Drawing.Size(79, 17);
            this.rdbBookId.TabIndex = 3;
            this.rdbBookId.TabStop = true;
            this.rdbBookId.Text = "شماره کتاب";
            this.rdbBookId.UseVisualStyleBackColor = true;
            // 
            // rdbUserId
            // 
            this.rdbUserId.AutoSize = true;
            this.highlighter1.SetHighlightOnFocus(this.rdbUserId, true);
            this.rdbUserId.Location = new System.Drawing.Point(339, 28);
            this.rdbUserId.Name = "rdbUserId";
            this.rdbUserId.Size = new System.Drawing.Size(78, 17);
            this.rdbUserId.TabIndex = 2;
            this.rdbUserId.TabStop = true;
            this.rdbUserId.Text = "شماره کاربر";
            this.rdbUserId.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::LibManagement.Properties.Resources.Back;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(19, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::LibManagement.Properties.Resources.rotate;
            this.btnRefresh.Location = new System.Drawing.Point(19, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::LibManagement.Properties.Resources.check__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(484, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافه ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::LibManagement.Properties.Resources.del0ete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(484, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.FieldName = "BookId";
            gridViewTextBoxColumn2.HeaderText = "شماره کتاب";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "BorrowerId";
            gridViewTextBoxColumn3.HeaderText = "شماره کاربر";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 122;
            gridViewTextBoxColumn4.FieldName = "Bookname";
            gridViewTextBoxColumn4.HeaderText = "نام کتاب";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 122;
            gridViewTextBoxColumn5.FieldName = "FName";
            gridViewTextBoxColumn5.HeaderText = "نام کاربر";
            gridViewTextBoxColumn5.Name = "column5";
            gridViewTextBoxColumn5.Width = 122;
            gridViewTextBoxColumn6.FieldName = "LName";
            gridViewTextBoxColumn6.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn6.Name = "column6";
            gridViewTextBoxColumn6.Width = 125;
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
            this.dgvAllBorrow.Size = new System.Drawing.Size(636, 335);
            this.dgvAllBorrow.TabIndex = 2;
            this.dgvAllBorrow.Text = "radGridView1";
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // frmAllBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 453);
            this.Controls.Add(this.dgvAllBorrow);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllBorrow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "همه امانت ها";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmAllBorrow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbBookId;
        private System.Windows.Forms.RadioButton rdbUserId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadGridView dgvAllBorrow;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}