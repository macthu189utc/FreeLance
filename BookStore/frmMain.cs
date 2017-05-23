using BookStore.Admin;
using BookStore.Data;
using BookStore.Sale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore {
    public partial class frmMain : Form {
        public int ROLE { get; set; }
        DBConnect db = new DBConnect();

        public frmMain() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            myTable = new DataTable();
            myBindS = new BindingSource();
        }

        private DataTable myTable;
        private BindingSource myBindS;
        private string[] headerText = { "Tên sách", "Tên danh mục", "Tên tác giả", "Mô tả", "Tên NXB", "Số lượng", "Đơn giá" };
        private int[] size = { 25, 20, 20, 15, 15, 10, 20 };

        //private string[] headerTextOrder = { "Tên sách", "Tên danh mục", "Tên tác giả", "Mô tả", "Tên NXB", "Số lượng", "Đơn giá" };
        //private int[] sizeOrder = { 25, 20, 20, 15, 15, 10, 20 };

        private void mnProduct_Click(object sender, EventArgs e) {
            frmProduct fp = new frmProduct();
            fp.ShowDialog();
        }

        private void mnCategory_Click(object sender, EventArgs e) {
            frmCategory fc = new frmCategory();
            fc.ShowDialog();
        }

        private void mnPublisher_Click(object sender, EventArgs e) {
            frmPublisher fpl = new frmPublisher();
            fpl.ShowDialog();
        }

        private void mnStaff_Click(object sender, EventArgs e) {
            frmStaff fs = new frmStaff();
            fs.ShowDialog();
        }

        private void mnProvider_Click(object sender, EventArgs e) {
            frmProvider fpv = new frmProvider();
            fpv.ShowDialog();
        }

        private void mnCustomer_Click(object sender, EventArgs e) {
            frmCustomer fct = new frmCustomer();
            fct.ShowDialog();
        }

        private void mnBill_Click(object sender, EventArgs e) {
            frmBillOrderOut fbo = new frmBillOrderOut();
            fbo.ShowDialog();
        }

        private void mnHelp_Click(object sender, EventArgs e) {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();
        }

        private void mnLogout_Click(object sender, EventArgs e) {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
        }

        private void mnBillOrderIn_Click(object sender, EventArgs e) {
            frmBillOrderIn fbi = new frmBillOrderIn();
            fbi.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            if (ROLE == 2) {
                mnManager.Enabled = false;
            }

            // Lấy dữ liệu từ CSDL
            string strCL = "SELECT TENSACH, TENDANHMUC, TENTACGIA, MOTA, TENNHAXUATBAN, SOLUONGTON, DONGIA, MASACH FROM SACH"
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

            this.dgvData.Columns[7].Visible = false;

            // Chọn theo chế độ cả hàng
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            int index = dgvData.SelectedRows[0].Index;
            foreach (DataGridViewRow item in dgvData.Rows) {
                int n = dgvOrder.Rows.Add();
                dgvOrder.Rows[n].Cells[0].Value = item.Cells[0].Value.ToString();
                dgvOrder.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
                dgvOrder.Rows[n].Cells[2].Value = item.Cells[2].Value.ToString();
                dgvOrder.Rows[n].Cells[3].Value = item.Cells[3].Value.ToString();
                dgvOrder.Rows[n].Cells[4].Value = item.Cells[4].Value.ToString();
                dgvOrder.Rows[n].Cells[5].Value = item.Cells[5].Value.ToString();
                dgvOrder.Rows[n].Cells[6].Value = item.Cells[6].Value.ToString();
            }
        }
    }
}
