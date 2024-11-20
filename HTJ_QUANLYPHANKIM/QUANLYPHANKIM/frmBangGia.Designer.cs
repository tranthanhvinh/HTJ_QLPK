namespace QUANLYPHANKIM
{
    partial class frmBangGia
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grTop = new DevExpress.XtraEditors.GroupControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GoldCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoldType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GoldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BuyRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SellRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShopId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShopName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkCuaHang = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).BeginInit();
            this.grTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCuaHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLuu,
            this.btnHuy,
            this.btnDong});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.save_16x16;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.undo_16x16;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.Image = global::QUANLYPHANKIM.Properties.Resources.cancel_16x16;
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1434, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 527);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1434, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1434, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 497);
            // 
            // grTop
            // 
            this.grTop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.grTop.Appearance.Options.UseBackColor = true;
            this.grTop.Controls.Add(this.labelControl1);
            this.grTop.Controls.Add(this.lkCuaHang);
            this.grTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grTop.Location = new System.Drawing.Point(0, 30);
            this.grTop.Margin = new System.Windows.Forms.Padding(4);
            this.grTop.Name = "grTop";
            this.grTop.Size = new System.Drawing.Size(1434, 74);
            this.grTop.TabIndex = 11;
            this.grTop.Text = "Thông tin chung";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 104);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1434, 423);
            this.gcDanhSach.TabIndex = 12;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GoldCode,
            this.GoldType,
            this.GoldName,
            this.BuyRate,
            this.SellRate,
            this.ShopId,
            this.ShopName});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            // 
            // GoldCode
            // 
            this.GoldCode.Caption = "GoldCode";
            this.GoldCode.FieldName = "GoldCode";
            this.GoldCode.MinWidth = 25;
            this.GoldCode.Name = "GoldCode";
            this.GoldCode.Width = 94;
            // 
            // GoldType
            // 
            this.GoldType.Caption = "GoldType";
            this.GoldType.FieldName = "GoldType";
            this.GoldType.MinWidth = 25;
            this.GoldType.Name = "GoldType";
            this.GoldType.Width = 94;
            // 
            // GoldName
            // 
            this.GoldName.Caption = "Loại vàng";
            this.GoldName.FieldName = "GoldName";
            this.GoldName.MinWidth = 25;
            this.GoldName.Name = "GoldName";
            this.GoldName.Visible = true;
            this.GoldName.VisibleIndex = 0;
            this.GoldName.Width = 94;
            // 
            // BuyRate
            // 
            this.BuyRate.Caption = "Giá mua";
            this.BuyRate.FieldName = "BuyRate";
            this.BuyRate.MinWidth = 25;
            this.BuyRate.Name = "BuyRate";
            this.BuyRate.Visible = true;
            this.BuyRate.VisibleIndex = 1;
            this.BuyRate.Width = 94;
            // 
            // SellRate
            // 
            this.SellRate.Caption = "Giá bán";
            this.SellRate.FieldName = "SellRate";
            this.SellRate.MinWidth = 25;
            this.SellRate.Name = "SellRate";
            this.SellRate.Visible = true;
            this.SellRate.VisibleIndex = 2;
            this.SellRate.Width = 94;
            // 
            // ShopId
            // 
            this.ShopId.Caption = "ShopId";
            this.ShopId.FieldName = "ShopId";
            this.ShopId.MinWidth = 25;
            this.ShopId.Name = "ShopId";
            this.ShopId.Width = 94;
            // 
            // ShopName
            // 
            this.ShopName.Caption = "Cửa hàng";
            this.ShopName.FieldName = "ShopName";
            this.ShopName.MinWidth = 25;
            this.ShopName.Name = "ShopName";
            this.ShopName.Visible = true;
            this.ShopName.VisibleIndex = 3;
            this.ShopName.Width = 94;
            // 
            // lkCuaHang
            // 
            this.lkCuaHang.Location = new System.Drawing.Point(111, 41);
            this.lkCuaHang.MenuManager = this.barManager1;
            this.lkCuaHang.Name = "lkCuaHang";
            this.lkCuaHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCuaHang.Properties.PopupView = this.searchLookUpEdit1View;
            this.lkCuaHang.Size = new System.Drawing.Size(335, 22);
            this.lkCuaHang.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cửa hàng";
            // 
            // frmBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 527);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.grTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangGia";
            this.Text = "Bảng giá";
            this.Load += new System.EventHandler(this.frmBangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).EndInit();
            this.grTop.ResumeLayout(false);
            this.grTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCuaHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn GoldCode;
        private DevExpress.XtraGrid.Columns.GridColumn GoldType;
        private DevExpress.XtraGrid.Columns.GridColumn GoldName;
        private DevExpress.XtraGrid.Columns.GridColumn BuyRate;
        private DevExpress.XtraGrid.Columns.GridColumn SellRate;
        private DevExpress.XtraGrid.Columns.GridColumn ShopId;
        private DevExpress.XtraGrid.Columns.GridColumn ShopName;
        private DevExpress.XtraEditors.GroupControl grTop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit lkCuaHang;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}