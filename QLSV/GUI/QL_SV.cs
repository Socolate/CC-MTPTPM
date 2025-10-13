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
using QLSV.DAO;
using QLSV.DTO;

namespace QLSV
{
    public partial class QL_SV : Form
    {
        SINHVIENBUS SVBUS = new SINHVIENBUS();
        LOPBUS LOPBUS= new LOPBUS();
        public QL_SV()
        {
            InitializeComponent();
        }

        private void QL_SV_Load(object sender, EventArgs e)
        {
            dgv_QLSV.DataSource = SVBUS.layDSSSV();
           
            
            cmb_LOP.DataSource = LOPBUS.laydsslop();
            cmb_LOP.DisplayMember = "Tên Lớp";
            cmb_LOP.ValueMember = "Mã lớp";


        }

        private void rdb_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_addSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_HoTenSV.Text) || string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_Gmail.Text))
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                SinhVienDTO svDTO = new SinhVienDTO()
                {
                    SDT = txt_SDT.Text,
                    HoTen = txt_HoTenSV.Text,
                    NgaySinh = DateTime.Parse(dtp_NGAYSINH.Value.ToString("yyyy-MM-dd")),
                    GioiTinh = rdb_Nam.Checked ? true : false,
                    DiaChi = txt_DiaChi.Text,
                    malop = (int)(cmb_LOP.SelectedValue),
                    gmail = txt_Gmail.Text,

                };


                if (SVBUS.ThemSV(svDTO))
                {
                    MessageBox.Show("thêm thành công");
                    dgv_QLSV.DataSource = SVBUS.layDSSSV();
                }

                else MessageBox.Show("thêm Thất bại");
               
                txt_MSSV.Text = "";
                txt_HoTenSV.Text = "";
                txt_SDT.Text = "";
                txt_Gmail.Text = "";
                txt_DiaChi.Text = "";
                dtp_NGAYSINH.Value = DateTime.Now;
                rdb_Nam.Checked = true;
            }

        }

        private void dgv_QLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_QLSV.Rows[e.RowIndex];
                txt_MSSV.Text = row.Cells[0].Value.ToString();
                txt_HoTenSV.Text = row.Cells[1].Value.ToString();
                dtp_NGAYSINH.Text = row.Cells[2].Value.ToString();

                if (row.Cells[3].Value.ToString() == "Nam")
                    rdb_Nam.Checked = true;
                else
                    rdb_Nu.Checked = true;
                txt_DiaChi.Text = row.Cells[5].Value.ToString();
                cmb_LOP.Text = row.Cells[6].Value.ToString();
                txt_Gmail.Text = row.Cells[7].Value.ToString();
                txt_SDT.Text = row.Cells[4].Value.ToString();

            }
            
        }

        private void btn_SuaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_HoTenSV.Text) || string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_Gmail.Text))
            {
                MessageBox.Show("vui lòng Sinh viên muốn sửa thông tin");
            }
            else
            {
                string temp = txt_MSSV.Text;
               
                SinhVienDTO svDTO = new SinhVienDTO()
                {   
                    mssv = int.Parse(temp.Substring(6)),
                    SDT = txt_SDT.Text,
                    HoTen = txt_HoTenSV.Text,
                    NgaySinh = DateTime.Parse(dtp_NGAYSINH.Value.ToString("yyyy-MM-dd")),
                    GioiTinh = rdb_Nam.Checked ? true : false,
                    DiaChi = txt_DiaChi.Text,
                    malop = (int)(cmb_LOP.SelectedValue),
                    gmail = txt_Gmail.Text,

                };
                if (SVBUS.SuaSV(svDTO))
                { MessageBox.Show("Sửa Thông tin thành công");
                    dgv_QLSV.DataSource = SVBUS.layDSSSV();
                 }    
                    
                else
                    MessageBox.Show("Sửa Thông tin thất bại");

                
                txt_MSSV.Text = "";
                txt_HoTenSV.Text = "";
                txt_SDT.Text = "";
                txt_Gmail.Text = "";
                txt_DiaChi.Text = "";
                dtp_NGAYSINH.Value = DateTime.Now;
                rdb_Nam.Checked = true;

            }
        }

        private void btn_XoaSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_MSSV.Text))
                    MessageBox.Show("Vui long chọn sinh viên muốn xoa ");
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string temp = txt_MSSV.Text;
                        SinhVienDTO svDTO = new SinhVienDTO() { mssv = int.Parse(temp.Substring(6)) };
                        if (SVBUS.XoaSV(svDTO))
                        {
                            MessageBox.Show("xóa Sinh viên thành công");
                            dgv_QLSV.DataSource = SVBUS.layDSSSV();
                        }
                        else
                        {
                            MessageBox.Show("xóa Sinh viên thất bại");

                            txt_MSSV.Text = "";
                            txt_HoTenSV.Text = "";
                            txt_SDT.Text = "";
                            txt_Gmail.Text = "";
                            txt_DiaChi.Text = "";
                            dtp_NGAYSINH.Value = DateTime.Now;
                            rdb_Nam.Checked = true;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("vui lòng xóa hết thông tin của sinh viên");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MSSV.Text = string.Empty;
            txt_HoTenSV.Text= string.Empty;
            txt_DiaChi.Text= string.Empty;
            txt_Gmail.Text= string.Empty;
            txt_SDT.Text=string.Empty;
            cmb_LOP.SelectedIndex = 0;
            rdb_Nam.Checked= true;
            dtp_NGAYSINH.Text= DateTime.Today.ToString();
        }
    }
}
