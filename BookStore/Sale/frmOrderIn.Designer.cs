namespace BookStore.Sale {
    partial class frmOrderIn {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ptbAddPro = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.rtbMoneyWord = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCountMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.cbbProvider = new System.Windows.Forms.ComboBox();
            this.dtpDateOrder = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ptbBook = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbAddBook = new System.Windows.Forms.PictureBox();
            this.cbbBook = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddPro)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbAddPro
            // 
            this.ptbAddPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAddPro.Image = global::BookStore.Properties.Resources._32_user_unstarred;
            this.ptbAddPro.Location = new System.Drawing.Point(390, 77);
            this.ptbAddPro.Name = "ptbAddPro";
            this.ptbAddPro.Size = new System.Drawing.Size(29, 29);
            this.ptbAddPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddPro.TabIndex = 6;
            this.ptbAddPro.TabStop = false;
            this.ptbAddPro.Click += new System.EventHandler(this.ptbAddPro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.lbNameStaff);
            this.groupBox2.Controls.Add(this.ptbAddPro);
            this.groupBox2.Controls.Add(this.btnPay);
            this.groupBox2.Controls.Add(this.rtbMoneyWord);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbCountMoney);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbbProvider);
            this.groupBox2.Controls.Add(this.dtpDateOrder);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(684, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 656);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng nhập";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::BookStore.Properties.Resources._32_bullet_deny;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(74, 584);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Huỷ đơn";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNameStaff.Location = new System.Drawing.Point(535, 18);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(52, 21);
            this.lbNameStaff.TabIndex = 12;
            this.lbNameStaff.Text = "Name";
            this.lbNameStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Image = global::BookStore.Properties.Resources._32_basket_add;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(74, 534);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 40);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // rtbMoneyWord
            // 
            this.rtbMoneyWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbMoneyWord.Location = new System.Drawing.Point(390, 561);
            this.rtbMoneyWord.Name = "rtbMoneyWord";
            this.rtbMoneyWord.Size = new System.Drawing.Size(245, 78);
            this.rtbMoneyWord.TabIndex = 10;
            this.rtbMoneyWord.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(310, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bằng chữ";
            // 
            // lbCountMoney
            // 
            this.lbCountMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCountMoney.Location = new System.Drawing.Point(456, 510);
            this.lbCountMoney.Name = "lbCountMoney";
            this.lbCountMoney.Size = new System.Drawing.Size(181, 37);
            this.lbCountMoney.TabIndex = 9;
            this.lbCountMoney.Text = "0";
            this.lbCountMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(312, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng tiền";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOrder);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 352);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách mặt hàng";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOrder.Location = new System.Drawing.Point(11, 30);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.Size = new System.Drawing.Size(604, 307);
            this.dgvOrder.TabIndex = 6;
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            // 
            // cbbProvider
            // 
            this.cbbProvider.BackColor = System.Drawing.Color.White;
            this.cbbProvider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbProvider.FormattingEnabled = true;
            this.cbbProvider.Location = new System.Drawing.Point(139, 77);
            this.cbbProvider.Name = "cbbProvider";
            this.cbbProvider.Size = new System.Drawing.Size(251, 29);
            this.cbbProvider.TabIndex = 7;
            // 
            // dtpDateOrder
            // 
            this.dtpDateOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOrder.Location = new System.Drawing.Point(468, 94);
            this.dtpDateOrder.Name = "dtpDateOrder";
            this.dtpDateOrder.Size = new System.Drawing.Size(125, 29);
            this.dtpDateOrder.TabIndex = 6;
            this.dtpDateOrder.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.AutoSize = true;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpDate.Location = new System.Drawing.Point(468, 59);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(89, 21);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhà cung cấp";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(9, 230);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(639, 413);
            this.dgvData.TabIndex = 6;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // ptbBook
            // 
            this.ptbBook.Image = global::BookStore.Properties.Resources.image;
            this.ptbBook.Location = new System.Drawing.Point(483, 23);
            this.ptbBook.Name = "ptbBook";
            this.ptbBook.Size = new System.Drawing.Size(160, 190);
            this.ptbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBook.TabIndex = 5;
            this.ptbBook.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::BookStore.Properties.Resources._32_user_search;
            this.pictureBox1.Location = new System.Drawing.Point(385, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(134, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 29);
            this.txtSearch.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvData);
            this.groupBox1.Controls.Add(this.ptbAddBook);
            this.groupBox1.Controls.Add(this.ptbBook);
            this.groupBox1.Controls.Add(this.cbbBook);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 656);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(33, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tiềm kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(33, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số lượng";
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(134, 173);
            this.numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(74, 29);
            this.numeric.TabIndex = 17;
            this.numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sách";
            // 
            // ptbAddBook
            // 
            this.ptbAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAddBook.Image = global::BookStore.Properties.Resources._32_basket_add;
            this.ptbAddBook.Location = new System.Drawing.Point(385, 55);
            this.ptbAddBook.Name = "ptbAddBook";
            this.ptbAddBook.Size = new System.Drawing.Size(29, 29);
            this.ptbAddBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddBook.TabIndex = 14;
            this.ptbAddBook.TabStop = false;
            this.ptbAddBook.Click += new System.EventHandler(this.ptbAddBook_Click);
            // 
            // cbbBook
            // 
            this.cbbBook.BackColor = System.Drawing.Color.White;
            this.cbbBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbBook.FormattingEnabled = true;
            this.cbbBook.Location = new System.Drawing.Point(134, 55);
            this.cbbBook.Name = "cbbBook";
            this.cbbBook.Size = new System.Drawing.Size(251, 29);
            this.cbbBook.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // mDelete
            // 
            this.mDelete.Name = "mDelete";
            this.mDelete.Size = new System.Drawing.Size(94, 22);
            this.mDelete.Text = "Xoá";
            this.mDelete.Click += new System.EventHandler(this.mDelete_Click);
            // 
            // frmOrderIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrderIn";
            this.Text = "Hoá đơn nhập hàng";
            this.Load += new System.EventHandler(this.frmOrderIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddPro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAddPro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbNameStaff;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.RichTextBox rtbMoneyWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCountMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.ComboBox cbbProvider;
        private System.Windows.Forms.DateTimePicker dtpDateOrder;
        private System.Windows.Forms.Label dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.PictureBox ptbBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbAddBook;
        private System.Windows.Forms.ComboBox cbbBook;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDelete;
    }
}