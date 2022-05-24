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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private SqlConnection conn_publisher = new SqlConnection();

        private int conn_SvPublisher()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open) conn_publisher.Close();

            try
            {
                conn_publisher.ConnectionString = Program.connstr_pulisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void getDSPM(String cmd)
        {

            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbbCN.DataSource = Program.bds_dspm;
            cbbCN.DisplayMember = "TENCN";
            cbbCN.ValueMember = "TENSERVER";


        }


        private void cbbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbbCN.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
            Program.frmChinh.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            if(txtUser.Text.Trim() == "" || txtPass.Text.Trim()== "")
            {
                MessageBox.Show("Username và Password không được trống!");
                return;
            }

            Program.mlogin = txtUser.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cbbCN.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            String cmd = "EXEC SP_Get_THONGTIN_Login '" + Program.mlogin + "' ";
            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
                return; 
            }
           

                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                Program.frmChinh.MANV.Text = "Mã NV: " + Program.username;
                Program.frmChinh.HOTEN.Text = "Họ và tên: " + Program.mHoten;
                Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
                Program.frmChinh.showMenu();

            
        }

        
        private void formLogin_Load(object sender, EventArgs e)
        {

            if (conn_SvPublisher() == 0) return;
            getDSPM("SELECT * FROM Get_subcribers");
            cbbCN.SelectedIndex = 1;
            cbbCN.SelectedIndex = 0;

        }
    }
}
