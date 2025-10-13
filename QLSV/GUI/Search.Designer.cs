namespace QLSV
{
    partial class Search
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
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_timKiem = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.cmb_LOP = new System.Windows.Forms.ComboBox();
            this.cmb_CN = new System.Windows.Forms.ComboBox();
            this.rdb_MSSV = new System.Windows.Forms.RadioButton();
            this.rdb_SVLOP = new System.Windows.Forms.RadioButton();
            this.rdb_SVCN = new System.Windows.Forms.RadioButton();
            this.rdb_AllSV = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.gb_timKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_search
            // 
            this.dgv_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(12, 174);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.ReadOnly = true;
            this.dgv_search.RowHeadersWidth = 51;
            this.dgv_search.RowTemplate.Height = 24;
            this.dgv_search.Size = new System.Drawing.Size(1139, 433);
            this.dgv_search.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // gb_timKiem
            // 
            this.gb_timKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_timKiem.Controls.Add(this.btn_Search);
            this.gb_timKiem.Controls.Add(this.txt_MSSV);
            this.gb_timKiem.Controls.Add(this.cmb_LOP);
            this.gb_timKiem.Controls.Add(this.cmb_CN);
            this.gb_timKiem.Controls.Add(this.rdb_MSSV);
            this.gb_timKiem.Controls.Add(this.rdb_SVLOP);
            this.gb_timKiem.Controls.Add(this.rdb_SVCN);
            this.gb_timKiem.Controls.Add(this.rdb_AllSV);
            this.gb_timKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_timKiem.Location = new System.Drawing.Point(12, 12);
            this.gb_timKiem.Name = "gb_timKiem";
            this.gb_timKiem.Size = new System.Drawing.Size(1139, 139);
            this.gb_timKiem.TabIndex = 1;
            this.gb_timKiem.TabStop = false;
            this.gb_timKiem.Text = "Tìm Kiếm";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(930, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(105, 38);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(649, 28);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(241, 30);
            this.txt_MSSV.TabIndex = 6;
            this.txt_MSSV.Click += new System.EventHandler(this.txt_MSSV_Click);
            this.txt_MSSV.TextChanged += new System.EventHandler(this.txt_MSSV_TextChanged);
            // 
            // cmb_LOP
            // 
            this.cmb_LOP.FormattingEnabled = true;
            this.cmb_LOP.Location = new System.Drawing.Point(206, 98);
            this.cmb_LOP.Name = "cmb_LOP";
            this.cmb_LOP.Size = new System.Drawing.Size(167, 30);
            this.cmb_LOP.TabIndex = 5;
            this.cmb_LOP.SelectedIndexChanged += new System.EventHandler(this.cmb_LOP_SelectedIndexChanged);
            // 
            // cmb_CN
            // 
            this.cmb_CN.FormattingEnabled = true;
            this.cmb_CN.Location = new System.Drawing.Point(206, 62);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(167, 30);
            this.cmb_CN.TabIndex = 4;
            this.cmb_CN.SelectedIndexChanged += new System.EventHandler(this.cmb_CN_SelectedIndexChanged);
            // 
            // rdb_MSSV
            // 
            this.rdb_MSSV.AutoSize = true;
            this.rdb_MSSV.Location = new System.Drawing.Point(505, 29);
            this.rdb_MSSV.Name = "rdb_MSSV";
            this.rdb_MSSV.Size = new System.Drawing.Size(138, 26);
            this.rdb_MSSV.TabIndex = 3;
            this.rdb_MSSV.Text = "Mã Sinh Viên";
            this.rdb_MSSV.UseVisualStyleBackColor = true;
            // 
            // rdb_SVLOP
            // 
            this.rdb_SVLOP.AutoSize = true;
            this.rdb_SVLOP.Location = new System.Drawing.Point(55, 99);
            this.rdb_SVLOP.Name = "rdb_SVLOP";
            this.rdb_SVLOP.Size = new System.Drawing.Size(101, 26);
            this.rdb_SVLOP.TabIndex = 2;
            this.rdb_SVLOP.Text = "Lớp Học";
            this.rdb_SVLOP.UseVisualStyleBackColor = true;
            this.rdb_SVLOP.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_SVCN
            // 
            this.rdb_SVCN.AutoSize = true;
            this.rdb_SVCN.Location = new System.Drawing.Point(55, 67);
            this.rdb_SVCN.Name = "rdb_SVCN";
            this.rdb_SVCN.Size = new System.Drawing.Size(144, 26);
            this.rdb_SVCN.TabIndex = 1;
            this.rdb_SVCN.Text = "Chuyên Ngành";
            this.rdb_SVCN.UseVisualStyleBackColor = true;
            // 
            // rdb_AllSV
            // 
            this.rdb_AllSV.AutoSize = true;
            this.rdb_AllSV.Checked = true;
            this.rdb_AllSV.Location = new System.Drawing.Point(55, 29);
            this.rdb_AllSV.Name = "rdb_AllSV";
            this.rdb_AllSV.Size = new System.Drawing.Size(163, 26);
            this.rdb_AllSV.TabIndex = 0;
            this.rdb_AllSV.TabStop = true;
            this.rdb_AllSV.Text = "Tất Cả Sinh viên";
            this.rdb_AllSV.UseVisualStyleBackColor = true;
            this.rdb_AllSV.CheckedChanged += new System.EventHandler(this.rdb_AllSV_CheckedChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 619);
            this.Controls.Add(this.gb_timKiem);
            this.Controls.Add(this.dgv_search);
            this.Name = "Search";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.gb_timKiem.ResumeLayout(false);
            this.gb_timKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb_timKiem;
        private System.Windows.Forms.RadioButton rdb_SVCN;
        private System.Windows.Forms.RadioButton rdb_AllSV;
        private System.Windows.Forms.RadioButton rdb_SVLOP;
        private System.Windows.Forms.RadioButton rdb_MSSV;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.ComboBox cmb_LOP;
        private System.Windows.Forms.ComboBox cmb_CN;
        private System.Windows.Forms.Button btn_Search;
    }
}