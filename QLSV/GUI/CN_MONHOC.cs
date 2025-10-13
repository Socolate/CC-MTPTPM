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
    public partial class CN_MONHOC: Form
    {   MONHOCBUS MH= new MONHOCBUS();
        CHUYENNGANHBUS CH=new CHUYENNGANHBUS();
        KHOABUS KHOABUS = new KHOABUS();
        public CN_MONHOC()
        {
            InitializeComponent();
        }

        private void CN_MONHOC_Load(object sender, EventArgs e)
        {
            dgv_CN.DataSource = CH.getChuyenNganh();
            dgv_MH.DataSource = MH.getMonHoc();
            cmb_MH_CN.DataSource = CH.getChuyenNganh();
            cmb_MH_CN.DisplayMember = "Tên Chuyên Ngành";
            cmb_MH_CN.ValueMember = "Mã Chuyên Ngành";
            cmb_CN_KHOA.DataSource=KHOABUS.getKhoaAll();
            cmb_CN_KHOA.DisplayMember = "Tên Khoa";
            cmb_CN_KHOA.ValueMember = "Mã khoa";
        }

        private void rdb_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_addSV_Click(object sender, EventArgs e)
        {

        }

        private void btn_XoaSV_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaSV_Click(object sender, EventArgs e)
        {

        }

        private void dgv_QLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_CN_THEM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CN_MCN.Text) || string.IsNullOrEmpty(txt_CN_TENCN.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                CHUYENGANHDTO CN = new CHUYENGANHDTO()
                {
                    MACN = int.Parse(txt_CN_MCN.Text),
                    TenCN=txt_CN_TENCN.Text,
                    MAKHOA=(int)(cmb_CN_KHOA.SelectedValue),
                    
                };
                if (CH.themCN(CN))
                {
                    MessageBox.Show("Thêm Chuyên Ngành Thành công");
                    txt_CN_MCN.Clear();
                    txt_CN_TENCN.Clear();
                    dgv_CN.DataSource = CH.getChuyenNganh();
                }
                else
                {
                    MessageBox.Show("Thêm Chuyên ngành Thất Bại");
                }
            }

        }

        private void dgv_CN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_CN.Rows[e.RowIndex];
            txt_CN_MCN.Text=row.Cells[0].Value.ToString();
            txt_CN_TENCN.Text = row.Cells[1].Value.ToString();
            cmb_CN_KHOA.Text=row.Cells[2].Value.ToString();
        }

        private void btn_CN_XOA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CN_MCN.Text))
            {
                MessageBox.Show("vui long chọn chuyên ngành cần xóa");
            }
            else 
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Chuyên ngành này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CHUYENGANHDTO CN = new CHUYENGANHDTO()
                    {
                        MACN = int.Parse(txt_CN_MCN.Text)
                    };
                    if (CH.xoaCN(CN))
                    {
                        MessageBox.Show("Xóa Chuyên Ngành thành công");
                        dgv_CN.DataSource = CH.getChuyenNganh();
                        txt_CN_MCN.Clear();
                        txt_CN_TENCN.Clear();
                    }
                    else {
                        MessageBox.Show("Xóa chuyên ngành thất bại");
                    }
                }
            }
        }

        private void btn_CN_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CN_MCN.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành muốn sửa");
            }
            else 
            {
                CHUYENGANHDTO chuyenNganh = new CHUYENGANHDTO()
                {
                    MACN = int.Parse(txt_CN_MCN.Text),
                    TenCN = txt_CN_TENCN.Text,
                    MAKHOA = (int) cmb_CN_KHOA.SelectedValue
                };
                if (CH.suaCN(chuyenNganh))
                {
                    MessageBox.Show("Sửa chuyên ngành thành công");
                    dgv_CN.DataSource=CH.getChuyenNganh();
                    txt_CN_MCN.Clear() ;
                    txt_CN_TENCN.Clear() ;
                }   
                    
                else 
                {
                    MessageBox.Show("Sửa chuyên ngành thất bại");
                }
            }
        }

        private void dgv_MH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_MH.Rows[e.RowIndex];
            txt_MH_MMH.Text = row.Cells[0].Value.ToString();
            txt_MH_TENMH.Text = row.Cells[1].Value.ToString();
            txt_MH_HOCKY.Text = row.Cells[2].Value.ToString();
            txt_MH_TINCHI.Text = row.Cells[3].Value.ToString();
            cmb_MH_CN.Text = row.Cells[4].Value.ToString();
        }

        private void btn_addMH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MH_MMH.Text) || string.IsNullOrEmpty(txt_MH_TENMH.Text) || string.IsNullOrEmpty(txt_MH_TINCHI.Text) || string.IsNullOrEmpty(txt_MH_HOCKY.Text))
            {
                MessageBox.Show("Vui lòng thêm đầy đủ thông tin");

            }
            else
            {
                MONHOCDTO MHDTO = new MONHOCDTO()
                {
                    MaMH = int.Parse(txt_MH_MMH.Text),
                    TenMH = txt_MH_TENMH.Text,
                    TinChi = int.Parse(txt_MH_TINCHI.Text),
                    HocKy = int.Parse(txt_MH_HOCKY.Text),
                    ChuyenNganh = (int)cmb_MH_CN.SelectedValue
                };
                if (MH.themMonHoc(MHDTO))
                {
                    MessageBox.Show("Thêm môn học thành công");
                    dgv_MH.DataSource = MH.getMonHoc();
                    txt_MH_MMH.Clear();
                    txt_MH_TENMH.Clear();
                    txt_MH_TINCHI.Clear();
                    txt_MH_HOCKY.Clear();
                }
                else
                    MessageBox.Show("Thêm môn học thất bại");
            }
        }

        private void btn_SuaMH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MH_MMH.Text) || string.IsNullOrEmpty(txt_MH_TENMH.Text) || string.IsNullOrEmpty(txt_MH_TINCHI.Text) || string.IsNullOrEmpty(txt_MH_HOCKY.Text))
            {
                MessageBox.Show("Vui lòng chọn môn học muốn sửa");

            }
            else 
            {
                MONHOCDTO MHDTO = new MONHOCDTO()
                {
                    MaMH = int.Parse(txt_MH_MMH.Text),
                    TenMH = txt_MH_TENMH.Text,
                    TinChi = int.Parse(txt_MH_TINCHI.Text),
                    HocKy = int.Parse(txt_MH_HOCKY.Text),
                    ChuyenNganh = (int)cmb_MH_CN.SelectedValue
                };
                if (MH.suaMonHoc(MHDTO)) 
                {
                    MessageBox.Show("Sửa môn học thành công");
                    dgv_MH.DataSource = MH.getMonHoc();
                    txt_MH_MMH.Clear();
                    txt_MH_TENMH.Clear();
                    txt_MH_TINCHI.Clear();
                    txt_MH_HOCKY.Clear();
                }
                else
                {
                    MessageBox.Show("Sửa môn học thất bại");
                }
            }
        }

        private void btn_XoaMH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MH_MMH.Text))
            {
                MessageBox.Show("vui long chọn chuyên ngành cần xóa");
            }
            else
            {

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa Chuyên ngành này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MONHOCDTO MHDTO = new MONHOCDTO();
                    MHDTO.MaMH=int.Parse(txt_MH_MMH.Text);
                    if(MH.xoaMonHoc(MHDTO))
                    {
                        MessageBox.Show("Xóa môn học thành công ");
                        dgv_MH.DataSource = MH.getMonHoc();
                        txt_MH_MMH.Clear();
                        txt_MH_TENMH.Clear();
                        txt_MH_TINCHI.Clear();
                        txt_MH_HOCKY.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa môn học thất bại");
                    }
                }    

            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_CN_MCN.Clear();
            txt_CN_TENCN.Clear();
            cmb_CN_KHOA.SelectedIndex = 0;
        }

        private void btn_ResetMonHoc_Click(object sender, EventArgs e)
        {
            txt_MH_MMH.Clear();
            txt_MH_TENMH.Clear();
            txt_MH_TINCHI.Clear();
            txt_MH_HOCKY.Clear();
            cmb_MH_CN.SelectedIndex = 0;
        }
    }
}
