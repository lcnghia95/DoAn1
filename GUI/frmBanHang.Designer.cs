namespace GUI
{
    partial class frmBanHang
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.dNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridBanHang = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNguoiID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnLoadThongTinKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDone = new DevExpress.XtraEditors.SimpleButton();
            this.txtNhapID = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.gcLapHoaDon = new DevExpress.XtraEditors.GroupControl();
            this.btnThietLapDonHang = new DevExpress.XtraEditors.SimpleButton();
            this.gcThanhToan = new DevExpress.XtraEditors.GroupControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDone2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDone1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLapHoaDon)).BeginInit();
            this.gcLapHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhToan)).BeginInit();
            this.gcThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dNgayLap
            // 
            this.dNgayLap.EditValue = null;
            this.dNgayLap.Enabled = false;
            this.dNgayLap.Location = new System.Drawing.Point(527, 26);
            this.dNgayLap.Name = "dNgayLap";
            this.dNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dNgayLap.Properties.Appearance.Options.UseFont = true;
            this.dNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayLap.Size = new System.Drawing.Size(186, 22);
            this.dNgayLap.TabIndex = 83;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Enabled = false;
            this.txtKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(527, 60);
            this.txtKhachHang.Multiline = true;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(186, 25);
            this.txtKhachHang.TabIndex = 80;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(118, 60);
            this.txtNhanVien.Multiline = true;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(201, 25);
            this.txtNhanVien.TabIndex = 79;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(415, 68);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 16);
            this.labelControl6.TabIndex = 75;
            this.labelControl6.Text = "Khách Hàng";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(415, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 17);
            this.labelControl5.TabIndex = 74;
            this.labelControl5.Text = "Ngày Lập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 72;
            this.labelControl2.Text = "Nhân Viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 71;
            this.labelControl1.Text = "Mã Hóa Đơn";
            // 
            // gridBanHang
            // 
            this.gridBanHang.AllowDrop = true;
            this.gridBanHang.DataMember = "GetKhachHang";
            this.gridBanHang.DataSource = this.sqlDataSource1;
            this.gridBanHang.Location = new System.Drawing.Point(9, 19);
            this.gridBanHang.MainView = this.gridView1;
            this.gridBanHang.Name = "gridBanHang";
            this.gridBanHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
            this.gridBanHang.Size = new System.Drawing.Size(782, 99);
            this.gridBanHang.TabIndex = 87;
            this.gridBanHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "desktop-m5ai04o.QUANLYBANDIENTHOAI.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"191\" />";
            table1.Name = "GetKhachHang";
            allColumns1.Table = table1;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Name = "GetKhachHang";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNguoiID,
            this.colhoTen,
            this.colgioiTinh,
            this.colngaySinh,
            this.colemail,
            this.colcmnd,
            this.coldiaChi});
            this.gridView1.GridControl = this.gridBanHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNguoiID
            // 
            this.colNguoiID.Caption = "ID";
            this.colNguoiID.FieldName = "NguoiID";
            this.colNguoiID.Name = "colNguoiID";
            this.colNguoiID.OptionsColumn.AllowEdit = false;
            this.colNguoiID.Visible = true;
            this.colNguoiID.VisibleIndex = 0;
            // 
            // colhoTen
            // 
            this.colhoTen.Caption = "Họ Tên";
            this.colhoTen.FieldName = "hoTen";
            this.colhoTen.Name = "colhoTen";
            this.colhoTen.OptionsColumn.AllowEdit = false;
            this.colhoTen.Visible = true;
            this.colhoTen.VisibleIndex = 1;
            // 
            // colgioiTinh
            // 
            this.colgioiTinh.Caption = "Giới Tính";
            this.colgioiTinh.FieldName = "gioiTinh";
            this.colgioiTinh.Name = "colgioiTinh";
            this.colgioiTinh.OptionsColumn.AllowEdit = false;
            this.colgioiTinh.Visible = true;
            this.colgioiTinh.VisibleIndex = 2;
            // 
            // colngaySinh
            // 
            this.colngaySinh.Caption = "Ngày Sinh";
            this.colngaySinh.FieldName = "ngaySinh";
            this.colngaySinh.Name = "colngaySinh";
            this.colngaySinh.OptionsColumn.AllowEdit = false;
            this.colngaySinh.Visible = true;
            this.colngaySinh.VisibleIndex = 3;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            // 
            // colcmnd
            // 
            this.colcmnd.Caption = "CMND";
            this.colcmnd.FieldName = "cmnd";
            this.colcmnd.Name = "colcmnd";
            this.colcmnd.OptionsColumn.AllowEdit = false;
            this.colcmnd.Visible = true;
            this.colcmnd.VisibleIndex = 5;
            // 
            // coldiaChi
            // 
            this.coldiaChi.Caption = "Địa Chỉ";
            this.coldiaChi.FieldName = "diaChi";
            this.coldiaChi.Name = "coldiaChi";
            this.coldiaChi.OptionsColumn.AllowEdit = false;
            this.coldiaChi.Visible = true;
            this.coldiaChi.VisibleIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnLoadThongTinKhachHang
            // 
            this.btnLoadThongTinKhachHang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoadThongTinKhachHang.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnLoadThongTinKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadThongTinKhachHang.ImageOptions.Image")));
            this.btnLoadThongTinKhachHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoadThongTinKhachHang.ImageOptions.SvgImage")));
            this.btnLoadThongTinKhachHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoadThongTinKhachHang.Location = new System.Drawing.Point(330, 124);
            this.btnLoadThongTinKhachHang.Name = "btnLoadThongTinKhachHang";
            this.btnLoadThongTinKhachHang.Size = new System.Drawing.Size(113, 39);
            this.btnLoadThongTinKhachHang.TabIndex = 88;
            this.btnLoadThongTinKhachHang.Text = "Load Info";
            this.btnLoadThongTinKhachHang.Click += new System.EventHandler(this.btnLoadThongTinKhachHang_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(118, 29);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(201, 25);
            this.txtMaHD.TabIndex = 78;
            // 
            // btnAddNew
            // 
            this.btnAddNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAddNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAddNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.ImageOptions.Image")));
            this.btnAddNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddNew.ImageOptions.SvgImage")));
            this.btnAddNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNew.Location = new System.Drawing.Point(449, 123);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 39);
            this.btnAddNew.TabIndex = 90;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDone);
            this.groupControl1.Controls.Add(this.txtNhapID);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.gridBanHang);
            this.groupControl1.Controls.Add(this.btnAddNew);
            this.groupControl1.Controls.Add(this.btnLoadThongTinKhachHang);
            this.groupControl1.Location = new System.Drawing.Point(-4, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(804, 171);
            this.groupControl1.TabIndex = 91;
            this.groupControl1.Text = "Thông Tin Khách hàng";
            // 
            // btnDone
            // 
            this.btnDone.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDone.Enabled = false;
            this.btnDone.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.ImageOptions.Image")));
            this.btnDone.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone.ImageOptions.SvgImage")));
            this.btnDone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone.Location = new System.Drawing.Point(679, 123);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(113, 39);
            this.btnDone.TabIndex = 92;
            this.btnDone.Text = "Done";
            this.btnDone.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtNhapID
            // 
            this.txtNhapID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapID.Location = new System.Drawing.Point(143, 132);
            this.txtNhapID.Multiline = true;
            this.txtNhapID.Name = "txtNhapID";
            this.txtNhapID.Size = new System.Drawing.Size(181, 25);
            this.txtNhapID.TabIndex = 89;
            this.txtNhapID.TextChanged += new System.EventHandler(this.txtNhapID_TextChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(9, 135);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(128, 17);
            this.labelControl9.TabIndex = 91;
            this.labelControl9.Text = "Nhập ID Khách Hàng";
            // 
            // gcLapHoaDon
            // 
            this.gcLapHoaDon.Controls.Add(this.btnDone1);
            this.gcLapHoaDon.Controls.Add(this.btnThietLapDonHang);
            this.gcLapHoaDon.Controls.Add(this.labelControl1);
            this.gcLapHoaDon.Controls.Add(this.labelControl2);
            this.gcLapHoaDon.Controls.Add(this.dNgayLap);
            this.gcLapHoaDon.Controls.Add(this.labelControl5);
            this.gcLapHoaDon.Controls.Add(this.labelControl6);
            this.gcLapHoaDon.Controls.Add(this.txtKhachHang);
            this.gcLapHoaDon.Controls.Add(this.txtNhanVien);
            this.gcLapHoaDon.Controls.Add(this.txtMaHD);
            this.gcLapHoaDon.Enabled = false;
            this.gcLapHoaDon.Location = new System.Drawing.Point(1, 178);
            this.gcLapHoaDon.Name = "gcLapHoaDon";
            this.gcLapHoaDon.Size = new System.Drawing.Size(799, 157);
            this.gcLapHoaDon.TabIndex = 92;
            this.gcLapHoaDon.Text = "Lập Hóa Đơn";
            // 
            // btnThietLapDonHang
            // 
            this.btnThietLapDonHang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThietLapDonHang.Enabled = false;
            this.btnThietLapDonHang.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnThietLapDonHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThietLapDonHang.ImageOptions.Image")));
            this.btnThietLapDonHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThietLapDonHang.ImageOptions.SvgImage")));
            this.btnThietLapDonHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThietLapDonHang.Location = new System.Drawing.Point(325, 104);
            this.btnThietLapDonHang.Name = "btnThietLapDonHang";
            this.btnThietLapDonHang.Size = new System.Drawing.Size(159, 39);
            this.btnThietLapDonHang.TabIndex = 102;
            this.btnThietLapDonHang.Text = "Thiết Lập Đơn Hàng";
            this.btnThietLapDonHang.Click += new System.EventHandler(this.btnThietLapDonHang_Click);
            // 
            // gcThanhToan
            // 
            this.gcThanhToan.Controls.Add(this.btnOK);
            this.gcThanhToan.Controls.Add(this.txtTienThua);
            this.gcThanhToan.Controls.Add(this.labelControl12);
            this.gcThanhToan.Controls.Add(this.txtTienNhan);
            this.gcThanhToan.Controls.Add(this.labelControl11);
            this.gcThanhToan.Controls.Add(this.txtTongTien);
            this.gcThanhToan.Controls.Add(this.labelControl10);
            this.gcThanhToan.Enabled = false;
            this.gcThanhToan.Location = new System.Drawing.Point(1, 341);
            this.gcThanhToan.Name = "gcThanhToan";
            this.gcThanhToan.Size = new System.Drawing.Size(798, 70);
            this.gcThanhToan.TabIndex = 93;
            this.gcThanhToan.Text = "Thanh Toán";
            // 
            // btnOK
            // 
            this.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnOK.Enabled = false;
            this.btnOK.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.ImageOptions.Image")));
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(460, 26);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 39);
            this.btnOK.TabIndex = 106;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Enabled = false;
            this.txtTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.Location = new System.Drawing.Point(663, 34);
            this.txtTienThua.Multiline = true;
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(123, 25);
            this.txtTienThua.TabIndex = 105;
            this.txtTienThua.TextChanged += new System.EventHandler(this.txtTienThua_TextChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(596, 37);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.ShowToolTips = false;
            this.labelControl12.Size = new System.Drawing.Size(61, 17);
            this.labelControl12.TabIndex = 104;
            this.labelControl12.Text = "Tiền Thừa";
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNhan.Location = new System.Drawing.Point(312, 34);
            this.txtTienNhan.Multiline = true;
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(123, 25);
            this.txtTienNhan.TabIndex = 103;
            this.txtTienNhan.Click += new System.EventHandler(this.txtTienNhan_Click);
            this.txtTienNhan.TextChanged += new System.EventHandler(this.txtTienNhan_TextChanged);
            this.txtTienNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienNhan_KeyPress);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(240, 37);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.ShowToolTips = false;
            this.labelControl11.Size = new System.Drawing.Size(61, 17);
            this.labelControl11.TabIndex = 102;
            this.labelControl11.Text = "Tiền Nhận";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(110, 33);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(123, 25);
            this.txtTongTien.TabIndex = 101;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(11, 37);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.ShowToolTips = false;
            this.labelControl10.Size = new System.Drawing.Size(90, 17);
            this.labelControl10.TabIndex = 100;
            this.labelControl10.Text = "Tổng Hóa Đơn";
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCancel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(545, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 39);
            this.btnCancel.TabIndex = 107;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone2
            // 
            this.btnDone2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDone2.Enabled = false;
            this.btnDone2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDone2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDone2.ImageOptions.Image")));
            this.btnDone2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone2.ImageOptions.SvgImage")));
            this.btnDone2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone2.Location = new System.Drawing.Point(675, 417);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(113, 39);
            this.btnDone2.TabIndex = 94;
            this.btnDone2.Text = "Done";
            this.btnDone2.Click += new System.EventHandler(this.btnDone2_Click);
            // 
            // btnDone1
            // 
            this.btnDone1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDone1.Enabled = false;
            this.btnDone1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDone1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnDone1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnDone1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone1.Location = new System.Drawing.Point(674, 104);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(113, 39);
            this.btnDone1.TabIndex = 103;
            this.btnDone1.Text = "Done";
            this.btnDone1.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone2);
            this.Controls.Add(this.gcThanhToan);
            this.Controls.Add(this.gcLapHoaDon);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.EnabledChanged += new System.EventHandler(this.frmBanHang_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLapHoaDon)).EndInit();
            this.gcLapHoaDon.ResumeLayout(false);
            this.gcLapHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhToan)).EndInit();
            this.gcThanhToan.ResumeLayout(false);
            this.gcThanhToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dNgayLap;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridBanHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiID;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colgioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colngaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colcmnd;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraEditors.SimpleButton btnLoadThongTinKhachHang;
        private System.Windows.Forms.TextBox txtMaHD;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl gcLapHoaDon;
        private DevExpress.XtraEditors.GroupControl gcThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnDone2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtNhapID;
        private DevExpress.XtraEditors.SimpleButton btnDone;
        private System.Windows.Forms.TextBox txtTienThua;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtTienNhan;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnThietLapDonHang;
        private DevExpress.XtraEditors.SimpleButton btnDone1;
    }
}