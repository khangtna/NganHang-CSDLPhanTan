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
    public partial class formTransfer : Form
    {
        public formTransfer()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSm);

        }

        SqlCommand cmd = new SqlCommand();
        int pos = 0;
        DateTime dt = DateTime.Today;


        private void formTransfer_Load(object sender, EventArgs e)
        {
            dSm.EnforceConstraints = false;

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dSm.GD_CHUYENTIEN);

            btUdo.Enabled = btCT.Enabled = false;

            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";
            cbbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG")
            {
                cbbChinhanh.Enabled = true;
                btCT.Enabled = false;
                pnTT.Enabled = false;
            }
            else
            {
                cbbChinhanh.Enabled = false;
            }


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_CHECK_SODUTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_CHECK_SODUTableAdapter.Fill(this.dSm.SP_CHECK_SODU, sotkToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private bool checkSOTKC()
        {
            SqlConnection conn = new SqlConnection(Program.connstr_pulisher);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE SOTK = @sotk", conn);
            cmd.Parameters.AddWithValue("@sotk", txtSOTKC.Text);
            int UserExist = (int)cmd.ExecuteScalar();

            if (UserExist > 0)
            {
                conn.Close();
                return true;

            }
            conn.Close();
            return false;

        }

        private bool checkSOTKN()
        {
            SqlConnection conn = new SqlConnection(Program.connstr_pulisher);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE SOTK = @sotk", conn);
            cmd.Parameters.AddWithValue("@sotk", txtSOTKN.Text);
            int UserExist = (int)cmd.ExecuteScalar();

            if (UserExist > 0)
            {
                conn.Close();
                return true;

            }
            conn.Close();
            return false;

        }

        private void cbbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cbbChinhanh.SelectedValue.ToString();

            if (cbbChinhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;

            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
            else
            {
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dSm.GD_CHUYENTIEN);
            }
        }

        private void ctExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCT_Click(object sender, EventArgs e)
        {

            if (txtSOTKC.Text == "")
            {
                MessageBox.Show("Số tài khoản chuyển không được để trống.");
                txtSOTKC.Focus();
                return;

            }
            else if (txtSOTIEN.Text == "")
            {
                MessageBox.Show("Số tiền không được để trống.");
                txtSOTIEN.Focus();
                return;

            }else if (txtSOTKN.Text == "")
            {
                MessageBox.Show("Số tài khoản nhận không được để trống.");
                txtSOTKN.Focus();
                return;
            }

            if (checkSOTKC() == false)
            {
                MessageBox.Show("Số tài khoản chuyển không tồn tại.");
                txtSOTKC.Focus();
                return;
            }
            if (checkSOTKN() == false)
            {
                MessageBox.Show("Số tài khoản nhận không tồn tại.");
                txtSOTKN.Focus();
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(txtSOTIEN.Text, "[^0-9]"))
            {

                MessageBox.Show("Số tiền không hợp lệ.");
                txtSOTIEN.Text = txtSOTIEN.Text.Remove(txtSOTIEN.Text.Length - 1);
            }
            else if (int.Parse(txtSOTIEN.Text) < 99999)
            {
                MessageBox.Show("Số tiền không được bé hơn 100.000 VND .");
                txtSOTIEN.Focus();
                return;
            }
            else
            {
                try
                {

                    string query = "INSERT INTO GD_CHUYENTIEN(SOTK_CHUYEN, NGAYGD, SOTIEN, SOTK_NHAN, MANV)" +
                        "VALUES(@SOTK_CHUYEN, @NGAYGD, @SOTIEN, @SOTK_NHAN, @MANV)";



                    Program.conn.Open();
                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@SOTK_CHUYEN", txtSOTKC.Text);
                    cmd.Parameters.AddWithValue("@SOTK_NHAN", txtSOTKN.Text);
                    cmd.Parameters.AddWithValue("@SOTIEN", txtSOTIEN.Text);
                    cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);
                    cmd.Parameters.AddWithValue("@NGAYGD", dtNGAYGD.DateTime);

                    cmd.ExecuteNonQuery();

                    string query1 = "EXEC SP_CHUYENTIEN @SOTKC, @SOTKN,@SOTIEN";
                    cmd = new SqlCommand(query1, Program.conn);
                    cmd.Parameters.AddWithValue("@SOTKC", txtSOTKC.Text);
                    cmd.Parameters.AddWithValue("@SOTKN", txtSOTKN.Text);
                    cmd.Parameters.AddWithValue("@SOTIEN", txtSOTIEN.Text);

                    cmd.ExecuteNonQuery();

                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_CHUYENTIENTableAdapter.Fill(this.dSm.GD_CHUYENTIEN);

                    bdsCT.MoveLast();
                    MessageBox.Show("Chuyển tiền thành công.");
                    Program.conn.Close();

                    btGD.Enabled = true;
                    btCT.Enabled= btUdo.Enabled = false;
                    gcCT.Enabled = true;

                }
                catch (Exception ex)
                {
                    Program.conn.Close();
                    return;
                }
            }

        }

        private void btGD_Click(object sender, EventArgs e)
        {
            pos = bdsCT.Position;
            //pnTT.Enabled = true;
            bdsCT.AddNew();
            txtMANV.Text = Program.username;
            dtNGAYGD.DateTime = dt;

            btGD.Enabled = false;
            btCT.Enabled= btUdo.Enabled = true;
            gcCT.Enabled = false;
        }

        private void btUdo_Click(object sender, EventArgs e)
        {
            bdsCT.CancelEdit();
            if (btGD.Enabled == false) bdsCT.Position = pos;

            gcCT.Enabled = true;
            btUdo.Enabled = btCT.Enabled = false;
            btGD.Enabled = true;

        }
    }
}
