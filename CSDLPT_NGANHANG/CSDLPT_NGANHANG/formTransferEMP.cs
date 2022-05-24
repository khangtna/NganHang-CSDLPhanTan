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
    public partial class formTransferEMP : Form
    {
        public formTransferEMP()
        {
            InitializeComponent();
        }

        private void chiNhanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSm);

        }

        SqlConnection conn1 = new SqlConnection(Program.connstr_pulisher);
        SqlCommand cmd = new SqlCommand();

        private void formTransferEMP_Load(object sender, EventArgs e)
        {
            
            dSm.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dSm.NhanVien);

            this.chiNhanhTableAdapter.Connection.ConnectionString = Program.connstr_pulisher;
            this.chiNhanhTableAdapter.Fill(this.dSm.ChiNhanh);

            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";
            cbbChinhanh.SelectedIndex = Program.mChinhanh;

            cbbMACN.DataSource = bdsCN;
            cbbMACN.DisplayMember = "MACN";
            cbbMACN.ValueMember = "MACN";

        }

        private void btExit_Click(object sender, EventArgs e)
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dSm.NhanVien);

            }
        }



        private void btConfirm_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn muốn chuyển chi nhánh nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    string query = "UPDATE NhanVien SET  MACN= @MACN WHERE MANV=@MANV";

                    conn1.Open();
                    cmd = new SqlCommand(query, conn1);
                    cmd.Parameters.AddWithValue("@MANV", txtMANV.Text);
                    cmd.Parameters.AddWithValue("@MACN", cbbMACN.SelectedValue);


                    cmd.ExecuteNonQuery();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dSm.NhanVien);

                    MessageBox.Show("Chuyển công tác thành công.");
                    conn1.Close();

                }
                catch (Exception ex)
                {
                    conn1.Close();
                    return;
                }
            }
        }

    }
}
