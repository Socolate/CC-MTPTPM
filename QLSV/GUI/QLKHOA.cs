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
    public partial class QLKHOA: Form
    {   KHOABUS KHOABUS = new KHOABUS();
        public QLKHOA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_BDMMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NDMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLKHOA_Load(object sender, EventArgs e)
        {
            dgv_Khoa.DataSource = KHOABUS.getKhoaAll();

        }

        private void dgv_Khoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgv_Khoa.Rows[e.RowIndex];
                txt_MaKhoa.Text = row.Cells[0].Value.ToString();
                txt_GmailKhoa.Text=row.Cells[2].Value.ToString();
                txt_TenKhoa.Text = row.Cells[1].Value.ToString() ;

            }
            
        }

        private void btn_addKhoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_MaKhoa.Text)||string.IsNullOrEmpty(txt_TenKhoa.Text)||string.IsNullOrEmpty(txt_GmailKhoa.Text))
            {
               MessageBox.Show("Vui lòng nhập đủ thông tin ");
            }
            else
            {
                KhoaDTO khoa = new KhoaDTO()
                {
                    MAKHOA = int.Parse(txt_MaKhoa.Text),
                    TenKhoa = txt_TenKhoa.Text,
                    GmailKhoa = txt_GmailKhoa.Text
                };
                if (KHOABUS.themKhoa(khoa))
                {
                    MessageBox.Show("Thêm Khoa thành công");
                    dgv_Khoa.DataSource = KHOABUS.getKhoaAll();
                }
                else
                {
                    MessageBox.Show("Thêm khoa thất bại");
                }
                txt_MaKhoa.Clear();
                txt_TenKhoa.Clear() ;
                txt_GmailKhoa .Clear() ;
            }
        }

        private void btn_SuaKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKhoa.Text) || string.IsNullOrEmpty(txt_TenKhoa.Text) || string.IsNullOrEmpty(txt_GmailKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn khoa muốn sửa ");
            }
            else
            {
                KhoaDTO Khoa = new KhoaDTO()
                {
                    MAKHOA = int.Parse(txt_MaKhoa.Text),
                    TenKhoa = txt_TenKhoa.Text,
                    GmailKhoa = txt_GmailKhoa.Text
                };

                if (KHOABUS.suaKhoa(Khoa))
                {
                    MessageBox.Show("Sửa thành công");
                    dgv_Khoa.DataSource = KHOABUS.getKhoaAll();
                }
                else
                {
                    MessageBox.Show("sửa không thành công");
                }
            }
        }

        private void btn_XoaKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn khoa muốn xóa !");
            }
            else 
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    KhoaDTO khoa = new KhoaDTO()
                    {
                        MAKHOA = int.Parse(txt_MaKhoa.Text),
                    };
                    if (KHOABUS.xoaKhoa(khoa))
                    {
                        MessageBox.Show("Xóa Khoa Thành Công !");
                        dgv_Khoa.DataSource = KHOABUS.getKhoaAll();
                        txt_MaKhoa.Clear();
                        txt_TenKhoa.Clear();
                        txt_GmailKhoa.Clear();
                    }
                    else 
                    {
                        MessageBox.Show("Xóa Khoa Thất Bại");
                    }
                   
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaKhoa.Text = string.Empty;
            txt_GmailKhoa.Text= string.Empty;
            txt_TenKhoa.Text=string.Empty;
        }
    }
}
