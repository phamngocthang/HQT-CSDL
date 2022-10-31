using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyQuanCafe.DAO;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyQuanCafe
{
    public partial class fProduct : Form
    {
        DbLayer DbLayer;
        int selectedIndex;
        bool them = false;
        int MaSoHangHoa;
        public fProduct()
        {
            InitializeComponent();
        }

        private void fProduct_Load(object sender, EventArgs e)
        {
            DbLayer = new DbLayer();
            GetSoHangHoa();
            showChildPanel(pnlProduct, pnlToolProduct);
            renderDgvHangHoa();
            cbbTimKiem.SelectedIndex = 0;
        }
        private void GetSoHangHoa()
        {
            DataTable dtProduct = DbLayer.ExecuteQuery("Select Max(idP) as MaxID from Product", CommandType.Text);
            foreach (DataRow row in dtProduct.Rows)
            {
                MaSoHangHoa = Convert.ToInt32(row["MaxID"]);
            }
            MaSoHangHoa++;
        }

        private void renderDgvHangHoa()
        {
            DataTable dtProduct = DbLayer.ExecuteQuery("Select *from Product", CommandType.Text);
            dgvProduct.DataSource = dtProduct;
            lblSoHangHoa.Text = ((DataTable)dgvProduct.DataSource).Rows.Count.ToString() + " Hang Hoa";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbbTimKiem.SelectedIndex;
            if (i == 0) txtTimKiem.PlaceholderText = "Nhập ID hàng hóa cần tìm";
            if (i == 1) txtTimKiem.PlaceholderText = "Nhập tên hàng hóa cần tìm";
            txtTimKiem.ResetText();
        }



        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(tl == DialogResult.OK)
            {
                string productID = dgvProduct.Rows[dgvProduct.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string err = "";
                string queryDel = "Delete from Product Where idP = @idP";
                if(DbLayer.ExecuteNonQuery(queryDel, CommandType.Text, ref err, 
                    new SqlParameter("@idP", productID)) == true)
                {
                    MessageBox.Show("Xoá thành công");
                }
                else
                {
                    MessageBox.Show("Loi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            renderDgvHangHoa();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            them = false;
            selectedIndex = dgvProduct.CurrentCell.RowIndex;
            lblType.Text = "Sửa Hàng Hoá";
            txtMaProduct.Text = dgvProduct.Rows[selectedIndex].Cells[0].Value.ToString();
            txtMaProduct.Enabled = false;
            txtNameProduct.Text = dgvProduct.Rows[selectedIndex].Cells[1].Value.ToString();
            txtPriceProduct.Text = dgvProduct.Rows[selectedIndex].Cells[2].Value.ToString();
            txtTrangThai.Text = dgvProduct.Rows[selectedIndex].Cells[3].Value.ToString();
            showChildPanel(pnlEditProduct, pnlToolProduct);
        }
        private void resetAlltext()
        {
            txtMaProduct.ResetText();
            txtNameProduct.ResetText();
            txtPriceProduct.ResetText();
            txtTrangThai.ResetText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetAlltext();
            showChildPanel(pnlProduct, pnlToolProduct);
            renderDgvHangHoa();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                if (txtNameProduct.Text == "" || txtPriceProduct.Text == "" || txtTrangThai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    string productID = txtMaProduct.Text.Trim();
                    string productName = txtNameProduct.Text.Trim();
                    string productPrice = txtPriceProduct.Text.Trim();
                    string productSL = txtTrangThai.Text.Trim();
                    string err = "";
                    string queryDel = "INSERT INTO Product VALUES(@id, @name, @price, @sl)";
                    if (DbLayer.ExecuteNonQuery(queryDel, CommandType.Text, ref err,
                        new SqlParameter("@id", productID),
                        new SqlParameter("@name", productName),
                        new SqlParameter("@price", productPrice),
                        new SqlParameter("@sl", productSL)) == true)
                    {
                        MessageBox.Show("Thêm thành công");
                        GetSoHangHoa();
                    }
                    else
                    {
                        MessageBox.Show("Loi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (them == false) //sửa
            {

                if (txtNameProduct.Text == "" || txtPriceProduct.Text == "" || txtTrangThai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    string productID = txtMaProduct.Text.Trim();
                    string productName = txtNameProduct.Text.Trim();
                    string productPrice = txtPriceProduct.Text.Trim();
                    string productSL = txtTrangThai.Text.Trim();
                    string err = "";
                    string queryDel = "UPDATE Product set name=@name, price=@price, soluong=@sl Where idP = @id";
                    if (DbLayer.ExecuteNonQuery(queryDel, CommandType.Text, ref err,
                        new SqlParameter("@name", productName),
                        new SqlParameter("@price", productPrice),
                        new SqlParameter("@sl", productSL),
                        new SqlParameter("@id", productID)) == true)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Loi: " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            resetAlltext();
            showChildPanel(pnlProduct, pnlToolProduct);
            renderDgvHangHoa();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            them = true;
            lblType.Text = "Thêm Hàng Hoá";
            txtMaProduct.Enabled = false;
            txtMaProduct.Text = MaSoHangHoa.ToString();
            showChildPanel(pnlEditProduct, pnlToolProduct);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string strTimKiem = txtTimKiem.Text.Trim();
            if (strTimKiem == "") renderDgvHangHoa();
            if(strTimKiem != "")
            {
                int selectedIndex = cbbTimKiem.SelectedIndex;
                if(selectedIndex == 0)
                {
                    DataTable reader = DbLayer.SelectWhere("Select *from Product Where idP = @idP", CommandType.Text, new SqlParameter("@idP", strTimKiem));
                    dgvProduct.DataSource = reader;
                    lblSoHangHoa.Text = ((DataTable)dgvProduct.DataSource).Rows.Count.ToString() + " Hang Hoa";

                }
                if (selectedIndex == 1) {
                    DataTable reader = DbLayer.ExecuteQuery("Select *from Product Where name LIKE '%" + strTimKiem +  "%'", CommandType.Text);
                    dgvProduct.DataSource = reader;
                    lblSoHangHoa.Text = ((DataTable)dgvProduct.DataSource).Rows.Count.ToString() + " Hang Hoa";
                }
            }
        }
    }
}
