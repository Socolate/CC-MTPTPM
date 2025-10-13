using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.BUS;
using QLSV.DTO;

namespace QLSV
{
    public partial class Search: Form
    {
        CHUYENNGANHBUS CNBUS =new CHUYENNGANHBUS();
        XEMTHONGTINBUS TTSV=new XEMTHONGTINBUS();
        LOPBUS LHBUS = new LOPBUS();
        public Search()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_AllSV_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_AllSV.Checked)
            {
                dgv_search.DataSource = TTSV.layDSTTSV();
            }
            else
            {
                dgv_search.DataSource=TTSV.layDSTTSV();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dgv_search.DataSource= TTSV.layDSTTSV();
            cmb_CN.DataSource = CNBUS.getChuyenNganh();
            cmb_CN.DisplayMember = "Tên Chuyên Ngành";
            cmb_CN.ValueMember = "Mã Chuyên Ngành";
            cmb_LOP.DataSource = LHBUS.laydsslop();
            cmb_LOP.DisplayMember = "Tên Lớp";
            cmb_LOP.ValueMember = "Mã lớp";
        }

        private void cmb_CN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdb_SVCN.Checked)
            {
                dgv_search.DataSource=TTSV.searchCN(cmb_CN.Text);
            }    
        }

        private void cmb_LOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdb_SVLOP.Checked)
            {
                dgv_search.DataSource=TTSV.searchLOP(cmb_LOP.Text);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(rdb_MSSV.Checked)
            {
                string temp=txt_MSSV.Text;
                dgv_search.DataSource = TTSV.searchMSSV(temp.Substring(6));
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txt_MSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MSSV_Click(object sender, EventArgs e)
        {
            rdb_MSSV.Checked = true;
        }
    }
}
