using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT_NGANHANG
{
    public partial class formpt_AccountList : Form
    {
        public formpt_AccountList()
        {
            InitializeComponent();
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            xrpt_AccountList rpt = new xrpt_AccountList( dtTN.DateTime, dtDN.DateTime);

            rpt.lbTN.Text = dtTN.DateTime.ToString();
            rpt.lbDN.Text = dtDN.DateTime.ToString();
            rpt.lbNV.Text = Program.mHoten;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }

        private void formpt_AccountList_Load(object sender, EventArgs e)
        {
            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";
            cbbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG")
            {
                cbbChinhanh.Enabled = true;
            }
            else
            {
                cbbChinhanh.Enabled = false;
            }
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
        }
    }
}
