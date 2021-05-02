
namespace Ex2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgCl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCL_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCl_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCl_Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCl_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCl_Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CÔNG NGHỆ .NET";
            // 
            // dataGridView1
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCl_ID,
            this.dgCL_Name,
            this.dgCl_Class,
            this.dgCl_Birth,
            this.dgCl_Sex,
            this.dgCl_Country});
            this.dgvMain.Location = new System.Drawing.Point(7, 67);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dataGridView1";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(949, 379);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // dgCl_ID
            // 
            this.dgCl_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgCl_ID.HeaderText = "Mã SV";
            this.dgCl_ID.MinimumWidth = 6;
            this.dgCl_ID.Name = "dgCl_ID";
            this.dgCl_ID.Width = 78;
            // 
            // dgCL_Name
            // 
            this.dgCL_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCL_Name.HeaderText = "Tên SV";
            this.dgCL_Name.MinimumWidth = 6;
            this.dgCL_Name.Name = "dgCL_Name";
            // 
            // dgCl_Class
            // 
            this.dgCl_Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgCl_Class.HeaderText = "Lớp";
            this.dgCl_Class.MinimumWidth = 6;
            this.dgCl_Class.Name = "dgCl_Class";
            this.dgCl_Class.Width = 61;
            // 
            // dgCl_Birth
            // 
            this.dgCl_Birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgCl_Birth.HeaderText = "Ngày sinh";
            this.dgCl_Birth.MinimumWidth = 6;
            this.dgCl_Birth.Name = "dgCl_Birth";
            // 
            // dgCl_Sex
            // 
            this.dgCl_Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgCl_Sex.HeaderText = "Giới tính";
            this.dgCl_Sex.MinimumWidth = 6;
            this.dgCl_Sex.Name = "dgCl_Sex";
            this.dgCl_Sex.Width = 89;
            // 
            // dgCl_Country
            // 
            this.dgCl_Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCl_Country.HeaderText = "Quê quán";
            this.dgCl_Country.MinimumWidth = 6;
            this.dgCl_Country.Name = "dgCl_Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm theo lớp:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(303, 472);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 28);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(180, 475);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "@ALL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 529);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCL_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCl_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCl_Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCl_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCl_Country;
    }
}

