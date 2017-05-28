using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Report {
    public partial class frmReportStaff : Form {
        public frmReportStaff() {
            InitializeComponent();
        }

        private void frmReportStaff_Load(object sender, EventArgs e) {

            this.reportViewer1.RefreshReport();
        }
    }
}
