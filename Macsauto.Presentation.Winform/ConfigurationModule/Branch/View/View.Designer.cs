namespace Macsauto.Presentation.WinForm.ConfigurationModule.Branch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.detailEmployeeInformation = new DevComponents.DotNetBar.ExpandablePanel();
            this.dgvEmployees = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeeGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeeCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailAddressInformation = new DevComponents.DotNetBar.ExpandablePanel();
            this.gbxAddress = new System.Windows.Forms.GroupBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddressLine = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.deleteBtnItem = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.detailEmployeeInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.detailAddressInformation.SuspendLayout();
            this.gbxAddress.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.detailEmployeeInformation);
            this.splitContainer.Panel1.Controls.Add(this.detailAddressInformation);
            this.splitContainer.Panel1.Controls.Add(this.headerPanel);
            this.splitContainer.Size = new System.Drawing.Size(1101, 712);
            this.splitContainer.SplitterDistance = 872;
            this.splitContainer.TabIndex = 2;
            // 
            // detailEmployeeInformation
            // 
            this.detailEmployeeInformation.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailEmployeeInformation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailEmployeeInformation.Controls.Add(this.dgvEmployees);
            this.detailEmployeeInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailEmployeeInformation.Location = new System.Drawing.Point(0, 248);
            this.detailEmployeeInformation.Name = "detailEmployeeInformation";
            this.detailEmployeeInformation.Size = new System.Drawing.Size(870, 214);
            this.detailEmployeeInformation.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailEmployeeInformation.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailEmployeeInformation.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailEmployeeInformation.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailEmployeeInformation.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailEmployeeInformation.Style.GradientAngle = 90;
            this.detailEmployeeInformation.TabIndex = 4;
            this.detailEmployeeInformation.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailEmployeeInformation.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailEmployeeInformation.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailEmployeeInformation.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailEmployeeInformation.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailEmployeeInformation.TitleStyle.GradientAngle = 90;
            this.detailEmployeeInformation.TitleStyle.MarginLeft = 10;
            this.detailEmployeeInformation.TitleText = "Employees";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColEmployeeId,
            this.dgvColEmployeeCode,
            this.dgvColEmployeeName,
            this.dgvColEmployeeGender,
            this.dgvColEmployeePosition,
            this.dgvColEmployeeEmail,
            this.dgvColEmployeeCellphone});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEmployees.Location = new System.Drawing.Point(0, 26);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(870, 188);
            this.dgvEmployees.TabIndex = 1;
            // 
            // dgvColEmployeeId
            // 
            this.dgvColEmployeeId.HeaderText = "Id";
            this.dgvColEmployeeId.Name = "dgvColEmployeeId";
            this.dgvColEmployeeId.ReadOnly = true;
            this.dgvColEmployeeId.Visible = false;
            // 
            // dgvColEmployeeCode
            // 
            this.dgvColEmployeeCode.HeaderText = "Code";
            this.dgvColEmployeeCode.Name = "dgvColEmployeeCode";
            this.dgvColEmployeeCode.ReadOnly = true;
            // 
            // dgvColEmployeeName
            // 
            this.dgvColEmployeeName.HeaderText = "Name";
            this.dgvColEmployeeName.Name = "dgvColEmployeeName";
            this.dgvColEmployeeName.ReadOnly = true;
            // 
            // dgvColEmployeeGender
            // 
            this.dgvColEmployeeGender.HeaderText = "Gender";
            this.dgvColEmployeeGender.Name = "dgvColEmployeeGender";
            this.dgvColEmployeeGender.ReadOnly = true;
            // 
            // dgvColEmployeePosition
            // 
            this.dgvColEmployeePosition.HeaderText = "Position";
            this.dgvColEmployeePosition.Name = "dgvColEmployeePosition";
            this.dgvColEmployeePosition.ReadOnly = true;
            // 
            // dgvColEmployeeEmail
            // 
            this.dgvColEmployeeEmail.HeaderText = "E-Mail";
            this.dgvColEmployeeEmail.Name = "dgvColEmployeeEmail";
            this.dgvColEmployeeEmail.ReadOnly = true;
            // 
            // dgvColEmployeeCellphone
            // 
            this.dgvColEmployeeCellphone.HeaderText = "Cellphone";
            this.dgvColEmployeeCellphone.Name = "dgvColEmployeeCellphone";
            this.dgvColEmployeeCellphone.ReadOnly = true;
            // 
            // detailAddressInformation
            // 
            this.detailAddressInformation.CanvasColor = System.Drawing.SystemColors.Control;
            this.detailAddressInformation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.detailAddressInformation.Controls.Add(this.gbxAddress);
            this.detailAddressInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailAddressInformation.Location = new System.Drawing.Point(0, 40);
            this.detailAddressInformation.Name = "detailAddressInformation";
            this.detailAddressInformation.Size = new System.Drawing.Size(870, 208);
            this.detailAddressInformation.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.detailAddressInformation.Style.BackColor1.Color = System.Drawing.Color.White;
            this.detailAddressInformation.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.detailAddressInformation.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailAddressInformation.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.detailAddressInformation.Style.GradientAngle = 90;
            this.detailAddressInformation.TabIndex = 3;
            this.detailAddressInformation.TitleStyle.BackColor1.Color = System.Drawing.Color.Gainsboro;
            this.detailAddressInformation.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.detailAddressInformation.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.detailAddressInformation.TitleStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.detailAddressInformation.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.detailAddressInformation.TitleStyle.GradientAngle = 90;
            this.detailAddressInformation.TitleStyle.MarginLeft = 10;
            this.detailAddressInformation.TitleText = "Address Information";
            // 
            // gbxAddress
            // 
            this.gbxAddress.BackColor = System.Drawing.Color.White;
            this.gbxAddress.Controls.Add(this.txtZipcode);
            this.gbxAddress.Controls.Add(this.label3);
            this.gbxAddress.Controls.Add(this.label4);
            this.gbxAddress.Controls.Add(this.cboProvince);
            this.gbxAddress.Controls.Add(this.label5);
            this.gbxAddress.Controls.Add(this.cboCity);
            this.gbxAddress.Controls.Add(this.label6);
            this.gbxAddress.Controls.Add(this.txtAddressLine);
            this.gbxAddress.Location = new System.Drawing.Point(16, 37);
            this.gbxAddress.Name = "gbxAddress";
            this.gbxAddress.Size = new System.Drawing.Size(456, 155);
            this.gbxAddress.TabIndex = 14;
            this.gbxAddress.TabStop = false;
            this.gbxAddress.Text = "Address Information";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(105, 117);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(110, 24);
            this.txtZipcode.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Zipcode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Province:";
            // 
            // cboProvince
            // 
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.Enabled = false;
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(105, 86);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(211, 23);
            this.cboProvince.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "City:";
            // 
            // cboCity
            // 
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCity.Enabled = false;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(105, 55);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(211, 23);
            this.cboCity.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address line:";
            // 
            // txtAddressLine
            // 
            this.txtAddressLine.Location = new System.Drawing.Point(105, 24);
            this.txtAddressLine.Name = "txtAddressLine";
            this.txtAddressLine.ReadOnly = true;
            this.txtAddressLine.Size = new System.Drawing.Size(333, 24);
            this.txtAddressLine.TabIndex = 14;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(870, 40);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(141)))), ((int)(((byte)(23)))));
            this.lblTitle.Location = new System.Drawing.Point(11, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Record Id : Description";
            // 
            // deleteBtnItem
            // 
            this.deleteBtnItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.deleteBtnItem.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.Error;
            this.deleteBtnItem.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.deleteBtnItem.ImagePaddingHorizontal = 20;
            this.deleteBtnItem.ImagePaddingVertical = 5;
            this.deleteBtnItem.Name = "deleteBtnItem";
            this.deleteBtnItem.SubItemsExpandWidth = 14;
            this.deleteBtnItem.Text = "Delete";
            this.deleteBtnItem.ThemeAware = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 712);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Name = "View";
            this.Text = "View";
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.detailEmployeeInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.detailAddressInformation.ResumeLayout(false);
            this.gbxAddress.ResumeLayout(false);
            this.gbxAddress.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private DevComponents.DotNetBar.ExpandablePanel detailAddressInformation;
        private System.Windows.Forms.GroupBox gbxAddress;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddressLine;
        private DevComponents.DotNetBar.ExpandablePanel detailEmployeeInformation;
        private DevComponents.DotNetBar.ButtonItem deleteBtnItem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeeGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeeCellphone;


    }
}