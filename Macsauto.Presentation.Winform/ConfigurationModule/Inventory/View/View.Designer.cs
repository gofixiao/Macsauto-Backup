namespace Macsauto.Presentation.WinForm.ConfigurationModule.Inventory
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvInventories = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.detailGbx = new System.Windows.Forms.GroupBox();
            this.dgvStorages = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvColInvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColInvCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColInvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColInvStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.lblUoM = new System.Windows.Forms.Label();
            this.txtMeasurement = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new Macsauto.Presentation.WinForm.Controls.ButtonStripItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventories)).BeginInit();
            this.detailPanel.SuspendLayout();
            this.detailGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorages)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvInventories);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.splitContainer.Panel2.Controls.Add(this.detailPanel);
            this.splitContainer.Panel2.Controls.Add(this.headerPanel);
            this.splitContainer.Size = new System.Drawing.Size(944, 308);
            this.splitContainer.SplitterDistance = 235;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 6;
            // 
            // dgvInventories
            // 
            this.dgvInventories.AllowUserToAddRows = false;
            this.dgvInventories.AllowUserToDeleteRows = false;
            this.dgvInventories.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColId,
            this.dgvColCode,
            this.dgvColName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInventories.Location = new System.Drawing.Point(0, 0);
            this.dgvInventories.Name = "dgvInventories";
            this.dgvInventories.ReadOnly = true;
            this.dgvInventories.RowHeadersVisible = false;
            this.dgvInventories.Size = new System.Drawing.Size(235, 308);
            this.dgvInventories.TabIndex = 0;
            this.dgvInventories.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventories_CellEnter);
            // 
            // dgvColId
            // 
            this.dgvColId.HeaderText = "Id";
            this.dgvColId.Name = "dgvColId";
            this.dgvColId.ReadOnly = true;
            this.dgvColId.Visible = false;
            // 
            // dgvColCode
            // 
            this.dgvColCode.HeaderText = "Code";
            this.dgvColCode.Name = "dgvColCode";
            this.dgvColCode.ReadOnly = true;
            // 
            // dgvColName
            // 
            this.dgvColName.HeaderText = "Name";
            this.dgvColName.Name = "dgvColName";
            this.dgvColName.ReadOnly = true;
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.detailGbx);
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPanel.Location = new System.Drawing.Point(0, 150);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Padding = new System.Windows.Forms.Padding(6);
            this.detailPanel.Size = new System.Drawing.Size(703, 158);
            this.detailPanel.TabIndex = 10;
            // 
            // detailGbx
            // 
            this.detailGbx.Controls.Add(this.dgvStorages);
            this.detailGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.detailGbx.Location = new System.Drawing.Point(6, 6);
            this.detailGbx.Name = "detailGbx";
            this.detailGbx.Size = new System.Drawing.Size(691, 146);
            this.detailGbx.TabIndex = 9;
            this.detailGbx.TabStop = false;
            this.detailGbx.Text = "Stock Details";
            // 
            // dgvStorages
            // 
            this.dgvStorages.AllowUserToAddRows = false;
            this.dgvStorages.AllowUserToDeleteRows = false;
            this.dgvStorages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStorages.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColInvId,
            this.dgvColInvCode,
            this.dgvColInvName,
            this.dgvColInvStock});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStorages.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStorages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStorages.Location = new System.Drawing.Point(3, 20);
            this.dgvStorages.Name = "dgvStorages";
            this.dgvStorages.ReadOnly = true;
            this.dgvStorages.RowHeadersVisible = false;
            this.dgvStorages.Size = new System.Drawing.Size(685, 123);
            this.dgvStorages.TabIndex = 1;
            // 
            // dgvColInvId
            // 
            this.dgvColInvId.HeaderText = "Id";
            this.dgvColInvId.Name = "dgvColInvId";
            this.dgvColInvId.ReadOnly = true;
            this.dgvColInvId.Visible = false;
            this.dgvColInvId.Width = 22;
            // 
            // dgvColInvCode
            // 
            this.dgvColInvCode.HeaderText = "Storage Code";
            this.dgvColInvCode.Name = "dgvColInvCode";
            this.dgvColInvCode.ReadOnly = true;
            this.dgvColInvCode.Width = 115;
            // 
            // dgvColInvName
            // 
            this.dgvColInvName.HeaderText = "Storage";
            this.dgvColInvName.Name = "dgvColInvName";
            this.dgvColInvName.ReadOnly = true;
            this.dgvColInvName.Width = 80;
            // 
            // dgvColInvStock
            // 
            this.dgvColInvStock.HeaderText = "Stock";
            this.dgvColInvStock.Name = "dgvColInvStock";
            this.dgvColInvStock.ReadOnly = true;
            this.dgvColInvStock.Width = 66;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblTotalStock);
            this.headerPanel.Controls.Add(this.txtTotalStock);
            this.headerPanel.Controls.Add(this.lblUoM);
            this.headerPanel.Controls.Add(this.txtMeasurement);
            this.headerPanel.Controls.Add(this.lblDescription);
            this.headerPanel.Controls.Add(this.txtDescription);
            this.headerPanel.Controls.Add(this.lblCode);
            this.headerPanel.Controls.Add(this.txtCode);
            this.headerPanel.Controls.Add(this.lblName);
            this.headerPanel.Controls.Add(this.txtFullname);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(703, 150);
            this.headerPanel.TabIndex = 9;
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(14, 105);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(74, 17);
            this.lblTotalStock.TabIndex = 12;
            this.lblTotalStock.Text = "Total stock:";
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Location = new System.Drawing.Point(94, 102);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.ReadOnly = true;
            this.txtTotalStock.Size = new System.Drawing.Size(116, 24);
            this.txtTotalStock.TabIndex = 13;
            // 
            // lblUoM
            // 
            this.lblUoM.AutoSize = true;
            this.lblUoM.Location = new System.Drawing.Point(216, 105);
            this.lblUoM.Name = "lblUoM";
            this.lblUoM.Size = new System.Drawing.Size(118, 17);
            this.lblUoM.TabIndex = 10;
            this.lblUoM.Text = "Measurement Unit:";
            // 
            // txtMeasurement
            // 
            this.txtMeasurement.Location = new System.Drawing.Point(340, 102);
            this.txtMeasurement.Name = "txtMeasurement";
            this.txtMeasurement.ReadOnly = true;
            this.txtMeasurement.Size = new System.Drawing.Size(88, 24);
            this.txtMeasurement.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 17);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 72);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(334, 24);
            this.txtDescription.TabIndex = 9;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(42, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(94, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(116, 24);
            this.txtCode.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(94, 42);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(334, 24);
            this.txtFullname.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.btnClose});
            this.statusStrip.Location = new System.Drawing.Point(0, 332);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(944, 30);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(766, 25);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "List of storages";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 28);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(944, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Macsauto.Presentation.WinForm.Properties.Resources.IC491114;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 362);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "View";
            this.Text = "Inventory - View All";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventories)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailGbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorages)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInventories;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.GroupBox detailGbx;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvStorages;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private Controls.ButtonStripItem btnClose;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.Label lblUoM;
        private System.Windows.Forms.TextBox txtMeasurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColInvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColInvCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColInvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColInvStock;
    }
}