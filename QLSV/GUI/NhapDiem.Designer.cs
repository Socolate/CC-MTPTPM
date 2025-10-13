namespace QLSV
{
    partial class NhapDiem
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
            this.dgv_QLSV = new System.Windows.Forms.DataGridView();
            this.btn_SuaSV = new System.Windows.Forms.Button();
            this.btn_NhapDiem = new System.Windows.Forms.Button();
            this.txt_BD_DTHI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BD_DKT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BD_DCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BD_MMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ND_MSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QLSV
            // 
            this.dgv_QLSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_QLSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLSV.Location = new System.Drawing.Point(12, 236);
            this.dgv_QLSV.Name = "dgv_QLSV";
            this.dgv_QLSV.ReadOnly = true;
            this.dgv_QLSV.RowHeadersWidth = 51;
            this.dgv_QLSV.RowTemplate.Height = 24;
            this.dgv_QLSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLSV.Size = new System.Drawing.Size(1136, 271);
            this.dgv_QLSV.TabIndex = 17;
            this.dgv_QLSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLSV_CellContentClick);
            // 
            // btn_SuaSV
            // 
            this.btn_SuaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SuaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaSV.Location = new System.Drawing.Point(328, 150);
            this.btn_SuaSV.Name = "btn_SuaSV";
            this.btn_SuaSV.Size = new System.Drawing.Size(138, 70);
            this.btn_SuaSV.TabIndex = 42;
            this.btn_SuaSV.Text = "Sửa Điểm";
            this.btn_SuaSV.UseVisualStyleBackColor = true;
            this.btn_SuaSV.Click += new System.EventHandler(this.btn_SuaSV_Click);
            // 
            // btn_NhapDiem
            // 
            this.btn_NhapDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NhapDiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapDiem.Location = new System.Drawing.Point(162, 150);
            this.btn_NhapDiem.Name = "btn_NhapDiem";
            this.btn_NhapDiem.Size = new System.Drawing.Size(138, 70);
            this.btn_NhapDiem.TabIndex = 41;
            this.btn_NhapDiem.Text = "Nhập Điểm";
            this.btn_NhapDiem.UseVisualStyleBackColor = true;
            this.btn_NhapDiem.Click += new System.EventHandler(this.btn_NhapDiem_Click);
            // 
            // txt_BD_DTHI
            // 
            this.txt_BD_DTHI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_BD_DTHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BD_DTHI.Location = new System.Drawing.Point(729, 73);
            this.txt_BD_DTHI.Name = "txt_BD_DTHI";
            this.txt_BD_DTHI.Size = new System.Drawing.Size(290, 30);
            this.txt_BD_DTHI.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 39;
            this.label5.Text = "Điểm Thi : \r\n";
            // 
            // txt_BD_DKT
            // 
            this.txt_BD_DKT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_BD_DKT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BD_DKT.Location = new System.Drawing.Point(729, 24);
            this.txt_BD_DKT.Name = "txt_BD_DKT";
            this.txt_BD_DKT.Size = new System.Drawing.Size(290, 30);
            this.txt_BD_DKT.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Điểm TB Kiểm Tra : ";
            // 
            // txt_BD_DCC
            // 
            this.txt_BD_DCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_BD_DCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BD_DCC.Location = new System.Drawing.Point(729, 117);
            this.txt_BD_DCC.Name = "txt_BD_DCC";
            this.txt_BD_DCC.Size = new System.Drawing.Size(292, 30);
            this.txt_BD_DCC.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Điểm Chuyên Cần : ";
            // 
            // txt_BD_MMH
            // 
            this.txt_BD_MMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_BD_MMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BD_MMH.Location = new System.Drawing.Point(292, 85);
            this.txt_BD_MMH.Name = "txt_BD_MMH";
            this.txt_BD_MMH.Size = new System.Drawing.Size(191, 30);
            this.txt_BD_MMH.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã Môn Học : ";
            // 
            // txt_ND_MSSV
            // 
            this.txt_ND_MSSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ND_MSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ND_MSSV.Location = new System.Drawing.Point(292, 44);
            this.txt_ND_MSSV.Name = "txt_ND_MSSV";
            this.txt_ND_MSSV.Size = new System.Drawing.Size(191, 30);
            this.txt_ND_MSSV.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã Sinh Viên :";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_OpenFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFile.Location = new System.Drawing.Point(490, 150);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(138, 70);
            this.btn_OpenFile.TabIndex = 43;
            this.btn_OpenFile.Text = "Open file";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(649, 152);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(137, 67);
            this.btn_save.TabIndex = 44;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(808, 152);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(137, 67);
            this.btn_Reset.TabIndex = 45;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 519);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_SuaSV);
            this.Controls.Add(this.btn_NhapDiem);
            this.Controls.Add(this.txt_BD_DTHI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_BD_DKT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_BD_DCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_BD_MMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ND_MSSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_QLSV);
            this.Name = "NhapDiem";
            this.Text = "NhapDiem";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QLSV;
        private System.Windows.Forms.Button btn_SuaSV;
        private System.Windows.Forms.Button btn_NhapDiem;
        private System.Windows.Forms.TextBox txt_BD_DTHI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_BD_DKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BD_DCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BD_MMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ND_MSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Reset;
    }
}