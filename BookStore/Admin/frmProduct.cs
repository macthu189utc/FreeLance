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
        private int input;
        private string nameBook;
        private String nameImage = "images.jpg";
        private String localPath = System.IO.Directory.GetCurrentDirectory();
        private DataTable myTable;
        private BindingSource myBindS;
        private string[] headerText = { "Mã sách", "Tên danh mục", "Tên sách", "Đơn giá bán", "Đơn giá nhập", "Số lượng kho", "Tên tác giả", "Mô tả", "Tên NXB" };
        private int[] size = { 10, 12, 22, 12, 12, 12, 15, 10, 18 };

        public int Input {
            get {
                return input;
            }

            set {
                input = value;
            }
        }

        public string NameBook {
            get {
                return nameBook;
            }

            set {
                nameBook = value;
            }
        }

        //Method
        public void Empty() {
            txtName.Text = "";
            txtName.Enabled = false;
            txtID.Text = "";
            txtPrice.Text = "";
            txtPrice.Enabled = false;
            txtNum.Text = "";
            txtNum.Enabled = false;
            txtPriceIn.Text = "";
            txtPriceIn.Enabled = false;
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
            ptbImage.Image = Image.FromFile(@"images\\image.jpg");
        }

        /// <summary>
        /// 
        /// </summary>
        public void Enable() {
            txtName.Enabled = true;
            txtPriceIn.Enabled = true;
            cbbAuthor.Enabled = true;
            txtPrice.Enabled = true;
            cbbPublisher.Enabled = true;
            cbbCategory.Enabled = true;
            rtbDescription.Enabled = true;
            btnCancel.Enabled = true;
        }

        //Get data
        public void GetData() {
            // Tìm vị trí hàng đang chọn
            int choose = dgvData.SelectedRows[0].Index;

            // Lấy ra các giá trị hàng đang chọn
            //MASACH, TENDANHMUC, TENSACH, DONGIABAN, DONGIANHAP, SOLUONGTON, TENTACGIA, MOTA, TENNHAXUATBAN, ANHBIA
            string id = dgvData.Rows[choose].Cells[0].Value.ToString();
            string cate = dgvData.Rows[choose].Cells[1].Value.ToString();
            string name = dgvData.Rows[choose].Cells[2].Value.ToString();
            string priceOut = dgvData.Rows[choose].Cells[3].Value.ToString();
            string priceIn = dgvData.Rows[choose].Cells[4].Value.ToString();
            string num = dgvData.Rows[choose].Cells[5].Value.ToString();
            string author = dgvData.Rows[choose].Cells[6].Value.ToString();
            string descrip = dgvData.Rows[choose].Cells[7].Value.ToString();
            string publ = dgvData.Rows[choose].Cells[8].Value.ToString();

            //Đưa dữ liệu đã lấy ra vào TextBox
            //MASACH, TENDANHMUC, TENSACH, DONGIABAN, DONGIANHAP, SOLUONGTON, TENTACGIA, MOTA, TENNHAXUATBAN, ANHBIA
            txtID.Text = id;
            txtName.Text = name;
            cbbCategory.Text = cate;
            txtPrice.Text = priceOut;
            txtPriceIn.Text = priceIn;
            txtNum.Text = num;
            cbbAuthor.Text = author;
            rtbDescription.Text = descrip;
            int choose_ing = dgvData.SelectedRows[0].Index;

            if (choose_ing >= 0) {
                // Đặt lại ảnh
                string urlImage = dgvData.Rows[choose_ing].Cells["ANHBIA"].Value.ToString();
                ptbImage.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\" + urlImage);
            }
            cbbPublisher.Text = publ;
        }

        //Event
        private void frmProduct_Load(object sender, EventArgs e) {
            // Lấy dữ liệu từ CSDL
            string strCL = "SELECT MASACH, TENDANHMUC, TENSACH, DONGIABAN, DONGIANHAP, SOLUONGTON, TENTACGIA, MOTA, TENNHAXUATBAN, ANHBIA FROM SACH"
                            + " INNER JOIN DANHMUC ON DANHMUC.MADANHMUC = SACH.MADANHMUC"
                            + " INNER JOIN TACGIA ON TACGIA.MATACGIA = SACH.MATACGIA"
                            + " INNER JOIN NHAXUATBAN ON NHAXUATBAN.MANHAXUATBAN = SACH.MANHAXUATBAN";
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

            string sqlAuthor = "Select * from TACGIA";
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
            if (input == 1) {
                Empty();
                txtNum.Enabled = true;
                Enable();
                btnSaveAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else {
                Empty();
                Enable();
                btnSaveAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;

            }
        }

        private void btnSaveAdd_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtNum.Text == "" || rtbDescription.Text == "" || txtPriceIn.Text == "") {
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
            string[] imgs = nameImage.Split('\\');
            string urlImage = nameImage;
            nameImage = imgs[imgs.Length - 1];
            if (imgs.Length > 1) {
                if (!System.IO.File.Exists(localPath + @"\images\" + nameImage)) {
                    System.IO.File.Copy(urlImage, localPath + @"\images\" + imgs[imgs.Length - 1]);
                }
            }

            string sql = string.Format("INSERT INTO SACH VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', N'{6}', '{7}', '{8}')", cate, name, price, priceIn, num, author, descrip, nameImage, publ);
            db.UpdataData(sql);

            MessageBox.Show("Thêm mới thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmProduct_Load(null, null);
            Empty();
            btnSaveAdd.Enabled = false;
            this.DialogResult = DialogResult.OK;
            this.NameBook = txtName.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                GetData();
                Enable();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSaveEdit.Enabled = true;
            }
            catch (Exception) {
                MessageBox.Show("Bạn phải chọn sách muốn sửa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtNum.Text == "" || rtbDescription.Text == "" || txtPriceIn.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = int.Parse(txtID.Text);
            string idCate = cbbCategory.SelectedValue.ToString();
            string name = txtName.Text;
            int priceOut = int.Parse(txtPrice.Text);
            int priceIn = int.Parse(txtPriceIn.Text);
            int num = int.Parse(txtNum.Text);
            int idAuthor = int.Parse(cbbAuthor.SelectedValue.ToString());
            string descrip = rtbDescription.Text;
            int idPubl = int.Parse(cbbPublisher.SelectedValue.ToString());
            string[] imgs = nameImage.Split('\\');
            string urlImage = nameImage;
            nameImage = imgs[imgs.Length - 1];
            if (imgs.Length > 1) {
                if (!System.IO.File.Exists(localPath + @"\images\" + nameImage)) {
                    System.IO.File.Copy(urlImage, localPath + @"\images\" + imgs[imgs.Length - 1]);
                }
            }
            //MASACH, TENDANHMUC, TENSACH, DONGIABAN, DONGIANHAP, SOLUONGTON, TENTACGIA, MOTA, TENNHAXUATBAN, ANHBIA
            string strSQL = string.Format("UPDATE SACH SET MADANHMUC = '{0}', TENSACH = N'{1}', DONGIABAN = '{2}', DONGIANHAP = '{3}', SOLUONGTON = '{4}', MATACGIA = '{5}', MOTA = N'{6}', ANHBIA = '{7}', MANHAXUATBAN = '{8}' WHERE MASACH = '{9}'",
                idCate, name, priceOut, priceIn, num, idAuthor, descrip, nameImage, idPubl, id);
            db.UpdataData(strSQL);
            MessageBox.Show("Sửa thành công khách hàng có mã là " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmProduct_Load(null, null);
            Empty();
            btnSaveEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //Lấy ra id muốn xoá
            string id = dgvData.Rows[dgvData.SelectedRows[0].Index].Cells[0].Value.ToString();

            //Lấy ra số bản ghi liên quan đến nhân viên có id vừa lấy
            string numRecordBillOut = "SELECT count(*) FROM CHITIETHOADONXUAT WHERE MASACH = '" + id + "'";
            string numRecordBillIn = "SELECT count(*) FROM CHITIETHOADONNHAP WHERE MASACH = '" + id + "'";

            //Đếm bản ghi
            int numBillOut = db.CountRecord(numRecordBillOut);
            int numBillIn = db.CountRecord(numRecordBillIn);

            DialogResult kq = MessageBox.Show("Có " + (numBillOut + numBillIn) + " dữ liệu liên quan đến " + id + " này! \nBạn có muốn xóa không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) {
                if (numBillOut > 0 || numBillIn > 0) {
                    MessageBox.Show("Có " + (numBillOut + numBillIn) + " dữ liệu liên quan đến Mã này. \nBạn không thể xóa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    string delete = "DELETE FROM SACH WHERE MASACH = '" + id + "'";
                    db.UpdataData(delete);

                    MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmProduct_Load(null, null);
                    Empty();
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

        private void btnChooseImage_Click(object sender, EventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Hình ảnh sản phẩm (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFile.ShowDialog() == DialogResult.OK) {
                nameImage = openFile.FileName;
                ptbImage.Image = Image.FromFile(nameImage);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e) {
            Empty();
            GetData();
        }

        private void btnAddPubL_Click(object sender, EventArgs e) {
            DataTable tablePubl = new DataTable();
            frmPublisher fp = new frmPublisher();
            if (fp.ShowDialog() == DialogResult.OK) {
                // Update dl
                string sql = "Select MANHAXUATBAN, TENNHAXUATBAN from NHAXUATBAN";
                tablePubl = db.GetData(sql);
                cbbPublisher.DataSource = tablePubl;
                cbbPublisher.DisplayMember = "TENNHAXUATBAN";
                cbbPublisher.ValueMember = "MANHAXUATBAN";

                // Set khách hàng là khách vừa thêm
                cbbPublisher.SelectedIndex = cbbPublisher.Items.Count - 1;
            }
            string sqlUpdate = "Select MAKHACHHANG, TENKHACHHANG from KHACHHANG";
            tablePubl = db.GetData(sqlUpdate);
        }

        private void btnAddCate_Click(object sender, EventArgs e) {
            DataTable tableCate = new DataTable();
            frmCategory fc = new frmCategory();
            if (fc.ShowDialog() == DialogResult.OK) {
                // Update dl
                string sql = "Select MADANHMUC, TENDANHMUC from DANHMUC";
                tableCate = db.GetData(sql);
                cbbCategory.DataSource = tableCate;
                cbbCategory.DisplayMember = "TENDANHMUC";
                cbbCategory.ValueMember = "MADANHMUC";

                // Set khách hàng là khách vừa thêm
                cbbCategory.SelectedIndex = cbbCategory.Items.Count - 1;
            }
            string sqlUpdate = "Select MADANHMUC, TENDANHMUC from DANHMUC";
            tableCate = db.GetData(sqlUpdate);
        }

        private void btnAddAuthor_Click(object sender, EventArgs e) {
            DataTable tableAuthor = new DataTable();
            frmAuthor fa = new frmAuthor();
            if (fa.ShowDialog() == DialogResult.OK) {
                // Update dl
                string sql = "Select MATACGIA, TENTACGIA from TACGIA";
                tableAuthor = db.GetData(sql);
                cbbAuthor.DataSource = tableAuthor;
                cbbAuthor.DisplayMember = "TENTACGIA";
                cbbAuthor.ValueMember = "MATACGIA";

                // Set khách hàng là khách vừa thêm
                cbbAuthor.SelectedIndex = cbbAuthor.Items.Count - 1;
            }
            string sqlUpdate = "Select MATACGIA, TENTACGIA from TACGIA";
            tableAuthor = db.GetData(sqlUpdate);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string loc = string.Format("TENSACH like '%{0}%' or TENNHAXUATBAN like '%{1}%' or TENTACGIA like '%{2}%' or TENDANHMUC like '%{3}%'",
                                       txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
            myBindS.Filter = loc;
            dgvData.DataSource = myBindS;
        }
    }
}
