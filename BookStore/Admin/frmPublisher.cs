using BookStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Admin {
    public partial class frmPublisher : Form {

        DBConnect db = new DBConnect();

        public frmPublisher() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            myTable = new DataTable();
            myBindS = new BindingSource();
        }

        //Attribute
        private DataTable myTable;
        private BindingSource myBindS;
        private string[] headerText = { "Mã NXB", "Tên nhà xuất bản", "SĐT", "Địa chỉ" };
        private int[] size = { 15, 33, 25, 30 };


        //Method
        public void Empty() {
            txtName.Text = "";
            txtName.Enabled = false;
            txtPhone.Text = "";
            txtPhone.Enabled = false;
            rtbAddress.Text = "";
            rtbAddress.Enabled = false;
            txtID.Text = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            btnSaveAdd.Enabled = false;
            btnSaveEdit.Enabled = false;
        }

        public void Enable() {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            rtbAddress.Enabled = true;
            btnCancel.Enabled = true;
        }

        //Event
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmPublisher_Load(object sender, EventArgs e) {
            // Lấy dữ liệu từ CSDL
            string strCL = "SELECT * FROM NHAXUATBAN";
            myTable = db.GetData(strCL);

            // Gán dl bảng vào binding, binding gán vào dgv
            myBindS.DataSource = myTable;
            dgvData.DataSource = myBindS;

            // Set size + headerText cho dgv
            for (int i = 0; i < headerText.Length; i++) {
                dgvData.Columns[i].HeaderText = headerText[i];
                dgvData.Columns[i].Width = ((dgvData.Width) / 100) * size[i];
            }

            // Chọn theo chế độ cả hàng
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Enable();
            btnSaveAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSaveAdd_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtPhone.Text == "" || rtbAddress.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = rtbAddress.Text;

            string sql = string.Format("INSERT INTO NHAXUATBAN VALUES (N'{0}', N'{1}', '{2}')", name, address, phone);
            db.UpdataData(sql);

            MessageBox.Show("Thêm mới thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPublisher_Load(null, null);
            Empty();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                // Tìm vị trí hàng đang chọn
                int choose = dgvData.SelectedRows[0].Index;

                // Lấy ra các giá trị hàng đang chọn
                string id = dgvData.Rows[choose].Cells[0].Value.ToString();
                string name = dgvData.Rows[choose].Cells[1].Value.ToString();
                string address = dgvData.Rows[choose].Cells[2].Value.ToString();
                string phone = dgvData.Rows[choose].Cells[3].Value.ToString();

                //Đưa dữ liệu đã lấy ra vào TextBox
                Enable();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSaveEdit.Enabled = true;

                txtID.Text = id;
                txtName.Text = name;
                txtPhone.Text = phone;
                rtbAddress.Text = address;
            }
            catch (Exception) {
                MessageBox.Show("Bạn phải chọn nhà xuất bản muốn sửa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtPhone.Text == "" || rtbAddress.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = rtbAddress.Text;

            string strSQL = string.Format("UPDATE NHAXUATBAN SET TENNHAXUATBAN = N'{0}',  DIACHI = N'{1}', SDT = '{2}' WHERE MANHAXUATBAN = '{3}'",
                name, address, phone, id);
            db.UpdataData(strSQL);
            MessageBox.Show("Sửa thành công nhà xuất bản có mã là " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPublisher_Load(null, null);
            Empty();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //Lấy ra id muốn xoá
            string id = dgvData.Rows[dgvData.SelectedRows[0].Index].Cells[0].Value.ToString();

            //Lấy ra số bản ghi liên quan đến nhân viên có id vừa lấy
            string numRecordBook = "SELECT count(*) FROM SACH WHERE MANHAXUATBAN = '" + id + "'";

            //Đếm bản ghi
            int numBook = db.CountRecord(numRecordBook);

            DialogResult kq = MessageBox.Show("Có " + (numBook) + " dữ liệu liên quan đến " + id + " này! \nBạn có muốn xóa không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) {
                if (numBook > 0) {
                    MessageBox.Show("Có " + (numBook) + " dữ liệu liên quan đến Mã này. \nBạn không thể xóa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    string delete = "DELETE FROM NHAXUATBAN WHERE MANHAXUATBAN = '" + id + "'";
                    db.UpdataData(delete);

                    MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPublisher_Load(null, null);
                }
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Empty();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string loc = string.Format("TENNHAXUATBAN like '%{0}%' or SDT like '%{1}%' or DIACHI like '%{2}%'",
                                        txtSearch.Text, txtSearch.Text, txtSearch.Text);
            myBindS.Filter = loc;
            dgvData.DataSource = myBindS;
        }
    }
}
