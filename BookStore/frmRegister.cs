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
    public partial class frmRegister : Form {
        DBConnect db = new DBConnect();
        public frmRegister() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private DataTable myTable;

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e) {

        }

        private void btnRegister_Click(object sender, EventArgs e) {
            string acc = txtAccount.Text.Trim().Replace("-", "");
            string pass = txtPassword.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;


            // Kiểm tra các trường bỏ trống
            if (acc == "") {
                MessageBox.Show("Vui lòng nhập vào tên tài khoản");
                return;
            }
            if (pass == "") {
                MessageBox.Show("Vui lòng nhập vào mật khẩu");
                return;
            }

            // Kiểm tra tên tài khoản, mật khẩu đã tồn tại
            string strSQL1 = string.Format("SELECT * FROM NHANVIEN " +
                                          "where TENTAIKHOAN = '{0}'", acc);
            DataTable data = db.GetData(strSQL1);
            int a = data.Rows.Count;
            if (a > 0) {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }

            // Đăng kí tài khoản
            try {
                string strSQL =
                        string.Format(
                            "INSERT INTO NHANVIEN " +
                            "(TENNHANVIEN, SODIENTHOAI, EMAIL, " +
                            " DIACHI, MABOPHAN, TRANGTHAI, TENTAIKHOAN, MATKHAU) " +
                            "VALUES('{0}', '{1}', '{2}', '{3}', {4}, {5}, '{6}', '{7}')",
                            acc, phone, email, "-", 1, 1, acc, pass);

                db.UpdataData(strSQL);
                MessageBox.Show("Bạn đã đăng ký thành công. Vui lòng đăng nhập.");
                this.Close();
            }
            catch (Exception) {
                MessageBox.Show("Không thể đăng ký tài khoản này!");
                throw;
            }
        }
    }
}
