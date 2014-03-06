namespace Macsauto.Presentation.WinForm.PointOfSalesModule.Customer
{
    partial class Select
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
            this.dgvCustomers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomerCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCustomerMembershipStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInformationBasic = new System.Windows.Forms.Panel();
            this.lblMemberStatus = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTotalPoints = new System.Windows.Forms.TextBox();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.dtpMemberSince = new System.Windows.Forms.DateTimePicker();
            this.dgvColMembershipTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColMembershipTransactionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColMembershipTransactionPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColMembershipTransactionSubtotalPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMemberSince = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.pboxMaskot = new System.Windows.Forms.PictureBox();
            this.pnlInformationTopMost = new System.Windows.Forms.Panel();
            this.btnBackToDashboard = new System.Windows.Forms.Button();
            this.pnlInformationAction = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInformationTop = new System.Windows.Forms.Panel();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.dgvColMembershipTransactionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColMembershipTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColMembershipTransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.pnlInformationFill = new System.Windows.Forms.Panel();
            this.gbxVehicleInformation = new System.Windows.Forms.GroupBox();
            this.lblMotor = new System.Windows.Forms.Label();
            this.txtTotalMotor = new System.Windows.Forms.TextBox();
            this.lblCars = new System.Windows.Forms.Label();
            this.dgvVehicles = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColVehicleBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColVehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColVehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColVehicleColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCurrentKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalCar = new System.Windows.Forms.TextBox();
            this.lblTotalRegisteredVehicles = new System.Windows.Forms.Label();
            this.gbxMembershipData = new System.Windows.Forms.GroupBox();
            this.dgvMemberTransactionHistory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cboMemberStatus = new System.Windows.Forms.ComboBox();
            this.mainPanelTop = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlInformationBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaskot)).BeginInit();
            this.pnlInformationTopMost.SuspendLayout();
            this.pnlInformationTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.informationPanel.SuspendLayout();
            this.pnlInformationFill.SuspendLayout();
            this.gbxVehicleInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.gbxMembershipData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberTransactionHistory)).BeginInit();
            this.mainPanelTop.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCustomerId,
            this.dgvColCustomerName,
            this.dgvColCustomerCellphone,
            this.dgvColCustomerMembershipStatus});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCustomers.Location = new System.Drawing.Point(0, 51);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.Size = new System.Drawing.Size(1370, 699);
            this.dgvCustomers.TabIndex = 2;
            // 
            // dgvColCustomerId
            // 
            this.dgvColCustomerId.HeaderText = "Id";
            this.dgvColCustomerId.Name = "dgvColCustomerId";
            this.dgvColCustomerId.ReadOnly = true;
            this.dgvColCustomerId.Visible = false;
            this.dgvColCustomerId.Width = 22;
            // 
            // dgvColCustomerName
            // 
            this.dgvColCustomerName.HeaderText = "Name";
            this.dgvColCustomerName.Name = "dgvColCustomerName";
            this.dgvColCustomerName.ReadOnly = true;
            this.dgvColCustomerName.Width = 78;
            // 
            // dgvColCustomerCellphone
            // 
            this.dgvColCustomerCellphone.HeaderText = "Cellphone";
            this.dgvColCustomerCellphone.Name = "dgvColCustomerCellphone";
            this.dgvColCustomerCellphone.ReadOnly = true;
            this.dgvColCustomerCellphone.Width = 109;
            // 
            // dgvColCustomerMembershipStatus
            // 
            this.dgvColCustomerMembershipStatus.HeaderText = "Membership Status";
            this.dgvColCustomerMembershipStatus.Name = "dgvColCustomerMembershipStatus";
            this.dgvColCustomerMembershipStatus.ReadOnly = true;
            this.dgvColCustomerMembershipStatus.Width = 161;
            // 
            // pnlInformationBasic
            // 
            this.pnlInformationBasic.Controls.Add(this.lblMemberStatus);
            this.pnlInformationBasic.Controls.Add(this.lblFullname);
            this.pnlInformationBasic.Controls.Add(this.txtFullname);
            this.pnlInformationBasic.Controls.Add(this.txtEmail);
            this.pnlInformationBasic.Controls.Add(this.lblCellphone);
            this.pnlInformationBasic.Controls.Add(this.lblEmail);
            this.pnlInformationBasic.Controls.Add(this.txtCellphone);
            this.pnlInformationBasic.Controls.Add(this.txtPhone);
            this.pnlInformationBasic.Controls.Add(this.lblAddress);
            this.pnlInformationBasic.Controls.Add(this.lblPhone);
            this.pnlInformationBasic.Controls.Add(this.txtAddress);
            this.pnlInformationBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformationBasic.Location = new System.Drawing.Point(0, 0);
            this.pnlInformationBasic.Name = "pnlInformationBasic";
            this.pnlInformationBasic.Size = new System.Drawing.Size(773, 150);
            this.pnlInformationBasic.TabIndex = 20;
            // 
            // lblMemberStatus
            // 
            this.lblMemberStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberStatus.AutoSize = true;
            this.lblMemberStatus.Location = new System.Drawing.Point(582, 10);
            this.lblMemberStatus.Name = "lblMemberStatus";
            this.lblMemberStatus.Size = new System.Drawing.Size(162, 21);
            this.lblMemberStatus.TabIndex = 20;
            this.lblMemberStatus.Text = "[Membership Status]";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(12, 10);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(79, 21);
            this.lblFullname.TabIndex = 8;
            this.lblFullname.Text = "Fullname:";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(106, 7);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(306, 29);
            this.txtFullname.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(513, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(231, 29);
            this.txtEmail.TabIndex = 18;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(12, 45);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(88, 21);
            this.lblCellphone.TabIndex = 10;
            this.lblCellphone.Text = "Cellphone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(438, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 21);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(106, 42);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.ReadOnly = true;
            this.txtCellphone.Size = new System.Drawing.Size(231, 29);
            this.txtCellphone.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(513, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(231, 29);
            this.txtPhone.TabIndex = 16;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 80);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 21);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(438, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 21);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 77);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(306, 62);
            this.txtAddress.TabIndex = 13;
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.Location = new System.Drawing.Point(664, 36);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.ReadOnly = true;
            this.txtTotalPoints.Size = new System.Drawing.Size(92, 29);
            this.txtTotalPoints.TabIndex = 20;
            this.txtTotalPoints.Text = "0";
            this.txtTotalPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Location = new System.Drawing.Point(557, 40);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(101, 21);
            this.lblTotalPoints.TabIndex = 19;
            this.lblTotalPoints.Text = "Total points:";
            // 
            // dtpMemberSince
            // 
            this.dtpMemberSince.Location = new System.Drawing.Point(136, 35);
            this.dtpMemberSince.Name = "dtpMemberSince";
            this.dtpMemberSince.Size = new System.Drawing.Size(241, 29);
            this.dtpMemberSince.TabIndex = 14;
            // 
            // dgvColMembershipTransactionDate
            // 
            this.dgvColMembershipTransactionDate.HeaderText = "Date";
            this.dgvColMembershipTransactionDate.Name = "dgvColMembershipTransactionDate";
            this.dgvColMembershipTransactionDate.ReadOnly = true;
            this.dgvColMembershipTransactionDate.Width = 69;
            // 
            // dgvColMembershipTransactionTotal
            // 
            this.dgvColMembershipTransactionTotal.HeaderText = "Total";
            this.dgvColMembershipTransactionTotal.Name = "dgvColMembershipTransactionTotal";
            this.dgvColMembershipTransactionTotal.ReadOnly = true;
            this.dgvColMembershipTransactionTotal.Width = 72;
            // 
            // dgvColMembershipTransactionPoints
            // 
            this.dgvColMembershipTransactionPoints.HeaderText = "Points";
            this.dgvColMembershipTransactionPoints.Name = "dgvColMembershipTransactionPoints";
            this.dgvColMembershipTransactionPoints.ReadOnly = true;
            this.dgvColMembershipTransactionPoints.Width = 80;
            // 
            // dgvColMembershipTransactionSubtotalPoints
            // 
            this.dgvColMembershipTransactionSubtotalPoints.HeaderText = "Subtotal Points";
            this.dgvColMembershipTransactionSubtotalPoints.Name = "dgvColMembershipTransactionSubtotalPoints";
            this.dgvColMembershipTransactionSubtotalPoints.ReadOnly = true;
            this.dgvColMembershipTransactionSubtotalPoints.Width = 146;
            // 
            // lblMemberSince
            // 
            this.lblMemberSince.AutoSize = true;
            this.lblMemberSince.Location = new System.Drawing.Point(12, 39);
            this.lblMemberSince.Name = "lblMemberSince";
            this.lblMemberSince.Size = new System.Drawing.Size(118, 21);
            this.lblMemberSince.TabIndex = 12;
            this.lblMemberSince.Text = "Member since:";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lblCustomerCode.Location = new System.Drawing.Point(5, 11);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(181, 30);
            this.lblCustomerCode.TabIndex = 2;
            this.lblCustomerCode.Text = "[Customer Code]";
            // 
            // pboxMaskot
            // 
            this.pboxMaskot.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxMaskot.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.MAI_Maskot;
            this.pboxMaskot.Location = new System.Drawing.Point(477, 5);
            this.pboxMaskot.Name = "pboxMaskot";
            this.pboxMaskot.Size = new System.Drawing.Size(72, 41);
            this.pboxMaskot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMaskot.TabIndex = 1;
            this.pboxMaskot.TabStop = false;
            this.pboxMaskot.Visible = false;
            // 
            // pnlInformationTopMost
            // 
            this.pnlInformationTopMost.Controls.Add(this.btnBackToDashboard);
            this.pnlInformationTopMost.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformationTopMost.Location = new System.Drawing.Point(0, 0);
            this.pnlInformationTopMost.Name = "pnlInformationTopMost";
            this.pnlInformationTopMost.Size = new System.Drawing.Size(773, 51);
            this.pnlInformationTopMost.TabIndex = 6;
            // 
            // btnBackToDashboard
            // 
            this.btnBackToDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            this.btnBackToDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackToDashboard.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnBackToDashboard.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDashboard.ForeColor = System.Drawing.Color.White;
            this.btnBackToDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(773, 51);
            this.btnBackToDashboard.TabIndex = 3;
            this.btnBackToDashboard.Text = "Back To Dashboard";
            this.btnBackToDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackToDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlInformationAction
            // 
            this.pnlInformationAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInformationAction.Location = new System.Drawing.Point(0, 597);
            this.pnlInformationAction.Name = "pnlInformationAction";
            this.pnlInformationAction.Size = new System.Drawing.Size(773, 51);
            this.pnlInformationAction.TabIndex = 22;
            // 
            // pnlInformationTop
            // 
            this.pnlInformationTop.Controls.Add(this.lblCustomerCode);
            this.pnlInformationTop.Controls.Add(this.pboxMaskot);
            this.pnlInformationTop.Controls.Add(this.pboxLogo);
            this.pnlInformationTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformationTop.Location = new System.Drawing.Point(0, 51);
            this.pnlInformationTop.Name = "pnlInformationTop";
            this.pnlInformationTop.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.pnlInformationTop.Size = new System.Drawing.Size(773, 51);
            this.pnlInformationTop.TabIndex = 3;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pboxLogo.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.MAI_Logo;
            this.pboxLogo.Location = new System.Drawing.Point(549, 5);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(224, 41);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // dgvColMembershipTransactionCode
            // 
            this.dgvColMembershipTransactionCode.HeaderText = "Code";
            this.dgvColMembershipTransactionCode.Name = "dgvColMembershipTransactionCode";
            this.dgvColMembershipTransactionCode.ReadOnly = true;
            this.dgvColMembershipTransactionCode.Width = 74;
            // 
            // dgvColMembershipTransactionType
            // 
            this.dgvColMembershipTransactionType.HeaderText = "Transaction";
            this.dgvColMembershipTransactionType.Name = "dgvColMembershipTransactionType";
            this.dgvColMembershipTransactionType.ReadOnly = true;
            this.dgvColMembershipTransactionType.Width = 119;
            // 
            // dgvColMembershipTransactionId
            // 
            this.dgvColMembershipTransactionId.HeaderText = "Id";
            this.dgvColMembershipTransactionId.Name = "dgvColMembershipTransactionId";
            this.dgvColMembershipTransactionId.ReadOnly = true;
            this.dgvColMembershipTransactionId.Visible = false;
            this.dgvColMembershipTransactionId.Width = 22;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(464, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(175, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // informationPanel
            // 
            this.informationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(17)))));
            this.informationPanel.Controls.Add(this.pnlInformationFill);
            this.informationPanel.Controls.Add(this.pnlInformationTop);
            this.informationPanel.Controls.Add(this.pnlInformationTopMost);
            this.informationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.informationPanel.Location = new System.Drawing.Point(597, 0);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(773, 750);
            this.informationPanel.TabIndex = 2;
            // 
            // pnlInformationFill
            // 
            this.pnlInformationFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(190)))), ((int)(((byte)(17)))));
            this.pnlInformationFill.Controls.Add(this.pnlInformationAction);
            this.pnlInformationFill.Controls.Add(this.gbxVehicleInformation);
            this.pnlInformationFill.Controls.Add(this.gbxMembershipData);
            this.pnlInformationFill.Controls.Add(this.pnlInformationBasic);
            this.pnlInformationFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformationFill.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.pnlInformationFill.Location = new System.Drawing.Point(0, 102);
            this.pnlInformationFill.Name = "pnlInformationFill";
            this.pnlInformationFill.Size = new System.Drawing.Size(773, 648);
            this.pnlInformationFill.TabIndex = 5;
            // 
            // gbxVehicleInformation
            // 
            this.gbxVehicleInformation.Controls.Add(this.lblMotor);
            this.gbxVehicleInformation.Controls.Add(this.txtTotalMotor);
            this.gbxVehicleInformation.Controls.Add(this.lblCars);
            this.gbxVehicleInformation.Controls.Add(this.dgvVehicles);
            this.gbxVehicleInformation.Controls.Add(this.txtTotalCar);
            this.gbxVehicleInformation.Controls.Add(this.lblTotalRegisteredVehicles);
            this.gbxVehicleInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxVehicleInformation.Location = new System.Drawing.Point(0, 381);
            this.gbxVehicleInformation.Name = "gbxVehicleInformation";
            this.gbxVehicleInformation.Size = new System.Drawing.Size(773, 225);
            this.gbxVehicleInformation.TabIndex = 21;
            this.gbxVehicleInformation.TabStop = false;
            this.gbxVehicleInformation.Text = "Vehicle Information";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(660, 39);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(101, 21);
            this.lblMotor.TabIndex = 24;
            this.lblMotor.Text = "Motorcycles";
            // 
            // txtTotalMotor
            // 
            this.txtTotalMotor.Location = new System.Drawing.Point(562, 36);
            this.txtTotalMotor.Name = "txtTotalMotor";
            this.txtTotalMotor.ReadOnly = true;
            this.txtTotalMotor.Size = new System.Drawing.Size(92, 29);
            this.txtTotalMotor.TabIndex = 23;
            this.txtTotalMotor.Text = "0";
            this.txtTotalMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Location = new System.Drawing.Point(485, 39);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(41, 21);
            this.lblCars.TabIndex = 22;
            this.lblCars.Text = "Cars";
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColRegistrationNumber,
            this.dgvColVehicleBrand,
            this.dgvColVehicleModel,
            this.dgvColVehicleType,
            this.dgvColVehicleColor,
            this.dgvColCurrentKm});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvVehicles.Location = new System.Drawing.Point(10, 70);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.Size = new System.Drawing.Size(751, 140);
            this.dgvVehicles.TabIndex = 21;
            // 
            // dgvColRegistrationNumber
            // 
            this.dgvColRegistrationNumber.HeaderText = "Reg. Number";
            this.dgvColRegistrationNumber.Name = "dgvColRegistrationNumber";
            this.dgvColRegistrationNumber.ReadOnly = true;
            this.dgvColRegistrationNumber.Width = 132;
            // 
            // dgvColVehicleBrand
            // 
            this.dgvColVehicleBrand.HeaderText = "Brand";
            this.dgvColVehicleBrand.Name = "dgvColVehicleBrand";
            this.dgvColVehicleBrand.ReadOnly = true;
            this.dgvColVehicleBrand.Width = 78;
            // 
            // dgvColVehicleModel
            // 
            this.dgvColVehicleModel.HeaderText = "Model";
            this.dgvColVehicleModel.Name = "dgvColVehicleModel";
            this.dgvColVehicleModel.ReadOnly = true;
            this.dgvColVehicleModel.Width = 83;
            // 
            // dgvColVehicleType
            // 
            this.dgvColVehicleType.HeaderText = "Type";
            this.dgvColVehicleType.Name = "dgvColVehicleType";
            this.dgvColVehicleType.ReadOnly = true;
            this.dgvColVehicleType.Width = 71;
            // 
            // dgvColVehicleColor
            // 
            this.dgvColVehicleColor.HeaderText = "Color";
            this.dgvColVehicleColor.Name = "dgvColVehicleColor";
            this.dgvColVehicleColor.ReadOnly = true;
            this.dgvColVehicleColor.Width = 75;
            // 
            // dgvColCurrentKm
            // 
            this.dgvColCurrentKm.HeaderText = "Current KM";
            this.dgvColCurrentKm.Name = "dgvColCurrentKm";
            this.dgvColCurrentKm.ReadOnly = true;
            this.dgvColCurrentKm.Width = 119;
            // 
            // txtTotalCar
            // 
            this.txtTotalCar.Location = new System.Drawing.Point(387, 36);
            this.txtTotalCar.Name = "txtTotalCar";
            this.txtTotalCar.ReadOnly = true;
            this.txtTotalCar.Size = new System.Drawing.Size(92, 29);
            this.txtTotalCar.TabIndex = 20;
            this.txtTotalCar.Text = "0";
            this.txtTotalCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalRegisteredVehicles
            // 
            this.lblTotalRegisteredVehicles.AutoSize = true;
            this.lblTotalRegisteredVehicles.Location = new System.Drawing.Point(12, 39);
            this.lblTotalRegisteredVehicles.Name = "lblTotalRegisteredVehicles";
            this.lblTotalRegisteredVehicles.Size = new System.Drawing.Size(193, 21);
            this.lblTotalRegisteredVehicles.TabIndex = 19;
            this.lblTotalRegisteredVehicles.Text = "Total registered vehicles:";
            // 
            // gbxMembershipData
            // 
            this.gbxMembershipData.Controls.Add(this.dgvMemberTransactionHistory);
            this.gbxMembershipData.Controls.Add(this.txtTotalPoints);
            this.gbxMembershipData.Controls.Add(this.lblTotalPoints);
            this.gbxMembershipData.Controls.Add(this.dtpMemberSince);
            this.gbxMembershipData.Controls.Add(this.lblMemberSince);
            this.gbxMembershipData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxMembershipData.Location = new System.Drawing.Point(0, 150);
            this.gbxMembershipData.Name = "gbxMembershipData";
            this.gbxMembershipData.Size = new System.Drawing.Size(773, 231);
            this.gbxMembershipData.TabIndex = 14;
            this.gbxMembershipData.TabStop = false;
            this.gbxMembershipData.Text = "Membership Information";
            this.gbxMembershipData.Visible = false;
            // 
            // dgvMemberTransactionHistory
            // 
            this.dgvMemberTransactionHistory.AllowUserToAddRows = false;
            this.dgvMemberTransactionHistory.AllowUserToDeleteRows = false;
            this.dgvMemberTransactionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMemberTransactionHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvMemberTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberTransactionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColMembershipTransactionId,
            this.dgvColMembershipTransactionType,
            this.dgvColMembershipTransactionCode,
            this.dgvColMembershipTransactionDate,
            this.dgvColMembershipTransactionTotal,
            this.dgvColMembershipTransactionPoints,
            this.dgvColMembershipTransactionSubtotalPoints});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMemberTransactionHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMemberTransactionHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMemberTransactionHistory.Location = new System.Drawing.Point(10, 70);
            this.dgvMemberTransactionHistory.Name = "dgvMemberTransactionHistory";
            this.dgvMemberTransactionHistory.ReadOnly = true;
            this.dgvMemberTransactionHistory.RowHeadersVisible = false;
            this.dgvMemberTransactionHistory.Size = new System.Drawing.Size(751, 148);
            this.dgvMemberTransactionHistory.TabIndex = 21;
            // 
            // cboMemberStatus
            // 
            this.cboMemberStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberStatus.FormattingEnabled = true;
            this.cboMemberStatus.Items.AddRange(new object[] {
            "MEMBER",
            "NON-MEMBER",
            "ALL"});
            this.cboMemberStatus.Location = new System.Drawing.Point(12, 12);
            this.cboMemberStatus.Name = "cboMemberStatus";
            this.cboMemberStatus.Size = new System.Drawing.Size(157, 29);
            this.cboMemberStatus.TabIndex = 4;
            // 
            // mainPanelTop
            // 
            this.mainPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.mainPanelTop.Controls.Add(this.cboMemberStatus);
            this.mainPanelTop.Controls.Add(this.btnClear);
            this.mainPanelTop.Controls.Add(this.txtSearch);
            this.mainPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanelTop.Location = new System.Drawing.Point(0, 0);
            this.mainPanelTop.Name = "mainPanelTop";
            this.mainPanelTop.Size = new System.Drawing.Size(1370, 51);
            this.mainPanelTop.TabIndex = 3;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvCustomers);
            this.mainPanel.Controls.Add(this.mainPanelTop);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1370, 750);
            this.mainPanel.TabIndex = 1;
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.informationPanel);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(66)))), ((int)(((byte)(148)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Select";
            this.Text = "Customer - Select";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlInformationBasic.ResumeLayout(false);
            this.pnlInformationBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMaskot)).EndInit();
            this.pnlInformationTopMost.ResumeLayout(false);
            this.pnlInformationTop.ResumeLayout(false);
            this.pnlInformationTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.informationPanel.ResumeLayout(false);
            this.pnlInformationFill.ResumeLayout(false);
            this.gbxVehicleInformation.ResumeLayout(false);
            this.gbxVehicleInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.gbxMembershipData.ResumeLayout(false);
            this.gbxMembershipData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberTransactionHistory)).EndInit();
            this.mainPanelTop.ResumeLayout(false);
            this.mainPanelTop.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomerCellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCustomerMembershipStatus;
        private System.Windows.Forms.Panel pnlInformationBasic;
        private System.Windows.Forms.Label lblMemberStatus;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTotalPoints;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.DateTimePicker dtpMemberSince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMembershipTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMembershipTransactionTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMembershipTransactionPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMembershipTransactionSubtotalPoints;
        private System.Windows.Forms.Label lblMemberSince;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.PictureBox pboxMaskot;
        private System.Windows.Forms.Panel pnlInformationTopMost;
        private System.Windows.Forms.Button btnBackToDashboard;
        private System.Windows.Forms.FlowLayoutPanel pnlInformationAction;
        private System.Windows.Forms.Panel pnlInformationTop;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMembershipTransactionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMembershipTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColMembershipTransactionId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.Panel pnlInformationFill;
        private System.Windows.Forms.GroupBox gbxVehicleInformation;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.TextBox txtTotalMotor;
        private System.Windows.Forms.Label lblCars;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColRegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColVehicleBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColVehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColVehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColVehicleColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCurrentKm;
        private System.Windows.Forms.TextBox txtTotalCar;
        private System.Windows.Forms.Label lblTotalRegisteredVehicles;
        private System.Windows.Forms.GroupBox gbxMembershipData;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMemberTransactionHistory;
        private System.Windows.Forms.ComboBox cboMemberStatus;
        private System.Windows.Forms.Panel mainPanelTop;
        private System.Windows.Forms.Panel mainPanel;
    }
}