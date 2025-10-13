namespace QLSV
{
    partial class QL_SV
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
            this.btn_XoaSV = new System.Windows.Forms.Button();
            this.btn_SuaSV = new System.Windows.Forms.Button();
            this.dtp_NGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Gmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoTenSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addSV = new System.Windows.Forms.Button();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_LOP = new System.Windows.Forms.ComboBox();
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
            this.dgv_QLSV.Location = new System.Drawing.Point(12, 263);
            this.dgv_QLSV.Name = "dgv_QLSV";
            this.dgv_QLSV.ReadOnly = true;
            this.dgv_QLSV.RowHeadersWidth = 51;
            this.dgv_QLSV.RowTemplate.Height = 24;
            this.dgv_QLSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLSV.Size = new System.Drawing.Size(1136, 326);
            this.dgv_QLSV.TabIndex = 16;
            this.dgv_QLSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLSV_CellContentClick);
            // 
            // btn_XoaSV
            // 
            this.btn_XoaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XoaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaSV.Location = new System.Drawing.Point(637, 213);
            this.btn_XoaSV.Name = "btn_XoaSV";
            this.btn_XoaSV.Size = new System.Drawing.Size(134, 44);
            this.btn_XoaSV.TabIndex = 46;
            this.btn_XoaSV.Text = "Xóa Sinh Viên";
            this.btn_XoaSV.UseVisualStyleBackColor = true;
            this.btn_XoaSV.Click += new System.EventHandler(this.btn_XoaSV_Click);
            // 
            // btn_SuaSV
            // 
            this.btn_SuaSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SuaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaSV.Location = new System.Drawing.Point(460, 213);
            this.btn_SuaSV.Name = "btn_SuaSV";
            this.btn_SuaSV.Size = new System.Drawing.Size(137, 44);
            this.btn_SuaSV.TabIndex = 45;
            this.btn_SuaSV.Text = "Sửa Thông Tin";
            this.btn_SuaSV.UseVisualStyleBackColor = true;
            this.btn_SuaSV.Click += new System.EventHandler(this.btn_SuaSV_Click);
            // 
            // dtp_NGAYSINH
            // 
            this.dtp_NGAYSINH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_NGAYSINH.CustomFormat = "dd/MM/yyyy";
            this.dtp_NGAYSINH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NGAYSINH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NGAYSINH.Location = new System.Drawing.Point(777, 173);
            this.dtp_NGAYSINH.Name = "dtp_NGAYSINH";
            this.dtp_NGAYSINH.Size = new System.Drawing.Size(286, 30);
            this.dtp_NGAYSINH.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ngày Sinh : ";
            // 
            // txt_Gmail
            // 
            this.txt_Gmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Gmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gmail.Location = new System.Drawing.Point(777, 80);
            this.txt_Gmail.Name = "txt_Gmail";
            this.txt_Gmail.Size = new System.Drawing.Size(286, 30);
            this.txt_Gmail.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Gmail : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "Giới Tính :";
            // 
            // txt_HoTenSV
            // 
            this.txt_HoTenSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_HoTenSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenSV.Location = new System.Drawing.Point(221, 72);
            this.txt_HoTenSV.Name = "txt_HoTenSV";
            this.txt_HoTenSV.Size = new System.Drawing.Size(239, 30);
            this.txt_HoTenSV.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Họ Tên : ";
            // 
            // btn_addSV
            // 
            this.btn_addSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSV.Location = new System.Drawing.Point(259, 213);
            this.btn_addSV.Name = "btn_addSV";
            this.btn_addSV.Size = new System.Drawing.Size(157, 44);
            this.btn_addSV.TabIndex = 47;
            this.btn_addSV.Text = "Thêm Sinh Viên";
            this.btn_addSV.UseVisualStyleBackColor = true;
            this.btn_addSV.Click += new System.EventHandler(this.btn_addSV_Click);
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Checked = true;
            this.rdb_Nam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nam.Location = new System.Drawing.Point(259, 121);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(62, 23);
            this.rdb_Nam.TabIndex = 48;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            this.rdb_Nam.CheckedChanged += new System.EventHandler(this.rdb_Nam_CheckedChanged);
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nu.Location = new System.Drawing.Point(378, 119);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(51, 23);
            this.rdb_Nu.TabIndex = 49;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(221, 162);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(239, 30);
            this.txt_DiaChi.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Địa Chỉ : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "Lớp : ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 40;
            this.label5.Text = "Số Điện Thoại : ";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(777, 121);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(286, 30);
            this.txt_SDT.TabIndex = 41;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MSSV.Location = new System.Drawing.Point(221, 17);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.ReadOnly = true;
            this.txt_MSSV.Size = new System.Drawing.Size(239, 30);
            this.txt_MSSV.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "Mã Sinh Viên :";
            // 
            // cmb_LOP
            // 
            this.cmb_LOP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_LOP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LOP.FormattingEnabled = true;
            this.cmb_LOP.Location = new System.Drawing.Point(777, 31);
            this.cmb_LOP.Name = "cmb_LOP";
            this.cmb_LOP.Size = new System.Drawing.Size(286, 30);
            this.cmb_LOP.TabIndex = 65;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(816, 213);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(134, 44);
            this.btn_Reset.TabIndex = 66;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // QL_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 601);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cmb_LOP);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdb_Nu);
            this.Controls.Add(this.rdb_Nam);
            this.Controls.Add(this.btn_addSV);
            this.Controls.Add(this.btn_XoaSV);
            this.Controls.Add(this.btn_SuaSV);
            this.Controls.Add(this.dtp_NGAYSINH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Gmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_HoTenSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_QLSV);
            this.Name = "QL_SV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QL_SV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_QLSV;
        private System.Windows.Forms.Button btn_XoaSV;
        private System.Windows.Forms.Button btn_SuaSV;
        private System.Windows.Forms.DateTimePicker dtp_NGAYSINH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Gmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoTenSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addSV;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_LOP;
        private System.Windows.Forms.Button btn_Reset;
    }
}