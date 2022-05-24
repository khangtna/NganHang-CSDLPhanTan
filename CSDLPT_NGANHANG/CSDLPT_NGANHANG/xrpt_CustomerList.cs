using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CSDLPT_NGANHANG
{
    public partial class xrpt_CustomerList : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_CustomerList(string cn)
        {
            InitializeComponent();
            try
            {

                this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
                this.sqlDataSource1.Queries[0].Parameters[0].Value = cn;
                this.sqlDataSource1.Fill();
            }
            catch (Exception ex)
            {
                return;
            }
        }

    }
}
