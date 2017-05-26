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
    public partial class frmProduct : Form {

        DBConnect db = new DBConnect();

        public frmProduct() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            myTable = new DataTable();
            myBindS = new BindingSource();
        }

        //Attribute
        private DataTable myTable;
        private BindingSource myBindS;
        private string[] headerText = { "Mã sách", "Tên danh mục", "Tên sách", "Đơn giá bán", "Đơn giá nhập", "Số lượng kho", "Tên tác giả", "Mô tả", "Tên NXB" };
        private int[] size = { 12, 20, 25, 15, 15, 10, 20, 25, 20 };

        //Method
        public void Empty() {
            txtName.Text = "";
            txtName.Enabled = false;
            txtID.Text = "";
            txtPrice.Text = "";
            txtPrice.Enabled = false;
            txtNum.Text = "";
            txtPriceIn.Text = "";
            txtPriceIn.Enabled = false;
            txtNum.Enabled = false;
            cbbAuthor.SelectedValue = 0;
            cbbAuthor.Enabled = false;
            cbbPublisher.SelectedValue = 0;
            cbbPublisher.Enabled = false;
            cbbCategory.Enabled = false;
            cbbCategory.SelectedValue = 0;
            rtbDescription.Text = "";
            rtbDescription.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
        }

        public void Enable() {
            txtName.Enabled = true;
            txtPriceIn.Enabled = true;
            cbbAuthor.Enabled = true;
            txtNum.Enabled = true;
            txtPrice.Enabled = true;
            cbbPublisher.Enabled = true;
            cbbCategory.Enabled = true;
            rtbDescription.Enabled = true;
            btnCancel.Enabled = true;
        }

        //Event
        private void frmCustomer_Load(object sender, EventArgs e) {

            // Lấy dữ liệu từ CSDL
            string strCL = "SELECT * FROM SACH";
            myTable = db.GetData(strCL);

            // Gán dl bảng vào binding, binding gán vào dgv
            myBindS.DataSource = myTable;
            dgvData.DataSource = myBindS;

            // Set size + headerText cho dgv
            for (int i = 0; i < headerText.Length; i++) {
                dgvData.Columns[i].HeaderText = headerText[i];
                dgvData.Columns[i].Width = ((dgvData.Width) / 100) * size[i];
            }

            this.dgvData.Columns["MASACH"].Visible = false;
            this.dgvData.Columns["ANHBIA"].Visible = false;

            // Chọn theo chế độ cả hàng
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Đổ dữ liệu cho ComboBox
            string sqlCate = "Select * from DANHMUC";
            DataTable dtCate = db.GetData(sqlCate);

            cbbCategory.DataSource = dtCate;
            cbbCategory.DisplayMember = "TENDANHMUC";
            cbbCategory.ValueMember = "MADANHMUC";
            cbbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbCategory.AutoCompleteMode = AutoCompleteMode.Suggest;

            string sqlAuthor = "Select * from AUTHOR";
            DataTable dtAuthor = db.GetData(sqlAuthor);

            cbbAuthor.DataSource = dtAuthor;
            cbbAuthor.DisplayMember = "TENTACGIA";
            cbbAuthor.ValueMember = "MATACGIA";
            cbbAuthor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbAuthor.AutoCompleteMode = AutoCompleteMode.Suggest;

            string sqlPubl = "Select * from NHAXUATBAN";
            DataTable dtPunl = db.GetData(sqlPubl);

            cbbPublisher.DataSource = dtPunl;
            cbbPublisher.DisplayMember = "TENNHAXUATBAN";
            cbbPublisher.ValueMember = "MANHAXUATBAN";
            cbbPublisher.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbPublisher.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Enable();
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSaveAdd_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtNum.Text == "" || txtPrice.Text == "" || rtbDescription.Text == "" || txtPriceIn.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = txtName.Text;
            string price = txtPrice.Text;
            string num = txtNum.Text;
            string priceIn = txtPriceIn.Text;
            string publ = cbbPublisher.SelectedValue.ToString();
            string author = cbbAuthor.SelectedValue.ToString();
            string cate = cbbCategory.SelectedValue.ToString();
            string descrip = rtbDescription.Text;


            string sql = string.Format("INSERT INTO SACH VALUES ('{0}', '{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', N'{7}', '{8}', '{9}')", cate, name, price, priceIn, num, author, descrip, "-", publ);
            db.UpdataData(sql);

            MessageBox.Show("Thêm mới thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCustomer_Load(null, null);
            Empty();
            btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                // Tìm vị trí hàng đang chọn
                int choose = dgvData.SelectedRows[0].Index;

                // Lấy ra các giá trị hàng đang chọn
                string id = dgvData.Rows[choose].Cells[0].Value.ToString();
                string cate = dgvData.Rows[choose].Cells[1].Value.ToString();
                string name = dgvData.Rows[choose].Cells[2].Value.ToString();
                string priceOut = dgvData.Rows[choose].Cells[3].Value.ToString();
                string priceIn = dgvData.Rows[choose].Cells[4].Value.ToString();
                string num = dgvData.Rows[choose].Cells[5].Value.ToString();
                string author = dgvData.Rows[choose].Cells[6].Value.ToString();
                string descrip = dgvData.Rows[choose].Cells[7].Value.ToString();
                string image = dgvData.Rows[choose].Cells[8].Value.ToString();
                string publ = dgvData.Rows[choose].Cells[9].Value.ToString();


                //Đưa dữ liệu đã lấy ra vào TextBox
                Enable();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;

                txtID.Text = id;
                txtName.Text = name;
                txtNum.Text = num;
                txtPrice.Text = priceOut;
                txtPriceIn.Text = priceIn;
                rtbDescription.Text = descrip;

                // Lấy vị trí hàng đang được chọn
                //string images = ptbImage.Image.ToString();

                //ptbImage.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Image\\" + images);

            }
            catch (Exception) {
                MessageBox.Show("Bạn phải chọn khách hàng muốn sửa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e) {
            if (txtName.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;

            string strSQL = string.Format("UPDATE KHACHHANG SET TENKHACHHANG = N'{0}', EMAIL = '{1}', SODIENTHOAI = '{2}', DIACHI = N'{3}' WHERE MAKHACHHANG = '{4}'",
                name, id);
            db.UpdataData(strSQL);
            MessageBox.Show("Sửa thành công khách hàng có mã là " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCustomer_Load(null, null);
            Empty();
            btnSave.Enabled = false;
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
            btnSave.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
