using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fAccountManager : Form
    {
        public fAccountManager()
        {
            InitializeComponent();
        }

        private void fAccountManager_Load(object sender, EventArgs e)
        {
            showChildPanel(pnlEditAccount);
        }

        private void showChildPanel(Panel childName)
        {
            this.Controls.Clear();
            this.Controls.Add(childName);
            childName.SetBounds(0, 0, 1876, 986);
            childName.BringToFront();
            childName.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlChangePass);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            showChildPanel(pnlEditAccount);
        }
    }
}
