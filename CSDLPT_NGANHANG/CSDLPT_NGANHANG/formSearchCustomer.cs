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
    public partial class formSearchCustomer : Form
    {
        public formSearchCustomer()
        {
            InitializeComponent();
        }

        private void formSearchCustomer_Load(object sender, EventArgs e)
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_FindCustomerTableAdapter.Fill(this.dSm.sp_FindCustomer, cmndToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
