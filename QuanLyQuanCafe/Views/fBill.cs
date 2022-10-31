using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Views
{
    public partial class fBill : Form
    {
        DbLayer DbLayer;
        public fBill()
        {
            InitializeComponent();
        }

        private void pnlToolNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fBill_Load(object sender, EventArgs e)
        {
            DbLayer = new DbLayer();
            showChildPanel(pnlHoaDon, pnlToolNV);
            renderDgvHangHoa();
        }

        private void renderDgvHangHoa()
        {
            DataTable dtProduct = DbLayer.ExecuteQuery("Select *from Product", CommandType.Text);
            dgvHoaDon.DataSource = dtProduct;
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

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvHoaDon.CurrentCell != null)
            {
                string idOrder = dgvHoaDon.Rows[dgvHoaDon.CurrentCell.RowIndex].Cells[0].Value.ToString();
                fChiTietHoaDon formChiTietHoaDon = new fChiTietHoaDon(idOrder);
                formChiTietHoaDon.Show();
            }
        }
    }
}
