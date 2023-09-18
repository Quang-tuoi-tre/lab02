using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = 0;
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null)
                {
                    if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
      
        private void InsertUpdate(int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtBox1.Text;
            dgvStudent.Rows[selectedRow].Cells[1].Value = txtBox2.Text;
            dgvStudent.Rows[selectedRow].Cells[2].Value = rbNu.Checked ? "Nữ" : "Nam";
            dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtBox3.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[4].Value = cmbKhoa.Text;


        }



        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox1.Text == "" || txtBox2.Text == "" || txtBox3.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên");

                int selectedRow = GetSelectedRow(txtBox1.Text);
                if (selectedRow == -1)
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);

                }
                else
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sum();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtBox1.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");

                }
                else
                {

                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "Yes/No", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa Sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);              
                            }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sum();
           
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng hay chưa
            if (dgvStudent.SelectedRows.Count>0)
            {
                // Lấy dòng đầu tiên đã được chọn
                DataGridViewRow selectedRow = dgvStudent.SelectedRows[0];

                // Lấy thông tin của sinh viên từ các cột trong dòng đã chọn
                string maSv = selectedRow.Cells["MSSV"].Value.ToString();
                string tenSv = selectedRow.Cells["Họ Tên"].Value.ToString();
                string lop = selectedRow.Cells["ĐTB"].Value.ToString();

                // Hiển thị thông tin sinh viên đã chọn ở phần nhập liệu
                txtBox1.Text = maSv;
                txtBox2.Text = tenSv;
                txtBox3.Text = lop;
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void sum()
        {
            int demNam = 0;
            int demNu = 0;
            // Kiểm tra nếu thay đổi giá trị trong cột giới tính Giới Tính
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {


                // Duyệt qua từng dòng trong DataGridView
                if (dgvStudent.Rows[i].Cells[0].Value != null)
                {
                    // Kiểm tra giá trị trong cột giới tính

                    if (dgvStudent.Rows[i].Cells[2].Value == "Nam")
                    {
                        demNam++;
                    }
                    else
                    {
                        demNu++;
                    }

                }

                // Hiển thị kết quả tính toán
                txtBox4.Text = demNam.ToString();
                txtBox5.Text = demNu.ToString();
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvStudent.CurrentRow.Selected = true;
                txtBox1.Text = dgvStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtBox1.Text = dgvStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                string gt = dgvStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                rbNam.Checked = gt == "Nam";
                rbNu.Checked = gt == "Nữ";
                txtBox3.Text = dgvStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmbKhoa.SelectedItem = dgvStudent.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

            }

        }


    }
    }
    
  


    




