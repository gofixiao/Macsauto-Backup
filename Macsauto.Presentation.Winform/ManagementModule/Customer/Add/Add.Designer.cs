namespace Macsauto.Presentation.WinForm.ManagementModule.Customer
{
    partial class Add
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.detailGeneralPanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.gbxContactInformation = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtHomephone = new System.Windows.Forms.TextBox();
            this.lblHomephone = new System.Windows.Forms.Label();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.gbxBasic = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIsMember = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.chkIsMember = new System.Windows.Forms.CheckBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.gbxAddressInformation = new System.Windows.Forms.GroupBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddressLine = new System.Windows.Forms.TextBox();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.detailVehiclePanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.dgvVehicleInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvVehRegNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCurrentKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtCurrentKM = new System.Windows.Forms.TextBox();
            this.lblCurrentKM = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.detailAddressPanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripReaderStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new Macsauto.Presentation.WinForm.Controls.ButtonStripItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.headerPanel.SuspendLayout();
            this.detailGeneralPanel.SuspendLayout();
            this.gbxContactInformation.SuspendLayout();
            this.gbxBasic.SuspendLayout();
            this.gbxAddressInformation.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.detailVehiclePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleInfo)).BeginInit();
            this.detailAddressPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.headerPanel.Controls.Add(this.txtCode);
            this.headerPanel.Controls.Add(this.lblCode);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 26);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1101, 52);
            this.headerPanel.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(63, 13);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(116, 25);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(15, 16);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(42, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code:";
            // 
            // detailGeneralPanel
            // 
            this.detailGeneralPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailGeneralPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailGeneralPanel.Controls.Add(this.gbxContactInformation);
            this.detailGeneralPanel.Controls.Add(this.gbxBasic);
            this.detailGeneralPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailGeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.detailGeneralPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailGeneralPanel.Name = "detailGeneralPanel";
            this.detailGeneralPanel.Size = new System.Drawing.Size(1101, 265);
            this.detailGeneralPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailGeneralPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailGeneralPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailGeneralPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailGeneralPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailGeneralPanel.Style.GradientAngle = 90;
            this.detailGeneralPanel.TabIndex = 2;
            this.detailGeneralPanel.TitleHeight = 34;
            this.detailGeneralPanel.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailGeneralPanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailGeneralPanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailGeneralPanel.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailGeneralPanel.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailGeneralPanel.TitleStyle.GradientAngle = 90;
            this.detailGeneralPanel.TitleStyle.MarginLeft = 10;
            this.detailGeneralPanel.TitleText = "General";
            // 
            // gbxContactInformation
            // 
            this.gbxContactInformation.BackColor = System.Drawing.Color.White;
            this.gbxContactInformation.Controls.Add(this.txtEmail);
            this.gbxContactInformation.Controls.Add(this.lblEmail);
            this.gbxContactInformation.Controls.Add(this.txtHomephone);
            this.gbxContactInformation.Controls.Add(this.lblHomephone);
            this.gbxContactInformation.Controls.Add(this.lblCellphone);
            this.gbxContactInformation.Controls.Add(this.txtCellphone);
            this.gbxContactInformation.Location = new System.Drawing.Point(416, 47);
            this.gbxContactInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxContactInformation.Name = "gbxContactInformation";
            this.gbxContactInformation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxContactInformation.Size = new System.Drawing.Size(391, 175);
            this.gbxContactInformation.TabIndex = 14;
            this.gbxContactInformation.TabStop = false;
            this.gbxContactInformation.Text = "Contact Information";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 97);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 25);
            this.txtEmail.TabIndex = 24;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(15, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 17);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtHomephone
            // 
            this.txtHomephone.Location = new System.Drawing.Point(122, 64);
            this.txtHomephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomephone.Name = "txtHomephone";
            this.txtHomephone.Size = new System.Drawing.Size(245, 25);
            this.txtHomephone.TabIndex = 14;
            // 
            // lblHomephone
            // 
            this.lblHomephone.AutoSize = true;
            this.lblHomephone.BackColor = System.Drawing.Color.White;
            this.lblHomephone.Location = new System.Drawing.Point(15, 67);
            this.lblHomephone.Name = "lblHomephone";
            this.lblHomephone.Size = new System.Drawing.Size(83, 17);
            this.lblHomephone.TabIndex = 16;
            this.lblHomephone.Text = "Homephone:";
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.BackColor = System.Drawing.Color.White;
            this.lblCellphone.Location = new System.Drawing.Point(15, 34);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(69, 17);
            this.lblCellphone.TabIndex = 13;
            this.lblCellphone.Text = "Cellphone:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(122, 31);
            this.txtCellphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(245, 25);
            this.txtCellphone.TabIndex = 14;
            // 
            // gbxBasic
            // 
            this.gbxBasic.BackColor = System.Drawing.Color.White;
            this.gbxBasic.Controls.Add(this.radFemale);
            this.gbxBasic.Controls.Add(this.radMale);
            this.gbxBasic.Controls.Add(this.label4);
            this.gbxBasic.Controls.Add(this.lblIsMember);
            this.gbxBasic.Controls.Add(this.lblFirstname);
            this.gbxBasic.Controls.Add(this.chkIsMember);
            this.gbxBasic.Controls.Add(this.txtFirstname);
            this.gbxBasic.Controls.Add(this.label1);
            this.gbxBasic.Controls.Add(this.txtMiddlename);
            this.gbxBasic.Controls.Add(this.txtLastname);
            this.gbxBasic.Controls.Add(this.lblLastname);
            this.gbxBasic.Location = new System.Drawing.Point(19, 47);
            this.gbxBasic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxBasic.Name = "gbxBasic";
            this.gbxBasic.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxBasic.Size = new System.Drawing.Size(391, 210);
            this.gbxBasic.TabIndex = 13;
            this.gbxBasic.TabStop = false;
            this.gbxBasic.Text = "Basic Information";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(183, 131);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(67, 21);
            this.radFemale.TabIndex = 23;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(122, 131);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(55, 21);
            this.radMale.TabIndex = 22;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gender:";
            // 
            // lblIsMember
            // 
            this.lblIsMember.AutoSize = true;
            this.lblIsMember.BackColor = System.Drawing.Color.White;
            this.lblIsMember.Location = new System.Drawing.Point(15, 162);
            this.lblIsMember.Name = "lblIsMember";
            this.lblIsMember.Size = new System.Drawing.Size(84, 17);
            this.lblIsMember.TabIndex = 12;
            this.lblIsMember.Text = "Is a member:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.BackColor = System.Drawing.Color.White;
            this.lblFirstname.Location = new System.Drawing.Point(15, 34);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(67, 17);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "Firstname:";
            // 
            // chkIsMember
            // 
            this.chkIsMember.AutoSize = true;
            this.chkIsMember.BackColor = System.Drawing.Color.White;
            this.chkIsMember.Location = new System.Drawing.Point(122, 164);
            this.chkIsMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIsMember.Name = "chkIsMember";
            this.chkIsMember.Size = new System.Drawing.Size(15, 14);
            this.chkIsMember.TabIndex = 10;
            this.chkIsMember.UseVisualStyleBackColor = false;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(122, 31);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(245, 25);
            this.txtFirstname.TabIndex = 3;
            this.superValidator.SetValidator1(this.txtFirstname, this.requiredFieldValidator1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Middlename:";
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(122, 64);
            this.txtMiddlename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(245, 25);
            this.txtMiddlename.TabIndex = 5;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(122, 97);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(245, 25);
            this.txtLastname.TabIndex = 7;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.White;
            this.lblLastname.Location = new System.Drawing.Point(15, 100);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(66, 17);
            this.lblLastname.TabIndex = 6;
            this.lblLastname.Text = "Lastname:";
            // 
            // gbxAddressInformation
            // 
            this.gbxAddressInformation.BackColor = System.Drawing.Color.White;
            this.gbxAddressInformation.Controls.Add(this.txtZipcode);
            this.gbxAddressInformation.Controls.Add(this.lblZipcode);
            this.gbxAddressInformation.Controls.Add(this.lblProvince);
            this.gbxAddressInformation.Controls.Add(this.cboProvince);
            this.gbxAddressInformation.Controls.Add(this.lblCity);
            this.gbxAddressInformation.Controls.Add(this.cboCity);
            this.gbxAddressInformation.Controls.Add(this.lblAddress);
            this.gbxAddressInformation.Controls.Add(this.txtAddressLine);
            this.gbxAddressInformation.Location = new System.Drawing.Point(19, 47);
            this.gbxAddressInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAddressInformation.Name = "gbxAddressInformation";
            this.gbxAddressInformation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxAddressInformation.Size = new System.Drawing.Size(532, 174);
            this.gbxAddressInformation.TabIndex = 14;
            this.gbxAddressInformation.TabStop = false;
            this.gbxAddressInformation.Text = "Address Information";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(122, 130);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(128, 25);
            this.txtZipcode.TabIndex = 14;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.BackColor = System.Drawing.Color.White;
            this.lblZipcode.Location = new System.Drawing.Point(15, 133);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(58, 17);
            this.lblZipcode.TabIndex = 13;
            this.lblZipcode.Text = "Zipcode:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.BackColor = System.Drawing.Color.White;
            this.lblProvince.Location = new System.Drawing.Point(15, 67);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(60, 17);
            this.lblProvince.TabIndex = 18;
            this.lblProvince.Text = "Province:";
            // 
            // cboProvince
            // 
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(122, 64);
            this.cboProvince.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(245, 25);
            this.cboProvince.TabIndex = 17;
            this.cboProvince.SelectedIndexChanged += new System.EventHandler(this.cboProvince_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(15, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 17);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City:";
            // 
            // cboCity
            // 
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(122, 97);
            this.cboCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(245, 25);
            this.cboCity.TabIndex = 15;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(15, 34);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 17);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address line:";
            // 
            // txtAddressLine
            // 
            this.txtAddressLine.Location = new System.Drawing.Point(122, 31);
            this.txtAddressLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddressLine.Name = "txtAddressLine";
            this.txtAddressLine.Size = new System.Drawing.Size(388, 25);
            this.txtAddressLine.TabIndex = 14;
            // 
            // detailPanel
            // 
            this.detailPanel.AutoScroll = true;
            this.detailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.detailPanel.Controls.Add(this.detailVehiclePanel);
            this.detailPanel.Controls.Add(this.detailAddressPanel);
            this.detailPanel.Controls.Add(this.detailGeneralPanel);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Location = new System.Drawing.Point(0, 78);
            this.detailPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(1101, 629);
            this.detailPanel.TabIndex = 4;
            // 
            // detailVehiclePanel
            // 
            this.detailVehiclePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailVehiclePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailVehiclePanel.Controls.Add(this.dgvVehicleInfo);
            this.detailVehiclePanel.Controls.Add(this.btnRemove);
            this.detailVehiclePanel.Controls.Add(this.txtCurrentKM);
            this.detailVehiclePanel.Controls.Add(this.lblCurrentKM);
            this.detailVehiclePanel.Controls.Add(this.txtColor);
            this.detailVehiclePanel.Controls.Add(this.lblColor);
            this.detailVehiclePanel.Controls.Add(this.txtSize);
            this.detailVehiclePanel.Controls.Add(this.lblSize);
            this.detailVehiclePanel.Controls.Add(this.lblModel);
            this.detailVehiclePanel.Controls.Add(this.cboModel);
            this.detailVehiclePanel.Controls.Add(this.lblBrand);
            this.detailVehiclePanel.Controls.Add(this.cboBrand);
            this.detailVehiclePanel.Controls.Add(this.txtRegistrationNumber);
            this.detailVehiclePanel.Controls.Add(this.btnAdd);
            this.detailVehiclePanel.Controls.Add(this.lblRegNum);
            this.detailVehiclePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailVehiclePanel.Location = new System.Drawing.Point(0, 299);
            this.detailVehiclePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailVehiclePanel.Name = "detailVehiclePanel";
            this.detailVehiclePanel.Size = new System.Drawing.Size(1101, 270);
            this.detailVehiclePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailVehiclePanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailVehiclePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailVehiclePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailVehiclePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailVehiclePanel.Style.GradientAngle = 90;
            this.detailVehiclePanel.TabIndex = 18;
            this.detailVehiclePanel.TitleHeight = 34;
            this.detailVehiclePanel.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailVehiclePanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailVehiclePanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailVehiclePanel.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailVehiclePanel.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailVehiclePanel.TitleStyle.GradientAngle = 90;
            this.detailVehiclePanel.TitleStyle.MarginLeft = 10;
            this.detailVehiclePanel.TitleText = "Vehicle Information";
            // 
            // dgvVehicleInfo
            // 
            this.dgvVehicleInfo.AllowUserToAddRows = false;
            this.dgvVehicleInfo.AllowUserToDeleteRows = false;
            this.dgvVehicleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehicleInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvVehRegNum,
            this.dgvColBrand,
            this.dgvColModel,
            this.dgvColSize,
            this.dgvColColor,
            this.dgvColCurrentKm});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicleInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicleInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvVehicleInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvVehicleInfo.Location = new System.Drawing.Point(453, 34);
            this.dgvVehicleInfo.Name = "dgvVehicleInfo";
            this.dgvVehicleInfo.ReadOnly = true;
            this.dgvVehicleInfo.Size = new System.Drawing.Size(648, 236);
            this.dgvVehicleInfo.TabIndex = 41;
            // 
            // dgvVehRegNum
            // 
            this.dgvVehRegNum.HeaderText = "Reg. Number";
            this.dgvVehRegNum.Name = "dgvVehRegNum";
            this.dgvVehRegNum.ReadOnly = true;
            this.dgvVehRegNum.Width = 111;
            // 
            // dgvColBrand
            // 
            this.dgvColBrand.HeaderText = "Brand";
            this.dgvColBrand.Name = "dgvColBrand";
            this.dgvColBrand.ReadOnly = true;
            this.dgvColBrand.Width = 67;
            // 
            // dgvColModel
            // 
            this.dgvColModel.HeaderText = "Model";
            this.dgvColModel.Name = "dgvColModel";
            this.dgvColModel.ReadOnly = true;
            this.dgvColModel.Width = 71;
            // 
            // dgvColSize
            // 
            this.dgvColSize.HeaderText = "Size";
            this.dgvColSize.Name = "dgvColSize";
            this.dgvColSize.ReadOnly = true;
            this.dgvColSize.Width = 56;
            // 
            // dgvColColor
            // 
            this.dgvColColor.HeaderText = "Color";
            this.dgvColColor.Name = "dgvColColor";
            this.dgvColColor.ReadOnly = true;
            this.dgvColColor.Width = 65;
            // 
            // dgvColCurrentKm
            // 
            this.dgvColCurrentKm.HeaderText = "Current KM";
            this.dgvColCurrentKm.Name = "dgvColCurrentKm";
            this.dgvColCurrentKm.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(99, 219);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 33);
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtCurrentKM
            // 
            this.txtCurrentKM.Location = new System.Drawing.Point(141, 180);
            this.txtCurrentKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentKM.Name = "txtCurrentKM";
            this.txtCurrentKM.Size = new System.Drawing.Size(128, 25);
            this.txtCurrentKM.TabIndex = 39;
            this.txtCurrentKM.Text = "0";
            this.txtCurrentKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrentKM
            // 
            this.lblCurrentKM.AutoSize = true;
            this.lblCurrentKM.BackColor = System.Drawing.Color.White;
            this.lblCurrentKM.Location = new System.Drawing.Point(16, 183);
            this.lblCurrentKM.Name = "lblCurrentKM";
            this.lblCurrentKM.Size = new System.Drawing.Size(78, 17);
            this.lblCurrentKM.TabIndex = 38;
            this.lblCurrentKM.Text = "Current KM:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(141, 147);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(128, 25);
            this.txtColor.TabIndex = 37;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(16, 150);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(43, 17);
            this.lblColor.TabIndex = 36;
            this.lblColor.Text = "Color:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(315, 114);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(95, 25);
            this.txtSize.TabIndex = 34;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(275, 117);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 17);
            this.lblSize.TabIndex = 33;
            this.lblSize.Text = "Size:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(16, 117);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 17);
            this.lblModel.TabIndex = 32;
            this.lblModel.Text = "Model:";
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(141, 114);
            this.cboModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(128, 25);
            this.cboModel.TabIndex = 31;
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.cboModel_SelectedIndexChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(16, 84);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 17);
            this.lblBrand.TabIndex = 30;
            this.lblBrand.Text = "Brand:";
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(141, 81);
            this.cboBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(245, 25);
            this.cboBrand.TabIndex = 29;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(141, 48);
            this.txtRegistrationNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(128, 25);
            this.txtRegistrationNumber.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.BackColor = System.Drawing.Color.White;
            this.lblRegNum.Location = new System.Drawing.Point(16, 51);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(89, 17);
            this.lblRegNum.TabIndex = 21;
            this.lblRegNum.Text = "Reg. Number:";
            // 
            // detailAddressPanel
            // 
            this.detailAddressPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailAddressPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailAddressPanel.Controls.Add(this.gbxAddressInformation);
            this.detailAddressPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailAddressPanel.Expanded = false;
            this.detailAddressPanel.ExpandedBounds = new System.Drawing.Rectangle(0, 266, 1084, 239);
            this.detailAddressPanel.Location = new System.Drawing.Point(0, 265);
            this.detailAddressPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.detailAddressPanel.Name = "detailAddressPanel";
            this.detailAddressPanel.Size = new System.Drawing.Size(1101, 34);
            this.detailAddressPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailAddressPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailAddressPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailAddressPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailAddressPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailAddressPanel.Style.GradientAngle = 90;
            this.detailAddressPanel.TabIndex = 16;
            this.detailAddressPanel.TitleHeight = 34;
            this.detailAddressPanel.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailAddressPanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailAddressPanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailAddressPanel.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailAddressPanel.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailAddressPanel.TitleStyle.GradientAngle = 90;
            this.detailAddressPanel.TitleStyle.MarginLeft = 10;
            this.detailAddressPanel.TitleText = "Address Information";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1101, 26);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSaveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fileSaveToolStripMenuItem
            // 
            this.fileSaveToolStripMenuItem.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.Checkmark;
            this.fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            this.fileSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSaveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.fileSaveToolStripMenuItem.Text = "Save";
            this.fileSaveToolStripMenuItem.Click += new System.EventHandler(this.fileSaveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.Checkmark;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripReaderStatusLabel,
            this.btnClose});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1101, 35);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripReaderStatusLabel
            // 
            this.toolStripReaderStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripReaderStatusLabel.Name = "toolStripReaderStatusLabel";
            this.toolStripReaderStatusLabel.Size = new System.Drawing.Size(811, 30);
            this.toolStripReaderStatusLabel.Spring = true;
            this.toolStripReaderStatusLabel.Text = "No reader detected";
            this.toolStripReaderStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 33);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(132, 30);
            this.toolStripStatusLabel.Text = "Create a new customer";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 742);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add";
            this.Text = "Customer - Add New";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.detailGeneralPanel.ResumeLayout(false);
            this.gbxContactInformation.ResumeLayout(false);
            this.gbxContactInformation.PerformLayout();
            this.gbxBasic.ResumeLayout(false);
            this.gbxBasic.PerformLayout();
            this.gbxAddressInformation.ResumeLayout(false);
            this.gbxAddressInformation.PerformLayout();
            this.detailPanel.ResumeLayout(false);
            this.detailVehiclePanel.ResumeLayout(false);
            this.detailVehiclePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleInfo)).EndInit();
            this.detailAddressPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private DevComponents.DotNetBar.ExpandablePanel detailGeneralPanel;
        private System.Windows.Forms.GroupBox gbxAddressInformation;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddressLine;
        private System.Windows.Forms.GroupBox gbxBasic;
        private System.Windows.Forms.Label lblIsMember;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.CheckBox chkIsMember;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Panel detailPanel;
        private DevComponents.DotNetBar.ExpandablePanel detailAddressPanel;
        private System.Windows.Forms.GroupBox gbxContactInformation;
        private System.Windows.Forms.TextBox txtHomephone;
        private System.Windows.Forms.Label lblHomephone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtCellphone;
        private DevComponents.DotNetBar.ExpandablePanel detailVehiclePanel;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtCurrentKM;
        private System.Windows.Forms.Label lblCurrentKM;
        private System.Windows.Forms.Button btnRemove;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvVehicleInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVehRegNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCurrentKm;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSaveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripReaderStatusLabel;
        private Controls.ButtonStripItem btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

    }
}