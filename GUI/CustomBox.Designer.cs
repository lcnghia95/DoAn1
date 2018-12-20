namespace GUI
{
    partial class CustomBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomBox));
            this.panHeader = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDaNghi = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangLam = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(52)))));
            this.panHeader.Appearance.Options.UseBackColor = true;
            this.panHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panHeader.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(380, 76);
            this.panHeader.TabIndex = 24;
            this.panHeader.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 13F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Chọn Trạng Thái Nhân Viên";
            // 
            // btnDaNghi
            // 
            this.btnDaNghi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDaNghi.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDaNghi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaNghi.ImageOptions.Image")));
            this.btnDaNghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDaNghi.ImageOptions.SvgImage")));
            this.btnDaNghi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDaNghi.Location = new System.Drawing.Point(219, 100);
            this.btnDaNghi.Name = "btnDaNghi";
            this.btnDaNghi.Size = new System.Drawing.Size(113, 39);
            this.btnDaNghi.TabIndex = 43;
            this.btnDaNghi.Text = "Đã Nghĩ";
            this.btnDaNghi.Click += new System.EventHandler(this.btnDaNghi_Click);
            // 
            // btnDangLam
            // 
            this.btnDangLam.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDangLam.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDangLam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangLam.ImageOptions.Image")));
            this.btnDangLam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangLam.ImageOptions.SvgImage")));
            this.btnDangLam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDangLam.Location = new System.Drawing.Point(39, 100);
            this.btnDangLam.Name = "btnDangLam";
            this.btnDangLam.Size = new System.Drawing.Size(113, 39);
            this.btnDangLam.TabIndex = 42;
            this.btnDangLam.Text = "Đang Làm";
            this.btnDangLam.Click += new System.EventHandler(this.btnDangLam_Click);
            // 
            // CustomBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 182);
            this.Controls.Add(this.btnDaNghi);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.btnDangLam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomBox";
            this.Load += new System.EventHandler(this.CustomBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl panHeader;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDaNghi;
        private DevExpress.XtraEditors.SimpleButton btnDangLam;
    }
}