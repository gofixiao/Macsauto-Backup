namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Dashboard
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainActionPanel = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnServiceBooking = new System.Windows.Forms.Button();
            this.btnPurchaseProduct = new System.Windows.Forms.Button();
            this.btnRedeemPoint = new System.Windows.Forms.Button();
            this.btnNewServiceOrder = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pnlRightBottom = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvPendingServices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanelTop = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.pnlRightFill = new System.Windows.Forms.Panel();
            this.gbxServiceData = new System.Windows.Forms.GroupBox();
            this.pnlDockFill = new System.Windows.Forms.Panel();
            this.dgvServiceItem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColServiceDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColVoid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlDockBottom = new System.Windows.Forms.Panel();
            this.dgvServiceProduct = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColProductDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColProductSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetailTop = new System.Windows.Forms.Panel();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.txtCurrentKm = new System.Windows.Forms.TextBox();
            this.lblVehicleBrand = new System.Windows.Forms.Label();
            this.lblCurrentKm = new System.Windows.Forms.Label();
            this.txtVehicleBrand = new System.Windows.Forms.TextBox();
            this.txtVehicleColor = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.lblVehicleColor = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.pnlRightTopTop = new System.Windows.Forms.Panel();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.pboxMaskot = new System.Windows.Forms.PictureBox();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.lblServiceCode = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainActionPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.pnlRightBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingServices)).BeginInit();
            this.mainPanelTop.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.pnlRightFill.SuspendLayout();
            this.gbxServiceData.SuspendLayout();
            this.pnlDockFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceItem)).BeginInit();
            this.pnlDockBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceProduct)).BeginInit();
            this.pnlDetailTop.SuspendLayout();
            this.pnlRightTopTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaskot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainActionPanel
            // 
            this.mainActionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(17)))));
            this.mainActionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainActionPanel.Controls.Add(this.btnCustomers);
            this.mainActionPanel.Controls.Add(this.btnServiceBooking);
            this.mainActionPanel.Controls.Add(this.btnPurchaseProduct);
            this.mainActionPanel.Controls.Add(this.btnRedeemPoint);
            this.mainActionPanel.Controls.Add(this.btnNewServiceOrder);
            this.mainActionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainActionPanel.Location = new System.Drawing.Point(517, 0);
            this.mainActionPanel.Name = "mainActionPanel";
            this.mainActionPanel.Size = new System.Drawing.Size(120, 708);
            this.mainActionPanel.TabIndex = 4;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Location = new System.Drawing.Point(3, 335);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(112, 77);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnServiceBooking
            // 
            this.btnServiceBooking.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnServiceBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceBooking.ForeColor = System.Drawing.Color.Black;
            this.btnServiceBooking.Location = new System.Drawing.Point(3, 252);
            this.btnServiceBooking.Name = "btnServiceBooking";
            this.btnServiceBooking.Size = new System.Drawing.Size(112, 77);
            this.btnServiceBooking.TabIndex = 3;
            this.btnServiceBooking.Text = "Service Booking";
            this.btnServiceBooking.UseVisualStyleBackColor = false;
            this.btnServiceBooking.Click += new System.EventHandler(this.btnServiceBooking_Click);
            // 
            // btnPurchaseProduct
            // 
            this.btnPurchaseProduct.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPurchaseProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPurchaseProduct.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseProduct.Location = new System.Drawing.Point(3, 86);
            this.btnPurchaseProduct.Name = "btnPurchaseProduct";
            this.btnPurchaseProduct.Size = new System.Drawing.Size(112, 77);
            this.btnPurchaseProduct.TabIndex = 2;
            this.btnPurchaseProduct.Text = "Purchase Product";
            this.btnPurchaseProduct.UseVisualStyleBackColor = false;
            // 
            // btnRedeemPoint
            // 
            this.btnRedeemPoint.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnRedeemPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRedeemPoint.ForeColor = System.Drawing.Color.White;
            this.btnRedeemPoint.Location = new System.Drawing.Point(3, 169);
            this.btnRedeemPoint.Name = "btnRedeemPoint";
            this.btnRedeemPoint.Size = new System.Drawing.Size(112, 77);
            this.btnRedeemPoint.TabIndex = 1;
            this.btnRedeemPoint.Text = "Redeem Point";
            this.btnRedeemPoint.UseVisualStyleBackColor = false;
            // 
            // btnNewServiceOrder
            // 
            this.btnNewServiceOrder.BackColor = System.Drawing.Color.Green;
            this.btnNewServiceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewServiceOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewServiceOrder.Location = new System.Drawing.Point(3, 3);
            this.btnNewServiceOrder.Name = "btnNewServiceOrder";
            this.btnNewServiceOrder.Size = new System.Drawing.Size(112, 77);
            this.btnNewServiceOrder.TabIndex = 0;
            this.btnNewServiceOrder.Text = "New Service Order";
            this.btnNewServiceOrder.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.pnlRightBottom);
            this.mainPanel.Controls.Add(this.dgvPendingServices);
            this.mainPanel.Controls.Add(this.mainPanelTop);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(517, 708);
            this.mainPanel.TabIndex = 5;
            // 
            // pnlRightBottom
            // 
            this.pnlRightBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlRightBottom.Controls.Add(this.btnPay);
            this.pnlRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRightBottom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRightBottom.Location = new System.Drawing.Point(0, 655);
            this.pnlRightBottom.Name = "pnlRightBottom";
            this.pnlRightBottom.Size = new System.Drawing.Size(515, 51);
            this.pnlRightBottom.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(0, 0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(515, 51);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // dgvPendingServices
            // 
            this.dgvPendingServices.AllowUserToAddRows = false;
            this.dgvPendingServices.AllowUserToDeleteRows = false;
            this.dgvPendingServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPendingServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvPendingServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColId,
            this.dgvColCode,
            this.dgvColCustomer,
            this.dgvColCellphone,
            this.dgvColCreatedOn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingServices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendingServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendingServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPendingServices.Location = new System.Drawing.Point(0, 50);
            this.dgvPendingServices.Name = "dgvPendingServices";
            this.dgvPendingServices.ReadOnly = true;
            this.dgvPendingServices.RowHeadersVisible = false;
            this.dgvPendingServices.Size = new System.Drawing.Size(515, 656);
            this.dgvPendingServices.TabIndex = 1;
            this.dgvPendingServices.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingServices_CellEnter);
            // 
            // dgvColId
            // 
            this.dgvColId.HeaderText = "Id";
            this.dgvColId.Name = "dgvColId";
            this.dgvColId.ReadOnly = true;
            this.dgvColId.Visible = false;
            this.dgvColId.Width = 22;
            // 
            // dgvColCode
            // 
            this.dgvColCode.HeaderText = "Service Order";
            this.dgvColCode.Name = "dgvColCode";
            this.dgvColCode.ReadOnly = true;
            this.dgvColCode.Width = 130;
            // 
            // dgvColCustomer
            // 
            this.dgvColCustomer.HeaderText = "Customer";
            this.dgvColCustomer.Name = "dgvColCustomer";
            this.dgvColCustomer.ReadOnly = true;
            this.dgvColCustomer.Width = 103;
            // 
            // dgvColCellphone
            // 
            this.dgvColCellphone.HeaderText = "Cellphone";
            this.dgvColCellphone.Name = "dgvColCellphone";
            this.dgvColCellphone.ReadOnly = true;
            this.dgvColCellphone.Width = 105;
            // 
            // dgvColCreatedOn
            // 
            this.dgvColCreatedOn.HeaderText = "Created On";
            this.dgvColCreatedOn.Name = "dgvColCreatedOn";
            this.dgvColCreatedOn.ReadOnly = true;
            this.dgvColCreatedOn.Width = 114;
            // 
            // mainPanelTop
            // 
            this.mainPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.mainPanelTop.Controls.Add(this.btnClear);
            this.mainPanelTop.Controls.Add(this.txtSearch);
            this.mainPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanelTop.Location = new System.Drawing.Point(0, 0);
            this.mainPanelTop.Name = "mainPanelTop";
            this.mainPanelTop.Size = new System.Drawing.Size(515, 50);
            this.mainPanelTop.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(403, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 29);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(392, 29);
            this.txtSearch.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.AutoScroll = true;
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.rightPanel.Controls.Add(this.pnlRightFill);
            this.rightPanel.Controls.Add(this.pnlRightTop);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(637, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(713, 708);
            this.rightPanel.TabIndex = 6;
            // 
            // pnlRightFill
            // 
            this.pnlRightFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(17)))));
            this.pnlRightFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightFill.Controls.Add(this.gbxServiceData);
            this.pnlRightFill.Controls.Add(this.txtCellphone);
            this.pnlRightFill.Controls.Add(this.lblCellphone);
            this.pnlRightFill.Controls.Add(this.txtFullname);
            this.pnlRightFill.Controls.Add(this.lblFullname);
            this.pnlRightFill.Controls.Add(this.pnlRightTopTop);
            this.pnlRightFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightFill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.pnlRightFill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            this.pnlRightFill.Location = new System.Drawing.Point(0, 51);
            this.pnlRightFill.Name = "pnlRightFill";
            this.pnlRightFill.Size = new System.Drawing.Size(713, 657);
            this.pnlRightFill.TabIndex = 1;
            // 
            // gbxServiceData
            // 
            this.gbxServiceData.Controls.Add(this.pnlDockFill);
            this.gbxServiceData.Controls.Add(this.pnlDockBottom);
            this.gbxServiceData.Controls.Add(this.pnlDetailTop);
            this.gbxServiceData.Location = new System.Drawing.Point(11, 131);
            this.gbxServiceData.Name = "gbxServiceData";
            this.gbxServiceData.Size = new System.Drawing.Size(689, 449);
            this.gbxServiceData.TabIndex = 8;
            this.gbxServiceData.TabStop = false;
            this.gbxServiceData.Text = "Service Data";
            // 
            // pnlDockFill
            // 
            this.pnlDockFill.Controls.Add(this.dgvServiceItem);
            this.pnlDockFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDockFill.Location = new System.Drawing.Point(3, 167);
            this.pnlDockFill.Name = "pnlDockFill";
            this.pnlDockFill.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlDockFill.Size = new System.Drawing.Size(683, 137);
            this.pnlDockFill.TabIndex = 16;
            // 
            // dgvServiceItem
            // 
            this.dgvServiceItem.AllowUserToAddRows = false;
            this.dgvServiceItem.AllowUserToDeleteRows = false;
            this.dgvServiceItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServiceItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColService,
            this.dgvColPrice,
            this.dgvColServiceDiscount,
            this.dgvColVoid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServiceItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvServiceItem.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceItem.Name = "dgvServiceItem";
            this.dgvServiceItem.ReadOnly = true;
            this.dgvServiceItem.RowHeadersVisible = false;
            this.dgvServiceItem.Size = new System.Drawing.Size(683, 127);
            this.dgvServiceItem.TabIndex = 2;
            // 
            // dgvColService
            // 
            this.dgvColService.HeaderText = "Service";
            this.dgvColService.Name = "dgvColService";
            this.dgvColService.ReadOnly = true;
            this.dgvColService.Width = 88;
            // 
            // dgvColPrice
            // 
            this.dgvColPrice.HeaderText = "Price";
            this.dgvColPrice.Name = "dgvColPrice";
            this.dgvColPrice.ReadOnly = true;
            this.dgvColPrice.Width = 71;
            // 
            // dgvColServiceDiscount
            // 
            this.dgvColServiceDiscount.HeaderText = "Discount";
            this.dgvColServiceDiscount.Name = "dgvColServiceDiscount";
            this.dgvColServiceDiscount.ReadOnly = true;
            this.dgvColServiceDiscount.Width = 99;
            // 
            // dgvColVoid
            // 
            this.dgvColVoid.HeaderText = "Void";
            this.dgvColVoid.Name = "dgvColVoid";
            this.dgvColVoid.ReadOnly = true;
            this.dgvColVoid.Width = 50;
            // 
            // pnlDockBottom
            // 
            this.pnlDockBottom.Controls.Add(this.dgvServiceProduct);
            this.pnlDockBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDockBottom.Location = new System.Drawing.Point(3, 304);
            this.pnlDockBottom.Name = "pnlDockBottom";
            this.pnlDockBottom.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlDockBottom.Size = new System.Drawing.Size(683, 142);
            this.pnlDockBottom.TabIndex = 17;
            // 
            // dgvServiceProduct
            // 
            this.dgvServiceProduct.AllowUserToAddRows = false;
            this.dgvServiceProduct.AllowUserToDeleteRows = false;
            this.dgvServiceProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServiceProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColProduct,
            this.dgvColProductPrice,
            this.dgvColProductDiscount,
            this.dgvColQuantity,
            this.dgvColProductSubtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiceProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvServiceProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceProduct.Name = "dgvServiceProduct";
            this.dgvServiceProduct.ReadOnly = true;
            this.dgvServiceProduct.RowHeadersVisible = false;
            this.dgvServiceProduct.Size = new System.Drawing.Size(683, 132);
            this.dgvServiceProduct.TabIndex = 3;
            // 
            // dgvColProduct
            // 
            this.dgvColProduct.HeaderText = "Product";
            this.dgvColProduct.Name = "dgvColProduct";
            this.dgvColProduct.ReadOnly = true;
            this.dgvColProduct.Width = 93;
            // 
            // dgvColProductPrice
            // 
            this.dgvColProductPrice.HeaderText = "Price";
            this.dgvColProductPrice.Name = "dgvColProductPrice";
            this.dgvColProductPrice.ReadOnly = true;
            this.dgvColProductPrice.Width = 71;
            // 
            // dgvColProductDiscount
            // 
            this.dgvColProductDiscount.HeaderText = "Discount";
            this.dgvColProductDiscount.Name = "dgvColProductDiscount";
            this.dgvColProductDiscount.ReadOnly = true;
            this.dgvColProductDiscount.Width = 99;
            // 
            // dgvColQuantity
            // 
            this.dgvColQuantity.HeaderText = "Quantity";
            this.dgvColQuantity.Name = "dgvColQuantity";
            this.dgvColQuantity.ReadOnly = true;
            this.dgvColQuantity.Width = 97;
            // 
            // dgvColProductSubtotal
            // 
            this.dgvColProductSubtotal.HeaderText = "Subtotal";
            this.dgvColProductSubtotal.Name = "dgvColProductSubtotal";
            this.dgvColProductSubtotal.ReadOnly = true;
            this.dgvColProductSubtotal.Width = 97;
            // 
            // pnlDetailTop
            // 
            this.pnlDetailTop.Controls.Add(this.lblVehicle);
            this.pnlDetailTop.Controls.Add(this.txtCurrentKm);
            this.pnlDetailTop.Controls.Add(this.lblVehicleBrand);
            this.pnlDetailTop.Controls.Add(this.lblCurrentKm);
            this.pnlDetailTop.Controls.Add(this.txtVehicleBrand);
            this.pnlDetailTop.Controls.Add(this.txtVehicleColor);
            this.pnlDetailTop.Controls.Add(this.lblVehicleModel);
            this.pnlDetailTop.Controls.Add(this.lblVehicleColor);
            this.pnlDetailTop.Controls.Add(this.txtVehicleModel);
            this.pnlDetailTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetailTop.Location = new System.Drawing.Point(3, 25);
            this.pnlDetailTop.Name = "pnlDetailTop";
            this.pnlDetailTop.Size = new System.Drawing.Size(683, 142);
            this.pnlDetailTop.TabIndex = 15;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblVehicle.Location = new System.Drawing.Point(3, 15);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(243, 21);
            this.lblVehicle.TabIndex = 5;
            this.lblVehicle.Text = "[Vehicle Registration Number]";
            // 
            // txtCurrentKm
            // 
            this.txtCurrentKm.Location = new System.Drawing.Point(436, 93);
            this.txtCurrentKm.Name = "txtCurrentKm";
            this.txtCurrentKm.ReadOnly = true;
            this.txtCurrentKm.Size = new System.Drawing.Size(231, 29);
            this.txtCurrentKm.TabIndex = 14;
            // 
            // lblVehicleBrand
            // 
            this.lblVehicleBrand.AutoSize = true;
            this.lblVehicleBrand.Location = new System.Drawing.Point(8, 61);
            this.lblVehicleBrand.Name = "lblVehicleBrand";
            this.lblVehicleBrand.Size = new System.Drawing.Size(57, 21);
            this.lblVehicleBrand.TabIndex = 7;
            this.lblVehicleBrand.Text = "Brand:";
            // 
            // lblCurrentKm
            // 
            this.lblCurrentKm.AutoSize = true;
            this.lblCurrentKm.Location = new System.Drawing.Point(332, 96);
            this.lblCurrentKm.Name = "lblCurrentKm";
            this.lblCurrentKm.Size = new System.Drawing.Size(98, 21);
            this.lblCurrentKm.TabIndex = 13;
            this.lblCurrentKm.Text = "Current KM:";
            // 
            // txtVehicleBrand
            // 
            this.txtVehicleBrand.Location = new System.Drawing.Point(71, 58);
            this.txtVehicleBrand.Name = "txtVehicleBrand";
            this.txtVehicleBrand.ReadOnly = true;
            this.txtVehicleBrand.Size = new System.Drawing.Size(231, 29);
            this.txtVehicleBrand.TabIndex = 8;
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Location = new System.Drawing.Point(71, 93);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.ReadOnly = true;
            this.txtVehicleColor.Size = new System.Drawing.Size(231, 29);
            this.txtVehicleColor.TabIndex = 12;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Location = new System.Drawing.Point(332, 61);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(62, 21);
            this.lblVehicleModel.TabIndex = 9;
            this.lblVehicleModel.Text = "Model:";
            // 
            // lblVehicleColor
            // 
            this.lblVehicleColor.AutoSize = true;
            this.lblVehicleColor.Location = new System.Drawing.Point(8, 96);
            this.lblVehicleColor.Name = "lblVehicleColor";
            this.lblVehicleColor.Size = new System.Drawing.Size(54, 21);
            this.lblVehicleColor.TabIndex = 11;
            this.lblVehicleColor.Text = "Color:";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Location = new System.Drawing.Point(436, 58);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.ReadOnly = true;
            this.txtVehicleModel.Size = new System.Drawing.Size(231, 29);
            this.txtVehicleModel.TabIndex = 10;
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(119, 96);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.ReadOnly = true;
            this.txtCellphone.Size = new System.Drawing.Size(231, 29);
            this.txtCellphone.TabIndex = 6;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(7, 99);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(88, 21);
            this.lblCellphone.TabIndex = 5;
            this.lblCellphone.Text = "Cellphone:";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(119, 61);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(434, 29);
            this.txtFullname.TabIndex = 4;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(7, 64);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(79, 21);
            this.lblFullname.TabIndex = 3;
            this.lblFullname.Text = "Fullname:";
            // 
            // pnlRightTopTop
            // 
            this.pnlRightTopTop.Controls.Add(this.lblCustomerCode);
            this.pnlRightTopTop.Controls.Add(this.pboxMaskot);
            this.pnlRightTopTop.Controls.Add(this.pboxLogo);
            this.pnlRightTopTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTopTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTopTop.Name = "pnlRightTopTop";
            this.pnlRightTopTop.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlRightTopTop.Size = new System.Drawing.Size(711, 55);
            this.pnlRightTopTop.TabIndex = 2;
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblCustomerCode.Location = new System.Drawing.Point(5, 11);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(394, 30);
            this.lblCustomerCode.TabIndex = 2;
            this.lblCustomerCode.Text = "[Customer Code - Membership Status]";
            // 
            // pboxMaskot
            // 
            this.pboxMaskot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxMaskot.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.MAI_Maskot;
            this.pboxMaskot.Location = new System.Drawing.Point(415, 5);
            this.pboxMaskot.Name = "pboxMaskot";
            this.pboxMaskot.Size = new System.Drawing.Size(72, 45);
            this.pboxMaskot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMaskot.TabIndex = 1;
            this.pboxMaskot.TabStop = false;
            this.pboxMaskot.Visible = false;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxLogo.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.MAI_Logo;
            this.pboxLogo.Location = new System.Drawing.Point(487, 5);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(224, 45);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            this.pnlRightTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightTop.Controls.Add(this.lblServiceCode);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRightTop.ForeColor = System.Drawing.Color.White;
            this.pnlRightTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(713, 51);
            this.pnlRightTop.TabIndex = 0;
            // 
            // lblServiceCode
            // 
            this.lblServiceCode.AutoSize = true;
            this.lblServiceCode.Location = new System.Drawing.Point(6, 12);
            this.lblServiceCode.Name = "lblServiceCode";
            this.lblServiceCode.Size = new System.Drawing.Size(301, 25);
            this.lblServiceCode.TabIndex = 0;
            this.lblServiceCode.Text = "[Service Code - Customer Name]";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 708);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(1330, 19);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Logged in user:";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainActionPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.mainActionPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.pnlRightBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingServices)).EndInit();
            this.mainPanelTop.ResumeLayout(false);
            this.mainPanelTop.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.pnlRightFill.ResumeLayout(false);
            this.pnlRightFill.PerformLayout();
            this.gbxServiceData.ResumeLayout(false);
            this.pnlDockFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceItem)).EndInit();
            this.pnlDockBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceProduct)).EndInit();
            this.pnlDetailTop.ResumeLayout(false);
            this.pnlDetailTop.PerformLayout();
            this.pnlRightTopTop.ResumeLayout(false);
            this.pnlRightTopTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaskot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainActionPanel;
        private System.Windows.Forms.Button btnRedeemPoint;
        private System.Windows.Forms.Button btnNewServiceOrder;
        private System.Windows.Forms.Panel mainPanel;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPendingServices;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel mainPanelTop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPurchaseProduct;
        private System.Windows.Forms.Button btnServiceBooking;
        private System.Windows.Forms.Panel pnlRightFill;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.Label lblServiceCode;
        private System.Windows.Forms.Panel pnlRightTopTop;
        private System.Windows.Forms.PictureBox pboxMaskot;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.GroupBox gbxServiceData;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox txtVehicleBrand;
        private System.Windows.Forms.Label lblVehicleBrand;
        private System.Windows.Forms.TextBox txtVehicleColor;
        private System.Windows.Forms.Label lblVehicleColor;
        private System.Windows.Forms.TextBox txtCurrentKm;
        private System.Windows.Forms.Label lblCurrentKm;
        private System.Windows.Forms.Panel pnlDockFill;
        private System.Windows.Forms.Panel pnlDockBottom;
        private System.Windows.Forms.Panel pnlDetailTop;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvServiceItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvServiceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColServiceDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn dgvColVoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductSubtotal;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel pnlRightBottom;
        private System.Windows.Forms.Button btnPay;
    }
}