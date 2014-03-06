namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
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
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.detailMerchandisePanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMerchandiseCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPointCost = new Macsauto.Presentation.WinForm.Controls.NumberTextBox();
            this.detailProductPanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVolume = new Macsauto.Presentation.WinForm.Controls.NumberTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSellPrice = new Macsauto.Presentation.WinForm.Controls.NumberTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProductCategory = new System.Windows.Forms.ComboBox();
            this.detailStoragePanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new Macsauto.Presentation.WinForm.Controls.NumberTextBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.cboStorage = new System.Windows.Forms.ComboBox();
            this.dgvStorage = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColStorageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColStorageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColStorageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetailTop = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.chkCreateMerchandise = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUoM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new Macsauto.Presentation.WinForm.Controls.NumberTextBox();
            this.chkCreateProduct = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new Macsauto.Presentation.WinForm.Controls.ButtonStripItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlDetail.SuspendLayout();
            this.detailMerchandisePanel.SuspendLayout();
            this.detailProductPanel.SuspendLayout();
            this.detailStoragePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.pnlDetailTop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.AutoScroll = true;
            this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.pnlDetail.Controls.Add(this.detailMerchandisePanel);
            this.pnlDetail.Controls.Add(this.detailProductPanel);
            this.pnlDetail.Controls.Add(this.detailStoragePanel);
            this.pnlDetail.Controls.Add(this.pnlDetailTop);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 26);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(784, 506);
            this.pnlDetail.TabIndex = 4;
            // 
            // detailMerchandisePanel
            // 
            this.detailMerchandisePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailMerchandisePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailMerchandisePanel.Controls.Add(this.label11);
            this.detailMerchandisePanel.Controls.Add(this.txtMerchandiseCode);
            this.detailMerchandisePanel.Controls.Add(this.label10);
            this.detailMerchandisePanel.Controls.Add(this.txtPointCost);
            this.detailMerchandisePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailMerchandisePanel.Enabled = false;
            this.detailMerchandisePanel.Expanded = false;
            this.detailMerchandisePanel.ExpandedBounds = new System.Drawing.Rectangle(0, 382, 767, 124);
            this.detailMerchandisePanel.Location = new System.Drawing.Point(0, 447);
            this.detailMerchandisePanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.detailMerchandisePanel.Name = "detailMerchandisePanel";
            this.detailMerchandisePanel.Size = new System.Drawing.Size(784, 39);
            this.detailMerchandisePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailMerchandisePanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailMerchandisePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailMerchandisePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailMerchandisePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailMerchandisePanel.Style.GradientAngle = 90;
            this.detailMerchandisePanel.TabIndex = 26;
            this.detailMerchandisePanel.TitleHeight = 39;
            this.detailMerchandisePanel.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailMerchandisePanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailMerchandisePanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailMerchandisePanel.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailMerchandisePanel.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailMerchandisePanel.TitleStyle.GradientAngle = 90;
            this.detailMerchandisePanel.TitleStyle.MarginLeft = 10;
            this.detailMerchandisePanel.TitleText = "Merchandise Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Code:";
            // 
            // txtMerchandiseCode
            // 
            this.txtMerchandiseCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMerchandiseCode.Location = new System.Drawing.Point(129, 55);
            this.txtMerchandiseCode.Name = "txtMerchandiseCode";
            this.txtMerchandiseCode.Size = new System.Drawing.Size(135, 25);
            this.txtMerchandiseCode.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(12, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Point cost:";
            // 
            // txtPointCost
            // 
            this.txtPointCost.Location = new System.Drawing.Point(129, 86);
            this.txtPointCost.Name = "txtPointCost";
            this.txtPointCost.Size = new System.Drawing.Size(121, 25);
            this.txtPointCost.TabIndex = 16;
            this.txtPointCost.Text = "0";
            this.txtPointCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // detailProductPanel
            // 
            this.detailProductPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailProductPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailProductPanel.Controls.Add(this.label9);
            this.detailProductPanel.Controls.Add(this.txtProductCode);
            this.detailProductPanel.Controls.Add(this.label7);
            this.detailProductPanel.Controls.Add(this.txtVolume);
            this.detailProductPanel.Controls.Add(this.label5);
            this.detailProductPanel.Controls.Add(this.txtSellPrice);
            this.detailProductPanel.Controls.Add(this.label4);
            this.detailProductPanel.Controls.Add(this.cboProductCategory);
            this.detailProductPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailProductPanel.Enabled = false;
            this.detailProductPanel.Expanded = false;
            this.detailProductPanel.ExpandedBounds = new System.Drawing.Rectangle(0, 286, 767, 181);
            this.detailProductPanel.Location = new System.Drawing.Point(0, 408);
            this.detailProductPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.detailProductPanel.Name = "detailProductPanel";
            this.detailProductPanel.Size = new System.Drawing.Size(784, 39);
            this.detailProductPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailProductPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailProductPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailProductPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailProductPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailProductPanel.Style.GradientAngle = 90;
            this.detailProductPanel.TabIndex = 25;
            this.detailProductPanel.TitleHeight = 39;
            this.detailProductPanel.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailProductPanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailProductPanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailProductPanel.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailProductPanel.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailProductPanel.TitleStyle.GradientAngle = 90;
            this.detailProductPanel.TitleStyle.MarginLeft = 10;
            this.detailProductPanel.TitleText = "Product Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Code:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductCode.Location = new System.Drawing.Point(129, 52);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(135, 25);
            this.txtProductCode.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Volume:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(129, 145);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(78, 25);
            this.txtVolume.TabIndex = 20;
            this.txtVolume.Text = "1";
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sell price:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(129, 114);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(121, 25);
            this.txtSellPrice.TabIndex = 16;
            this.txtSellPrice.Text = "0";
            this.txtSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product category:";
            // 
            // cboProductCategory
            // 
            this.cboProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductCategory.FormattingEnabled = true;
            this.cboProductCategory.Location = new System.Drawing.Point(129, 83);
            this.cboProductCategory.Name = "cboProductCategory";
            this.cboProductCategory.Size = new System.Drawing.Size(211, 25);
            this.cboProductCategory.TabIndex = 14;
            // 
            // detailStoragePanel
            // 
            this.detailStoragePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailStoragePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailStoragePanel.Controls.Add(this.btnRemove);
            this.detailStoragePanel.Controls.Add(this.btnAdd);
            this.detailStoragePanel.Controls.Add(this.label2);
            this.detailStoragePanel.Controls.Add(this.txtQuantity);
            this.detailStoragePanel.Controls.Add(this.lblStorage);
            this.detailStoragePanel.Controls.Add(this.cboStorage);
            this.detailStoragePanel.Controls.Add(this.dgvStorage);
            this.detailStoragePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailStoragePanel.Location = new System.Drawing.Point(0, 212);
            this.detailStoragePanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.detailStoragePanel.Name = "detailStoragePanel";
            this.detailStoragePanel.Size = new System.Drawing.Size(784, 196);
            this.detailStoragePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailStoragePanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailStoragePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailStoragePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailStoragePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailStoragePanel.Style.GradientAngle = 90;
            this.detailStoragePanel.TabIndex = 16;
            this.detailStoragePanel.TitleHeight = 39;
            this.detailStoragePanel.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailStoragePanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailStoragePanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailStoragePanel.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailStoragePanel.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailStoragePanel.TitleStyle.GradientAngle = 90;
            this.detailStoragePanel.TitleStyle.MarginLeft = 10;
            this.detailStoragePanel.TitleText = "Storage Details";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(96, 146);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 33);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(109, 83);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(78, 25);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblStorage.Location = new System.Drawing.Point(12, 55);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(57, 17);
            this.lblStorage.TabIndex = 13;
            this.lblStorage.Text = "Storage:";
            // 
            // cboStorage
            // 
            this.cboStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStorage.FormattingEnabled = true;
            this.cboStorage.Location = new System.Drawing.Point(109, 52);
            this.cboStorage.Name = "cboStorage";
            this.cboStorage.Size = new System.Drawing.Size(121, 25);
            this.cboStorage.TabIndex = 2;
            // 
            // dgvStorage
            // 
            this.dgvStorage.AllowUserToAddRows = false;
            this.dgvStorage.AllowUserToDeleteRows = false;
            this.dgvStorage.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColStorageId,
            this.dgvColStorageCode,
            this.dgvColStorageName,
            this.dgvColQty});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStorage.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStorage.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvStorage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStorage.Location = new System.Drawing.Point(377, 39);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.ReadOnly = true;
            this.dgvStorage.Size = new System.Drawing.Size(407, 157);
            this.dgvStorage.TabIndex = 1;
            // 
            // dgvColStorageId
            // 
            this.dgvColStorageId.HeaderText = "Id";
            this.dgvColStorageId.Name = "dgvColStorageId";
            this.dgvColStorageId.ReadOnly = true;
            this.dgvColStorageId.Visible = false;
            // 
            // dgvColStorageCode
            // 
            this.dgvColStorageCode.HeaderText = "Code";
            this.dgvColStorageCode.Name = "dgvColStorageCode";
            this.dgvColStorageCode.ReadOnly = true;
            // 
            // dgvColStorageName
            // 
            this.dgvColStorageName.HeaderText = "Storage";
            this.dgvColStorageName.Name = "dgvColStorageName";
            this.dgvColStorageName.ReadOnly = true;
            // 
            // dgvColQty
            // 
            this.dgvColQty.HeaderText = "Quantity";
            this.dgvColQty.Name = "dgvColQty";
            this.dgvColQty.ReadOnly = true;
            // 
            // pnlDetailTop
            // 
            this.pnlDetailTop.Controls.Add(this.label8);
            this.pnlDetailTop.Controls.Add(this.chkCreateMerchandise);
            this.pnlDetailTop.Controls.Add(this.label3);
            this.pnlDetailTop.Controls.Add(this.cboUoM);
            this.pnlDetailTop.Controls.Add(this.label6);
            this.pnlDetailTop.Controls.Add(this.label1);
            this.pnlDetailTop.Controls.Add(this.txtBuyPrice);
            this.pnlDetailTop.Controls.Add(this.chkCreateProduct);
            this.pnlDetailTop.Controls.Add(this.lblDescription);
            this.pnlDetailTop.Controls.Add(this.txtDescription);
            this.pnlDetailTop.Controls.Add(this.lblCode);
            this.pnlDetailTop.Controls.Add(this.txtCode);
            this.pnlDetailTop.Controls.Add(this.lblName);
            this.pnlDetailTop.Controls.Add(this.txtName);
            this.pnlDetailTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetailTop.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailTop.Name = "pnlDetailTop";
            this.pnlDetailTop.Size = new System.Drawing.Size(784, 212);
            this.pnlDetailTop.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Quick add merchandise:";
            // 
            // chkCreateMerchandise
            // 
            this.chkCreateMerchandise.AutoSize = true;
            this.chkCreateMerchandise.Location = new System.Drawing.Point(166, 178);
            this.chkCreateMerchandise.Name = "chkCreateMerchandise";
            this.chkCreateMerchandise.Size = new System.Drawing.Size(15, 14);
            this.chkCreateMerchandise.TabIndex = 20;
            this.chkCreateMerchandise.UseVisualStyleBackColor = true;
            this.chkCreateMerchandise.CheckedChanged += new System.EventHandler(this.chkCreateMerchandise_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(310, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Measurement unit:";
            // 
            // cboUoM
            // 
            this.cboUoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUoM.FormattingEnabled = true;
            this.cboUoM.Location = new System.Drawing.Point(432, 112);
            this.cboUoM.Name = "cboUoM";
            this.cboUoM.Size = new System.Drawing.Size(121, 25);
            this.cboUoM.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Buy price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quick add product:";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(166, 112);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(121, 25);
            this.txtBuyPrice.TabIndex = 18;
            this.txtBuyPrice.Text = "0";
            this.txtBuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkCreateProduct
            // 
            this.chkCreateProduct.AutoSize = true;
            this.chkCreateProduct.Location = new System.Drawing.Point(166, 148);
            this.chkCreateProduct.Name = "chkCreateProduct";
            this.chkCreateProduct.Size = new System.Drawing.Size(15, 14);
            this.chkCreateProduct.TabIndex = 14;
            this.chkCreateProduct.UseVisualStyleBackColor = true;
            this.chkCreateProduct.CheckedChanged += new System.EventHandler(this.chkCreateProduct_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 84);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 17);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Location = new System.Drawing.Point(164, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(389, 25);
            this.txtDescription.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 22);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(42, 17);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Location = new System.Drawing.Point(164, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(135, 25);
            this.txtCode.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(164, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(389, 25);
            this.txtName.TabIndex = 11;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(784, 26);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.Checkmark;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
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
            this.btnClose});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 22, 0);
            this.statusStrip.Size = new System.Drawing.Size(784, 30);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(631, 25);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Create a new inventory";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 28);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "Add";
            this.Text = "Inventory - Add";
            this.pnlDetail.ResumeLayout(false);
            this.detailMerchandisePanel.ResumeLayout(false);
            this.detailMerchandisePanel.PerformLayout();
            this.detailProductPanel.ResumeLayout(false);
            this.detailProductPanel.PerformLayout();
            this.detailStoragePanel.ResumeLayout(false);
            this.detailStoragePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.pnlDetailTop.ResumeLayout(false);
            this.pnlDetailTop.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private Controls.ButtonStripItem btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCreateProduct;
        private DevComponents.DotNetBar.ExpandablePanel detailStoragePanel;
        private System.Windows.Forms.Panel pnlDetailTop;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvStorage;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.ComboBox cboStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColStorageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColStorageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColStorageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColQty;
        private Controls.NumberTextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUoM;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private DevComponents.DotNetBar.ExpandablePanel detailProductPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProductCategory;
        private System.Windows.Forms.Label label6;
        private Controls.NumberTextBox txtBuyPrice;
        private System.Windows.Forms.Label label5;
        private Controls.NumberTextBox txtSellPrice;
        private System.Windows.Forms.Label label7;
        private Controls.NumberTextBox txtVolume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkCreateMerchandise;
        private DevComponents.DotNetBar.ExpandablePanel detailMerchandisePanel;
        private System.Windows.Forms.Label label10;
        private Controls.NumberTextBox txtPointCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMerchandiseCode;
    }
}