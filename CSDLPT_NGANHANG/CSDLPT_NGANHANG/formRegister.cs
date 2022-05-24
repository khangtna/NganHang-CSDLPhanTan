using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_NGANHANG
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        SqlCommand cmd = new SqlCommand();

        private void formRegister_Load(object sender, EventArgs e)
        {

            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";
            cbbChinhanh.SelectedIndex = Program.mChinhanh;
            
            cbbChinhanh.Enabled = false;

            txtRole.Text = Program.mGroup;
            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool checkID()
        {
            SqlConnection conn = new SqlConnection(Program.connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM NhanVien WHERE (MANV = @manv)", conn);
            cmd.Parameters.AddWithValue("@manv", txtMANV.Text);
            int UserExist = (int)cmd.ExecuteScalar();

            if (UserExist > 0)
            {
                conn.Close();
                return true;

            }
            conn.Close();
            return false;

        }

        private bool checkUsername()
        {
            SqlConnection conn = new SqlConnection(Program.connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM master.dbo.syslogins WHERE (name = @username)", conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            int UserExist = (int)cmd.ExecuteScalar();

            if (UserExist > 0)
            {
                conn.Close();
                return true;

            }
            conn.Close();
            return false;

        }

        private void btRegister_Click(object sender, EventArgs e)
        {

            

            if (txtMANV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                txtMANV.Focus();
                return;

            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username không được để trống.");
                txtUsername.Focus();
                return;

            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Tên không được để trống.");
                txtPass.Focus();
                return;

            }
            else if (txtConfirm.Text == "")
            {
                MessageBox.Show("Xác nhận password không được để trống.");
                txtConfirm.Focus();
                return;

            }

            if(txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("Xác nhận password không trùng với password.");
                txtConfirm.Focus();
                return;

            }
            if(checkID() == false)
            {
                MessageBox.Show("Mã nhân viên không tồn tại trong chi nhánh này.");
                txtMANV.Focus();
                return;
            }
            if (checkUsername()== true)
            {
                MessageBox.Show("Username đã tồn tại.");
                txtUsername.Focus();
                return;

            }

            string username = txtUsername.Text;
            string manv = txtMANV.Text;
            string pass = txtPass.Text;

            String query = "exec sp_Dangky '" + username + "', '" + pass + "', '" + manv + "', '" + Program.mGroup + "'";
            int check = Program.ExecSqlNonQuery(query, Program.connstr);

            if ( check== 0)
            {
 
                MessageBox.Show("Đăng ký thành công.");
                Program.conn.Close();

            }
            else
            {
                MessageBox.Show("Nhân viên này đã có tài khoản.");
                Program.conn.Close();
            }




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
