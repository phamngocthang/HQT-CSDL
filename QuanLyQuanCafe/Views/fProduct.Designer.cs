
namespace QuanLyQuanCafe
{
    partial class fProduct
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
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblSoHangHoa = new System.Windows.Forms.Label();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.pnlEditProduct = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtMaProduct = new System.Windows.Forms.TextBox();
            this.pnlToolProduct = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlProduct.SuspendLayout();
            this.pnlEditProduct.SuspendLayout();
            this.pnlToolProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tên Hàng Hóa",
            "Loại Món"});
            this.cbbTimKiem.Location = new System.Drawing.Point(11, 43);
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(237, 49);
            this.cbbTimKiem.TabIndex = 0;
            this.cbbTimKiem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(281, 45);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(820, 47);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblSoHangHoa
            // 
            this.lblSoHangHoa.AutoSize = true;
            this.lblSoHangHoa.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoHangHoa.Location = new System.Drawing.Point(1116, 41);
            this.lblSoHangHoa.Name = "lblSoHangHoa";
            this.lblSoHangHoa.Size = new System.Drawing.Size(246, 54);
            this.lblSoHangHoa.TabIndex = 2;
            this.lblSoHangHoa.Text = "xx Mặt Hàng";
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelProduct.Location = new System.Drawing.Point(1401, 46);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(125, 52);
            this.btnDelProduct.TabIndex = 3;
            this.btnDelProduct.Text = "Xóa";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditProduct.Location = new System.Drawing.Point(1571, 46);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(118, 54);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(1729, 46);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 54);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.productName,
            this.productPrice,
            this.productSoLuong});
            this.dgvProduct.Location = new System.Drawing.Point(38, 31);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(1096, 512);
            this.dgvProduct.TabIndex = 6;
            // 
            // idProduct
            // 
            this.idProduct.DataPropertyName = "idP";
            this.idProduct.HeaderText = "idProduct";
            this.idProduct.MinimumWidth = 6;
            this.idProduct.Name = "idProduct";
            this.idProduct.Width = 150;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "name";
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 450;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "price";
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 220;
            // 
            // productSoLuong
            // 
            this.productSoLuong.DataPropertyName = "soluong";
            this.productSoLuong.HeaderText = "Số Lượng";
            this.productSoLuong.MinimumWidth = 6;
            this.productSoLuong.Name = "productSoLuong";
            this.productSoLuong.Width = 220;
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.dgvProduct);
            this.pnlProduct.Location = new System.Drawing.Point(8, 939);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(1880, 737);
            this.pnlProduct.TabIndex = 8;
            // 
            // pnlEditProduct
            // 
            this.pnlEditProduct.Controls.Add(this.label9);
            this.pnlEditProduct.Controls.Add(this.label8);
            this.pnlEditProduct.Controls.Add(this.label7);
            this.pnlEditProduct.Controls.Add(this.label6);
            this.pnlEditProduct.Controls.Add(this.label5);
            this.pnlEditProduct.Controls.Add(this.cbLoaiMon);
            this.pnlEditProduct.Controls.Add(this.btnLuu);
            this.pnlEditProduct.Controls.Add(this.label4);
            this.pnlEditProduct.Controls.Add(this.btnHuy);
            this.pnlEditProduct.Controls.Add(this.label3);
            this.pnlEditProduct.Controls.Add(this.lblType);
            this.pnlEditProduct.Controls.Add(this.txtTrangThai);
            this.pnlEditProduct.Controls.Add(this.txtPriceProduct);
            this.pnlEditProduct.Controls.Add(this.txtNameProduct);
            this.pnlEditProduct.Controls.Add(this.txtMaProduct);
            this.pnlEditProduct.Location = new System.Drawing.Point(12, 173);
            this.pnlEditProduct.Name = "pnlEditProduct";
            this.pnlEditProduct.Size = new System.Drawing.Size(1883, 743);
            this.pnlEditProduct.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(373, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 54);
            this.label9.TabIndex = 15;
            this.label9.Text = "Trạng Thái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(373, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 54);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giá Bán ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(373, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 54);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Thực Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(373, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 54);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Hàng Hóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(373, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 54);
            this.label5.TabIndex = 11;
            this.label5.Text = "Loại Món";
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(719, 127);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(324, 49);
            this.cbLoaiMon.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1655, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 61);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(719, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá bán *";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1469, 20);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 61);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1141, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "VND";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(29, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(310, 54);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Thêm Hàng Hóa";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTrangThai.Location = new System.Drawing.Point(719, 588);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(666, 61);
            this.txtTrangThai.TabIndex = 5;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriceProduct.Location = new System.Drawing.Point(719, 478);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(384, 61);
            this.txtPriceProduct.TabIndex = 4;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameProduct.Location = new System.Drawing.Point(719, 347);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(666, 61);
            this.txtNameProduct.TabIndex = 3;
            // 
            // txtMaProduct
            // 
            this.txtMaProduct.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaProduct.Location = new System.Drawing.Point(719, 230);
            this.txtMaProduct.Name = "txtMaProduct";
            this.txtMaProduct.Size = new System.Drawing.Size(666, 61);
            this.txtMaProduct.TabIndex = 2;
            // 
            // pnlToolProduct
            // 
            this.pnlToolProduct.Controls.Add(this.cbbTimKiem);
            this.pnlToolProduct.Controls.Add(this.txtTimKiem);
            this.pnlToolProduct.Controls.Add(this.lblSoHangHoa);
            this.pnlToolProduct.Controls.Add(this.btnDelProduct);
            this.pnlToolProduct.Controls.Add(this.btnEditProduct);
            this.pnlToolProduct.Controls.Add(this.btnAddProduct);
            this.pnlToolProduct.Location = new System.Drawing.Point(5, 23);
            this.pnlToolProduct.Name = "pnlToolProduct";
            this.pnlToolProduct.Size = new System.Drawing.Size(1883, 127);
            this.pnlToolProduct.TabIndex = 10;
            // 
            // fProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 951);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlToolProduct);
            this.Controls.Add(this.pnlEditProduct);
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlProduct.ResumeLayout(false);
            this.pnlEditProduct.ResumeLayout(false);
            this.pnlEditProduct.PerformLayout();
            this.pnlToolProduct.ResumeLayout(false);
            this.pnlToolProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Panel pnlEditProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSoHangHoa;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtMaProduct;
        private System.Windows.Forms.Panel pnlToolProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSoLuong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}