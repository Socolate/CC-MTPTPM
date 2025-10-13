using QLSV.BUS;
using QLSV.DAO;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLSV
{
    public partial class txt_MaMonHoc: Form
    {
        LOPBUS lop=new LOPBUS();
        XemDiemBUS xdbus=new XemDiemBUS();
       
        NHAPDIEMBUS nd=new NHAPDIEMBUS();
        public txt_MaMonHoc()
        {
            InitializeComponent();
        }

        private void ExportToExcel(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.Title = "Chọn nơi lưu file Excel";
            sfd.FileName = "DuLieu.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Exported from DGV";

                
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

              
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        object value = dgv.Rows[i].Cells[j].Value;
                        if (value != null)
                        {
                            
                            worksheet.Cells[i + 2, j + 1] = "'" + value.ToString();
                        }
                    }
                }

                
                workbook.SaveAs(sfd.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void XemDiem_TheoLop_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void XemDiem_TheoSinhVien_Click(object sender, EventArgs e)
        {  
        }

        private void btn_XemDiem_Click(object sender, EventArgs e)
        {
            dgv_XemDiemTheoLop.DataSource = xdbus.xemDiemTheoLop(cmb_XemDiemTheoLop.Text, int.Parse(txt_MaMon.Text));
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            cmb_XemDiemTheoLop.DataSource = lop.laydsslop();
            cmb_XemDiemTheoLop.DisplayMember = "Tên lớp";
            dgv_XemDiemTheoLop.DataSource = xdbus.getDiem();
            dgv_XemDiemTheoSinhVien.DataSource = nd.getDiem();
        }

        private void btn_XemDiemTheoSinhVien_Click(object sender, EventArgs e)
        {
            string temp = txt_XemDiem_SinhVien.Text;
            if (string.IsNullOrEmpty(txt_XemDiem_MaMon.Text))
            {
                dgv_XemDiemTheoSinhVien.DataSource = xdbus.xemDiemTheoSV_ChuaNhapMaMonHoc(temp.Substring(6));
            }
            else
            {
                dgv_XemDiemTheoSinhVien.DataSource = xdbus.xemDiemTheoSV(temp.Substring(6), int.Parse(txt_XemDiem_MaMon.Text));
            }
        }

        private void btn_SinhVienDau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaMon.Text))
            {
                dgv_XemDiemTheoLop.DataSource = xdbus.getSinhVienDau_KhiChuaNhapMaMonHoc(cmb_XemDiemTheoLop.Text);
            }
            else
            {
                dgv_XemDiemTheoLop.DataSource = xdbus.getSinhVienDau(cmb_XemDiemTheoLop.Text, int.Parse(txt_MaMon.Text));
            }
        }

        private void btn_SinhVienRot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaMon.Text))
            {
                dgv_XemDiemTheoLop.DataSource = xdbus.getSinhVienRot_KhiChuaNhapMaMonHoc(cmb_XemDiemTheoLop.Text);
            }
            else
            {
                dgv_XemDiemTheoLop.DataSource = xdbus.getSinhVienRot(cmb_XemDiemTheoLop.Text, int.Parse(txt_MaMon.Text));
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            txt_XemDiem_MaMon.Clear();
            txt_XemDiem_SinhVien.Clear();
            dgv_XemDiemTheoSinhVien.DataSource = nd.getDiem();
        }

        private void txt_XemDiem_SinhVien_TextChanged(object sender, EventArgs e)
        {
            DataTable a= nd.getDiem();
            string text=txt_XemDiem_SinhVien.Text;
            if (string.IsNullOrEmpty(text))
            {
                dgv_XemDiemTheoSinhVien.DataSource = a;
            }
            else
            {
                string textExpression = $"[Mã sinh viên] LIKE '%{text}%'";
                a.DefaultView.RowFilter = textExpression ;
            }
               dgv_XemDiemTheoSinhVien.DataSource= a;
        }
        
        private void txt_XemDiem_SinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void txt_XemDiem_MaMon_TextChanged(object sender, EventArgs e)
        {
            //DataTable a = nd.getDiem();
            //string text = txt_MaMon.Text;
            //if (string.IsNullOrEmpty(text))
            //{
            //    dgv_XemDiemTheoLop.DataSource = a;
            //}
            //else
            //{
            //    string textExpression = $"[Mã môn học] LIKE '%{text}%'";
            //    a.DefaultView.RowFilter = textExpression;
            //}
            //dgv_XemDiemTheoLop.DataSource = a;
        }

        private void txt_MaMon_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Reset_Lop_Click(object sender, EventArgs e)
        {
            txt_MaMon.Clear();
            dgv_XemDiemTheoLop.DataSource=xdbus.getDiem();
        }

        private void btn_xuatfile_Lop_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_XemDiemTheoLop); 
        }

        private void btn_export_sv_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_XemDiemTheoSinhVien);
        }
    }
}
