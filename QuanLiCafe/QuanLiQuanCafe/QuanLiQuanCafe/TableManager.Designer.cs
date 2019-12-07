namespace QuanLiQuanCafe
{
    partial class TableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnChuyenBan = new DevExpress.XtraEditors.SimpleButton();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new DevExpress.XtraEditors.SimpleButton();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.cbCategrory = new System.Windows.Forms.ComboBox();
            this.fnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(421, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 272);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(9, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 257);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChuyenBan);
            this.panel3.Controls.Add(this.btnChuyenBan);
            this.panel3.Controls.Add(this.nudGiamGia);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(424, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(446, 108);
            this.panel3.TabIndex = 3;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(274, 9);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(136, 21);
            this.cbChuyenBan.TabIndex = 7;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Appearance.Options.UseFont = true;
            this.btnChuyenBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenBan.ImageOptions.Image")));
            this.btnChuyenBan.Location = new System.Drawing.Point(274, 34);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(136, 66);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(147, 3);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(121, 20);
            this.nudGiamGia.TabIndex = 4;
            this.nudGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamGia.Appearance.Options.UseFont = true;
            this.btnGiamGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiamGia.ImageOptions.Image")));
            this.btnGiamGia.Location = new System.Drawing.Point(147, 34);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(121, 66);
            this.btnGiamGia.TabIndex = 5;
            this.btnGiamGia.Text = "Giảm giá";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.ImageOptions.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(6, 34);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 66);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.FoodCount);
            this.panel4.Controls.Add(this.btnadd);
            this.panel4.Controls.Add(this.cbMonAn);
            this.panel4.Controls.Add(this.cbCategrory);
            this.panel4.Location = new System.Drawing.Point(424, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 73);
            this.panel4.TabIndex = 4;
            // 
            // FoodCount
            // 
            this.FoodCount.Location = new System.Drawing.Point(362, 25);
            this.FoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.FoodCount.Name = "FoodCount";
            this.FoodCount.Size = new System.Drawing.Size(84, 20);
            this.FoodCount.TabIndex = 3;
            this.FoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnadd
            // 
            this.btnadd.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Appearance.Options.UseFont = true;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(221, 0);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(138, 66);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Thêm món";
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(3, 30);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(212, 21);
            this.cbMonAn.TabIndex = 1;
            // 
            // cbCategrory
            // 
            this.cbCategrory.FormattingEnabled = true;
            this.cbCategrory.Location = new System.Drawing.Point(3, 3);
            this.cbCategrory.Name = "cbCategrory";
            this.cbCategrory.Size = new System.Drawing.Size(212, 21);
            this.cbCategrory.TabIndex = 0;
            // 
            // fnlTable
            // 
            this.fnlTable.Location = new System.Drawing.Point(0, 30);
            this.fnlTable.Name = "fnlTable";
            this.fnlTable.Size = new System.Drawing.Size(415, 425);
            this.fnlTable.TabIndex = 5;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 481);
            this.Controls.Add(this.fnlTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm  quản lí quán cà phê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown FoodCount;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.ComboBox cbCategrory;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private System.Windows.Forms.FlowLayoutPanel fnlTable;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private DevExpress.XtraEditors.SimpleButton btnChuyenBan;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private DevExpress.XtraEditors.SimpleButton btnGiamGia;
    }
}