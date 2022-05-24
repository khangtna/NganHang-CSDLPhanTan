using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CSDLPT_NGANHANG
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_pulisher = "Data Source=ROCKET;Initial Catalog=NGANHANG;User ID=sa;Password=sa";

        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String servername1 = "ROCKET\\MSSQLSERVER01";
        public static String servername2 = "ROCKET\\MSSQLSERVER02";
        public static String database = "NGANHANG";
        public static String username="";
        public static String password="";
        public static String mlogin="";
        public static String mGroup="";
        public static String mHoten="";
        public static int mChinhanh = 0;

        public static String remotelogin = "HTKN";
        public static String remotepassword = "htkn";

        public static String mloginDN = "";
        public static String passwordDN = "";

        public static BindingSource bds_dspm = new BindingSource();
        public static formMain frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        //public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        //{
        //    SqlDataReader myreader; 

        //    SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
        //    sqlcmd.CommandType = CommandType.Text;

        //    if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
        //    try
        //    {
        //        myreader = sqlcmd.ExecuteReader(); return myreader;
        //    }
        //    catch (SqlException ex)
        //    {
        //        Program.conn.Close();
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //}

        public static SqlDataReader ExecSqlDataReader(string cmd)
        {
            SqlDataReader myreader;

            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt1 = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            conn.Close();
            return dt1;

        }


        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {

            SqlCommand Sqlcmd = new SqlCommand(cmd, Program.conn);

            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 0;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                conn.Close();
                //return 0;
                return ex.State;
            }
        }
        //public static void SetEnableOfButton(Form frm, Boolean Active)
        //{

        //    foreach (Control ctl in frm.Controls)
        //        if ((ctl) is Button)
        //            ctl.Enabled = Active;
        //}



/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmChinh = new formMain();
            Application.Run(frmChinh);

            //Application.Run(new formLogin());
        }
    }
}
