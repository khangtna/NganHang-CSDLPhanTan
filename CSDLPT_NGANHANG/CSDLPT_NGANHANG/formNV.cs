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
    public partial class formNV : Form
    {
        public formNV()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

       
        SqlCommand cmd = new SqlCommand();
        int pos = 0;
            
        String macn = "";


        private void formNV_Load(object sender, EventArgs e)
        {
            //btRes.Enabled = btNote.Enabled = false;

            dS.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);

            btNote.Enabled = btRes.Enabled = false;

            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";
            cbbChinhanh.SelectedIndex = Program.mChinhanh;
            if(Program.mGroup== "NGANHANG")
            {
                cbbChinhanh.Enabled = true;
                btAdd.Enabled = btDel.Enabled = btFix.Enabled = btNote.Enabled = btRes.Enabled = false;
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

        private void btAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            pos = bdsNV.Position;
            //pnTT.Enabled = true;
            bdsNV.AddNew();
            txtMACN.Text = macn;

            btAdd.Enabled = btDel.Enabled = btFix.Enabled = btExit.Enabled = btReload.Enabled = false;
            btNote.Enabled = btRes.Enabled = true;
            gcNV.Enabled = false;

            

        }


        private void btRes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsNV.CancelEdit();
            if (btAdd.Enabled == false) bdsNV.Position = pos;
            gcNV.Enabled = true;
            //pnTT.Enabled = false;

            btAdd.Enabled = btDel.Enabled = btFix.Enabled =btReload.Enabled=btExit.Enabled = true;
            btNote.Enabled = btRes.Enabled = false;

        }

        private void btDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Int32 manv = 0;

            if(bdsCT.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập chuyển tiền.");
                return;
            }
            if(bdsGR.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập gửi tiền.");
                return;
            }

            if(MessageBox.Show("Bạn muốn xóa nhân viên này?","Xác nhận", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                try
                {
                   string query = "DELETE FROM NhanVien WHERE MANV = @MANV";
                   Program.conn.Open();

                    //manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    //bdsNV.RemoveCurrent();
                    //this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.nhanVienTableAdapter.Update(this.dS.NhanVien);

                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);

                    cmd.ExecuteNonQuery();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                    MessageBox.Show("Xóa thành công.");
                    Program.conn.Close();

                }
                catch(Exception ex)
                {
                    Program.conn.Close();
                    //MessageBox.Show("Error: " + ex.Message);
                    //this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    //bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;

                }
            }

            if (bdsNV.Count == 0) btDel.Enabled = false;

        }

        private void btFix_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //pos = bdsNV.Position;
            //pnTT.Enabled = true;

            //btAdd.Enabled = btDel.Enabled = btFix.Enabled = btReload.Enabled = btExit.Enabled = false;
            //btNote.Enabled = btRes.Enabled = true;
            //gcNV.Enabled = false;


            if (txtMANV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                txtMANV.Focus();
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
            else if (cbTTX.Text == "")
            {
                MessageBox.Show("Trạng thái xóa không được để trống.");
                cbTTX.Focus();
                return;
            }

            string manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();

            if (txtMANV.Text != manv)
            {
                MessageBox.Show("Mã nhân viên không trùng.");
            }
            else
            {
                try
                {
                    string query = "UPDATE NhanVien SET  HO= @HO, TEN= @TEN, DIACHI=@DIACHI, PHAI=@PHAI, SODT= @SODT, MACN= @MACN, TrangThaiXoa=@TrangThaiXoa WHERE MANV=@MANV";

                    Program.conn.Open();
                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);
                    cmd.Parameters.AddWithValue("@HO", txtHO.Text);
                    cmd.Parameters.AddWithValue("@TEN", txtTEN.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                    cmd.Parameters.AddWithValue("@PHAI", txtPHAI.Text);
                    cmd.Parameters.AddWithValue("@SODT", txtSODT.Text);
                    cmd.Parameters.AddWithValue("@MACN", txtMACN.Text);
                    cmd.Parameters.AddWithValue("@TrangThaiXoa", cbTTX.Text);

                    cmd.ExecuteNonQuery();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

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

        private void btReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
        }

        private void btExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();

        }

        private void cbbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cbbChinhanh.SelectedValue.ToString();

            if(cbbChinhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;

            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if(Program.KetNoi()==0)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.dS.GD_CHUYENTIEN);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.dS.GD_GOIRUT);
            }

        }

        private void btNote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if (txtMANV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                txtMANV.Focus();
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
            else if (cbTTX.Text == "")
            {
                MessageBox.Show("Trạng thái xóa không được để trống.");
                cbTTX.Focus();
                return;
            }

            if (checkID() == true)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.");
            }
            else
            {
                try
                {



                    string query = "INSERT INTO NhanVien(MANV, HO, TEN, DIACHI, PHAI, SODT, MACN, TrangThaiXoa)" +
                        "VALUES(@MANV ,@HO, @TEN, @DIACHI, @PHAI, @SODT, @MACN, @TrangThaiXoa)";

                    Program.conn.Open();
                    cmd = new SqlCommand(query, Program.conn);
                    cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);
                    cmd.Parameters.AddWithValue("@HO", txtHO.Text);
                    cmd.Parameters.AddWithValue("@TEN", txtTEN.Text);
                    cmd.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                    cmd.Parameters.AddWithValue("@PHAI", txtPHAI.Text);
                    cmd.Parameters.AddWithValue("@SODT", txtSODT.Text);
                    cmd.Parameters.AddWithValue("@MACN", txtMACN.Text);
                    cmd.Parameters.AddWithValue("@TrangThaiXoa", cbTTX.Text);

                    cmd.ExecuteNonQuery();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                    MessageBox.Show("Thêm thành công.");
                    Program.conn.Close();

                    btAdd.Enabled = btDel.Enabled = btFix.Enabled = btReload.Enabled = btExit.Enabled = true;
                    btNote.Enabled = btRes.Enabled = false;
                    gcNV.Enabled = true;

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
