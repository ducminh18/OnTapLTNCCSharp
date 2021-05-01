
namespace Ex1
{
    partial class frmCongNgheNET
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cHID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHDatebirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDatebirth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.mtbDatebirth = new System.Windows.Forms.MaskedTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHID,
            this.cHName,
            this.cHClass,
            this.cHDatebirth,
            this.cHGender,
            this.cHAddress});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 70);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(897, 314);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // cHID
            // 
            this.cHID.Text = "Mã SV";
            // 
            // cHName
            // 
            this.cHName.Text = "Tên SV";
            this.cHName.Width = 194;
            // 
            // cHClass
            // 
            this.cHClass.Text = "Lớp";
            this.cHClass.Width = 89;
            // 
            // cHDatebirth
            // 
            this.cHDatebirth.Text = "Ngày sinh";
            this.cHDatebirth.Width = 130;
            // 
            // cHGender
            // 
            this.cHGender.Text = "Giới tính";
            this.cHGender.Width = 79;
            // 
            // cHAddress
            // 
            this.cHAddress.Text = "Quê quán";
            this.cHAddress.Width = 320;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÔNG NGHỆ .NET";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(25, 424);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(64, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Mã SV:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(342, 424);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 20);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Lớp:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(135, 424);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Tên SV:";
            // 
            // lblDatebirth
            // 
            this.lblDatebirth.AutoSize = true;
            this.lblDatebirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatebirth.Location = new System.Drawing.Point(487, 424);
            this.lblDatebirth.Name = "lblDatebirth";
            this.lblDatebirth.Size = new System.Drawing.Size(88, 20);
            this.lblDatebirth.TabIndex = 5;
            this.lblDatebirth.Text = "Ngày sinh:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(768, 424);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Quê quán:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(632, 424);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(76, 20);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Giới tính:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(29, 469);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 22);
            this.txtID.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 469);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 22);
            this.txtName.TabIndex = 9;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(346, 469);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(106, 22);
            this.txtClass.TabIndex = 10;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(636, 469);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(87, 22);
            this.txtGender.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(772, 469);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(137, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // mtbDatebirth
            // 
            this.mtbDatebirth.Location = new System.Drawing.Point(491, 468);
            this.mtbDatebirth.Mask = "00/00/0000";
            this.mtbDatebirth.Name = "mtbDatebirth";
            this.mtbDatebirth.Size = new System.Drawing.Size(112, 22);
            this.mtbDatebirth.TabIndex = 13;
            this.mtbDatebirth.ValidatingType = typeof(System.DateTime);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 518);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 33);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCongNgheNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 564);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.mtbDatebirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDatebirth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "frmCongNgheNET";
            this.Text = "CÔNG NGHỆ .NET";
            this.Load += new System.EventHandler(this.frmCongNgheNET_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cHID;
        private System.Windows.Forms.ColumnHeader cHName;
        private System.Windows.Forms.ColumnHeader cHClass;
        private System.Windows.Forms.ColumnHeader cHDatebirth;
        private System.Windows.Forms.ColumnHeader cHGender;
        private System.Windows.Forms.ColumnHeader cHAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDatebirth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox mtbDatebirth;
        private System.Windows.Forms.Button btnDelete;
    }
}

