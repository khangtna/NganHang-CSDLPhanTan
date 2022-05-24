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
    public partial class formpt_Statement : Form
    {
        public formpt_Statement()
        {
            InitializeComponent();
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            xrpt_Statement rpt = new xrpt_Statement(txtSOTK.Text, dtTN.DateTime , dtDN.DateTime);

            rpt.lbSOTK.Text = txtSOTK.Text;
            rpt.lbTUNGAY.Text = dtTN.DateTime.ToString();
            rpt.lbDENNGAY.Text = dtDN.DateTime.ToString();
            rpt.lbHOTENNV.Text = Program.mHoten;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
