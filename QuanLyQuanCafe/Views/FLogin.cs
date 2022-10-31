using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyQuanCafe
{   
    public partial class FLogin : Form
    {
        DbLayer dblayer;
        public FLogin()
        {
            InitializeComponent();
            dblayer = new DbLayer();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Thông báo", "Tài Khoản và mật không không được để trống",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlDataReader TaiKhoan = dblayer.SelectWhere1("Select *from Account Where username = @user",
                    CommandType.Text,
                    new SqlParameter("@user", txtUsername.Text.Trim())); ;
                if (TaiKhoan.HasRows)
                {
                    while(TaiKhoan.Read())
                    {
                        var password = TaiKhoan["password"].ToString();
                        if(password != txtPass.Text.Trim())
                        {
                            MessageBox.Show("Thông báo", "Mật khẩu không chính xác",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            var isAdmin = Convert.ToInt32(TaiKhoan["isAdmin"]);
                            if(isAdmin == 1)
                            {
                                fMain fdb = new fMain();
                                this.Hide();
                                fdb.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                fManager fdb = new fManager();
                                this.Hide();
                                fdb.ShowDialog();
                                this.Show();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thông báo", "Tài khoản không chinh xác",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Thông báo", "Bạn có thật sự muốn thoát? (Y/N)", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(tl != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
