using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Views
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            showChildPanel(pnlNV, pnlToolNV);

        }

        private void showChildPanel(Panel childName, Panel tool)
        {
            this.Controls.Clear();
            this.Controls.Add(tool);
            tool.SetBounds(5, 23, 1883, 127);
            tool.BringToFront();
            tool.Show();

            this.Controls.Add(childName);
            childName.SetBounds(5, 188, 1883, 743);
            childName.BringToFront();
            childName.Show();
        }
        private void resetAlltext()
        {
            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtNgayBatDau.ResetText();
            txtSoNgayLam.ResetText();
            txtChucVu.ResetText();
            txtNgaySinh.ResetText();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlNV, pnlToolNV);
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlEditNV, pnlToolNV);
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlEditNV, pnlToolNV);
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa NV này (Y/N)", "Thông báo"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl == DialogResult.Yes)
            {
                // Thức thi lệnh xóa

                // Render lại nhân viên lên datagridview
            }
        }
    }
}
