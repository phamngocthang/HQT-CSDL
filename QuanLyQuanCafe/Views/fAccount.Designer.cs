
namespace QuanLyQuanCafe
{
    partial class fAccount
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
            this.pnlToolAccount = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblSoHangHoa = new System.Windows.Forms.Label();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.idAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEditAccount = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlToolAccount.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlEditAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolAccount
            // 
            this.pnlToolAccount.Controls.Add(this.button1);
            this.pnlToolAccount.Controls.Add(this.comboBox1);
            this.pnlToolAccount.Controls.Add(this.txtTimKiem);
            this.pnlToolAccount.Controls.Add(this.lblSoHangHoa);
            this.pnlToolAccount.Controls.Add(this.btnDelProduct);
            this.pnlToolAccount.Location = new System.Drawing.Point(5, 29);
            this.pnlToolAccount.Name = "pnlToolAccount";
            this.pnlToolAccount.Size = new System.Drawing.Size(1883, 127);
            this.pnlToolAccount.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1589, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 49);
            this.button1.TabIndex = 39;
            this.button1.Text = "Đổi Mật Khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 49);
            this.comboBox1.TabIndex = 0;
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
            this.lblSoHangHoa.Size = new System.Drawing.Size(240, 54);
            this.lblSoHangHoa.TabIndex = 2;
            this.lblSoHangHoa.Text = "xx Tài Khoản";
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
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.dgvProduct);
            this.pnlAccount.Location = new System.Drawing.Point(2, 931);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(1880, 737);
            this.pnlAccount.TabIndex = 11;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAccount,
            this.password,
            this.quyen});
            this.dgvProduct.Location = new System.Drawing.Point(164, 14);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(1209, 698);
            this.dgvProduct.TabIndex = 6;
            // 
            // idAccount
            // 
            this.idAccount.HeaderText = "Tên Tài Khoản";
            this.idAccount.MinimumWidth = 6;
            this.idAccount.Name = "idAccount";
            this.idAccount.Width = 450;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 350;
            // 
            // quyen
            // 
            this.quyen.HeaderText = "Quyền";
            this.quyen.MinimumWidth = 6;
            this.quyen.Name = "quyen";
            this.quyen.Width = 350;
            // 
            // pnlEditAccount
            // 
            this.pnlEditAccount.Controls.Add(this.label12);
            this.pnlEditAccount.Controls.Add(this.checkBox1);
            this.pnlEditAccount.Controls.Add(this.txtRePass);
            this.pnlEditAccount.Controls.Add(this.label16);
            this.pnlEditAccount.Controls.Add(this.txtNewPass);
            this.pnlEditAccount.Controls.Add(this.label15);
            this.pnlEditAccount.Controls.Add(this.txtPass);
            this.pnlEditAccount.Controls.Add(this.label14);
            this.pnlEditAccount.Controls.Add(this.label13);
            this.pnlEditAccount.Controls.Add(this.txtUserName);
            this.pnlEditAccount.Controls.Add(this.btnLuu);
            this.pnlEditAccount.Controls.Add(this.btnHuy);
            this.pnlEditAccount.Location = new System.Drawing.Point(2, 171);
            this.pnlEditAccount.Name = "pnlEditAccount";
            this.pnlEditAccount.Size = new System.Drawing.Size(1883, 743);
            this.pnlEditAccount.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label12.Location = new System.Drawing.Point(24, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(380, 72);
            this.label12.TabIndex = 38;
            this.label12.Text = "Đổi Mật Khẩu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(823, 692);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(249, 38);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtRePass
            // 
            this.txtRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRePass.Location = new System.Drawing.Point(827, 581);
            this.txtRePass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(688, 68);
            this.txtRePass.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(372, 588);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(460, 61);
            this.label16.TabIndex = 35;
            this.label16.Text = "Xác nhận mật khẩu:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPass.Location = new System.Drawing.Point(827, 462);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(684, 68);
            this.txtNewPass.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(372, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(360, 61);
            this.label15.TabIndex = 33;
            this.label15.Text = "Mật khẩu mới: ";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(823, 328);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(688, 68);
            this.txtPass.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(372, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(436, 61);
            this.label14.TabIndex = 31;
            this.label14.Text = "Mật khẩu hiện tại: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(372, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(369, 61);
            this.label13.TabIndex = 30;
            this.label13.Text = "Tên Tài Khoản:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(823, 181);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(688, 68);
            this.txtUserName.TabIndex = 29;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1655, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 61);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
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
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 951);
            this.Controls.Add(this.pnlEditAccount);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.pnlToolAccount);
            this.Name = "fAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fAccount_Load);
            this.pnlToolAccount.ResumeLayout(false);
            this.pnlToolAccount.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlEditAccount.ResumeLayout(false);
            this.pnlEditAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolAccount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblSoHangHoa;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
        private System.Windows.Forms.Panel pnlEditAccount;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
    }
}