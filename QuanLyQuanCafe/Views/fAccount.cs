using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAccount : Form
    {
        DbLayer DbLayer;
        public fAccount()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            DbLayer = new DbLayer();
            showChildPanel(pnlAccount, pnlToolAccount);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlAccount, pnlToolAccount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlEditAccount, pnlToolAccount);
        }
    }
}
