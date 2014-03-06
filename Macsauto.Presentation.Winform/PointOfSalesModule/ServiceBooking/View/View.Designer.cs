namespace Macsauto.Presentation.WinForm.PointOfSalesModule.ServiceBooking
{
    partial class View
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dgvPendingBookings = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColBookingDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanelTop = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
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
            this.lblBookingCode = new System.Windows.Forms.Label();
            this.pnlInformationBottomMost = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingBookings)).BeginInit();
            this.mainPanelTop.SuspendLayout();
            this.actionPanel.SuspendLayout();
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
            this.pnlInformationBottomMost.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.dgvPendingBookings);
            this.mainPanel.Controls.Add(this.mainPanelTop);
            this.mainPanel.Controls.Add(this.actionPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(637, 730);
            this.mainPanel.TabIndex = 6;
            // 
            // dgvPendingBookings
            // 
            this.dgvPendingBookings.AllowUserToAddRows = false;
            this.dgvPendingBookings.AllowUserToDeleteRows = false;
            this.dgvPendingBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPendingBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvPendingBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColId,
            this.dgvColCode,
            this.dgvColCustomer,
            this.dgvColCellphone,
            this.dgvColBookingDueDate,
            this.dgvColCreatedOn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingBookings.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPendingBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendingBookings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPendingBookings.Location = new System.Drawing.Point(0, 50);
            this.dgvPendingBookings.Name = "dgvPendingBookings";
            this.dgvPendingBookings.ReadOnly = true;
            this.dgvPendingBookings.RowHeadersVisible = false;
            this.dgvPendingBookings.Size = new System.Drawing.Size(635, 627);
            this.dgvPendingBookings.TabIndex = 1;
            // 
            // dgvColId
            // 
            this.dgvColId.HeaderText = "Id";
            this.dgvColId.Name = "dgvColId";
            this.dgvColId.ReadOnly = true;
            this.dgvColId.Visible = false;
            this.dgvColId.Width = 29;
            // 
            // dgvColCode
            // 
            this.dgvColCode.HeaderText = "Service Booking";
            this.dgvColCode.Name = "dgvColCode";
            this.dgvColCode.ReadOnly = true;
            this.dgvColCode.Width = 146;
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
            // dgvColBookingDueDate
            // 
            this.dgvColBookingDueDate.HeaderText = "Due Date";
            this.dgvColBookingDueDate.Name = "dgvColBookingDueDate";
            this.dgvColBookingDueDate.ReadOnly = true;
            this.dgvColBookingDueDate.Width = 99;
            // 
            // dgvColCreatedOn
            // 
            this.dgvColCreatedOn.HeaderText = "Booked On";
            this.dgvColCreatedOn.Name = "dgvColCreatedOn";
            this.dgvColCreatedOn.ReadOnly = true;
            this.dgvColCreatedOn.Width = 112;
            // 
            // mainPanelTop
            // 
            this.mainPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.mainPanelTop.Controls.Add(this.btnClear);
            this.mainPanelTop.Controls.Add(this.txtSearch);
            this.mainPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanelTop.Location = new System.Drawing.Point(0, 0);
            this.mainPanelTop.Name = "mainPanelTop";
            this.mainPanelTop.Size = new System.Drawing.Size(635, 50);
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
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(17)))));
            this.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionPanel.Controls.Add(this.btnCheckout);
            this.actionPanel.Controls.Add(this.btnNew);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 677);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(635, 51);
            this.actionPanel.TabIndex = 3;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.btnCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(0, 0);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(462, 49);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(462, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(171, 49);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Create New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.rightPanel.Size = new System.Drawing.Size(713, 730);
            this.rightPanel.TabIndex = 7;
            // 
            // pnlRightFill
            // 
            this.pnlRightFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(17)))));
            this.pnlRightFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightFill.Controls.Add(this.pnlInformationBottomMost);
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
            this.pnlRightFill.Size = new System.Drawing.Size(713, 679);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceItem.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiceProduct.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.pnlRightTop.Controls.Add(this.lblBookingCode);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRightTop.ForeColor = System.Drawing.Color.White;
            this.pnlRightTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(713, 51);
            this.pnlRightTop.TabIndex = 0;
            // 
            // lblBookingCode
            // 
            this.lblBookingCode.AutoSize = true;
            this.lblBookingCode.Location = new System.Drawing.Point(6, 12);
            this.lblBookingCode.Name = "lblBookingCode";
            this.lblBookingCode.Size = new System.Drawing.Size(314, 25);
            this.lblBookingCode.TabIndex = 0;
            this.lblBookingCode.Text = "[Booking Code - Customer Name]";
            // 
            // pnlInformationBottomMost
            // 
            this.pnlInformationBottomMost.Controls.Add(this.btnClose);
            this.pnlInformationBottomMost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInformationBottomMost.Location = new System.Drawing.Point(0, 626);
            this.pnlInformationBottomMost.Name = "pnlInformationBottomMost";
            this.pnlInformationBottomMost.Size = new System.Drawing.Size(711, 51);
            this.pnlInformationBottomMost.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(711, 51);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.rightPanel);
            this.Name = "View";
            this.Text = "Service Booking - View";
            this.Load += new System.EventHandler(this.View_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingBookings)).EndInit();
            this.mainPanelTop.ResumeLayout(false);
            this.mainPanelTop.PerformLayout();
            this.actionPanel.ResumeLayout(false);
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
            this.pnlInformationBottomMost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPendingBookings;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColBookingDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCreatedOn;
        private System.Windows.Forms.Panel mainPanelTop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel pnlRightFill;
        private System.Windows.Forms.GroupBox gbxServiceData;
        private System.Windows.Forms.Panel pnlDockFill;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvServiceItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColServiceDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn dgvColVoid;
        private System.Windows.Forms.Panel pnlDockBottom;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvServiceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColProductSubtotal;
        private System.Windows.Forms.Panel pnlDetailTop;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.TextBox txtCurrentKm;
        private System.Windows.Forms.Label lblVehicleBrand;
        private System.Windows.Forms.Label lblCurrentKm;
        private System.Windows.Forms.TextBox txtVehicleBrand;
        private System.Windows.Forms.TextBox txtVehicleColor;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.Label lblVehicleColor;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Panel pnlRightTopTop;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.PictureBox pboxMaskot;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.Label lblBookingCode;
        private System.Windows.Forms.Panel pnlInformationBottomMost;
        private System.Windows.Forms.Button btnClose;

    }
}