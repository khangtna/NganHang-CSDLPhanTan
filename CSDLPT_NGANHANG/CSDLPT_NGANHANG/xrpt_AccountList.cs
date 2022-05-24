using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CSDLPT_NGANHANG
{
    public partial class xrpt_AccountList : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_AccountList(DateTime tungay, DateTime denngay)
        {
            InitializeComponent();
            try
            {

                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = tungay;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = denngay;
                this.sqlDataSource1.Fill();
            }
            catch (Exception ex)
            {
                return;
            }
        }

    }
}
