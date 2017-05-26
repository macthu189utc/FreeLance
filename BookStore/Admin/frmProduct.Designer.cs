namespace BookStore.Admin {
    partial class frmProduct {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbAuthor = new System.Windows.Forms.ComboBox();
            this.cbbPublisher = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPriceIn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChooseImage);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPriceIn);
            this.groupBox1.Controls.Add(this.cbbAuthor);
            this.groupBox1.Controls.Add(this.cbbPublisher);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rtbDescription);
            this.groupBox1.Controls.Add(this.cbbCategory);
            this.groupBox1.Controls.Add(this.ptbImage);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // cbbAuthor
            // 
            this.cbbAuthor.Enabled = false;
            this.cbbAuthor.FormattingEnabled = true;
            this.cbbAuthor.Location = new System.Drawing.Point(654, 164);
            this.cbbAuthor.Name = "cbbAuthor";
            this.cbbAuthor.Size = new System.Drawing.Size(129, 29);
            this.cbbAuthor.TabIndex = 23;
            // 
            // cbbPublisher
            // 
            this.cbbPublisher.Enabled = false;
            this.cbbPublisher.FormattingEnabled = true;
            this.cbbPublisher.Location = new System.Drawing.Point(654, 69);
            this.cbbPublisher.Name = "cbbPublisher";
            this.cbbPublisher.Size = new System.Drawing.Size(129, 29);
            this.cbbPublisher.TabIndex = 22;
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(988, 28);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(129, 29);
            this.txtNum.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(909, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Số lượng";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Enabled = false;
            this.rtbDescription.Location = new System.Drawing.Point(881, 72);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(236, 123);
            this.rtbDescription.TabIndex = 19;
            this.rtbDescription.Text = "";
            // 
            // cbbCategory
            // 
            this.cbbCategory.Enabled = false;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(654, 116);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(129, 29);
            this.cbbCategory.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(326, 116);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(129, 29);
            this.txtPrice.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(326, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(383, 29);
            this.txtName.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(326, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 29);
            this.txtID.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhà xuất bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh mục";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(535, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(822, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1123, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(5, 21);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(1112, 268);
            this.dgvData.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(12, 542);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1123, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(787, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 35);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(675, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 35);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(563, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 35);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(451, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(339, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 35);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(227, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 35);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.Enabled = false;
            this.txtPriceIn.Location = new System.Drawing.Point(326, 164);
            this.txtPriceIn.Name = "txtPriceIn";
            this.txtPriceIn.Size = new System.Drawing.Size(129, 29);
            this.txtPriceIn.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Giá nhập";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseImage.Image = global::BookStore.Properties.Resources.Natsu_FolderOpen;
            this.btnChooseImage.Location = new System.Drawing.Point(172, 25);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(35, 32);
            this.btnChooseImage.TabIndex = 26;
            this.btnChooseImage.UseVisualStyleBackColor = true;
            // 
            // ptbImage
            // 
            this.ptbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.Image = global::BookStore.Properties.Resources.images;
            this.ptbImage.Location = new System.Drawing.Point(16, 25);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(155, 186);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 17;
            this.ptbImage.TabStop = false;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 624);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbAuthor;
        private System.Windows.Forms.ComboBox cbbPublisher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPriceIn;
        private System.Windows.Forms.Button btnChooseImage;
    }
}