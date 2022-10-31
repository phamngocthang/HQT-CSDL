
namespace QuanLyQuanCafe
{
    partial class fMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPos = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChuaFormChild = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccount,
            this.btnStaff,
            this.btnProduct,
            this.btnBill,
            this.btnPos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnAccount
            // 
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(98, 32);
            this.btnAccount.Text = "Account";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(65, 32);
            this.btnStaff.Text = "Staff";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(95, 32);
            this.btnProduct.Text = "Product";
            this.btnProduct.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // btnBill
            // 
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(52, 32);
            this.btnBill.Text = "Bill";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnPos
            // 
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(56, 32);
            this.btnPos.Text = "Pos";
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // pnlChuaFormChild
            // 
            this.pnlChuaFormChild.Location = new System.Drawing.Point(12, 45);
            this.pnlChuaFormChild.Name = "pnlChuaFormChild";
            this.pnlChuaFormChild.Size = new System.Drawing.Size(1918, 998);
            this.pnlChuaFormChild.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlChuaFormChild);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAccount;
        private System.Windows.Forms.ToolStripMenuItem btnStaff;
        private System.Windows.Forms.ToolStripMenuItem btnProduct;
        private System.Windows.Forms.ToolStripMenuItem btnBill;
        private System.Windows.Forms.ToolStripMenuItem btnPos;
        private System.Windows.Forms.Panel pnlChuaFormChild;
    }
}