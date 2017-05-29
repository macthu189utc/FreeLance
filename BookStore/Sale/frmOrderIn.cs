using BookStore.Admin;
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
    public partial class frmOrderIn : Form {
        DBConnect db = new DBConnect();
        public frmOrderIn() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            myTable = new DataTable();
            myBindS = new BindingSource();
            lbNameStaff.Text = DBConnect.TENNHANVIEN;

        }
        private int input = 0;
        private DataTable tablePro;
        private DataTable tableBook;
        private DataTable myTable;
        private DataTable myTableOrder;
        private BindingSource myBindS;
        private MakeToString changeMoney;

        private string[] headerText = { "Mã sách", "Tên sách", "Tên danh mục", "Tên tác giả", "Mô tả", "Tên NXB", "Số lượng", "Đơn giá" };
        private int[] size = { 0, 25, 20, 20, 15, 15, 10, 20 };

        private string[] headerTextOrder = { "Tên sách", "Đơn giá", "Số lượng", "Thành tiền", "Mã sách" };
        private int[] sizeOrder = { 30, 25, 15, 30, 0 };

        public int Input {
            get {
                return input;
            }

            set {
                input = value;
            }
        }

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

        private void frmOrderIn_Load(object sender, EventArgs e) {
            //Lấy dữ liệu từ bảng sách
            string strCL = "SELECT MASACH, TENSACH, TENDANHMUC, TENTACGIA, MOTA, TENNHAXUATBAN, SOLUONGTON, DONGIABAN, DONGIANHAP, ANHBIA FROM SACH"
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
            this.dgvData.Columns["DONGIANHAP"].Visible = false;

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
            tableBook = new DataTable();

            string sql = "Select MASACH, TENSACH from SACH";
            tableBook = db.GetData(sql);
            cbbBook.DataSource = tableBook;
            cbbBook.DisplayMember = "TENSACH";
            cbbBook.ValueMember = "MASACH";

            DataRow dr = tableBook.NewRow();
            dr["TENSACH"] = "-- Chọn sách --";
            dr["MASACH"] = 0;

            tableBook.Rows.InsertAt(dr, 0);
            cbbBook.SelectedIndex = 0;

            tablePro = new DataTable();

            string sql2 = "Select MANHACUNGCAP, TENNHACUNGCAP from NHACUNGCAP";
            tablePro = db.GetData(sql2);
            cbbProvider.DataSource = tablePro;
            cbbProvider.DisplayMember = "TENNHACUNGCAP";
            cbbProvider.ValueMember = "MANHACUNGCAP";

            DataRow dr2 = tablePro.NewRow();
            dr2["TENNHACUNGCAP"] = "-- Chọn NCC --";
            dr2["MANHACUNGCAP"] = 0;

            tablePro.Rows.InsertAt(dr2, 0);
            cbbProvider.SelectedIndex = 0;

            Input = 1;
        }

        private void ptbAddBook_Click(object sender, EventArgs e) {
            tableBook = new DataTable();
            frmProduct fp = new frmProduct();
            fp.Input = 1;
            if (fp.ShowDialog() == DialogResult.OK) {
                // Update dl
                string sql = "Select MASACH, TENSACH from SACH";
                tableBook = db.GetData(sql);
                cbbBook.DataSource = tableBook;
                cbbBook.DisplayMember = "TENSACH";
                cbbBook.ValueMember = "MASACH";
                frmOrderIn_Load(null, null);
                // Set quyển sách là sách vừa thêm
                cbbBook.SelectedIndex = cbbBook.Items.Count - 1;

            }
            string sqlUpdate = "Select MASACH, TENSACH from SACH";
            tableBook = db.GetData(sqlUpdate);

        }

        private void ptbAddPro_Click(object sender, EventArgs e) {
            tablePro = new DataTable();
            frmProvider fp = new frmProvider();
            if (fp.ShowDialog() == DialogResult.OK) {
                // Update dl
                string sql = "Select MANHACUNGCAP, TENNHACUNGCAP from NHACUNGCAP";
                tablePro = db.GetData(sql);
                cbbProvider.DataSource = tablePro;
                cbbProvider.DisplayMember = "TENNHACUNGCAP";
                cbbProvider.ValueMember = "MANHACUNGCAP";

                // Set khách hàng là khách vừa thêm
                cbbProvider.SelectedIndex = cbbProvider.Items.Count - 1;
            }
            string sqlUpdate = "Select MANHACUNGCAP, TENNHACUNGCAP from NHACUNGCAP";
            tablePro = db.GetData(sqlUpdate);
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
            try {
                //Lấy ra vitri
                int index = dgvData.SelectedRows[0].Index;

                int numInventory = int.Parse(myTable.Rows[index]["SOLUONGTON"].ToString());
                int numAdd = (int)numeric.Value;

                int numAfterInput = numInventory + numAdd;

                myTable.Rows[index]["SOLUONGTON"] = numAfterInput;

                string name = myTable.Rows[index]["TENSACH"].ToString();
                int price = int.Parse(myTable.Rows[index]["DONGIANHAP"].ToString());
                string id = myTable.Rows[index]["MASACH"].ToString();


                // Kieerm tra cong don
                int id2 = -1;
                for (int i = 0; i < myTableOrder.Rows.Count; i++) {
                    string mas = myTableOrder.Rows[i][4].ToString();

                    if (id.Equals(mas)) {
                        id2 = i;
                        break;
                    }
                }

                if (id2 == -1) {
                    int sumMoney = price * numAdd;
                    myTableOrder.Rows.Add(name, price, numAdd, sumMoney, id);

                }
                else {
                    int dongia = int.Parse(myTableOrder.Rows[id2][1].ToString());
                    int sl = int.Parse(myTableOrder.Rows[id2][2].ToString());
                    myTableOrder.Rows[id2][2] = numAdd + sl;
                    myTableOrder.Rows[id2][3] = (numAdd + sl) * dongia;
                }

                Money();
            }
            catch (Exception ex) {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                // Kiểm tra số lượng có thỏa mãn
                int index = dgvOrder.SelectedRows[0].Index;

                int numOrder = int.Parse(myTableOrder.Rows[index][2].ToString());
                int numDown = 1;
                if (numDown > numOrder) {
                    MessageBox.Show("Số lượng không hợp lệ");
                    return;
                }

                string id = myTableOrder.Rows[index][4].ToString();
                int index2 = -1;

                // Lấy ra index cần trừ bên bảng sản phẩm
                for (int i = 0; i < myTable.Rows.Count; i++) {
                    if (id.Equals(myTable.Rows[i]["MASACH"].ToString())) {
                        index2 = i;
                        break;
                    }
                }

                // Nếu số lượng giảm = số lượng bên bảng HD thì xóa luôn dòng đi
                // Còn không thì trừ đi thông thường
                if (numDown == numOrder) {
                    myTableOrder.Rows.RemoveAt(index);
                }
                else {
                    int numNew = numOrder - numDown;
                    int price = int.Parse(myTable.Rows[index2]["DONGIANHAP"].ToString());

                    int sumMoneyNew = price * numNew;

                    myTableOrder.Rows[index][2] = numNew;
                    myTableOrder.Rows[index][3] = sumMoneyNew;
                }

                // Cập nhật số lượng bên bảng sản phẩm
                int numEqualOld = int.Parse(myTable.Rows[index2]["SOLUONGTON"].ToString());
                int numEqualNew = numEqualOld + numDown;
                myTable.Rows[index2]["SOLUONGTON"] = numEqualNew;

                //Tinhs tổng tiên;
                Money();
            }
            catch (Exception) {
                MessageBox.Show("Vui lòng chọn sản phẩm cần giảm");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            rtbMoneyWord.Text = "";
            lbCountMoney.Text = "";
            frmOrderIn_Load(null, null);
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
                int idPro = int.Parse(cbbProvider.SelectedValue.ToString());
                string idStaff = DBConnect.MANHANVIEN;
                DateTime dateIn = DateTime.Parse(dtpDateOrder.Value.ToShortDateString());

                String sql = string.Format("INSERT INTO HOADONNHAP (MANHANVIEN, MANHACUNGCAP, NGAYNHAP) VALUES( '{0}', '{1}', '{2}')",
                        idStaff, idPro, dateIn);
                db.UpdataData(sql);

                // Cập nhật chi tiết HD nhập
                sql = "select max(MAHOADON) as 'MAHOADON' from HOADONNHAP";
                string id = db.GetData(sql).Rows[0][0].ToString();
                string idBook;
                string price;
                string num;

                for (int i = 0; i < myTableOrder.Rows.Count; i++) {
                    idBook = myTableOrder.Rows[i][4].ToString();
                    price = myTableOrder.Rows[i][1].ToString();
                    num = myTableOrder.Rows[i][2].ToString();
                    sql = string.Format("INSERT INTO CHITIETHOADONNHAP(MAHOADON, MASACH, DONGIA, SOLUONG) VALUES('{0}', '{1}', '{2}', '{3}')", id, idBook, price, num);
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
                frmOrderIn_Load(null, null);
            }
            catch (Exception) {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mDelete_Click(object sender, EventArgs e) {
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
            int num = int.Parse(myTableOrder.Rows[index][2].ToString());

            int index2 = -1;
            string id = myTableOrder.Rows[index][4].ToString();

            // Lấy ra index cần cộng bên bảng sản phẩm
            for (int i = 0; i < myTable.Rows.Count; i++) {
                if (id.Equals(myTable.Rows[i]["MASACH"].ToString())) {
                    index2 = i;
                    break;
                }
            }

            // Cộng vào bảng sản phẩm
            int numEqualOld = int.Parse(myTable.Rows[index2]["SOLUONGTON"].ToString());
            int numEaualNew = numEqualOld + num;
            myTable.Rows[index2]["SOLUONGTON"] = numEaualNew;

            // Xóa dòng bên bảng hóa đơn
            myTableOrder.Rows.RemoveAt(index);

            Money();
        }
    }
}
