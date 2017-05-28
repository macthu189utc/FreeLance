namespace BookStore {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPublisher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBillOrderOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBillOrderIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnManager,
            this.mnSale,
            this.mnHelp,
            this.mnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnManager
            // 
            this.mnManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProduct,
            this.mnCategory,
            this.mnPublisher,
            this.mnStaff,
            this.mnProvider});
            this.mnManager.Image = global::BookStore.Properties.Resources._32_user_starred;
            this.mnManager.Name = "mnManager";
            this.mnManager.Size = new System.Drawing.Size(76, 20);
            this.mnManager.Text = "Quản lý";
            // 
            // mnProduct
            // 
            this.mnProduct.Image = global::BookStore.Properties.Resources._32_basket_full;
            this.mnProduct.Name = "mnProduct";
            this.mnProduct.Size = new System.Drawing.Size(148, 22);
            this.mnProduct.Text = "Sản phẩm";
            this.mnProduct.Click += new System.EventHandler(this.mnProduct_Click);
            // 
            // mnCategory
            // 
            this.mnCategory.Image = global::BookStore.Properties.Resources._32_folder_tag;
            this.mnCategory.Name = "mnCategory";
            this.mnCategory.Size = new System.Drawing.Size(148, 22);
            this.mnCategory.Text = "Danh mục";
            this.mnCategory.Click += new System.EventHandler(this.mnCategory_Click);
            // 
            // mnPublisher
            // 
            this.mnPublisher.Image = global::BookStore.Properties.Resources._32_user_starred1;
            this.mnPublisher.Name = "mnPublisher";
            this.mnPublisher.Size = new System.Drawing.Size(148, 22);
            this.mnPublisher.Text = "Nhà xuất bản";
            this.mnPublisher.Click += new System.EventHandler(this.mnPublisher_Click);
            // 
            // mnStaff
            // 
            this.mnStaff.Image = global::BookStore.Properties.Resources._32_user_favourite;
            this.mnStaff.Name = "mnStaff";
            this.mnStaff.Size = new System.Drawing.Size(148, 22);
            this.mnStaff.Text = "Nhân viên";
            this.mnStaff.Click += new System.EventHandler(this.mnStaff_Click);
            // 
            // mnProvider
            // 
            this.mnProvider.Image = global::BookStore.Properties.Resources._32_user_unstarred;
            this.mnProvider.Name = "mnProvider";
            this.mnProvider.Size = new System.Drawing.Size(148, 22);
            this.mnProvider.Text = "Nhà cung cấp";
            this.mnProvider.Click += new System.EventHandler(this.mnProvider_Click);
            // 
            // mnSale
            // 
            this.mnSale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCustomer,
            this.mnBillOrderOut,
            this.mnBillOrderIn});
            this.mnSale.Image = global::BookStore.Properties.Resources._32_basket_empty;
            this.mnSale.Name = "mnSale";
            this.mnSale.Size = new System.Drawing.Size(85, 20);
            this.mnSale.Text = "Bán hàng";
            // 
            // mnCustomer
            // 
            this.mnCustomer.Image = global::BookStore.Properties.Resources._32_user;
            this.mnCustomer.Name = "mnCustomer";
            this.mnCustomer.Size = new System.Drawing.Size(150, 22);
            this.mnCustomer.Text = "Khách hàng";
            this.mnCustomer.Click += new System.EventHandler(this.mnCustomer_Click);
            // 
            // mnBillOrderOut
            // 
            this.mnBillOrderOut.Image = global::BookStore.Properties.Resources._32_file;
            this.mnBillOrderOut.Name = "mnBillOrderOut";
            this.mnBillOrderOut.Size = new System.Drawing.Size(150, 22);
            this.mnBillOrderOut.Text = "Hoá đơn bán";
            this.mnBillOrderOut.Click += new System.EventHandler(this.mnBill_Click);
            // 
            // mnBillOrderIn
            // 
            this.mnBillOrderIn.Image = global::BookStore.Properties.Resources._32_note;
            this.mnBillOrderIn.Name = "mnBillOrderIn";
            this.mnBillOrderIn.Size = new System.Drawing.Size(150, 22);
            this.mnBillOrderIn.Text = "Hoá đơn nhập";
            this.mnBillOrderIn.Click += new System.EventHandler(this.mnBillOrderIn_Click);
            // 
            // mnHelp
            // 
            this.mnHelp.Image = global::BookStore.Properties.Resources._32_settings;
            this.mnHelp.Name = "mnHelp";
            this.mnHelp.Size = new System.Drawing.Size(79, 20);
            this.mnHelp.Text = "Trợ giúp";
            this.mnHelp.Click += new System.EventHandler(this.mnHelp_Click);
            // 
            // mnLogout
            // 
            this.mnLogout.Image = global::BookStore.Properties.Resources._32_arrow_refresh;
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(88, 20);
            this.mnLogout.Text = "Đăng xuất";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // btnCart
            // 
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Image = global::BookStore.Properties.Resources._32_basket_full;
            this.btnCart.Location = new System.Drawing.Point(1294, 25);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(46, 46);
            this.btnCart.TabIndex = 4;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(376, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhân viên:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Snow;
            this.lbName.Location = new System.Drawing.Point(528, 46);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(137, 31);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Dương Vũ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BookStore.Properties.Resources.best_books_2015_wide_18ea71bcef7792d9fd6ea5183846999a06b17eee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 680);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Hệ thống quản lý cửa hàng bán sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnManager;
        private System.Windows.Forms.ToolStripMenuItem mnProduct;
        private System.Windows.Forms.ToolStripMenuItem mnCategory;
        private System.Windows.Forms.ToolStripMenuItem mnPublisher;
        private System.Windows.Forms.ToolStripMenuItem mnStaff;
        private System.Windows.Forms.ToolStripMenuItem mnSale;
        private System.Windows.Forms.ToolStripMenuItem mnHelp;
        private System.Windows.Forms.ToolStripMenuItem mnCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnBillOrderOut;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.ToolStripMenuItem mnProvider;
        private System.Windows.Forms.ToolStripMenuItem mnBillOrderIn;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
    }
}

