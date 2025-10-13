namespace QLSV
{
    partial class QLKHOA
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
            this.dgv_Khoa = new System.Windows.Forms.DataGridView();
            this.txt_GmailKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addKhoa = new System.Windows.Forms.Button();
            this.btn_SuaKhoa = new System.Windows.Forms.Button();
            this.btn_XoaKhoa = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Khoa
            // 
            this.dgv_Khoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Khoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khoa.Location = new System.Drawing.Point(14, 219);
            this.dgv_Khoa.Name = "dgv_Khoa";
            this.dgv_Khoa.ReadOnly = true;
            this.dgv_Khoa.RowHeadersWidth = 51;
            this.dgv_Khoa.RowTemplate.Height = 24;
            this.dgv_Khoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Khoa.Size = new System.Drawing.Size(1136, 293);
            this.dgv_Khoa.TabIndex = 17;
            this.dgv_Khoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Khoa_CellContentClick);
            // 
            // txt_GmailKhoa
            // 
            this.txt_GmailKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_GmailKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GmailKhoa.Location = new System.Drawing.Point(256, 77);
            this.txt_GmailKhoa.Name = "txt_GmailKhoa";
            this.txt_GmailKhoa.Size = new System.Drawing.Size(243, 30);
            this.txt_GmailKhoa.TabIndex = 38;
            this.txt_GmailKhoa.TextChanged += new System.EventHandler(this.txt_BDMMH_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Gmail Khoa : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MaKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKhoa.Location = new System.Drawing.Point(256, 36);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(243, 30);
            this.txt_MaKhoa.TabIndex = 36;
            this.txt_MaKhoa.TextChanged += new System.EventHandler(this.txt_NDMSSV_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã Khoa : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_TenKhoa
            // 
            this.txt_TenKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TenKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKhoa.Location = new System.Drawing.Point(256, 120);
            this.txt_TenKhoa.Name = "txt_TenKhoa";
            this.txt_TenKhoa.Size = new System.Drawing.Size(243, 30);
            this.txt_TenKhoa.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ten Khoa : ";
            // 
            // btn_addKhoa
            // 
            this.btn_addKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addKhoa.Location = new System.Drawing.Point(748, 3);
            this.btn_addKhoa.Name = "btn_addKhoa";
            this.btn_addKhoa.Size = new System.Drawing.Size(138, 49);
            this.btn_addKhoa.TabIndex = 42;
            this.btn_addKhoa.Text = "Thêm Khoa";
            this.btn_addKhoa.UseVisualStyleBackColor = true;
            this.btn_addKhoa.Click += new System.EventHandler(this.btn_addKhoa_Click);
            // 
            // btn_SuaKhoa
            // 
            this.btn_SuaKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SuaKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaKhoa.Location = new System.Drawing.Point(748, 58);
            this.btn_SuaKhoa.Name = "btn_SuaKhoa";
            this.btn_SuaKhoa.Size = new System.Drawing.Size(138, 49);
            this.btn_SuaKhoa.TabIndex = 45;
            this.btn_SuaKhoa.Text = "Sửa Khoa";
            this.btn_SuaKhoa.UseVisualStyleBackColor = true;
            this.btn_SuaKhoa.Click += new System.EventHandler(this.btn_SuaKhoa_Click);
            // 
            // btn_XoaKhoa
            // 
            this.btn_XoaKhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XoaKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaKhoa.Location = new System.Drawing.Point(748, 113);
            this.btn_XoaKhoa.Name = "btn_XoaKhoa";
            this.btn_XoaKhoa.Size = new System.Drawing.Size(138, 49);
            this.btn_XoaKhoa.TabIndex = 46;
            this.btn_XoaKhoa.Text = "Xóa Khoa";
            this.btn_XoaKhoa.UseVisualStyleBackColor = true;
            this.btn_XoaKhoa.Click += new System.EventHandler(this.btn_XoaKhoa_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(748, 164);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(138, 49);
            this.btn_Reset.TabIndex = 47;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // QLKHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 540);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_XoaKhoa);
            this.Controls.Add(this.btn_SuaKhoa);
            this.Controls.Add(this.btn_addKhoa);
            this.Controls.Add(this.txt_TenKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_GmailKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Khoa);
            this.Name = "QLKHOA";
            this.Text = "QLKHOA";
            this.Load += new System.EventHandler(this.QLKHOA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Khoa;
        private System.Windows.Forms.TextBox txt_GmailKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addKhoa;
        private System.Windows.Forms.Button btn_SuaKhoa;
        private System.Windows.Forms.Button btn_XoaKhoa;
        private System.Windows.Forms.Button btn_Reset;
    }
}