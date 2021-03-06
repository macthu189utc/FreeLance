﻿using BookStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Sale {
    public partial class frmBillOrderOut : Form {
        DBConnect db = new DBConnect();
        public frmBillOrderOut() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            myTable1 = new DataTable();
            myTable2 = new DataTable();
            myBindS1 = new BindingSource();
        }
        private BindingSource myBindS1 = null;
        private DataTable myTable2 = null;
        private DataTable myTable1 = null;
        private string[] headerTextBill = { "Mã HĐB", "Tên nhân viên", "Tên khách hàng", "Ngày bán" };
        private int[] sizeBillOut = { 17, 32, 30, 20 };
        private string[] headerTextDetail = { "Mã HĐB", "Tên sách", "Đơn giá", "Số lượng" };
        private int[] sizeDetail = { 15, 35, 25, 25 };

        private void frmBillOrderOut_Load(object sender, EventArgs e) {
            // Thêm các cột cho bảng
            string strBill = "Select MAHOADON, TENNHANVIEN, TENKHACHHANG, NGAYXUAT"
                              + " from HOADONXUAT"
                              + " inner join KHACHHANG on HOADONXUAT.MAKHACHHANG = KHACHHANG.MAKHACHHANG"
                              + " inner join NHANVIEN on HOADONXUAT.MANHANVIEN = NHANVIEN.MANHANVIEN";

            myTable1 = db.GetData(strBill);

            // Gán dữ liệu nguồn của data grid view vào bảng, bảng gán vào binding, bingding dán vào dgv
            myBindS1.DataSource = myTable1;
            dgvBill.DataSource = myBindS1;

            // Chỉnh độ rộng tên hiển thị của cột
            for (int i = 0; i < headerTextBill.Length; i++) {
                dgvBill.Columns[i].Width = ((dgvBill.Width) / 100) * sizeBillOut[i];
                dgvBill.Columns[i].HeaderText = headerTextBill[i];
            }
            //Chế độ chọn theo hàng
            dgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Đỉnh dạng dgv chi tiết trước

        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e) {
            // Lấy ra vị trí hàng đầu thứ 0
            // Lấy hàng có vị trí vừa lấy ra, ô thứ 0 tức là ô Mã hoá đơn
            // Gán các DetailOut có mã vừa lấy ra vào dgvDetail
            int index = dgvBill.SelectedRows[0].Index;
            string strID = dgvBill.Rows[index].Cells[0].Value.ToString();

            string str = "select MAHOADON, TENSACH, CHITIETHOADONXUAT.DONGIA, CHITIETHOADONXUAT.SOLUONG "
                           + " from CHITIETHOADONXUAT "
                           + " inner join SACH on CHITIETHOADONXUAT.MASACH = SACH.MASACH "
                           + " where MAHOADON = '" + strID + "'";
            // Thêm các cột cho bảng
            myTable2 = db.GetData(str);

            // Gán dữ liệu nguồn của data grid view vào bảng, bảng gán vào binding, bingding dán vào dgv
            dgvDetail.DataSource = myTable2;
            //dgvDetail.DataSource = myBindS2;

            // Chỉnh độ rộng tên hiển thị của cột
            for (int i = 0; i < headerTextDetail.Length; i++) {
                dgvDetail.Columns[i].Width = ((dgvDetail.Width) / 100) * sizeDetail[i];
                dgvDetail.Columns[i].HeaderText = headerTextDetail[i];
            }
            //Chế độ chọn theo hàng
            dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string loc = string.Format("TENKHACHHANG like '%{0}%' or TENNHANVIEN like '%{1}%'",
                                           txtSearch.Text, txtSearch.Text);
            myBindS1.Filter = loc;
            dgvBill.DataSource = myBindS1;
        }
    }
}
