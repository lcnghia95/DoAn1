namespace GUI
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery3 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table5 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table6 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table7 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join4 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo4 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.btnDone2 = new DevExpress.XtraEditors.SimpleButton();
            this.gcLapHoaDon = new DevExpress.XtraEditors.GroupControl();
            this.btnDone1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThietLapDonHang = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.gcThongTinNhaCC = new DevExpress.XtraEditors.GroupControl();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnDone = new DevExpress.XtraEditors.SimpleButton();
            this.gridNhapHang = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadThongTinKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcThanhToan = new DevExpress.XtraEditors.GroupControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtTienThua = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcLapHoaDon)).BeginInit();
            this.gcLapHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinNhaCC)).BeginInit();
            this.gcThongTinNhaCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhToan)).BeginInit();
            this.gcThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDone2
            // 
            this.btnDone2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDone2.Enabled = false;
            this.btnDone2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDone2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDone2.ImageOptions.Image")));
            this.btnDone2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone2.ImageOptions.SvgImage")));
            this.btnDone2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone2.Location = new System.Drawing.Point(675, 409);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(113, 39);
            this.btnDone2.TabIndex = 99;
            this.btnDone2.Text = "Done";
            this.btnDone2.Click += new System.EventHandler(this.btnDone2_Click);
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
            this.gcLapHoaDon.Location = new System.Drawing.Point(3, 151);
            this.gcLapHoaDon.Name = "gcLapHoaDon";
            this.gcLapHoaDon.Size = new System.Drawing.Size(799, 163);
            this.gcLapHoaDon.TabIndex = 97;
            this.gcLapHoaDon.Text = "Lập Hóa Đơn";
            // 
            // btnDone1
            // 
            this.btnDone1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDone1.Enabled = false;
            this.btnDone1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDone1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDone1.ImageOptions.Image")));
            this.btnDone1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone1.ImageOptions.SvgImage")));
            this.btnDone1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone1.Location = new System.Drawing.Point(672, 116);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(113, 39);
            this.btnDone1.TabIndex = 113;
            this.btnDone1.Text = "Done";
            this.btnDone1.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // btnThietLapDonHang
            // 
            this.btnThietLapDonHang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThietLapDonHang.Enabled = false;
            this.btnThietLapDonHang.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnThietLapDonHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThietLapDonHang.ImageOptions.Image")));
            this.btnThietLapDonHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThietLapDonHang.ImageOptions.SvgImage")));
            this.btnThietLapDonHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThietLapDonHang.Location = new System.Drawing.Point(326, 116);
            this.btnThietLapDonHang.Name = "btnThietLapDonHang";
            this.btnThietLapDonHang.Size = new System.Drawing.Size(159, 39);
            this.btnThietLapDonHang.TabIndex = 112;
            this.btnThietLapDonHang.Text = "Thiết Lập Đơn Hàng";
            this.btnThietLapDonHang.Click += new System.EventHandler(this.btnThietLapDonHang_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 104;
            this.labelControl1.Text = "Mã Hóa Đơn";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 105;
            this.labelControl2.Text = "Nhân Viên";
            // 
            // dNgayLap
            // 
            this.dNgayLap.EditValue = null;
            this.dNgayLap.Enabled = false;
            this.dNgayLap.Location = new System.Drawing.Point(530, 26);
            this.dNgayLap.Name = "dNgayLap";
            this.dNgayLap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dNgayLap.Properties.Appearance.Options.UseFont = true;
            this.dNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayLap.Size = new System.Drawing.Size(186, 22);
            this.dNgayLap.TabIndex = 111;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(418, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 17);
            this.labelControl5.TabIndex = 106;
            this.labelControl5.Text = "Ngày Lập";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(418, 68);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 16);
            this.labelControl6.TabIndex = 107;
            this.labelControl6.Text = "Khách Hàng";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Enabled = false;
            this.txtKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachHang.Location = new System.Drawing.Point(530, 60);
            this.txtKhachHang.Multiline = true;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(186, 25);
            this.txtKhachHang.TabIndex = 110;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(121, 60);
            this.txtNhanVien.Multiline = true;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(201, 25);
            this.txtNhanVien.TabIndex = 109;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(121, 29);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(201, 25);
            this.txtMaHD.TabIndex = 108;
            // 
            // gcThongTinNhaCC
            // 
            this.gcThongTinNhaCC.Controls.Add(this.txtNhaCC);
            this.gcThongTinNhaCC.Controls.Add(this.labelControl9);
            this.gcThongTinNhaCC.Controls.Add(this.btnDone);
            this.gcThongTinNhaCC.Controls.Add(this.gridNhapHang);
            this.gcThongTinNhaCC.Controls.Add(this.btnAddNew);
            this.gcThongTinNhaCC.Controls.Add(this.btnLoadThongTinKhachHang);
            this.gcThongTinNhaCC.Location = new System.Drawing.Point(-2, 3);
            this.gcThongTinNhaCC.Name = "gcThongTinNhaCC";
            this.gcThongTinNhaCC.Size = new System.Drawing.Size(804, 142);
            this.gcThongTinNhaCC.TabIndex = 96;
            this.gcThongTinNhaCC.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCC.Location = new System.Drawing.Point(130, 99);
            this.txtNhaCC.Multiline = true;
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(126, 25);
            this.txtNhaCC.TabIndex = 115;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 102);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(100, 17);
            this.labelControl9.TabIndex = 116;
            this.labelControl9.Text = "Nhập ID Nhà CC";
            // 
            // btnDone
            // 
            this.btnDone.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDone.Enabled = false;
            this.btnDone.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnDone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.ImageOptions.Image")));
            this.btnDone.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDone.ImageOptions.SvgImage")));
            this.btnDone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDone.Location = new System.Drawing.Point(677, 93);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(113, 39);
            this.btnDone.TabIndex = 114;
            this.btnDone.Text = "Done";
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // gridNhapHang
            // 
            this.gridNhapHang.AllowDrop = true;
            this.gridNhapHang.DataMember = "NHACUNGCAP";
            this.gridNhapHang.DataSource = this.sqlDataSource3;
            this.gridNhapHang.Location = new System.Drawing.Point(8, 24);
            this.gridNhapHang.MainView = this.gridView1;
            this.gridNhapHang.Name = "gridNhapHang";
            this.gridNhapHang.Size = new System.Drawing.Size(782, 61);
            this.gridNhapHang.TabIndex = 91;
            this.gridNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "desktop-m5ai04o.QUANLYBANDIENTHOAI.dbo";
            this.sqlDataSource3.Name = "sqlDataSource3";
            columnExpression1.ColumnName = "maNhaCC";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"96\" />";
            table1.Name = "NHACUNGCAP";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "tenNhaCC";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "diaChi";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"96\" />";
            table2.Name = "NHACUNGCAP_DIACHI";
            columnExpression3.Table = table2;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "SDT";
            table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"96\" />";
            table3.Name = "NHACUNGCAP_SDT";
            columnExpression4.Table = table3;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "NHACUNGCAP";
            relationColumnInfo1.NestedKeyColumn = "maNhaCC";
            relationColumnInfo1.ParentKeyColumn = "maNhaCC";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "maNhaCC";
            relationColumnInfo2.ParentKeyColumn = "maNhaCC";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaNhaCC,
            this.coltenNhaCC,
            this.coldiaChi,
            this.colSDT});
            this.gridView1.GridControl = this.gridNhapHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmaNhaCC
            // 
            this.colmaNhaCC.Caption = "Mã Nhà CC";
            this.colmaNhaCC.FieldName = "maNhaCC";
            this.colmaNhaCC.Name = "colmaNhaCC";
            this.colmaNhaCC.Visible = true;
            this.colmaNhaCC.VisibleIndex = 0;
            // 
            // coltenNhaCC
            // 
            this.coltenNhaCC.Caption = "Tên Nhà CC";
            this.coltenNhaCC.FieldName = "tenNhaCC";
            this.coltenNhaCC.Name = "coltenNhaCC";
            this.coltenNhaCC.Visible = true;
            this.coltenNhaCC.VisibleIndex = 1;
            // 
            // coldiaChi
            // 
            this.coldiaChi.Caption = "Địa Chỉ";
            this.coldiaChi.FieldName = "diaChi";
            this.coldiaChi.Name = "coldiaChi";
            this.coldiaChi.Visible = true;
            this.coldiaChi.VisibleIndex = 2;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số Điện Thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAddNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAddNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.ImageOptions.Image")));
            this.btnAddNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddNew.ImageOptions.SvgImage")));
            this.btnAddNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNew.Location = new System.Drawing.Point(390, 91);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 39);
            this.btnAddNew.TabIndex = 90;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnLoadThongTinKhachHang
            // 
            this.btnLoadThongTinKhachHang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoadThongTinKhachHang.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnLoadThongTinKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadThongTinKhachHang.ImageOptions.Image")));
            this.btnLoadThongTinKhachHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoadThongTinKhachHang.ImageOptions.SvgImage")));
            this.btnLoadThongTinKhachHang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoadThongTinKhachHang.Location = new System.Drawing.Point(271, 91);
            this.btnLoadThongTinKhachHang.Name = "btnLoadThongTinKhachHang";
            this.btnLoadThongTinKhachHang.Size = new System.Drawing.Size(113, 39);
            this.btnLoadThongTinKhachHang.TabIndex = 88;
            this.btnLoadThongTinKhachHang.Text = "Load Info";
            this.btnLoadThongTinKhachHang.Click += new System.EventHandler(this.btnLoadThongTinKhachHang_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "desktop-m5ai04o.QUANLYBANDIENTHOAI.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table4.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"191\" />";
            table4.Name = "GetKhachHang";
            allColumns1.Table = table4;
            selectQuery2.Columns.Add(allColumns1);
            selectQuery2.Name = "GetKhachHang";
            selectQuery2.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // btnDelete
            // 
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDelete.Name = "btnDelete";
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
            this.gcThanhToan.Location = new System.Drawing.Point(3, 320);
            this.gcThanhToan.Name = "gcThanhToan";
            this.gcThanhToan.Size = new System.Drawing.Size(798, 81);
            this.gcThanhToan.TabIndex = 98;
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
            this.btnOK.Location = new System.Drawing.Point(461, 27);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(113, 39);
            this.btnOK.TabIndex = 113;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtTienThua
            // 
            this.txtTienThua.Enabled = false;
            this.txtTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.Location = new System.Drawing.Point(664, 35);
            this.txtTienThua.Multiline = true;
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(123, 25);
            this.txtTienThua.TabIndex = 112;
            this.txtTienThua.TextChanged += new System.EventHandler(this.txtTienThua_TextChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(597, 38);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.ShowToolTips = false;
            this.labelControl12.Size = new System.Drawing.Size(61, 17);
            this.labelControl12.TabIndex = 111;
            this.labelControl12.Text = "Tiền Thừa";
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNhan.Location = new System.Drawing.Point(313, 35);
            this.txtTienNhan.Multiline = true;
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(123, 25);
            this.txtTienNhan.TabIndex = 110;
            this.txtTienNhan.TextChanged += new System.EventHandler(this.txtTienNhan_TextChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(241, 38);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.ShowToolTips = false;
            this.labelControl11.Size = new System.Drawing.Size(49, 17);
            this.labelControl11.TabIndex = 109;
            this.labelControl11.Text = "Tiền Trả";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(111, 34);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(123, 25);
            this.txtTongTien.TabIndex = 108;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(12, 38);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.ShowToolTips = false;
            this.labelControl10.Size = new System.Drawing.Size(90, 17);
            this.labelControl10.TabIndex = 107;
            this.labelControl10.Text = "Tổng Hóa Đơn";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "desktop-m5ai04o.QUANLYBANDIENTHOAI.dbo";
            this.sqlDataSource2.Name = "sqlDataSource2";
            table5.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"96\" />";
            table5.Name = "NHACUNGCAP";
            allColumns2.Table = table5;
            columnExpression5.ColumnName = "maNhaCC";
            columnExpression5.Table = table5;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "tenNhaCC";
            columnExpression6.Table = table5;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "diaChi";
            table6.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"96\" />";
            table6.Name = "NHACUNGCAP_DIACHI";
            columnExpression7.Table = table6;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "SDT";
            table7.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"96\" />";
            table7.Name = "NHACUNGCAP_SDT";
            columnExpression8.Table = table7;
            column8.Expression = columnExpression8;
            selectQuery3.Columns.Add(allColumns2);
            selectQuery3.Columns.Add(column5);
            selectQuery3.Columns.Add(column6);
            selectQuery3.Columns.Add(column7);
            selectQuery3.Columns.Add(column8);
            selectQuery3.Name = "NHACUNGCAP";
            relationColumnInfo3.NestedKeyColumn = "maNhaCC";
            relationColumnInfo3.ParentKeyColumn = "maNhaCC";
            join3.KeyColumns.Add(relationColumnInfo3);
            join3.Nested = table6;
            join3.Parent = table5;
            relationColumnInfo4.NestedKeyColumn = "maNhaCC";
            relationColumnInfo4.ParentKeyColumn = "maNhaCC";
            join4.KeyColumns.Add(relationColumnInfo4);
            join4.Nested = table7;
            join4.Parent = table5;
            selectQuery3.Relations.Add(join3);
            selectQuery3.Relations.Add(join4);
            selectQuery3.Tables.Add(table5);
            selectQuery3.Tables.Add(table6);
            selectQuery3.Tables.Add(table7);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery3});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCancel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(548, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 39);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone2);
            this.Controls.Add(this.gcLapHoaDon);
            this.Controls.Add(this.gcThongTinNhaCC);
            this.Controls.Add(this.gcThanhToan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapHang";
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLapHoaDon)).EndInit();
            this.gcLapHoaDon.ResumeLayout(false);
            this.gcLapHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinNhaCC)).EndInit();
            this.gcThongTinNhaCC.ResumeLayout(false);
            this.gcThongTinNhaCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhToan)).EndInit();
            this.gcThanhToan.ResumeLayout(false);
            this.gcThanhToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDone2;
        private DevExpress.XtraEditors.GroupControl gcLapHoaDon;
        private DevExpress.XtraEditors.GroupControl gcThongTinNhaCC;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.SimpleButton btnLoadThongTinKhachHang;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraEditors.GroupControl gcThanhToan;
        private DevExpress.XtraGrid.GridControl gridNhapHang;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraGrid.Columns.GridColumn colmaNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn coltenNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraEditors.SimpleButton btnDone1;
        private DevExpress.XtraEditors.SimpleButton btnThietLapDonHang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dNgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtMaHD;
        private DevExpress.XtraEditors.SimpleButton btnDone;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.TextBox txtTienThua;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtTienNhan;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.TextBox txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.TextBox txtNhaCC;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}