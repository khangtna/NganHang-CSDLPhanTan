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
    public partial class formCustomer : Form
    {
        public formCustomer()
        {
            InitializeComponent();
        }

        

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSm);

        }

        SqlCommand cmd = new SqlCommand();
        int pos = 0;
        DateTime dt = DateTime.Today;
        String macn = "";


        private void formCustomer_Load(object sender, EventArgs e)
        {
            dSm.EnforceConstraints = false;

            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dSm.KhachHang);

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.dSm.TaiKhoan);

            btUdo.Enabled = btSave.Enabled = false;

            macn = ((DataRowView)bdsKH[0])["MACN"].ToString();
            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";
            cbbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG")
            {
                cbbChinhanh.Enabled = true;
                btAdd.Enabled = btDel.Enabled = btFix.Enabled  = btRes.Enabled = false;
                pnTT.Enabled = false;
            }
            else
            {
                cbbChinhanh.Enabled = false;
            }

        }


        private bool checkID()
        {
            SqlConnection conn = new SqlConnection(Program.connstr_pulisher);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM KhachHang WHERE (CMND = @cmnd)", conn);
            cmd.Parameters.AddWithValue("@cmnd", txtCMND.Text);
            int UserExist = (int)cmd.ExecuteScalar();

            if (UserExist > 0)
            {
                conn.Close();
                return true;

            }
            conn.Close();
            return false;

        }
        private void btAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            pos = bdsKH.Position;
            bdsKH.AddNew();
            txtMACN.Text = macn;
            dtNGAY.DateTime = dt;

            btAdd.Enabled = btDel.Enabled = btFix.Enabled = btReload.Enabled = btExit.Enabled = false;
            btUdo.Enabled = btSave.Enabled = true;
            gcKH.Enabled = false;

        }

        private void khachHangBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btFix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCMND.Text == "")
            {
                MessageBox.Show("CMND không được để trống.");
                txtCMND.Focus();
                return;

            }
            else if (txtHO.Text == "")
            {
                MessageBox.Show("Họ không được để trống.");
                txtHO.Focus();
                return;

            }
            else if (txtTEN.Text == "")
            {
                MessageBox.Show("Tên không được để trống.");
                txtTEN.Focus();
                return;

            }
            else if (txtDIACHI.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống.");
                txtDIACHI.Focus();
                return;

            }
            else if (txtPHAI.Text == "")
            {
                MessageBox.Show("Phái không được để trống.");
                txtPHAI.Focus();
                return;

            }
            else if (txtSODT.Text == "")
            {
                MessageBox.Show("Số điện thoại không dc để trống.");
                txtSODT.Focus();
                return;

            }
            else if (txtMACN.Text == "")
            {
                MessageBox.Show("Mã chi nhánh không được để trống.");
                txtMACN.Focus();
                return;

            }
            else if (dtNGAY.Text == "")
            {
                MessageBox.Show("Ngày cấp không được để trống.");
                dtNGAY.Focus();
                return;
            }

            string manv = ((DataRowView)bdsKH[bdsKH.Position])["CMND"].ToString();

            if (txtCMND.Text != manv)
            {
                MessageBox.Show("CMND không trùng với thông tin cần sửa.");
            }
            else
            {
                try
                {
                    string query = "UPDATE KhachHang SET  HO= @HO, TEN= @TEN, DIACHI=@DIACHI, PHAI=@PHAI, SODT= @SODT, NGAYCAP=@NGAYCAP ,MACN= @MACN WHERE CMND=@CMND";

                    Program.conn.Open();
                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);
                    cmd.Parameters.AddWithValue("@HO", txtHO.Text);
                    cmd.Parameters.AddWithValue("@TEN", txtTEN.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                    cmd.Parameters.AddWithValue("@PHAI", txtPHAI.Text);
                    cmd.Parameters.AddWithValue("@SODT", txtSODT.Text);
                    cmd.Parameters.AddWithValue("@MACN", txtMACN.Text);
                    cmd.Parameters.AddWithValue("@NGAYCAP", dtNGAY.DateTime);

                    cmd.ExecuteNonQuery();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Fill(this.dSm.KhachHang);

                    MessageBox.Show("Sửa thành công.");
                    Program.conn.Close();

                }
                catch (Exception ex)
                {
                    Program.conn.Close();
                    return;
                }
            }
        }

        private void btDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if(bdsTK.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đã mở tài khoản.");
                return;
            }

            if(MessageBox.Show("Bạn muốn xóa khách hàng này?","Xác nhận", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                try
                {
                   string query = "DELETE FROM KhachHang WHERE CMND = @CMND";
                   Program.conn.Open();

                    

                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@CMND", txtCMND.Text);

                    cmd.ExecuteNonQuery();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Fill(this.dSm.KhachHang);

                            MessageBox.Show("Xóa thành công.");
                    Program.conn.Close();

                }
                catch(Exception ex)
                {
                    Program.conn.Close();
                    return;

                }
            }

            if (bdsKH.Count == 0) btDel.Enabled = false;
      
        }

        private void btReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.khachHangTableAdapter.Fill(this.dSm.KhachHang);
        }

        private void btExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
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
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.dSm.KhachHang);

                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.dSm.TaiKhoan);
            }
        }

        private void btSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCMND.Text == "")
            {
                MessageBox.Show("CMND không được để trống.");
                txtCMND.Focus();
                return;

            }
            else if (txtHO.Text == "")
            {
                MessageBox.Show("Họ không được để trống.");
                txtHO.Focus();
                return;

            }
            else if (txtTEN.Text == "")
            {
                MessageBox.Show("Tên không được để trống.");
                txtTEN.Focus();
                return;

            }
            else if (txtDIACHI.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống.");
                txtDIACHI.Focus();
                return;

            }
            else if (txtPHAI.Text == "")
            {
                MessageBox.Show("Phái không được để trống.");
                txtPHAI.Focus();
                return;

            }
            else if (txtSODT.Text == "")
            {
                MessageBox.Show("Số điện thoại không dc để trống.");
                txtSODT.Focus();
                return;

            }
            else if (txtMACN.Text == "")
            {
                MessageBox.Show("Mã chi nhánh không được để trống.");
                txtMACN.Focus();
                return;

            }
            else if (dtNGAY.Text == "")
            {
                MessageBox.Show("Ngày cấp không được để trống.");
                dtNGAY.Focus();
                return;
            }

            if (checkID() == true)
            {
                MessageBox.Show("CMND đã tồn tại.");
            }
            else
            {
                try
                {

                    string query = "INSERT INTO KhachHang(CMND, HO, TEN, DIACHI, PHAI, SODT, NGAYCAP, MACN)" +
                        "VALUES(@MANV ,@HO, @TEN, @DIACHI, @PHAI, @SODT, @NGAYCAP,@MACN)";

                    Program.conn.Open();
                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@MANV", txtCMND.Text);
                    cmd.Parameters.AddWithValue("@HO", txtHO.Text);
                    cmd.Parameters.AddWithValue("@TEN", txtTEN.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                    cmd.Parameters.AddWithValue("@PHAI", txtPHAI.Text);
                    cmd.Parameters.AddWithValue("@SODT", txtSODT.Text);
                    cmd.Parameters.AddWithValue("@MACN", txtMACN.Text);
                    cmd.Parameters.AddWithValue("@NGAYCAP", dtNGAY.DateTime);

                    cmd.ExecuteNonQuery();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Fill(this.dSm.KhachHang);

                    bdsKH.MoveLast();
                    MessageBox.Show("Thêm thành công.");
                    Program.conn.Close();

                    btAdd.Enabled = btDel.Enabled = btFix.Enabled = btReload.Enabled = btExit.Enabled = true;
                    btUdo.Enabled = btSave.Enabled = false;
                    gcKH.Enabled = true;

                }
                catch (Exception ex)
                {
                    Program.conn.Close();
                    return;
                }
            }
        }
    }
}
