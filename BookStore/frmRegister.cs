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
            string sqlDp = "Select * from BOPHAN";
            DataTable dtDp = db.GetData(sqlDp);

            cbbDepartment.DataSource = dtDp;
            cbbDepartment.DisplayMember = "TENBOPHAN";
            cbbDepartment.ValueMember = "MABOPHAN";
            cbbDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (txtAccount.Text == "" || txtPassword.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            

            this.Close();
        }
    }
}
