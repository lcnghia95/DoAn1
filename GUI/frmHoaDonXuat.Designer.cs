namespace GUI
{
    partial class frmHoaDonXuat
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
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonXuat));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            this.gridHoaDonXuat = new DevExpress.XtraGrid.GridControl();
            this.hoaDonXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàyLập = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhânViên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKháchhàng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênHàng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốLượng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiáBán = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDonXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHoaDonXuat
            // 
            this.gridHoaDonXuat.AllowDrop = true;
            this.gridHoaDonXuat.DataSource = this.hoaDonXuatBindingSource;
            this.gridHoaDonXuat.Location = new System.Drawing.Point(1, 3);
            this.gridHoaDonXuat.MainView = this.gridView1;
            this.gridHoaDonXuat.Name = "gridHoaDonXuat";
            this.gridHoaDonXuat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
            this.gridHoaDonXuat.Size = new System.Drawing.Size(796, 406);
            this.gridHoaDonXuat.TabIndex = 44;
            this.gridHoaDonXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hoaDonXuatBindingSource
            // 
            this.hoaDonXuatBindingSource.DataMember = "HoaDonXuat";
            this.hoaDonXuatBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "desktop-m5ai04o.QUANLYBANDIENTHOAI.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"191\" />";
            table1.Name = "HoaDonXuat";
            allColumns1.Table = table1;
            columnExpression1.ColumnName = "Mã HD";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Ngày Lập";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Nhân Viên";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Khách hàng";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Tên Hàng";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Số Lượng";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Giá Bán";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Name = "HoaDonXuat";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãHD,
            this.colNgàyLập,
            this.colNhânViên,
            this.colKháchhàng,
            this.colTênHàng,
            this.colSốLượng,
            this.colGiáBán});
            this.gridView1.GridControl = this.gridHoaDonXuat;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMãHD
            // 
            this.colMãHD.Caption = "Mã HD";
            this.colMãHD.FieldName = "Mã_HD";
            this.colMãHD.Name = "colMãHD";
            this.colMãHD.Visible = true;
            this.colMãHD.VisibleIndex = 0;
            this.colMãHD.Width = 98;
            // 
            // colNgàyLập
            // 
            this.colNgàyLập.Caption = "Ngày Lập";
            this.colNgàyLập.FieldName = "Ngày_Lập";
            this.colNgàyLập.Name = "colNgàyLập";
            this.colNgàyLập.Visible = true;
            this.colNgàyLập.VisibleIndex = 1;
            this.colNgàyLập.Width = 98;
            // 
            // colNhânViên
            // 
            this.colNhânViên.Caption = "Nhân Viên";
            this.colNhânViên.FieldName = "Nhân_Viên";
            this.colNhânViên.Name = "colNhânViên";
            this.colNhânViên.Visible = true;
            this.colNhânViên.VisibleIndex = 2;
            this.colNhânViên.Width = 116;
            // 
            // colKháchhàng
            // 
            this.colKháchhàng.Caption = "Khách Hàng";
            this.colKháchhàng.FieldName = "Khách_hàng";
            this.colKháchhàng.Name = "colKháchhàng";
            this.colKháchhàng.Visible = true;
            this.colKháchhàng.VisibleIndex = 3;
            this.colKháchhàng.Width = 124;
            // 
            // colTênHàng
            // 
            this.colTênHàng.Caption = "Tên Hàng";
            this.colTênHàng.FieldName = "Tên_Hàng";
            this.colTênHàng.Name = "colTênHàng";
            this.colTênHàng.Visible = true;
            this.colTênHàng.VisibleIndex = 4;
            this.colTênHàng.Width = 111;
            // 
            // colSốLượng
            // 
            this.colSốLượng.Caption = "Số Lượng";
            this.colSốLượng.FieldName = "Số_Lượng";
            this.colSốLượng.Name = "colSốLượng";
            this.colSốLượng.Visible = true;
            this.colSốLượng.VisibleIndex = 5;
            this.colSốLượng.Width = 67;
            // 
            // colGiáBán
            // 
            this.colGiáBán.Caption = "Đơn Giá";
            this.colGiáBán.FieldName = "Giá_Bán";
            this.colGiáBán.Name = "colGiáBán";
            this.colGiáBán.Visible = true;
            this.colGiáBán.VisibleIndex = 6;
            this.colGiáBán.Width = 78;
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
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "desktop-m5ai04o.QUANLYBANDIENTHOAI.dbo";
            this.sqlDataSource2.Name = "sqlDataSource2";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"191\" />";
            table2.Name = "HoaDonXuat";
            allColumns2.Table = table2;
            selectQuery2.Columns.Add(allColumns2);
            selectQuery2.Name = "HoaDonXuat";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(683, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 39);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLoad.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoad.ImageOptions.SvgImage")));
            this.btnLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoad.Location = new System.Drawing.Point(2, 413);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(113, 39);
            this.btnLoad.TabIndex = 45;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gridHoaDonXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDonXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Xuất";
            this.Load += new System.EventHandler(this.frmHoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDonXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridHoaDonXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private System.Windows.Forms.BindingSource hoaDonXuatBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMãHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàyLập;
        private DevExpress.XtraGrid.Columns.GridColumn colNhânViên;
        private DevExpress.XtraGrid.Columns.GridColumn colKháchhàng;
        private DevExpress.XtraGrid.Columns.GridColumn colTênHàng;
        private DevExpress.XtraGrid.Columns.GridColumn colSốLượng;
        private DevExpress.XtraGrid.Columns.GridColumn colGiáBán;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
    }
}