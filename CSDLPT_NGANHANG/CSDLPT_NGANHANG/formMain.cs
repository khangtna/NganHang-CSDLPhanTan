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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        


        public void showMenu()
        {
            MessageBox.Show("Đăng nhập thành công.");

            btCr.Enabled = true;

            if (Program.mGroup == "NGANHANG")
            {
                ribHT.Visible = ribDM.Visible = rbNV.Visible = true;
                rbTK.Visible = true;

            }
            else
            {
                ribHT.Visible = ribDM.Visible = rbNV.Visible = true;
                rbTK.Visible = true;
                btCNV1.Enabled = false;
            }
            

        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                Form frm = this.CheckExists(typeof(formNV));
                if (frm != null) frm.Activate();
                else
                {
                    formNV f = new formNV();
                    f.MdiParent = this;
                    f.Show();
                }
            
        }

        private void btLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formLogin));
            if (frm != null) frm.Activate();
            else
            {
                formLogin f = new formLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formCustomer));
            if (frm != null) frm.Activate();
            else
            {
                formCustomer f = new formCustomer();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btTTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formAccount));
            if (frm != null) frm.Activate();
            else
            {
                formAccount f = new formAccount();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btGR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTrade));
            if (frm != null) frm.Activate();
            else
            {
                formTrade f = new formTrade();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btTrade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTransfer));
            if (frm != null) frm.Activate();
            else
            {
                formTransfer f = new formTransfer();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            btCr.Enabled = false;
        }

        private void btCCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btCNV1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTransferEMP));
            if (frm != null) frm.Activate();
            else
            {
                formTransferEMP f = new formTransferEMP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btSK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formpt_Statement));
            if (frm != null) frm.Activate();
            else
            {
                formpt_Statement f = new formpt_Statement();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btLKTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formpt_AccountList));
            if (frm != null) frm.Activate();
            else
            {
                formpt_AccountList f = new formpt_AccountList();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btLKKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formpt_CustomerList));
            if (frm != null) frm.Activate();
            else
            {
                formpt_CustomerList f = new formpt_CustomerList();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btTCNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formSearchEMP));
            if (frm != null) frm.Activate();
            else
            {
                formSearchEMP f = new formSearchEMP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btTCKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formSearchCustomer));
            if (frm != null) frm.Activate();
            else
            {
                formSearchCustomer f = new formSearchCustomer();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btCr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formRegister));
            if (frm != null) frm.Activate();
            else
            {
                formRegister f = new formRegister();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
