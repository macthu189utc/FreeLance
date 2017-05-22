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
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            frmRegister fr = new frmRegister();
            fr.ShowDialog();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
