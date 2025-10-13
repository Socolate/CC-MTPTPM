namespace QLSV
{
    partial class txt_MaMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.XemDiem_TheoSinhVien = new System.Windows.Forms.TabPage();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_XemDiem_MaMon = new System.Windows.Forms.TextBox();
            this.txt_XemDiem_SinhVien = new System.Windows.Forms.TextBox();
            this.btn_XemDiemTheoSinhVien = new System.Windows.Forms.Button();
            this.dgv_XemDiemTheoSinhVien = new System.Windows.Forms.DataGridView();
            this.XemDiem_TheoLop = new System.Windows.Forms.TabPage();
            this.btn_xuatfile_Lop = new System.Windows.Forms.Button();
            this.btn_Reset_Lop = new System.Windows.Forms.Button();
            this.btn_SinhVienRot = new System.Windows.Forms.Button();
            this.btn_SinhVienDau = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaMon = new System.Windows.Forms.TextBox();
            this.btn_XemDiem_TheoLop = new System.Windows.Forms.Button();
            this.cmb_XemDiemTheoLop = new System.Windows.Forms.ComboBox();
            this.dgv_XemDiemTheoLop = new System.Windows.Forms.DataGridView();
            this.tb_XemDiem = new System.Windows.Forms.TabControl();
            this.btn_export_sv = new System.Windows.Forms.Button();
            this.XemDiem_TheoSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDiemTheoSinhVien)).BeginInit();
            this.XemDiem_TheoLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDiemTheoLop)).BeginInit();
            this.tb_XemDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // XemDiem_TheoSinhVien
            // 
            this.XemDiem_TheoSinhVien.Controls.Add(this.btn_export_sv);
            this.XemDiem_TheoSinhVien.Controls.Add(this.btn_Reset);
            this.XemDiem_TheoSinhVien.Controls.Add(this.label2);
            this.XemDiem_TheoSinhVien.Controls.Add(this.label1);
            this.XemDiem_TheoSinhVien.Controls.Add(this.txt_XemDiem_MaMon);
            this.XemDiem_TheoSinhVien.Controls.Add(this.txt_XemDiem_SinhVien);
            this.XemDiem_TheoSinhVien.Controls.Add(this.btn_XemDiemTheoSinhVien);
            this.XemDiem_TheoSinhVien.Controls.Add(this.dgv_XemDiemTheoSinhVien);
            this.XemDiem_TheoSinhVien.Location = new System.Drawing.Point(4, 25);
            this.XemDiem_TheoSinhVien.Name = "XemDiem_TheoSinhVien";
            this.XemDiem_TheoSinhVien.Size = new System.Drawing.Size(1172, 504);
            this.XemDiem_TheoSinhVien.TabIndex = 2;
            this.XemDiem_TheoSinhVien.Text = "Theo Sinh Viên";
            this.XemDiem_TheoSinhVien.UseVisualStyleBackColor = true;
            this.XemDiem_TheoSinhVien.Click += new System.EventHandler(this.XemDiem_TheoSinhVien_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(797, 76);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(102, 37);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Môn Học :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Sinh Viên : ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_XemDiem_MaMon
            // 
            this.txt_XemDiem_MaMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_XemDiem_MaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XemDiem_MaMon.Location = new System.Drawing.Point(264, 74);
            this.txt_XemDiem_MaMon.Name = "txt_XemDiem_MaMon";
            this.txt_XemDiem_MaMon.Size = new System.Drawing.Size(527, 38);
            this.txt_XemDiem_MaMon.TabIndex = 7;
            this.txt_XemDiem_MaMon.TextChanged += new System.EventHandler(this.txt_XemDiem_MaMon_TextChanged);
            // 
            // txt_XemDiem_SinhVien
            // 
            this.txt_XemDiem_SinhVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_XemDiem_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XemDiem_SinhVien.Location = new System.Drawing.Point(264, 19);
            this.txt_XemDiem_SinhVien.Name = "txt_XemDiem_SinhVien";
            this.txt_XemDiem_SinhVien.Size = new System.Drawing.Size(527, 38);
            this.txt_XemDiem_SinhVien.TabIndex = 5;
            this.txt_XemDiem_SinhVien.TextChanged += new System.EventHandler(this.txt_XemDiem_SinhVien_TextChanged);
            this.txt_XemDiem_SinhVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_XemDiem_SinhVien_KeyPress);
            // 
            // btn_XemDiemTheoSinhVien
            // 
            this.btn_XemDiemTheoSinhVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XemDiemTheoSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDiemTheoSinhVien.Location = new System.Drawing.Point(797, 21);
            this.btn_XemDiemTheoSinhVien.Name = "btn_XemDiemTheoSinhVien";
            this.btn_XemDiemTheoSinhVien.Size = new System.Drawing.Size(102, 37);
            this.btn_XemDiemTheoSinhVien.TabIndex = 6;
            this.btn_XemDiemTheoSinhVien.Text = "Xem";
            this.btn_XemDiemTheoSinhVien.UseVisualStyleBackColor = true;
            this.btn_XemDiemTheoSinhVien.Click += new System.EventHandler(this.btn_XemDiemTheoSinhVien_Click);
            // 
            // dgv_XemDiemTheoSinhVien
            // 
            this.dgv_XemDiemTheoSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_XemDiemTheoSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_XemDiemTheoSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemDiemTheoSinhVien.Location = new System.Drawing.Point(6, 118);
            this.dgv_XemDiemTheoSinhVien.Name = "dgv_XemDiemTheoSinhVien";
            this.dgv_XemDiemTheoSinhVien.ReadOnly = true;
            this.dgv_XemDiemTheoSinhVien.RowHeadersWidth = 51;
            this.dgv_XemDiemTheoSinhVien.RowTemplate.Height = 24;
            this.dgv_XemDiemTheoSinhVien.Size = new System.Drawing.Size(1160, 383);
            this.dgv_XemDiemTheoSinhVien.TabIndex = 4;
            // 
            // XemDiem_TheoLop
            // 
            this.XemDiem_TheoLop.Controls.Add(this.btn_xuatfile_Lop);
            this.XemDiem_TheoLop.Controls.Add(this.btn_Reset_Lop);
            this.XemDiem_TheoLop.Controls.Add(this.btn_SinhVienRot);
            this.XemDiem_TheoLop.Controls.Add(this.btn_SinhVienDau);
            this.XemDiem_TheoLop.Controls.Add(this.label4);
            this.XemDiem_TheoLop.Controls.Add(this.label3);
            this.XemDiem_TheoLop.Controls.Add(this.txt_MaMon);
            this.XemDiem_TheoLop.Controls.Add(this.btn_XemDiem_TheoLop);
            this.XemDiem_TheoLop.Controls.Add(this.cmb_XemDiemTheoLop);
            this.XemDiem_TheoLop.Controls.Add(this.dgv_XemDiemTheoLop);
            this.XemDiem_TheoLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemDiem_TheoLop.Location = new System.Drawing.Point(4, 25);
            this.XemDiem_TheoLop.Name = "XemDiem_TheoLop";
            this.XemDiem_TheoLop.Padding = new System.Windows.Forms.Padding(3);
            this.XemDiem_TheoLop.Size = new System.Drawing.Size(1172, 504);
            this.XemDiem_TheoLop.TabIndex = 0;
            this.XemDiem_TheoLop.Text = "Theo Lớp";
            this.XemDiem_TheoLop.UseVisualStyleBackColor = true;
            this.XemDiem_TheoLop.Click += new System.EventHandler(this.XemDiem_TheoLop_Click);
            // 
            // btn_xuatfile_Lop
            // 
            this.btn_xuatfile_Lop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xuatfile_Lop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatfile_Lop.Location = new System.Drawing.Point(1060, 41);
            this.btn_xuatfile_Lop.Name = "btn_xuatfile_Lop";
            this.btn_xuatfile_Lop.Size = new System.Drawing.Size(86, 47);
            this.btn_xuatfile_Lop.TabIndex = 16;
            this.btn_xuatfile_Lop.Text = "export";
            this.btn_xuatfile_Lop.UseVisualStyleBackColor = true;
            this.btn_xuatfile_Lop.Click += new System.EventHandler(this.btn_xuatfile_Lop_Click);
            // 
            // btn_Reset_Lop
            // 
            this.btn_Reset_Lop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Reset_Lop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset_Lop.Location = new System.Drawing.Point(928, 75);
            this.btn_Reset_Lop.Name = "btn_Reset_Lop";
            this.btn_Reset_Lop.Size = new System.Drawing.Size(106, 51);
            this.btn_Reset_Lop.TabIndex = 15;
            this.btn_Reset_Lop.Text = "Reset";
            this.btn_Reset_Lop.UseVisualStyleBackColor = true;
            this.btn_Reset_Lop.Click += new System.EventHandler(this.btn_Reset_Lop_Click);
            // 
            // btn_SinhVienRot
            // 
            this.btn_SinhVienRot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SinhVienRot.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinhVienRot.Location = new System.Drawing.Point(813, 78);
            this.btn_SinhVienRot.Name = "btn_SinhVienRot";
            this.btn_SinhVienRot.Size = new System.Drawing.Size(109, 53);
            this.btn_SinhVienRot.TabIndex = 14;
            this.btn_SinhVienRot.Text = "Sinh Viên Rớt";
            this.btn_SinhVienRot.UseVisualStyleBackColor = true;
            this.btn_SinhVienRot.Click += new System.EventHandler(this.btn_SinhVienRot_Click);
            // 
            // btn_SinhVienDau
            // 
            this.btn_SinhVienDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SinhVienDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinhVienDau.Location = new System.Drawing.Point(813, 15);
            this.btn_SinhVienDau.Name = "btn_SinhVienDau";
            this.btn_SinhVienDau.Size = new System.Drawing.Size(109, 57);
            this.btn_SinhVienDau.TabIndex = 13;
            this.btn_SinhVienDau.Text = "Sinh Viên Đậu";
            this.btn_SinhVienDau.UseVisualStyleBackColor = true;
            this.btn_SinhVienDau.Click += new System.EventHandler(this.btn_SinhVienDau_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên Lớp :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã Môn Học :";
            // 
            // txt_MaMon
            // 
            this.txt_MaMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMon.Location = new System.Drawing.Point(336, 93);
            this.txt_MaMon.Name = "txt_MaMon";
            this.txt_MaMon.Size = new System.Drawing.Size(436, 38);
            this.txt_MaMon.TabIndex = 10;
            this.txt_MaMon.TextChanged += new System.EventHandler(this.txt_MaMon_TextChanged);
            // 
            // btn_XemDiem_TheoLop
            // 
            this.btn_XemDiem_TheoLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XemDiem_TheoLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDiem_TheoLop.Location = new System.Drawing.Point(928, 15);
            this.btn_XemDiem_TheoLop.Name = "btn_XemDiem_TheoLop";
            this.btn_XemDiem_TheoLop.Size = new System.Drawing.Size(106, 51);
            this.btn_XemDiem_TheoLop.TabIndex = 6;
            this.btn_XemDiem_TheoLop.Text = "Xem Điểm";
            this.btn_XemDiem_TheoLop.UseVisualStyleBackColor = true;
            this.btn_XemDiem_TheoLop.Click += new System.EventHandler(this.btn_XemDiem_Click);
            // 
            // cmb_XemDiemTheoLop
            // 
            this.cmb_XemDiemTheoLop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_XemDiemTheoLop.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_XemDiemTheoLop.FormattingEnabled = true;
            this.cmb_XemDiemTheoLop.Location = new System.Drawing.Point(337, 41);
            this.cmb_XemDiemTheoLop.Name = "cmb_XemDiemTheoLop";
            this.cmb_XemDiemTheoLop.Size = new System.Drawing.Size(429, 39);
            this.cmb_XemDiemTheoLop.TabIndex = 3;
            // 
            // dgv_XemDiemTheoLop
            // 
            this.dgv_XemDiemTheoLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_XemDiemTheoLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_XemDiemTheoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemDiemTheoLop.Location = new System.Drawing.Point(6, 148);
            this.dgv_XemDiemTheoLop.Name = "dgv_XemDiemTheoLop";
            this.dgv_XemDiemTheoLop.ReadOnly = true;
            this.dgv_XemDiemTheoLop.RowHeadersWidth = 51;
            this.dgv_XemDiemTheoLop.RowTemplate.Height = 24;
            this.dgv_XemDiemTheoLop.Size = new System.Drawing.Size(1160, 350);
            this.dgv_XemDiemTheoLop.TabIndex = 2;
            // 
            // tb_XemDiem
            // 
            this.tb_XemDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_XemDiem.Controls.Add(this.XemDiem_TheoLop);
            this.tb_XemDiem.Controls.Add(this.XemDiem_TheoSinhVien);
            this.tb_XemDiem.Location = new System.Drawing.Point(12, 12);
            this.tb_XemDiem.Name = "tb_XemDiem";
            this.tb_XemDiem.SelectedIndex = 0;
            this.tb_XemDiem.Size = new System.Drawing.Size(1180, 533);
            this.tb_XemDiem.TabIndex = 0;
            // 
            // btn_export_sv
            // 
            this.btn_export_sv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_export_sv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export_sv.Location = new System.Drawing.Point(942, 42);
            this.btn_export_sv.Name = "btn_export_sv";
            this.btn_export_sv.Size = new System.Drawing.Size(86, 47);
            this.btn_export_sv.TabIndex = 17;
            this.btn_export_sv.Text = "export";
            this.btn_export_sv.UseVisualStyleBackColor = true;
            this.btn_export_sv.Click += new System.EventHandler(this.btn_export_sv_Click);
            // 
            // txt_MaMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 571);
            this.Controls.Add(this.tb_XemDiem);
            this.Name = "txt_MaMonHoc";
            this.Text = "XemDiem";
            this.Load += new System.EventHandler(this.XemDiem_Load);
            this.XemDiem_TheoSinhVien.ResumeLayout(false);
            this.XemDiem_TheoSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDiemTheoSinhVien)).EndInit();
            this.XemDiem_TheoLop.ResumeLayout(false);
            this.XemDiem_TheoLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemDiemTheoLop)).EndInit();
            this.tb_XemDiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage XemDiem_TheoSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_XemDiem_MaMon;
        private System.Windows.Forms.TextBox txt_XemDiem_SinhVien;
        private System.Windows.Forms.Button btn_XemDiemTheoSinhVien;
        private System.Windows.Forms.DataGridView dgv_XemDiemTheoSinhVien;
        private System.Windows.Forms.TabPage XemDiem_TheoLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaMon;
        private System.Windows.Forms.Button btn_XemDiem_TheoLop;
        private System.Windows.Forms.ComboBox cmb_XemDiemTheoLop;
        private System.Windows.Forms.DataGridView dgv_XemDiemTheoLop;
        private System.Windows.Forms.TabControl tb_XemDiem;
        private System.Windows.Forms.Button btn_SinhVienRot;
        private System.Windows.Forms.Button btn_SinhVienDau;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Reset_Lop;
        private System.Windows.Forms.Button btn_xuatfile_Lop;
        private System.Windows.Forms.Button btn_export_sv;
    }
}