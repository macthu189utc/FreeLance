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

namespace BookStore {
    public partial class frmLogin : Form {

        DBConnect db = new DBConnect();
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

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e) {

            string acc = txtAccount.Text.Trim().Replace("-", "");
            string pass = txtPassword.Text;

            if (acc == "") {
                lbError.Text = "Vui lòng nhập vào tên tài khoản";
                lbError.Visible = true;
                return;
            }
            if (pass == "") {
                lbError.Text = "Vui lòng nhập vào mật khẩu";
                lbError.Visible = true;
                return;
            }
            string strSQL = string.Format("SELECT * FROM NHANVIEN " +
                                          "where TENTAIKHOAN = '{0}' and MATKHAU = '{1}'", acc, pass);
            DataTable data = db.GetData(strSQL);

            int a = data.Rows.Count;
            if (a == 0) {
                lbError.Text = "Sai tên đăng nhập hoặc mật khẩu";
                lbError.Visible = true;
                return;
            }
            else {
                long state = long.Parse(data.Rows[0]["TRANGTHAI"].ToString());
                if (state == 2) {
                    lbError.Text = "Tài khoản đã bị khóa";
                    lbError.Visible = true;
                    return;
                }

                lbError.Visible = false;
                //this.AcceptButton = btnLogin;
                this.Hide();
                int role = int.Parse(data.Rows[0]["MABOPHAN"].ToString());
                frmMain fMain = new frmMain();
                DBConnect.BOPHAN = role;
                DBConnect.TENNHANVIEN = data.Rows[0]["TENNHANVIEN"].ToString();
                fMain.ShowDialog();
                this.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e) {
            this.AcceptButton = btnLogin;
        }
    }
}
