
namespace lab03
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
            this.lblQL = new System.Windows.Forms.Label();
            this.grbBox1 = new System.Windows.Forms.GroupBox();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblHT = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblNu = new System.Windows.Forms.Label();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ĐTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQL
            // 
            this.lblQL.AutoSize = true;
            this.lblQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQL.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblQL.Location = new System.Drawing.Point(211, 39);
            this.lblQL.Name = "lblQL";
            this.lblQL.Size = new System.Drawing.Size(342, 29);
            this.lblQL.TabIndex = 0;
            this.lblQL.Text = "Quản lý Thông Tin Sinh viên";
            this.lblQL.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbBox1
            // 
            this.grbBox1.Controls.Add(this.cmbKhoa);
            this.grbBox1.Controls.Add(this.rbNu);
            this.grbBox1.Controls.Add(this.rbNam);
            this.grbBox1.Controls.Add(this.txtBox3);
            this.grbBox1.Controls.Add(this.txtBox2);
            this.grbBox1.Controls.Add(this.txtBox1);
            this.grbBox1.Controls.Add(this.lblCN);
            this.grbBox1.Controls.Add(this.lblDTB);
            this.grbBox1.Controls.Add(this.lblGT);
            this.grbBox1.Controls.Add(this.lblHT);
            this.grbBox1.Controls.Add(this.lblMSV);
            this.grbBox1.Location = new System.Drawing.Point(25, 124);
            this.grbBox1.Name = "grbBox1";
            this.grbBox1.Size = new System.Drawing.Size(269, 210);
            this.grbBox1.TabIndex = 1;
            this.grbBox1.TabStop = false;
            this.grbBox1.Text = "Thông Tin Sinh Viên";
            this.grbBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(18, 29);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(70, 13);
            this.lblMSV.TabIndex = 2;
            this.lblMSV.Text = "Mã Sinh Viên";
            this.lblMSV.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(18, 63);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(43, 13);
            this.lblHT.TabIndex = 2;
            this.lblHT.Text = "Họ Tên";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(18, 98);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(51, 13);
            this.lblGT.TabIndex = 2;
            this.lblGT.Text = "Giới Tính";
            this.lblGT.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(18, 136);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(48, 13);
            this.lblDTB.TabIndex = 2;
            this.lblDTB.Text = "Điểm TB";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.Location = new System.Drawing.Point(18, 171);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(78, 13);
            this.lblCN.TabIndex = 2;
            this.lblCN.Text = "Chuyên Ngành";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(119, 22);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 3;
            this.txtBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(119, 56);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 20);
            this.txtBox2.TabIndex = 3;
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(119, 129);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 3;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(119, 96);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 4;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(194, 94);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 4;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbKhoa.Location = new System.Drawing.Point(119, 163);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoa.TabIndex = 5;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnThemSua
            // 
            this.btnThemSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemSua.Location = new System.Drawing.Point(116, 370);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(75, 23);
            this.btnThemSua.TabIndex = 2;
            this.btnThemSua.Text = "Thêm/Sữa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(207, 370);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.GioiTinh,
            this.ĐTB,
            this.Khoa});
            this.dgvStudent.Location = new System.Drawing.Point(294, 124);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(497, 273);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(488, 411);
            this.lblNam.Name = "lblNam";
            this.lblNam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNam.Size = new System.Drawing.Size(74, 13);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Tổng SV Nam";
            this.lblNam.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNu
            // 
            this.lblNu.AutoSize = true;
            this.lblNu.Location = new System.Drawing.Point(664, 411);
            this.lblNu.Name = "lblNu";
            this.lblNu.Size = new System.Drawing.Size(21, 13);
            this.lblNu.TabIndex = 2;
            this.lblNu.Text = "Nữ";
            this.lblNu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtBox4
            // 
            this.txtBox4.Enabled = false;
            this.txtBox4.Location = new System.Drawing.Point(568, 411);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(67, 20);
            this.txtBox4.TabIndex = 3;
            this.txtBox4.Text = "0";
            this.txtBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBox5
            // 
            this.txtBox5.Enabled = false;
            this.txtBox5.Location = new System.Drawing.Point(691, 408);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(100, 20);
            this.txtBox5.TabIndex = 3;
            this.txtBox5.Text = "0";
            this.txtBox5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // ĐTB
            // 
            this.ĐTB.HeaderText = "ĐTB";
            this.ĐTB.Name = "ĐTB";
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.grbBox1);
            this.Controls.Add(this.lblQL);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.lblNu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbBox1.ResumeLayout(false);
            this.grbBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQL;
        private System.Windows.Forms.GroupBox grbBox1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblNu;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ĐTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    }
}

