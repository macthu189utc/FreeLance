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

namespace BookStore.Sale {
    public partial class frmCustomer : Form {

        DBConnect db = new DBConnect();

        public frmCustomer() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            myTable = new DataTable();
            myBindS = new BindingSource();
        }

        //Attribute
        private DataTable myTable;
        private BindingSource myBindS;
        private string[] headerText = { "Mã KH", "Tên khách hàng", "Email", "SĐT", "Địa chỉ" };
        private int[] size = { 12, 25, 25, 22, 25 };


        //Method
        public void Empty() {
            txtName.Text = "";
            txtName.Enabled = false;
            txtPhone.Text = "";
            txtPhone.Enabled = false;
            rtbAddress.Text = "";
            rtbAddress.Enabled = false;
            txtEmail.Text = "";
            txtEmail.Enabled = false;
            txtID.Text = "";
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
        }

        public void Enable() {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            rtbAddress.Enabled = true;
            btnCancel.Enabled = true;
            txtEmail.Enabled = true;
        }

        //Event
        private void frmCustomer_Load(object sender, EventArgs e) {
            // Lấy dữ liệu từ CSDL
            string strCL = "SELECT * FROM KHACHHANG";
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
            if (txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || rtbAddress.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = rtbAddress.Text;

                string sql = string.Format("INSERT INTO KHACHHANG VALUES (N'{0}', '{1}', '{2}', N'{3}')", name, email, phone, address);
                db.UpdataData(sql);

                MessageBox.Show("Thêm mới thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCustomer_Load(null, null);
                Empty();
                btnSaveAdd.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                // Tìm vị trí hàng đang chọn
                int choose = dgvData.SelectedRows[0].Index;

                // Lấy ra các giá trị hàng đang chọn
                string id = dgvData.Rows[choose].Cells[0].Value.ToString();
                string name = dgvData.Rows[choose].Cells[1].Value.ToString();
                string email = dgvData.Rows[choose].Cells[2].Value.ToString();
                string phone = dgvData.Rows[choose].Cells[3].Value.ToString();
                string address = dgvData.Rows[choose].Cells[4].Value.ToString();

                //Đưa dữ liệu đã lấy ra vào TextBox
                Enable();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSaveEdit.Enabled = true;

                txtID.Text = id;
                txtName.Text = name;
                txtPhone.Text = phone;
                txtEmail.Text = email;
                rtbAddress.Text = address;
            }
            catch (Exception) {
                MessageBox.Show("Bạn phải chọn khách hàng muốn sửa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || rtbAddress.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = rtbAddress.Text;

            string strSQL = string.Format("UPDATE KHACHHANG SET TENKHACHHANG = N'{0}', EMAIL = '{1}', SODIENTHOAI = '{2}', DIACHI = N'{3}' WHERE MAKHACHHANG = '{4}'",
                name, phone, email, address, id);
            db.UpdataData(strSQL);
            MessageBox.Show("Sửa thành công khách hàng có mã là " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCustomer_Load(null, null);
            Empty();
            btnSaveEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //Lấy ra id muốn xoá
            string id = dgvData.Rows[dgvData.SelectedRows[0].Index].Cells[0].Value.ToString();

            //Lấy ra số bản ghi liên quan đến nhân viên có id vừa lấy
            string numRecordBillOut = "SELECT count(*) FROM HOADONXUAT WHERE MAKHACHHANG = '" + id + "'";

            //Đếm bản ghi
            int numBillIn = db.CountRecord(numRecordBillOut);

            DialogResult kq = MessageBox.Show("Có " + (numBillIn) + " dữ liệu liên quan đến " + id + " này! \nBạn có muốn xóa không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) {
                if (numBillIn > 0) {
                    MessageBox.Show("Có " + (numBillIn) + " dữ liệu liên quan đến Mã này. \nBạn không thể xóa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    string delete = "DELETE FROM KHACHHANG WHERE MAKHACHHANG = '" + id + "'";
                    db.UpdataData(delete);

                    MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCustomer_Load(null, null);
                }
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Empty();
            btnSaveEdit.Enabled = false;
            btnSaveAdd.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string loc = string.Format("TENKHACHHANG like '%{0}%' or SODIENTHOAI like '%{1}%' or EMAIL like '%{2}%' or DIACHI like '%{3}%'",
                                        txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
            myBindS.Filter = loc;
            dgvData.DataSource = myBindS;
        }
    }
}
