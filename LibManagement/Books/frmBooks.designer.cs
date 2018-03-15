namespace LibManagement
{
    partial class frmBooks
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnType = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbBookName = new System.Windows.Forms.RadioButton();
            this.rdbBookWriter = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvBooks = new Telerik.WinControls.UI.RadGridView();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.Transparent;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnType.ForeColor = System.Drawing.Color.Black;
            this.btnType.Location = new System.Drawing.Point(15, 283);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(104, 34);
            this.btnType.TabIndex = 6;
            this.btnType.Text = "اضافه کردن موضوع";
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtSearch, true);
            this.txtSearch.Location = new System.Drawing.Point(15, 170);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(104, 21);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rdbBookName
            // 
            this.rdbBookName.AutoSize = true;
            this.rdbBookName.BackColor = System.Drawing.Color.Transparent;
            this.rdbBookName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rdbBookName.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.rdbBookName, true);
            this.rdbBookName.Location = new System.Drawing.Point(57, 219);
            this.rdbBookName.Name = "rdbBookName";
            this.rdbBookName.Size = new System.Drawing.Size(62, 17);
            this.rdbBookName.TabIndex = 5;
            this.rdbBookName.TabStop = true;
            this.rdbBookName.Text = "نام کتاب";
            this.rdbBookName.UseVisualStyleBackColor = false;
            this.rdbBookName.CheckedChanged += new System.EventHandler(this.rdbBookName_CheckedChanged);
            // 
            // rdbBookWriter
            // 
            this.rdbBookWriter.AutoSize = true;
            this.rdbBookWriter.BackColor = System.Drawing.Color.Transparent;
            this.rdbBookWriter.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rdbBookWriter.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.rdbBookWriter, true);
            this.rdbBookWriter.Location = new System.Drawing.Point(40, 196);
            this.rdbBookWriter.Name = "rdbBookWriter";
            this.rdbBookWriter.Size = new System.Drawing.Size(79, 17);
            this.rdbBookWriter.TabIndex = 4;
            this.rdbBookWriter.TabStop = true;
            this.rdbBookWriter.Text = "نام نویسنده";
            this.rdbBookWriter.UseVisualStyleBackColor = false;
            this.rdbBookWriter.CheckedChanged += new System.EventHandler(this.rdbBookWriter_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::LibManagement.Properties.Resources.Back1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(26, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnAdd);
            this.radGroupBox1.Controls.Add(this.rdbBookWriter);
            this.radGroupBox1.Controls.Add(this.btnDelete);
            this.radGroupBox1.Controls.Add(this.rdbBookName);
            this.radGroupBox1.Controls.Add(this.btnEdit);
            this.radGroupBox1.Controls.Add(this.txtSearch);
            this.radGroupBox1.Controls.Add(this.btnType);
            this.radGroupBox1.Controls.Add(this.btnRefresh);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(367, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(140, 412);
            this.radGroupBox1.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::LibManagement.Properties.Resources.notebook__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(15, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافه ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::LibManagement.Properties.Resources.notebook__2_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(15, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = global::LibManagement.Properties.Resources.notebook;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(15, 114);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::LibManagement.Properties.Resources.rotate;
            this.btnRefresh.Location = new System.Drawing.Point(26, 323);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 36);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBooks.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvBooks.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.dgvBooks.MasterTemplate.AllowAddNewRow = false;
            this.dgvBooks.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn5.FieldName = "Id";
            gridViewTextBoxColumn5.HeaderText = "شماره";
            gridViewTextBoxColumn5.Name = "column1";
            gridViewTextBoxColumn5.Width = 85;
            gridViewTextBoxColumn6.FieldName = "Bookname";
            gridViewTextBoxColumn6.HeaderText = "نام کتاب";
            gridViewTextBoxColumn6.Name = "column2";
            gridViewTextBoxColumn6.Width = 85;
            gridViewTextBoxColumn7.FieldName = "Writer";
            gridViewTextBoxColumn7.HeaderText = "نویسنده";
            gridViewTextBoxColumn7.Name = "column3";
            gridViewTextBoxColumn7.Width = 85;
            gridViewTextBoxColumn8.FieldName = "Type";
            gridViewTextBoxColumn8.HeaderText = "ژانر";
            gridViewTextBoxColumn8.Name = "column4";
            gridViewTextBoxColumn8.Width = 85;
            this.dgvBooks.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.dgvBooks.MasterTemplate.EnableGrouping = false;
            this.dgvBooks.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(361, 430);
            this.dgvBooks.TabIndex = 10;
            this.dgvBooks.Text = "radGridView1";
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 430);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBooks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کتاب ها";
            this.ThemeName = "Windows8";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbBookName;
        private System.Windows.Forms.RadioButton rdbBookWriter;
        private System.Windows.Forms.Button btnCancel;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView dgvBooks;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}