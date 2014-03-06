namespace Macsauto.Presentation.WinForm.ManagementModule.Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDetailTop = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.dgvServices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlDetailFill = new System.Windows.Forms.Panel();
            this.pnlDetailBottomTitle = new System.Windows.Forms.Panel();
            this.lblServiceCategoryValue = new System.Windows.Forms.LinkLabel();
            this.pnlDetailBottom = new System.Windows.Forms.Panel();
            this.pnlDetailBottomPad = new System.Windows.Forms.Panel();
            this.lblServiceCategoryTitle = new System.Windows.Forms.Label();
            this.lblCreatedOnValue = new System.Windows.Forms.Label();
            this.lblCreatedOnTitle = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.dgvColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetailBottomLeft = new System.Windows.Forms.Panel();
            this.pnlDetailBottomFill = new System.Windows.Forms.Panel();
            this.dgvServicePricings = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColVehicleSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetailTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.pnlDetailFill.SuspendLayout();
            this.pnlDetailBottomTitle.SuspendLayout();
            this.pnlDetailBottom.SuspendLayout();
            this.pnlDetailBottomPad.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.pnlDetailBottomLeft.SuspendLayout();
            this.pnlDetailBottomFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicePricings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(141)))), ((int)(((byte)(23)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "All services";
            // 
            // pnlDetailTop
            // 
            this.pnlDetailTop.Controls.Add(this.lblTitle);
            this.pnlDetailTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetailTop.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailTop.Name = "pnlDetailTop";
            this.pnlDetailTop.Size = new System.Drawing.Size(944, 45);
            this.pnlDetailTop.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblCode.Location = new System.Drawing.Point(11, 17);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(173, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "SXXX - [Service Name]";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColId,
            this.dgvColCode,
            this.dgvColName,
            this.dgvColDescription,
            this.dgvColCategory,
            this.dgvColCreatedOn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvServices.Location = new System.Drawing.Point(0, 0);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.Size = new System.Drawing.Size(944, 572);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellEnter);
            // 
            // pnlDetailFill
            // 
            this.pnlDetailFill.Controls.Add(this.dgvServices);
            this.pnlDetailFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailFill.Location = new System.Drawing.Point(0, 45);
            this.pnlDetailFill.Name = "pnlDetailFill";
            this.pnlDetailFill.Size = new System.Drawing.Size(944, 572);
            this.pnlDetailFill.TabIndex = 1;
            // 
            // pnlDetailBottomTitle
            // 
            this.pnlDetailBottomTitle.Controls.Add(this.lblCode);
            this.pnlDetailBottomTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetailBottomTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailBottomTitle.Name = "pnlDetailBottomTitle";
            this.pnlDetailBottomTitle.Size = new System.Drawing.Size(942, 57);
            this.pnlDetailBottomTitle.TabIndex = 0;
            // 
            // lblServiceCategoryValue
            // 
            this.lblServiceCategoryValue.AutoSize = true;
            this.lblServiceCategoryValue.Location = new System.Drawing.Point(158, 77);
            this.lblServiceCategoryValue.Name = "lblServiceCategoryValue";
            this.lblServiceCategoryValue.Size = new System.Drawing.Size(114, 17);
            this.lblServiceCategoryValue.TabIndex = 18;
            this.lblServiceCategoryValue.TabStop = true;
            this.lblServiceCategoryValue.Text = "[Service Category]";
            this.lblServiceCategoryValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblServiceCategoryValue_LinkClicked);
            // 
            // pnlDetailBottom
            // 
            this.pnlDetailBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetailBottom.Controls.Add(this.pnlDetailBottomPad);
            this.pnlDetailBottom.Controls.Add(this.pnlDetailBottomTitle);
            this.pnlDetailBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetailBottom.Location = new System.Drawing.Point(0, 366);
            this.pnlDetailBottom.Name = "pnlDetailBottom";
            this.pnlDetailBottom.Size = new System.Drawing.Size(944, 251);
            this.pnlDetailBottom.TabIndex = 2;
            // 
            // pnlDetailBottomPad
            // 
            this.pnlDetailBottomPad.Controls.Add(this.pnlDetailBottomFill);
            this.pnlDetailBottomPad.Controls.Add(this.pnlDetailBottomLeft);
            this.pnlDetailBottomPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailBottomPad.Location = new System.Drawing.Point(0, 57);
            this.pnlDetailBottomPad.Name = "pnlDetailBottomPad";
            this.pnlDetailBottomPad.Size = new System.Drawing.Size(942, 192);
            this.pnlDetailBottomPad.TabIndex = 1;
            // 
            // lblServiceCategoryTitle
            // 
            this.lblServiceCategoryTitle.AutoSize = true;
            this.lblServiceCategoryTitle.Location = new System.Drawing.Point(15, 77);
            this.lblServiceCategoryTitle.Name = "lblServiceCategoryTitle";
            this.lblServiceCategoryTitle.Size = new System.Drawing.Size(107, 17);
            this.lblServiceCategoryTitle.TabIndex = 12;
            this.lblServiceCategoryTitle.Text = "Service category:";
            // 
            // lblCreatedOnValue
            // 
            this.lblCreatedOnValue.AutoSize = true;
            this.lblCreatedOnValue.Location = new System.Drawing.Point(158, 139);
            this.lblCreatedOnValue.Name = "lblCreatedOnValue";
            this.lblCreatedOnValue.Size = new System.Drawing.Size(83, 17);
            this.lblCreatedOnValue.TabIndex = 11;
            this.lblCreatedOnValue.Text = "[Created On]";
            // 
            // lblCreatedOnTitle
            // 
            this.lblCreatedOnTitle.AutoSize = true;
            this.lblCreatedOnTitle.Location = new System.Drawing.Point(15, 139);
            this.lblCreatedOnTitle.Name = "lblCreatedOnTitle";
            this.lblCreatedOnTitle.Size = new System.Drawing.Size(76, 17);
            this.lblCreatedOnTitle.TabIndex = 10;
            this.lblCreatedOnTitle.Text = "Created on:";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Location = new System.Drawing.Point(158, 108);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(79, 17);
            this.lblCreatedByValue.TabIndex = 9;
            this.lblCreatedByValue.Text = "[Created By]";
            // 
            // lblCreatedByTitle
            // 
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Location = new System.Drawing.Point(15, 108);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(75, 17);
            this.lblCreatedByTitle.TabIndex = 8;
            this.lblCreatedByTitle.Text = "Created by:";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Location = new System.Drawing.Point(156, 15);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(82, 17);
            this.lblDescriptionValue.TabIndex = 3;
            this.lblDescriptionValue.Text = "[Description]";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(77, 17);
            this.lblDescriptionTitle.TabIndex = 2;
            this.lblDescriptionTitle.Text = "Description:";
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.Controls.Add(this.pnlDetailBottom);
            this.pnlDetail.Controls.Add(this.pnlDetailFill);
            this.pnlDetail.Controls.Add(this.pnlDetailTop);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(944, 617);
            this.pnlDetail.TabIndex = 4;
            // 
            // dgvColId
            // 
            this.dgvColId.HeaderText = "Id";
            this.dgvColId.Name = "dgvColId";
            this.dgvColId.ReadOnly = true;
            this.dgvColId.Visible = false;
            this.dgvColId.Width = 44;
            // 
            // dgvColCode
            // 
            this.dgvColCode.HeaderText = "Code";
            this.dgvColCode.Name = "dgvColCode";
            this.dgvColCode.ReadOnly = true;
            this.dgvColCode.Width = 225;
            // 
            // dgvColName
            // 
            this.dgvColName.HeaderText = "Name";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.ReadOnly = true;
            this.dgvColName.Width = 226;
            // 
            // dgvColDescription
            // 
            this.dgvColDescription.HeaderText = "Description";
            this.dgvColDescription.Name = "dgvColDescription";
            this.dgvColDescription.ReadOnly = true;
            this.dgvColDescription.Width = 225;
            // 
            // dgvColCategory
            // 
            this.dgvColCategory.HeaderText = "Service Category";
            this.dgvColCategory.Name = "dgvColCategory";
            this.dgvColCategory.ReadOnly = true;
            this.dgvColCategory.Width = 225;
            // 
            // dgvColCreatedOn
            // 
            this.dgvColCreatedOn.HeaderText = "Created On";
            this.dgvColCreatedOn.Name = "dgvColCreatedOn";
            this.dgvColCreatedOn.ReadOnly = true;
            this.dgvColCreatedOn.Visible = false;
            this.dgvColCreatedOn.Width = 92;
            // 
            // pnlDetailBottomLeft
            // 
            this.pnlDetailBottomLeft.Controls.Add(this.lblDescriptionTitle);
            this.pnlDetailBottomLeft.Controls.Add(this.lblServiceCategoryValue);
            this.pnlDetailBottomLeft.Controls.Add(this.lblDescriptionValue);
            this.pnlDetailBottomLeft.Controls.Add(this.lblServiceCategoryTitle);
            this.pnlDetailBottomLeft.Controls.Add(this.lblCreatedByTitle);
            this.pnlDetailBottomLeft.Controls.Add(this.lblCreatedOnValue);
            this.pnlDetailBottomLeft.Controls.Add(this.lblCreatedByValue);
            this.pnlDetailBottomLeft.Controls.Add(this.lblCreatedOnTitle);
            this.pnlDetailBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDetailBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailBottomLeft.Name = "pnlDetailBottomLeft";
            this.pnlDetailBottomLeft.Size = new System.Drawing.Size(308, 192);
            this.pnlDetailBottomLeft.TabIndex = 19;
            // 
            // pnlDetailBottomFill
            // 
            this.pnlDetailBottomFill.Controls.Add(this.dgvServicePricings);
            this.pnlDetailBottomFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailBottomFill.Location = new System.Drawing.Point(308, 0);
            this.pnlDetailBottomFill.Name = "pnlDetailBottomFill";
            this.pnlDetailBottomFill.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDetailBottomFill.Size = new System.Drawing.Size(634, 192);
            this.pnlDetailBottomFill.TabIndex = 20;
            // 
            // dgvServicePricings
            // 
            this.dgvServicePricings.AllowUserToAddRows = false;
            this.dgvServicePricings.AllowUserToDeleteRows = false;
            this.dgvServicePricings.BackgroundColor = System.Drawing.Color.White;
            this.dgvServicePricings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicePricings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColVehicleSize,
            this.dgvColPrice});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicePricings.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServicePricings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicePricings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvServicePricings.Location = new System.Drawing.Point(10, 10);
            this.dgvServicePricings.Name = "dgvServicePricings";
            this.dgvServicePricings.ReadOnly = true;
            this.dgvServicePricings.Size = new System.Drawing.Size(614, 172);
            this.dgvServicePricings.TabIndex = 1;
            // 
            // dgvColVehicleSize
            // 
            this.dgvColVehicleSize.HeaderText = "Vehicle Size";
            this.dgvColVehicleSize.Name = "dgvColVehicleSize";
            this.dgvColVehicleSize.ReadOnly = true;
            // 
            // dgvColPrice
            // 
            this.dgvColPrice.HeaderText = "Price";
            this.dgvColPrice.Name = "dgvColPrice";
            this.dgvColPrice.ReadOnly = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.pnlDetail);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View";
            this.Text = "Service - View All";
            this.pnlDetailTop.ResumeLayout(false);
            this.pnlDetailTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.pnlDetailFill.ResumeLayout(false);
            this.pnlDetailBottomTitle.ResumeLayout(false);
            this.pnlDetailBottomTitle.PerformLayout();
            this.pnlDetailBottom.ResumeLayout(false);
            this.pnlDetailBottomPad.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetailBottomLeft.ResumeLayout(false);
            this.pnlDetailBottomLeft.PerformLayout();
            this.pnlDetailBottomFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicePricings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDetailTop;
        private System.Windows.Forms.Label lblCode;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvServices;
        private System.Windows.Forms.Panel pnlDetailFill;
        private System.Windows.Forms.Panel pnlDetailBottomTitle;
        private System.Windows.Forms.LinkLabel lblServiceCategoryValue;
        private System.Windows.Forms.Panel pnlDetailBottom;
        private System.Windows.Forms.Panel pnlDetailBottomPad;
        private System.Windows.Forms.Label lblServiceCategoryTitle;
        private System.Windows.Forms.Label lblCreatedOnValue;
        private System.Windows.Forms.Label lblCreatedOnTitle;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.Label lblDescriptionValue;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCreatedOn;
        private System.Windows.Forms.Panel pnlDetailBottomFill;
        private System.Windows.Forms.Panel pnlDetailBottomLeft;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvServicePricings;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColVehicleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPrice;
    }
}