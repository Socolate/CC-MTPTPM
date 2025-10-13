namespace QLSV
{
    partial class QLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSV));
            this.pl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_left = new System.Windows.Forms.Panel();
            this.btn_XEMDIEM = new System.Windows.Forms.Button();
            this.btn_QLCNMONHOC = new System.Windows.Forms.Button();
            this.btn_QLKHOA = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_NhapDIem = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_QLSV = new System.Windows.Forms.Button();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.pl_body = new System.Windows.Forms.Panel();
            this.pl_top.SuspendLayout();
            this.pl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_top
            // 
            this.pl_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_top.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pl_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_top.Controls.Add(this.label1);
            this.pl_top.Location = new System.Drawing.Point(179, 3);
            this.pl_top.Name = "pl_top";
            this.pl_top.Size = new System.Drawing.Size(1167, 168);
            this.pl_top.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // pl_left
            // 
            this.pl_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pl_left.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pl_left.Controls.Add(this.btn_XEMDIEM);
            this.pl_left.Controls.Add(this.btn_QLCNMONHOC);
            this.pl_left.Controls.Add(this.btn_QLKHOA);
            this.pl_left.Controls.Add(this.btn_exit);
            this.pl_left.Controls.Add(this.btn_NhapDIem);
            this.pl_left.Controls.Add(this.btn_search);
            this.pl_left.Controls.Add(this.btn_QLSV);
            this.pl_left.Controls.Add(this.ptb_logo);
            this.pl_left.Location = new System.Drawing.Point(-2, 3);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(182, 719);
            this.pl_left.TabIndex = 3;
            // 
            // btn_XEMDIEM
            // 
            this.btn_XEMDIEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_XEMDIEM.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XEMDIEM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_XEMDIEM.Location = new System.Drawing.Point(0, 547);
            this.btn_XEMDIEM.Name = "btn_XEMDIEM";
            this.btn_XEMDIEM.Size = new System.Drawing.Size(182, 71);
            this.btn_XEMDIEM.TabIndex = 7;
            this.btn_XEMDIEM.Text = "Xem Điểm";
            this.btn_XEMDIEM.UseVisualStyleBackColor = true;
            this.btn_XEMDIEM.Click += new System.EventHandler(this.btn_XEMDIEM_Click);
            // 
            // btn_QLCNMONHOC
            // 
            this.btn_QLCNMONHOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLCNMONHOC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLCNMONHOC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_QLCNMONHOC.Location = new System.Drawing.Point(0, 476);
            this.btn_QLCNMONHOC.Name = "btn_QLCNMONHOC";
            this.btn_QLCNMONHOC.Size = new System.Drawing.Size(182, 71);
            this.btn_QLCNMONHOC.TabIndex = 6;
            this.btn_QLCNMONHOC.Text = "Quản Lý \r\nCN và MH";
            this.btn_QLCNMONHOC.UseVisualStyleBackColor = true;
            this.btn_QLCNMONHOC.Click += new System.EventHandler(this.btn_QLMONHOC_Click);
            // 
            // btn_QLKHOA
            // 
            this.btn_QLKHOA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLKHOA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLKHOA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_QLKHOA.Location = new System.Drawing.Point(0, 405);
            this.btn_QLKHOA.Name = "btn_QLKHOA";
            this.btn_QLKHOA.Size = new System.Drawing.Size(182, 71);
            this.btn_QLKHOA.TabIndex = 5;
            this.btn_QLKHOA.Text = "Quản Lý Khoa";
            this.btn_QLKHOA.UseVisualStyleBackColor = true;
            this.btn_QLKHOA.Click += new System.EventHandler(this.btn_QLKHOA_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_exit.Location = new System.Drawing.Point(0, 680);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(182, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_NhapDIem
            // 
            this.btn_NhapDIem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhapDIem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapDIem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_NhapDIem.Location = new System.Drawing.Point(0, 334);
            this.btn_NhapDIem.Name = "btn_NhapDIem";
            this.btn_NhapDIem.Size = new System.Drawing.Size(182, 71);
            this.btn_NhapDIem.TabIndex = 3;
            this.btn_NhapDIem.Text = "Nhập Điểm";
            this.btn_NhapDIem.UseVisualStyleBackColor = true;
            this.btn_NhapDIem.Click += new System.EventHandler(this.btn_NhapDIem_Click);
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_search.Location = new System.Drawing.Point(0, 263);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(182, 71);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_QLSV
            // 
            this.btn_QLSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QLSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLSV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_QLSV.Location = new System.Drawing.Point(0, 192);
            this.btn_QLSV.Name = "btn_QLSV";
            this.btn_QLSV.Size = new System.Drawing.Size(182, 71);
            this.btn_QLSV.TabIndex = 1;
            this.btn_QLSV.Text = "Quản Lý Sinh Viên";
            this.btn_QLSV.UseVisualStyleBackColor = true;
            this.btn_QLSV.Click += new System.EventHandler(this.btn_QLSV_Click);
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_logo.BackgroundImage")));
            this.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptb_logo.Location = new System.Drawing.Point(0, 0);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(182, 192);
            this.ptb_logo.TabIndex = 0;
            this.ptb_logo.TabStop = false;
            this.ptb_logo.Click += new System.EventHandler(this.ptb_logo_Click);
            // 
            // pl_body
            // 
            this.pl_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_body.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_body.BackgroundImage")));
            this.pl_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_body.Location = new System.Drawing.Point(179, 170);
            this.pl_body.Name = "pl_body";
            this.pl_body.Size = new System.Drawing.Size(1167, 552);
            this.pl_body.TabIndex = 5;
            this.pl_body.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_body_Paint);
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 722);
            this.Controls.Add(this.pl_top);
            this.Controls.Add(this.pl_left);
            this.Controls.Add(this.pl_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QLSV";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLSV_Load);
            this.pl_top.ResumeLayout(false);
            this.pl_top.PerformLayout();
            this.pl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pl_left;
        private System.Windows.Forms.Button btn_QLKHOA;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_NhapDIem;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_QLSV;
        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Panel pl_body;
        private System.Windows.Forms.Button btn_QLCNMONHOC;
        private System.Windows.Forms.Button btn_XEMDIEM;
    }
}

