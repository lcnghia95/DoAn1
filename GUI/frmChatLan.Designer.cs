namespace GUI
{
    partial class frmChatLan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChatLan));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lvOnline = new System.Windows.Forms.ListView();
            this.panHeader = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
//            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lvOnline
            // 
            this.lvOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOnline.Location = new System.Drawing.Point(12, 44);
            this.lvOnline.Name = "lvOnline";
            this.lvOnline.Size = new System.Drawing.Size(203, 308);
            this.lvOnline.TabIndex = 11;
            this.lvOnline.UseCompatibleStateImageBehavior = false;
            this.lvOnline.View = System.Windows.Forms.View.List;
            this.lvOnline.SelectedIndexChanged += new System.EventHandler(this.lvOnline_SelectedIndexChanged);
            this.lvOnline.Click += new System.EventHandler(this.lvOnline_Click);
            this.lvOnline.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvOnline_MouseDoubleClick);
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
            this.panHeader.Size = new System.Drawing.Size(229, 27);
            this.panHeader.TabIndex = 24;
            this.panHeader.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 13F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(40, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Danh Sách Online";
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.SvgImage = global::GUI.Properties.Resources.close;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(68, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 39);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmChatLan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(229, 407);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.lvOnline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChatLan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Lan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChatLan_FormClosed);
            this.Load += new System.EventHandler(this.frmChatLan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmChatLan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmChatLan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmChatLan_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lvOnline;
        internal DevExpress.XtraEditors.PanelControl panHeader;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}