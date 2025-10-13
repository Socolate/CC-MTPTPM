using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class QLSV: Form
    {
        public QLSV()
        {
            InitializeComponent();
        }
        private Form Formchild;
        private void openForm(Form childform)
        {
            if (Formchild != null)
            {
                Formchild.Close();
            }
            Formchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pl_body.Controls.Add(childform);
            pl_body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void QLSV_Load(object sender, EventArgs e)
        {

        }

        private void btn_QLSV_Click(object sender, EventArgs e)
        {
            openForm(new QL_SV());
            label1.Text=btn_QLSV.Text;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            openForm(new Search());
            label1.Text=btn_search.Text;
        }

        private void btn_NhapDIem_Click(object sender, EventArgs e)
        {
            openForm(new NhapDiem());
            label1.Text=btn_NhapDIem.Text;
        }

        private void btn_QLKHOA_Click(object sender, EventArgs e)
        {
            openForm(new QLKHOA());
            label1.Text = btn_QLKHOA.Text;
        }

        private void btn_QLMONHOC_Click(object sender, EventArgs e)
        {
            openForm(new CN_MONHOC());
            label1.Text=btn_QLCNMONHOC.Text;
        }

        private void ptb_logo_Click(object sender, EventArgs e)
        {
            if (Formchild != null)
            {
                Formchild.Close();
            }
            label1.Text = "Home";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pl_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_XEMDIEM_Click(object sender, EventArgs e)
        {
            openForm(new txt_MaMonHoc());
            label1.Text=btn_XEMDIEM.Text;
        }
    }
}
