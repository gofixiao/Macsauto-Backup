﻿namespace Macsauto.Presentation.WinForm.ManagementModule.Merchandise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.pnlDetailBottom = new System.Windows.Forms.Panel();
            this.pnlDetailBottomPad = new System.Windows.Forms.Panel();
            this.lblPointValue = new System.Windows.Forms.Label();
            this.lblVolumeValue = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblVolumeTitle = new System.Windows.Forms.Label();
            this.lblPointTitle = new System.Windows.Forms.Label();
            this.pnlDetailBottomTitle = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.pnlDetailFill = new System.Windows.Forms.Panel();
            this.dgvMerchandises = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDetailTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblCreatedByTitle = new System.Windows.Forms.Label();
            this.lblCreatedOnValue = new System.Windows.Forms.Label();
            this.lblCreatedOnTitle = new System.Windows.Forms.Label();
            this.lblInventoryCodeTitle = new System.Windows.Forms.Label();
            this.lblInventoryNameValue = new System.Windows.Forms.Label();
            this.lblInventoryNameTitle = new System.Windows.Forms.Label();
            this.lblInventoryTotalStockValue = new System.Windows.Forms.Label();
            this.lblInventoryTotalStockTitle = new System.Windows.Forms.Label();
            this.lblInventoryCodeValue = new System.Windows.Forms.LinkLabel();
            this.pnlDetail.SuspendLayout();
            this.pnlDetailBottom.SuspendLayout();
            this.pnlDetailBottomPad.SuspendLayout();
            this.pnlDetailBottomTitle.SuspendLayout();
            this.pnlDetailFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerchandises)).BeginInit();
            this.pnlDetailTop.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlDetail.TabIndex = 2;
            // 
            // pnlDetailBottom
            // 
            this.pnlDetailBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetailBottom.Controls.Add(this.pnlDetailBottomPad);
            this.pnlDetailBottom.Controls.Add(this.pnlDetailBottomTitle);
            this.pnlDetailBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetailBottom.Location = new System.Drawing.Point(0, 335);
            this.pnlDetailBottom.Name = "pnlDetailBottom";
            this.pnlDetailBottom.Size = new System.Drawing.Size(944, 282);
            this.pnlDetailBottom.TabIndex = 2;
            // 
            // pnlDetailBottomPad
            // 
            this.pnlDetailBottomPad.Controls.Add(this.lblInventoryCodeValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblInventoryTotalStockValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblInventoryTotalStockTitle);
            this.pnlDetailBottomPad.Controls.Add(this.lblInventoryNameValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblInventoryNameTitle);
            this.pnlDetailBottomPad.Controls.Add(this.lblInventoryCodeTitle);
            this.pnlDetailBottomPad.Controls.Add(this.lblCreatedOnValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblCreatedOnTitle);
            this.pnlDetailBottomPad.Controls.Add(this.lblCreatedByValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblCreatedByTitle);
            this.pnlDetailBottomPad.Controls.Add(this.lblPointValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblVolumeValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblDescriptionValue);
            this.pnlDetailBottomPad.Controls.Add(this.lblDescription);
            this.pnlDetailBottomPad.Controls.Add(this.lblVolumeTitle);
            this.pnlDetailBottomPad.Controls.Add(this.lblPointTitle);
            this.pnlDetailBottomPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailBottomPad.Location = new System.Drawing.Point(0, 57);
            this.pnlDetailBottomPad.Name = "pnlDetailBottomPad";
            this.pnlDetailBottomPad.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.pnlDetailBottomPad.Size = new System.Drawing.Size(942, 223);
            this.pnlDetailBottomPad.TabIndex = 1;
            // 
            // lblPointValue
            // 
            this.lblPointValue.AutoSize = true;
            this.lblPointValue.Location = new System.Drawing.Point(154, 86);
            this.lblPointValue.Name = "lblPointValue";
            this.lblPointValue.Size = new System.Drawing.Size(45, 17);
            this.lblPointValue.TabIndex = 5;
            this.lblPointValue.Text = "[Point]";
            // 
            // lblVolumeValue
            // 
            this.lblVolumeValue.AutoSize = true;
            this.lblVolumeValue.Location = new System.Drawing.Point(154, 117);
            this.lblVolumeValue.Name = "lblVolumeValue";
            this.lblVolumeValue.Size = new System.Drawing.Size(60, 17);
            this.lblVolumeValue.TabIndex = 4;
            this.lblVolumeValue.Text = "[Volume]";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Location = new System.Drawing.Point(154, 24);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(82, 17);
            this.lblDescriptionValue.TabIndex = 3;
            this.lblDescriptionValue.Text = "[Description]";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 24);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblVolumeTitle
            // 
            this.lblVolumeTitle.AutoSize = true;
            this.lblVolumeTitle.Location = new System.Drawing.Point(11, 117);
            this.lblVolumeTitle.Name = "lblVolumeTitle";
            this.lblVolumeTitle.Size = new System.Drawing.Size(55, 17);
            this.lblVolumeTitle.TabIndex = 1;
            this.lblVolumeTitle.Text = "Volume:";
            // 
            // lblPointTitle
            // 
            this.lblPointTitle.AutoSize = true;
            this.lblPointTitle.Location = new System.Drawing.Point(11, 86);
            this.lblPointTitle.Name = "lblPointTitle";
            this.lblPointTitle.Size = new System.Drawing.Size(40, 17);
            this.lblPointTitle.TabIndex = 0;
            this.lblPointTitle.Text = "Point:";
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
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblCode.Location = new System.Drawing.Point(11, 17);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(220, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "MXXX - [Merchandise Name]";
            // 
            // pnlDetailFill
            // 
            this.pnlDetailFill.Controls.Add(this.dgvMerchandises);
            this.pnlDetailFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailFill.Location = new System.Drawing.Point(0, 45);
            this.pnlDetailFill.Name = "pnlDetailFill";
            this.pnlDetailFill.Size = new System.Drawing.Size(944, 572);
            this.pnlDetailFill.TabIndex = 1;
            // 
            // dgvMerchandises
            // 
            this.dgvMerchandises.AllowUserToAddRows = false;
            this.dgvMerchandises.AllowUserToDeleteRows = false;
            this.dgvMerchandises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMerchandises.BackgroundColor = System.Drawing.Color.White;
            this.dgvMerchandises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMerchandises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColId,
            this.dgvColCode,
            this.dgvColName,
            this.dgvColDescription,
            this.dgvColPoint,
            this.dgvColVolume,
            this.dgvColCreatedOn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMerchandises.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMerchandises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMerchandises.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMerchandises.Location = new System.Drawing.Point(0, 0);
            this.dgvMerchandises.Name = "dgvMerchandises";
            this.dgvMerchandises.ReadOnly = true;
            this.dgvMerchandises.Size = new System.Drawing.Size(944, 572);
            this.dgvMerchandises.TabIndex = 0;
            this.dgvMerchandises.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMerchandises_CellEnter);
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
            this.dgvColCode.Width = 64;
            // 
            // dgvColName
            // 
            this.dgvColName.HeaderText = "Name";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.ReadOnly = true;
            this.dgvColName.Width = 68;
            // 
            // dgvColDescription
            // 
            this.dgvColDescription.HeaderText = "Description";
            this.dgvColDescription.Name = "dgvColDescription";
            this.dgvColDescription.ReadOnly = true;
            this.dgvColDescription.Width = 99;
            // 
            // dgvColPoint
            // 
            this.dgvColPoint.HeaderText = "Point";
            this.dgvColPoint.Name = "dgvColPoint";
            this.dgvColPoint.ReadOnly = true;
            this.dgvColPoint.Width = 62;
            // 
            // dgvColVolume
            // 
            this.dgvColVolume.HeaderText = "Volume";
            this.dgvColVolume.Name = "dgvColVolume";
            this.dgvColVolume.ReadOnly = true;
            this.dgvColVolume.Width = 77;
            // 
            // dgvColCreatedOn
            // 
            this.dgvColCreatedOn.HeaderText = "Created On";
            this.dgvColCreatedOn.Name = "dgvColCreatedOn";
            this.dgvColCreatedOn.ReadOnly = true;
            this.dgvColCreatedOn.Visible = false;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(141)))), ((int)(((byte)(23)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "All merchandises";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Location = new System.Drawing.Point(154, 148);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(79, 17);
            this.lblCreatedByValue.TabIndex = 9;
            this.lblCreatedByValue.Text = "[Created By]";
            // 
            // lblCreatedByTitle
            // 
            this.lblCreatedByTitle.AutoSize = true;
            this.lblCreatedByTitle.Location = new System.Drawing.Point(11, 148);
            this.lblCreatedByTitle.Name = "lblCreatedByTitle";
            this.lblCreatedByTitle.Size = new System.Drawing.Size(75, 17);
            this.lblCreatedByTitle.TabIndex = 8;
            this.lblCreatedByTitle.Text = "Created by:";
            // 
            // lblCreatedOnValue
            // 
            this.lblCreatedOnValue.AutoSize = true;
            this.lblCreatedOnValue.Location = new System.Drawing.Point(154, 179);
            this.lblCreatedOnValue.Name = "lblCreatedOnValue";
            this.lblCreatedOnValue.Size = new System.Drawing.Size(83, 17);
            this.lblCreatedOnValue.TabIndex = 11;
            this.lblCreatedOnValue.Text = "[Created On]";
            // 
            // lblCreatedOnTitle
            // 
            this.lblCreatedOnTitle.AutoSize = true;
            this.lblCreatedOnTitle.Location = new System.Drawing.Point(11, 179);
            this.lblCreatedOnTitle.Name = "lblCreatedOnTitle";
            this.lblCreatedOnTitle.Size = new System.Drawing.Size(76, 17);
            this.lblCreatedOnTitle.TabIndex = 10;
            this.lblCreatedOnTitle.Text = "Created on:";
            // 
            // lblInventoryCodeTitle
            // 
            this.lblInventoryCodeTitle.AutoSize = true;
            this.lblInventoryCodeTitle.Location = new System.Drawing.Point(429, 24);
            this.lblInventoryCodeTitle.Name = "lblInventoryCodeTitle";
            this.lblInventoryCodeTitle.Size = new System.Drawing.Size(97, 17);
            this.lblInventoryCodeTitle.TabIndex = 12;
            this.lblInventoryCodeTitle.Text = "Inventory code:";
            // 
            // lblInventoryNameValue
            // 
            this.lblInventoryNameValue.AutoSize = true;
            this.lblInventoryNameValue.Location = new System.Drawing.Point(572, 55);
            this.lblInventoryNameValue.Name = "lblInventoryNameValue";
            this.lblInventoryNameValue.Size = new System.Drawing.Size(108, 17);
            this.lblInventoryNameValue.TabIndex = 15;
            this.lblInventoryNameValue.Text = "[Inventory Name]";
            // 
            // lblInventoryNameTitle
            // 
            this.lblInventoryNameTitle.AutoSize = true;
            this.lblInventoryNameTitle.Location = new System.Drawing.Point(429, 55);
            this.lblInventoryNameTitle.Name = "lblInventoryNameTitle";
            this.lblInventoryNameTitle.Size = new System.Drawing.Size(100, 17);
            this.lblInventoryNameTitle.TabIndex = 14;
            this.lblInventoryNameTitle.Text = "Inventory name:";
            // 
            // lblInventoryTotalStockValue
            // 
            this.lblInventoryTotalStockValue.AutoSize = true;
            this.lblInventoryTotalStockValue.Location = new System.Drawing.Point(572, 86);
            this.lblInventoryTotalStockValue.Name = "lblInventoryTotalStockValue";
            this.lblInventoryTotalStockValue.Size = new System.Drawing.Size(76, 17);
            this.lblInventoryTotalStockValue.TabIndex = 17;
            this.lblInventoryTotalStockValue.Text = "Total Stock]";
            // 
            // lblInventoryTotalStockTitle
            // 
            this.lblInventoryTotalStockTitle.AutoSize = true;
            this.lblInventoryTotalStockTitle.Location = new System.Drawing.Point(429, 86);
            this.lblInventoryTotalStockTitle.Name = "lblInventoryTotalStockTitle";
            this.lblInventoryTotalStockTitle.Size = new System.Drawing.Size(75, 17);
            this.lblInventoryTotalStockTitle.TabIndex = 16;
            this.lblInventoryTotalStockTitle.Text = "Total Stock:";
            // 
            // lblInventoryCodeValue
            // 
            this.lblInventoryCodeValue.AutoSize = true;
            this.lblInventoryCodeValue.Location = new System.Drawing.Point(572, 24);
            this.lblInventoryCodeValue.Name = "lblInventoryCodeValue";
            this.lblInventoryCodeValue.Size = new System.Drawing.Size(104, 17);
            this.lblInventoryCodeValue.TabIndex = 18;
            this.lblInventoryCodeValue.TabStop = true;
            this.lblInventoryCodeValue.Text = "[Inventory Code]";
            this.lblInventoryCodeValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInventoryCodeValue_LinkClicked);
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
            this.Text = "Merchandise - View All";
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetailBottom.ResumeLayout(false);
            this.pnlDetailBottomPad.ResumeLayout(false);
            this.pnlDetailBottomPad.PerformLayout();
            this.pnlDetailBottomTitle.ResumeLayout(false);
            this.pnlDetailBottomTitle.PerformLayout();
            this.pnlDetailFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerchandises)).EndInit();
            this.pnlDetailTop.ResumeLayout(false);
            this.pnlDetailTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Panel pnlDetailBottom;
        private System.Windows.Forms.Panel pnlDetailBottomPad;
        private System.Windows.Forms.Panel pnlDetailBottomTitle;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel pnlDetailFill;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMerchandises;
        private System.Windows.Forms.Panel pnlDetailTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCreatedOn;
        private System.Windows.Forms.Label lblPointValue;
        private System.Windows.Forms.Label lblVolumeValue;
        private System.Windows.Forms.Label lblDescriptionValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblVolumeTitle;
        private System.Windows.Forms.Label lblPointTitle;
        private System.Windows.Forms.Label lblInventoryCodeTitle;
        private System.Windows.Forms.Label lblCreatedOnValue;
        private System.Windows.Forms.Label lblCreatedOnTitle;
        private System.Windows.Forms.Label lblCreatedByValue;
        private System.Windows.Forms.Label lblCreatedByTitle;
        private System.Windows.Forms.LinkLabel lblInventoryCodeValue;
        private System.Windows.Forms.Label lblInventoryTotalStockValue;
        private System.Windows.Forms.Label lblInventoryTotalStockTitle;
        private System.Windows.Forms.Label lblInventoryNameValue;
        private System.Windows.Forms.Label lblInventoryNameTitle;
    }
}