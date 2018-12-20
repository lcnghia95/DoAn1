namespace GUI
{
    partial class frmDangNhapServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhapServer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnGetIPAddress = new System.Windows.Forms.Button();
            this.rtxtIP = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Server Name / IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(127, 19);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(179, 28);
            this.txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(127, 62);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 28);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tài Khoản Đăng Nhập";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Enabled = false;
            this.btnKetNoi.Location = new System.Drawing.Point(416, 334);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(138, 34);
            this.btnKetNoi.TabIndex = 8;
            this.btnKetNoi.Text = "Kết Nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Chọn DataBase";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Enabled = false;
            this.cbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.ItemHeight = 24;
            this.cbDatabase.Location = new System.Drawing.Point(399, 296);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(340, 32);
            this.cbDatabase.TabIndex = 36;
            // 
            // cbServer
            // 
            this.cbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Location = new System.Drawing.Point(544, 11);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(224, 32);
            this.cbServer.TabIndex = 3;
            this.cbServer.Text = "myserver-doan1.database.windows.net";
            // 
            // btExit
            // 
            this.btExit.Enabled = false;
            this.btExit.Location = new System.Drawing.Point(584, 334);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(138, 34);
            this.btExit.TabIndex = 9;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(416, 219);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(306, 34);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Lấy Danh Sách Database";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.label2);
            this.gbUser.Controls.Add(this.txtUser);
            this.gbUser.Controls.Add(this.txtPassword);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Location = new System.Drawing.Point(405, 90);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(344, 114);
            this.gbUser.TabIndex = 4;
            this.gbUser.TabStop = false;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(140, 12);
            this.txtIPAddress.Multiline = true;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(220, 28);
            this.txtIPAddress.TabIndex = 1;
            // 
            // btnGetIPAddress
            // 
            this.btnGetIPAddress.Location = new System.Drawing.Point(27, 9);
            this.btnGetIPAddress.Name = "btnGetIPAddress";
            this.btnGetIPAddress.Size = new System.Drawing.Size(107, 34);
            this.btnGetIPAddress.TabIndex = 0;
            this.btnGetIPAddress.Text = "Lấy IP Address";
            this.btnGetIPAddress.UseVisualStyleBackColor = true;
            this.btnGetIPAddress.Click += new System.EventHandler(this.btnGetIPAddress_Click);
            // 
            // rtxtIP
            // 
            this.rtxtIP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtIP.Location = new System.Drawing.Point(27, 63);
            this.rtxtIP.Name = "rtxtIP";
            this.rtxtIP.Size = new System.Drawing.Size(333, 248);
            this.rtxtIP.TabIndex = 44;
            this.rtxtIP.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lấy DS IP / Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDangNhapServer
            // 
            this.AcceptButton = this.btnKetNoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtIP);
            this.Controls.Add(this.btnGetIPAddress);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.gbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhapServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống Dữ Liệu";
            this.Load += new System.EventHandler(this.frmDangNhapServer_Load);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnGetIPAddress;
        private System.Windows.Forms.RichTextBox rtxtIP;
        private System.Windows.Forms.Button button1;
    }
}