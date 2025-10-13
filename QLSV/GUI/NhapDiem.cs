using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.BUS;
using QLSV.DTO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace QLSV
{
    public partial class NhapDiem: Form
    {   NHAPDIEMBUS ND=new NHAPDIEMBUS();
        private void LoadExcelToDataGridView(string filePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            DataTable dt = new DataTable();

      
            for (int j = 1; j <= colCount; j++)
            {
                string columnName = xlRange.Cells[1, j].Value2?.ToString() ?? $"Column{j}";
                dt.Columns.Add(columnName);
            }

            
            for (int i = 2; i <= rowCount; i++)
            {
                DataRow row = dt.NewRow();
                for (int j = 1; j <= colCount; j++)
                {
                    row[j - 1] = xlRange.Cells[i, j].Value2?.ToString() ?? "";
                }
                dt.Rows.Add(row);
            }

            dgv_QLSV.DataSource = dt;

        
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
        public NhapDiem()
        {
            InitializeComponent();
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            dgv_QLSV.DataSource = ND.getNhapDiem();
        }

        private void btn_NhapDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ND_MSSV.Text) || string.IsNullOrEmpty(txt_BD_MMH.Text) || string.IsNullOrEmpty(txt_BD_DCC.Text) || string.IsNullOrEmpty(txt_BD_DKT.Text) || string.IsNullOrEmpty(txt_BD_DTHI.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                
            }
            else {
                NhapDiemDTO NDIEMDTO = new NhapDiemDTO()
                {
                    MASV = txt_ND_MSSV.Text,
                    MAMH = int.Parse(txt_BD_MMH.Text),
                    DIEMCC = float.Parse(txt_BD_DCC.Text),
                    DIEMTBK = float.Parse(txt_BD_DKT.Text),
                    DIEMTHI = float.Parse(txt_BD_DTHI.Text)
                };
                if (ND.NHAPDIEM(NDIEMDTO))
                {
                    MessageBox.Show("Nhập điểm thành công");
                    dgv_QLSV.DataSource = ND.getNhapDiem();
                    txt_ND_MSSV.Clear();
                    txt_BD_MMH.Clear();
                    txt_BD_DCC.Clear();
                    txt_BD_DKT.Clear();
                    txt_BD_DTHI.Clear();
                }
                else
                {
                    MessageBox.Show("Nhập điểm không thành công");
                }
            }
          
        }

        private void dgv_QLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row=dgv_QLSV.Rows[e.RowIndex];
            txt_ND_MSSV.Text=row.Cells[0].Value.ToString();
            txt_BD_MMH.Text = row.Cells[1].Value.ToString();
            txt_BD_DCC.Text=row.Cells[2].Value.ToString();
            txt_BD_DKT.Text=row.Cells[3].Value.ToString();
            txt_BD_DTHI.Text=row.Cells[4].Value.ToString();
        }

        private void btn_SuaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ND_MSSV.Text) || string.IsNullOrEmpty(txt_BD_MMH.Text) || string.IsNullOrEmpty(txt_BD_DCC.Text) || string.IsNullOrEmpty(txt_BD_DKT.Text) || string.IsNullOrEmpty(txt_BD_DTHI.Text))
            {
                NhapDiemDTO NDIEMDTO = new NhapDiemDTO();
                foreach (DataGridViewRow row in dgv_QLSV.Rows)
                {
                    if (row.IsNewRow) continue;


                    NDIEMDTO.MASV = row.Cells[0].Value.ToString().Substring(6) ;
                    NDIEMDTO.MAMH = int.Parse(row.Cells[1].Value.ToString() );
                    NDIEMDTO.DIEMCC = float.Parse(row.Cells[2].Value.ToString() );
                    NDIEMDTO.DIEMTBK = float.Parse(row.Cells[3].Value.ToString() );
                    NDIEMDTO.DIEMTHI = float.Parse(row.Cells[4].Value.ToString() );
                    
                    ND.suaDiem(NDIEMDTO);
                }
                dgv_QLSV.DataSource = ND.getNhapDiem();
            }
            else
            {
                string temp = txt_ND_MSSV.Text;
                NhapDiemDTO NDIEMDTO = new NhapDiemDTO()
                {
                    MASV = temp.Substring(6),
                    MAMH = int.Parse(txt_BD_MMH.Text),
                    DIEMCC = float.Parse(txt_BD_DCC.Text),
                    DIEMTBK = float.Parse(txt_BD_DKT.Text),
                    DIEMTHI = float.Parse(txt_BD_DTHI.Text)
                };
                if (ND.suaDiem(NDIEMDTO))
                {
                    MessageBox.Show("Sửa điểm thành công");
                    dgv_QLSV.DataSource = ND.getNhapDiem();
                    txt_ND_MSSV.Clear();
                    txt_BD_MMH.Clear();
                    txt_BD_DCC.Clear();
                    txt_BD_DKT.Clear();
                    txt_BD_DTHI.Clear();
                }
                else
                {
                    MessageBox.Show("Sửa điểm không thành công");
                }
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadExcelToDataGridView(ofd.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            NhapDiemDTO NDIEMDTO = new NhapDiemDTO();
            foreach (DataGridViewRow row in dgv_QLSV.Rows) {
               
                if (string.IsNullOrEmpty(row.Cells[0].Value.ToString())) break;
               
                int dai = row.Cells[0].Value.ToString().Length - 6;
                NDIEMDTO.MASV = row.Cells[0].Value.ToString().Substring(6,dai) ;
             
                NDIEMDTO.MAMH = int.Parse(row.Cells[1].Value.ToString()) ;
                NDIEMDTO.DIEMCC = float.Parse(row.Cells[2].Value.ToString());
                NDIEMDTO.DIEMTBK = float.Parse(row.Cells[3].Value.ToString());
                NDIEMDTO.DIEMTHI = float.Parse(row.Cells[4].Value.ToString() );
                
                ND.NHAPDIEM(NDIEMDTO);
            }
            dgv_QLSV.DataSource = ND.getNhapDiem();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_ND_MSSV.Text = string.Empty;
            txt_BD_DCC.Text = string.Empty;
            txt_BD_DKT.Text = string.Empty;
            txt_BD_DTHI.Text = string.Empty;
            txt_BD_MMH.Text = string.Empty;
            
        }
    }
}
