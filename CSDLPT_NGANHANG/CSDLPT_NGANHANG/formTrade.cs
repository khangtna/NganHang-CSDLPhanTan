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
    public partial class formTrade : Form
    {
        public formTrade()
        {
            InitializeComponent();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGR.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSm);

        }

        SqlCommand cmd = new SqlCommand();
        int pos = 0;
        DateTime dt = DateTime.Today;

        private void formTrade_Load(object sender, EventArgs e)
        {
            dSm.EnforceConstraints = false;

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dSm.GD_GOIRUT);

            btUdo.Enabled = btRut.Enabled = btGui.Enabled = false;

            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";
            cbbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG")
            {
                cbbChinhanh.Enabled = true;
                btAdd.Enabled = btGui.Enabled= btRut.Enabled=btUdo.Enabled = false;
                //pnTT.Enabled = false;
                txtSOTIEN.Enabled = txtSOTK.Enabled = false;
            }
            else
            {
                cbbChinhanh.Enabled = false;
            }

        }

        private bool checkSOTK()
        {
            SqlConnection conn = new SqlConnection(Program.connstr_pulisher);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE SOTK = @sotk", conn);
            cmd.Parameters.AddWithValue("@sotk", txtSOTK.Text);
            int UserExist = (int)cmd.ExecuteScalar();

            if (UserExist > 0)
            {
                conn.Close();
                return true;

            }
            conn.Close();
            return false;

        }

        private void lOAIGDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGui_Click(object sender, EventArgs e)
        {


        }

        private void btAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pos = bdsGR.Position;
            pnTT.Enabled = true;
            bdsGR.AddNew();
            dtNGAYGD.DateTime = dt;
            txtMANV.Text = Program.username;

            btAdd.Enabled = btDel.Enabled  = btExit.Enabled = btReload.Enabled = false;
            btGui.Enabled = btUdo.Enabled =btRut.Enabled = true;
            gcGR.Enabled = false;

        }

        private void btRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtLOAIGD.Text = "RT";

            if (txtSOTK.Text == "")
            {
                MessageBox.Show("Số tài khoản không được để trống.");
                txtSOTK.Focus();
                return;

            }
            else if (txtSOTIEN.Text == "")
            {
                MessageBox.Show("Số tiền không được để trống.");
                txtSOTIEN.Focus();
                return;

            }
            else if (txtLOAIGD.Text == "")
            {
                MessageBox.Show("Loại gd không được để trống.");
                txtLOAIGD.Focus();
                return;

            }

            if (checkSOTK() == false)
            {
                MessageBox.Show("Số tài khoản không tồn tại.");
                txtSOTK.Focus();
                return;
            }

            if ( System.Text.RegularExpressions.Regex.IsMatch(txtSOTIEN.Text, "[^0-9]"))
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

                    string query = "INSERT INTO GD_GOIRUT(SOTK, LOAIGD, NGAYGD, SOTIEN,MANV)" +
                        "VALUES(@SOTK, @LOAIGD, @NGAYGD, @SOTIEN, @MANV)";


                    Program.conn.Open();
                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@SOTK", txtSOTK.Text);
                    cmd.Parameters.AddWithValue("@LOAIGD", txtLOAIGD.Text);
                    cmd.Parameters.AddWithValue("@SOTIEN", txtSOTIEN.Text);
                    cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);
                    cmd.Parameters.AddWithValue("@NGAYGD", dtNGAYGD.DateTime);

                    cmd.ExecuteNonQuery();

                    string query1 = "EXEC SP_RUT @SOTK, @SOTIEN";
                    cmd = new SqlCommand(query1, Program.conn);
                    cmd.Parameters.AddWithValue("@SOTK", txtSOTK.Text);
                    cmd.Parameters.AddWithValue("@SOTIEN", txtSOTIEN.Text);

                    cmd.ExecuteNonQuery();

                    this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_GOIRUTTableAdapter.Fill(this.dSm.GD_GOIRUT);

                    MessageBox.Show("Rút tiền thành công.");
                    Program.conn.Close();

                    bdsGR.MoveLast();
                    gcGR.Enabled = true;
                    btAdd.Enabled = btDel.Enabled = btReload.Enabled = btExit.Enabled = true;
                    btGui.Enabled = btUdo.Enabled = btRut.Enabled = false;

                }
                catch (Exception ex)
                {
                    Program.conn.Close();
                    return;
                }
            }

        }

        private void btReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gD_GOIRUTTableAdapter.Fill(this.dSm.GD_GOIRUT);
        }

        private void btExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btUdo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGR.CancelEdit();
            if (btAdd.Enabled == false) bdsGR.Position = pos;
            gcGR.Enabled = true;
            //pnTT.Enabled = false;
            btAdd.Enabled = btDel.Enabled = btReload.Enabled = btExit.Enabled = true;
            btGui.Enabled=btRut.Enabled = btUdo.Enabled = false;
        }

        private void btGui_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtLOAIGD.Text = "GT";

            if (txtSOTK.Text == "")
            {
                MessageBox.Show("Số tài khoản không được để trống.");
                txtSOTK.Focus();
                return;

            }
            else if (txtSOTIEN.Text == "")
            {
                MessageBox.Show("Số tiền không được để trống.");
                txtSOTIEN.Focus();
                return;

            }

            if(checkSOTK()== false)
            {
                MessageBox.Show("Số tài khoản không tồn tại.");
                txtSOTK.Focus();
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

                    string query = "INSERT INTO GD_GOIRUT(SOTK, LOAIGD, NGAYGD, SOTIEN,MANV)" +
                        "VALUES(@SOTK, @LOAIGD, @NGAYGD, @SOTIEN, @MANV)";



                    Program.conn.Open();
                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@SOTK", txtSOTK.Text);
                    cmd.Parameters.AddWithValue("@LOAIGD", txtLOAIGD.Text);
                    cmd.Parameters.AddWithValue("@SOTIEN", txtSOTIEN.Text);
                    cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);
                    cmd.Parameters.AddWithValue("@NGAYGD", dtNGAYGD.DateTime);

                    cmd.ExecuteNonQuery();

                    string query1 = "EXEC SP_GUI @SOTK, @SOTIEN";
                    cmd = new SqlCommand(query1, Program.conn);
                    cmd.Parameters.AddWithValue("@SOTK", txtSOTK.Text);
                    cmd.Parameters.AddWithValue("@SOTIEN", txtSOTIEN.Text);

                    cmd.ExecuteNonQuery();

                    this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gD_GOIRUTTableAdapter.Fill(this.dSm.GD_GOIRUT);

                    MessageBox.Show("Gửi tiền thành công.");
                    Program.conn.Close();

                    bdsGR.MoveLast();
                    gcGR.Enabled = true;
                    btAdd.Enabled = btDel.Enabled = btReload.Enabled = btExit.Enabled = true;
                    btGui.Enabled = btUdo.Enabled = btRut.Enabled = false;

                }
                catch (Exception ex)
                {
                    Program.conn.Close();
                    return;
                }
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

            if (checkSOTK() == false)
            {
                MessageBox.Show("Số tài khoản không tồn tại.");
                txtSOTK.Focus();
                return;
            }
            else
            {

                try
                {
                    this.sP_CHECK_SODUTableAdapter.Fill(this.dSm.SP_CHECK_SODU, sotkToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void sotkToolStripTextBox_Click(object sender, EventArgs e)
        {

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
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dSm.GD_GOIRUT);
            }
        }
    }
}
