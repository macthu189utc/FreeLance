using BookStore.Admin;
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
        public frmMain() {
            InitializeComponent();
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
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
        }

        private void mnBillOrderIn_Click(object sender, EventArgs e) {
            frmBillOrderIn fbi = new frmBillOrderIn();
            fbi.ShowDialog();
        }
    }
}
