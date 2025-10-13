namespace QLSV
{
    partial class CN_MONHOC
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_CN_XOA = new System.Windows.Forms.Button();
            this.btn_CN_SUA = new System.Windows.Forms.Button();
            this.btn_CN_THEM = new System.Windows.Forms.Button();
            this.cmb_CN_KHOA = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CN_TENCN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CN_MCN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_CN = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_MH_CN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MH_TENMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_XoaMH = new System.Windows.Forms.Button();
            this.btn_SuaMH = new System.Windows.Forms.Button();
            this.btn_addMH = new System.Windows.Forms.Button();
            this.txt_MH_HOCKY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MH_TINCHI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MH_MMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_MH = new System.Windows.Forms.DataGridView();
            this.btn_ResetChuyenNghanh = new System.Windows.Forms.Button();
            this.btn_ResetMonHoc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CN)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MH)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 663);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ResetChuyenNghanh);
            this.tabPage1.Controls.Add(this.btn_CN_XOA);
            this.tabPage1.Controls.Add(this.btn_CN_SUA);
            this.tabPage1.Controls.Add(this.btn_CN_THEM);
            this.tabPage1.Controls.Add(this.cmb_CN_KHOA);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_CN_TENCN);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_CN_MCN);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dgv_CN);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1219, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chuyên Ngành";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_CN_XOA
            // 
            this.btn_CN_XOA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CN_XOA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CN_XOA.Location = new System.Drawing.Point(729, 140);
            this.btn_CN_XOA.Name = "btn_CN_XOA";
            this.btn_CN_XOA.Size = new System.Drawing.Size(138, 49);
            this.btn_CN_XOA.TabIndex = 67;
            this.btn_CN_XOA.Text = "Xóa Chuyên Ngành";
            this.btn_CN_XOA.UseVisualStyleBackColor = true;
            this.btn_CN_XOA.Click += new System.EventHandler(this.btn_CN_XOA_Click);
            // 
            // btn_CN_SUA
            // 
            this.btn_CN_SUA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CN_SUA.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CN_SUA.Location = new System.Drawing.Point(729, 85);
            this.btn_CN_SUA.Name = "btn_CN_SUA";
            this.btn_CN_SUA.Size = new System.Drawing.Size(138, 49);
            this.btn_CN_SUA.TabIndex = 66;
            this.btn_CN_SUA.Text = "Sửa Chuyên Ngành";
            this.btn_CN_SUA.UseVisualStyleBackColor = true;
            this.btn_CN_SUA.Click += new System.EventHandler(this.btn_CN_SUA_Click);
            // 
            // btn_CN_THEM
            // 
            this.btn_CN_THEM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CN_THEM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CN_THEM.Location = new System.Drawing.Point(729, 30);
            this.btn_CN_THEM.Name = "btn_CN_THEM";
            this.btn_CN_THEM.Size = new System.Drawing.Size(138, 49);
            this.btn_CN_THEM.TabIndex = 65;
            this.btn_CN_THEM.Text = "Thêm Chuyên Ngành";
            this.btn_CN_THEM.UseVisualStyleBackColor = true;
            this.btn_CN_THEM.Click += new System.EventHandler(this.btn_CN_THEM_Click);
            // 
            // cmb_CN_KHOA
            // 
            this.cmb_CN_KHOA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_CN_KHOA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CN_KHOA.FormattingEnabled = true;
            this.cmb_CN_KHOA.Location = new System.Drawing.Point(347, 148);
            this.cmb_CN_KHOA.Name = "cmb_CN_KHOA";
            this.cmb_CN_KHOA.Size = new System.Drawing.Size(243, 30);
            this.cmb_CN_KHOA.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 63;
            this.label8.Text = "Khoa :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_CN_TENCN
            // 
            this.txt_CN_TENCN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CN_TENCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CN_TENCN.Location = new System.Drawing.Point(347, 101);
            this.txt_CN_TENCN.Name = "txt_CN_TENCN";
            this.txt_CN_TENCN.Size = new System.Drawing.Size(243, 30);
            this.txt_CN_TENCN.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 22);
            this.label6.TabIndex = 61;
            this.label6.Text = "Tên Chuyên Ngành  : ";
            // 
            // txt_CN_MCN
            // 
            this.txt_CN_MCN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CN_MCN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CN_MCN.Location = new System.Drawing.Point(347, 58);
            this.txt_CN_MCN.Name = "txt_CN_MCN";
            this.txt_CN_MCN.Size = new System.Drawing.Size(243, 30);
            this.txt_CN_MCN.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 22);
            this.label7.TabIndex = 59;
            this.label7.Text = "Mã Chuyên Ngành :";
            // 
            // dgv_CN
            // 
            this.dgv_CN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CN.Location = new System.Drawing.Point(9, 272);
            this.dgv_CN.Name = "dgv_CN";
            this.dgv_CN.ReadOnly = true;
            this.dgv_CN.RowHeadersWidth = 51;
            this.dgv_CN.RowTemplate.Height = 24;
            this.dgv_CN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CN.Size = new System.Drawing.Size(1203, 353);
            this.dgv_CN.TabIndex = 48;
            this.dgv_CN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CN_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ResetMonHoc);
            this.tabPage2.Controls.Add(this.cmb_MH_CN);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_MH_TENMH);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_XoaMH);
            this.tabPage2.Controls.Add(this.btn_SuaMH);
            this.tabPage2.Controls.Add(this.btn_addMH);
            this.tabPage2.Controls.Add(this.txt_MH_HOCKY);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_MH_TINCHI);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_MH_MMH);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgv_MH);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1219, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Môn Học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_MH_CN
            // 
            this.cmb_MH_CN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_MH_CN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_MH_CN.FormattingEnabled = true;
            this.cmb_MH_CN.Location = new System.Drawing.Point(291, 213);
            this.cmb_MH_CN.Name = "cmb_MH_CN";
            this.cmb_MH_CN.Size = new System.Drawing.Size(243, 30);
            this.cmb_MH_CN.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Chuyên Ngành :";
            // 
            // txt_MH_TENMH
            // 
            this.txt_MH_TENMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MH_TENMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MH_TENMH.Location = new System.Drawing.Point(291, 104);
            this.txt_MH_TENMH.Name = "txt_MH_TENMH";
            this.txt_MH_TENMH.Size = new System.Drawing.Size(243, 30);
            this.txt_MH_TENMH.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tên Môn Học : ";
            // 
            // btn_XoaMH
            // 
            this.btn_XoaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XoaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaMH.Location = new System.Drawing.Point(775, 158);
            this.btn_XoaMH.Name = "btn_XoaMH";
            this.btn_XoaMH.Size = new System.Drawing.Size(138, 49);
            this.btn_XoaMH.TabIndex = 56;
            this.btn_XoaMH.Text = "Xóa Môn Học";
            this.btn_XoaMH.UseVisualStyleBackColor = true;
            this.btn_XoaMH.Click += new System.EventHandler(this.btn_XoaMH_Click);
            // 
            // btn_SuaMH
            // 
            this.btn_SuaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SuaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaMH.Location = new System.Drawing.Point(775, 103);
            this.btn_SuaMH.Name = "btn_SuaMH";
            this.btn_SuaMH.Size = new System.Drawing.Size(138, 49);
            this.btn_SuaMH.TabIndex = 55;
            this.btn_SuaMH.Text = "Sửa Môn Học";
            this.btn_SuaMH.UseVisualStyleBackColor = true;
            this.btn_SuaMH.Click += new System.EventHandler(this.btn_SuaMH_Click);
            // 
            // btn_addMH
            // 
            this.btn_addMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMH.Location = new System.Drawing.Point(775, 48);
            this.btn_addMH.Name = "btn_addMH";
            this.btn_addMH.Size = new System.Drawing.Size(138, 49);
            this.btn_addMH.TabIndex = 54;
            this.btn_addMH.Text = "Thêm Môn Học";
            this.btn_addMH.UseVisualStyleBackColor = true;
            this.btn_addMH.Click += new System.EventHandler(this.btn_addMH_Click);
            // 
            // txt_MH_HOCKY
            // 
            this.txt_MH_HOCKY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MH_HOCKY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MH_HOCKY.Location = new System.Drawing.Point(291, 173);
            this.txt_MH_HOCKY.Name = "txt_MH_HOCKY";
            this.txt_MH_HOCKY.Size = new System.Drawing.Size(243, 30);
            this.txt_MH_HOCKY.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Học Kỳ : ";
            // 
            // txt_MH_TINCHI
            // 
            this.txt_MH_TINCHI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MH_TINCHI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MH_TINCHI.Location = new System.Drawing.Point(291, 137);
            this.txt_MH_TINCHI.Name = "txt_MH_TINCHI";
            this.txt_MH_TINCHI.Size = new System.Drawing.Size(243, 30);
            this.txt_MH_TINCHI.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tín Chỉ :";
            // 
            // txt_MH_MMH
            // 
            this.txt_MH_MMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MH_MMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MH_MMH.Location = new System.Drawing.Point(291, 72);
            this.txt_MH_MMH.Name = "txt_MH_MMH";
            this.txt_MH_MMH.Size = new System.Drawing.Size(243, 30);
            this.txt_MH_MMH.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã Môn Học :";
            // 
            // dgv_MH
            // 
            this.dgv_MH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MH.Location = new System.Drawing.Point(6, 272);
            this.dgv_MH.Name = "dgv_MH";
            this.dgv_MH.ReadOnly = true;
            this.dgv_MH.RowHeadersWidth = 51;
            this.dgv_MH.RowTemplate.Height = 24;
            this.dgv_MH.Size = new System.Drawing.Size(1203, 353);
            this.dgv_MH.TabIndex = 47;
            this.dgv_MH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MH_CellContentClick);
            // 
            // btn_ResetChuyenNghanh
            // 
            this.btn_ResetChuyenNghanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ResetChuyenNghanh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetChuyenNghanh.Location = new System.Drawing.Point(729, 195);
            this.btn_ResetChuyenNghanh.Name = "btn_ResetChuyenNghanh";
            this.btn_ResetChuyenNghanh.Size = new System.Drawing.Size(138, 49);
            this.btn_ResetChuyenNghanh.TabIndex = 68;
            this.btn_ResetChuyenNghanh.Text = "Reset";
            this.btn_ResetChuyenNghanh.UseVisualStyleBackColor = true;
            this.btn_ResetChuyenNghanh.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_ResetMonHoc
            // 
            this.btn_ResetMonHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ResetMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetMonHoc.Location = new System.Drawing.Point(775, 213);
            this.btn_ResetMonHoc.Name = "btn_ResetMonHoc";
            this.btn_ResetMonHoc.Size = new System.Drawing.Size(138, 49);
            this.btn_ResetMonHoc.TabIndex = 61;
            this.btn_ResetMonHoc.Text = "Reset";
            this.btn_ResetMonHoc.UseVisualStyleBackColor = true;
            this.btn_ResetMonHoc.Click += new System.EventHandler(this.btn_ResetMonHoc_Click);
            // 
            // CN_MONHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 663);
            this.Controls.Add(this.tabControl1);
            this.Name = "CN_MONHOC";
            this.Text = "CN_MONHOC";
            this.Load += new System.EventHandler(this.CN_MONHOC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CN)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_XoaMH;
        private System.Windows.Forms.Button btn_SuaMH;
        private System.Windows.Forms.Button btn_addMH;
        private System.Windows.Forms.TextBox txt_MH_HOCKY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MH_TINCHI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MH_MMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_MH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MH_TENMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_MH_CN;
        private System.Windows.Forms.ComboBox cmb_CN_KHOA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CN_TENCN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CN_MCN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_CN;
        private System.Windows.Forms.Button btn_CN_XOA;
        private System.Windows.Forms.Button btn_CN_SUA;
        private System.Windows.Forms.Button btn_CN_THEM;
        private System.Windows.Forms.Button btn_ResetChuyenNghanh;
        private System.Windows.Forms.Button btn_ResetMonHoc;
    }
}