using BookStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Sale {
    public partial class frmCart : Form {
        DBConnect db = new DBConnect();

        public frmCart() {
            InitializeComponent();
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            tableCus = new DataTable();
            myTable = new DataTable();
            myBindS = new BindingSource();
            lbNameStaff.Text = DBConnect.TENNHANVIEN;

        }

        private DataTable tableCus;
        private DataTable myTable;
        private DataTable myTableOrder;
        private BindingSource myBindS;
        private MakeToString changeMoney;

        private string[] headerText = { "Mã sách", "Tên sách", "Tên danh mục", "Tên tác giả", "Mô tả", "Tên NXB", "Số lượng", "Đơn giá" };
        private int[] size = { 0, 25, 20, 20, 15, 15, 10, 20 };

        private string[] headerTextOrder = { "Tên sách", "Đơn giá", "Số lượng", "Thành tiền", "Mã sách" };
        private int[] sizeOrder = { 30, 25, 15, 30, 0 };

        //Method
        private void Money() {
            double sumMoney = 0;

            // Duyệt vòng lặp bảng hóa đơn, tính tiền
            for (int i = 0; i < myTableOrder.Rows.Count; i++) {
                double temp = double.Parse(myTableOrder.Rows[i][3].ToString());
                sumMoney += temp;
            }

            // In số tiền vào ô tổng tiền bằng số.
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            lbCountMoney.Text = sumMoney.ToString("#,###", cul.NumberFormat) + " VNĐ";
            if (sumMoney == 0) {
                lbCountMoney.Text = "0 VNĐ";
                rtbMoneyWord.Text = "";
            }
            else {
                // In ra số tiền bằng chữ
                changeMoney = new MakeToString(sumMoney);
                changeMoney.thucHienDoiTien();
                rtbMoneyWord.Text = changeMoney.ReadThis() + " đồng";
            }
        }

        private void frmCart_Load(object sender, EventArgs e) {
            if (DBConnect.BOPHAN == DBConnect.BANHANG) {

            }

            //Lấy dữ liệu từ bảng sách
            string strCL = "SELECT MASACH, TENSACH, TENDANHMUC, TENTACGIA, MOTA, TENNHAXUATBAN, SOLUONGTON, DONGIABAN, ANHBIA FROM SACH"
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

            this.dgvData.Columns["ANHBIA"].Visible = false;

            myTableOrder = new DataTable();
            dgvOrder.DataSource = myTableOrder;

            // Setup bảng hóa đơn
            for (int i = 0; i < headerTextOrder.Length; i++) {
                myTableOrder.Columns.Add(headerTextOrder[i]);
            }

            for (int i = 0; i < headerTextOrder.Length; i++) {
                dgvOrder.Columns[i].Width = (dgvOrder.Width / 100) * sizeOrder[i];
                dgvOrder.Columns[i].HeaderText = headerTextOrder[i];
            }
            //Đổ dữ liệu khách hàng cho cbb
            string sqlCus = "Select MAKHACHHANG, TENKHACHHANG from KHACHHANG";
            DataTable dt = db.GetData(sqlCus);

            cbbCustomer.DisplayMember = "TENKHACHHANG";
            cbbCustomer.ValueMember = "MAKHACHHANG";
            cbbCustomer.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["TENKHACHHANG"] = "-- Chọn khách hàng --";
            dr["MAKHACHHANG"] = 0;

            dt.Rows.InsertAt(dr, 0);
            cbbCustomer.SelectedIndex = 0;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e) {
            // Lấy vị trí hàng đang được chọn
            int choose_ing = dgvData.SelectedRows[0].Index;

            if (choose_ing >= 0) {
                // Đặt lại ảnh
                string urlImage = dgvData.Rows[choose_ing].Cells["ANHBIA"].Value.ToString();
                ptbBook.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\" + urlImage);

            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            // Kiểm tra số lượng có thỏa mãn
            int index = dgvData.SelectedRows[0].Index;
            if (index < 0)
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm");
            int numInventory = int.Parse(myTable.Rows[index]["SOLUONGTON"].ToString());
            int numAdd = (int) numericSoluong.Value;
            if (numAdd > numInventory || numAdd == 0) {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            int numAfterInput = numInventory - numAdd;
            myTable.Rows[index]["SOLUONGTON"] = numAfterInput;

            string name = myTable.Rows[index]["TENSACH"].ToString();
            int price = int.Parse(myTable.Rows[index]["DONGIABAN"].ToString());
            string id = myTable.Rows[index]["MASACH"].ToString();

            // Kiểm tra xem bảng hóa đơn đã có chưa.
            // --> Có = cộng dồn,
            // --> Chưa có thì thêm mới
            int id2 = -1;
            for (int i = 0; i < myTableOrder.Rows.Count; i++) {
                string mas = myTableOrder.Rows[i][4].ToString();
                if (id.Equals(mas)) {
                    id2 = i;
                    break;
                }
            }
            if(id2 != -1) {
                int dongia = int.Parse(myTableOrder.Rows[id2][1].ToString());
                int sl = int.Parse(myTableOrder.Rows[id2][2].ToString());
                myTableOrder.Rows[id2][2] = sl + numAdd;
                myTableOrder.Rows[id2][3] = (sl + numAdd) * dongia;

            }
            else {
                int sumMoney = price * numAdd;
                myTableOrder.Rows.Add(name, price, numAdd, sumMoney, id);
            }
            
            Money();
        }

        private void ptbAddCustomer_Click(object sender, EventArgs e) {
            frmCustomer fc = new frmCustomer();
            if (fc.ShowDialog() == DialogResult.OK) {
                // Update dl
                string sql = "Select MAKHACHHANG, TENKHACHHANG from KHACHHANG";
                tableCus = db.GetData(sql);
                cbbCustomer.DataSource = tableCus;
                cbbCustomer.DisplayMember = "TENKHACHHANG";
                cbbCustomer.ValueMember = "MAKHACHHANG";

                // Set khách hàng là khách vừa thêm
                cbbCustomer.SelectedIndex = cbbCustomer.Items.Count - 1;
            }
            string sqlUpdate = "Select MAKHACHHANG, TENKHACHHANG from KHACHHANG";
            tableCus = db.GetData(sqlUpdate);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string loc = string.Format("TENSACH like '%{0}%' or TENNHAXUATBAN like '%{1}%' or TENTACGIA like '%{2}%' or TENDANHMUC like '%{3}%'",
                                       txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
            myBindS.Filter = loc;
            dgvData.DataSource = myBindS;
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            // Kiểm tra điều kiện
            int index = -1;
            try {
                index = dgvOrder.SelectedRows[0].Index;
            }
            catch (Exception exception) {
                MessageBox.Show("Vui lòng chọn sản phẩm xóa");
                return;
            }

            // Lấy ra số lượng bên hóa đơn
            int soluonghoadon = int.Parse(myTableOrder.Rows[index][2].ToString());

            int index2 = -1;
            string mahang = myTableOrder.Rows[index][4].ToString();

            // Lấy ra index cần cộng bên bảng sản phẩm
            for (int i = 0; i < myTable.Rows.Count; i++) {
                if (mahang.Equals(myTable.Rows[i]["MASACH"].ToString())) {
                    index2 = i;
                    break;
                }
            }

            // Cộng vào bảng sản phẩm
            int soluongbangsanphamcu = int.Parse(myTable.Rows[index2]["SOLUONGTON"].ToString());
            int soluongbangsanphammoi = soluongbangsanphamcu + soluonghoadon;
            myTable.Rows[index2]["SOLUONGTON"] = soluongbangsanphammoi;

            // Xóa dòng bên bảng hóa đơn
            myTableOrder.Rows.RemoveAt(index);

            Money();
        }

        private void btnPay_Click(object sender, EventArgs e) {
            try {
                // Kiểm tra trước khi thanh toán
                if (myTableOrder.Rows.Count < 1) {
                    MessageBox.Show("Chưa có hàng trong hóa đơn");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn thanh toán", "Xác nhận", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No) {
                    return;
                }
                // Cập nhật hóa đơn bán
                int idCus = int.Parse(cbbCustomer.SelectedValue.ToString());
                string idStaff = DBConnect.MANHANVIEN;
                DateTime dateOut = DateTime.Parse(dtpDateOrder.Value.ToShortDateString());

                String sql = string.Format("INSERT INTO HOADONXUAT (MANHANVIEN, MAKHACHHANG, NGAYXUAT) VALUES( '{0}', '{1}', '{2}')",
                        idStaff, idCus, dateOut);
                db.UpdataData(sql);

                // Cập nhật chi tiết HD xuất
                sql = "select max(MAHOADON) as 'MAHOADON' from HOADONXUAT";
                string id = db.GetData(sql).Rows[0][0].ToString();
                string idBook;
                string price;
                string num;

                for (int i = 0; i < myTableOrder.Rows.Count; i++) {
                    idBook = myTableOrder.Rows[i][4].ToString();
                    price = myTableOrder.Rows[i][1].ToString();
                    num = myTableOrder.Rows[i][2].ToString();
                    sql = string.Format("INSERT INTO CHITIETHOADONXUAT(MAHOADON, MASACH, DONGIA, SOLUONG) VALUES('{0}', '{1}', '{2}', '{3}')", id, idBook, price, num);
                    db.UpdataData(sql);
                }

                // Cập nhật sản phẩm (số lượng)
                for (int i = 0; i < myTable.Rows.Count; i++) {
                    idBook = myTable.Rows[i]["MASACH"].ToString();
                    num = myTable.Rows[i]["SOLUONGTON"].ToString();
                    sql = string.Format("UPDATE SACH SET SOLUONGTON = '{0}'  WHERE MASACH = '{1}'", num, idBook);
                    db.UpdataData(sql);
                }

                MessageBox.Show("Thanh toán thành công");
                rtbMoneyWord.Text = "";
                lbCountMoney.Text = "";
                frmCart_Load(null, null);
            }
            catch (Exception) {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            rtbMoneyWord.Text = "";
            lbCountMoney.Text = "";
            frmCart_Load(null, null);
        }
    }
}
