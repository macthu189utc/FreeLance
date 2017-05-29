using BookStore.Admin;
using BookStore.Data;
using BookStore.Report;
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

        DBConnect db = new DBConnect();

        public frmMain() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            label1.BackColor = Color.Transparent;
            lbName.BackColor = Color.Transparent;
            if (DBConnect.BOPHAN == DBConnect.BANHANG) {
                mnManager.Enabled = false;
            }

            lbName.Text = DBConnect.TENNHANVIEN;
        }

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
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
        }

        private void mnBillOrderIn_Click(object sender, EventArgs e) {
            this.Hide();
            frmBillOrderIn fbi = new frmBillOrderIn();
            fbi.ShowDialog();
            this.Show();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            
        }

        private void btnCart_Click(object sender, EventArgs e) {
            this.Hide();
            frmCart fc = new frmCart();
            fc.ShowDialog();
            this.Show();
        }

        private void mniReport_Click(object sender, EventArgs e) {
            frmReport fReport = new frmReport();
            fReport.ShowDialog();
        }
    }
}
