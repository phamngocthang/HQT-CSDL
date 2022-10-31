using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Views
{
    public partial class fChiTietHoaDon : Form
    {
        string idHoaDonHienTai;
        public fChiTietHoaDon(string Id)
        {
            this.idHoaDonHienTai = Id;
            InitializeComponent();
        }

        private void fChiTietHoaDon_Load(object sender, EventArgs e)
        {
            setLabel();
            setDatadv();
        }

        private void setLabel()
        {
            lblSoHoaDon.Text = "Hóa Đơn #" + idHoaDonHienTai.Trim();// + id Hoa đơn hiện 
            // Tìm hoa đơn dựa vào ID hóa đơn rồi lấy tổng tiền

        }

        private void setDatadv()
        {
            // Select Chi Tiet Hoa Don dua vào idHoaDonHienTai rồi đưa lên datagridview
        }

    }
}
