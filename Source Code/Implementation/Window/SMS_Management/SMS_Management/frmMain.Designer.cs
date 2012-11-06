namespace SMS_Management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELL_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMONEY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTABLE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHEF_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBILLING_DETAILS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTABLES_INFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHEF_INFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comConnection1 = new SMS_Management.COMConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISH_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISH_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WAITER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHEF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(673, 326);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.toolStrip1);
            this.xtraTabPage1.Enabled = true;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(667, 298);
            this.xtraTabPage1.Text = "Gọi món";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(74, 67);
            this.toolStripButton1.Text = "Xem chi tiết";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Xem chi tiết";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(77, 67);
            this.toolStripButton3.Text = "Đưa vào bếp";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.ToolTipText = "Đưa vào bếp";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(122, 67);
            this.toolStripButton2.Text = "In danh sách món ăn";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.ToolTipText = "In danh sách món ăn";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(72, 67);
            this.toolStripButton4.Text = "Thanh toán";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.ToolTipText = "Thanh toán";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 67);
            this.toolStripButton5.Text = "Hủy";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.ToolTipText = "Hủy";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Enabled = true;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(667, 298);
            this.xtraTabPage2.Text = "Nhà bếp";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colSELL_DATE
            // 
            this.colSELL_DATE.FieldName = "SELL_DATE";
            this.colSELL_DATE.Name = "colSELL_DATE";
            // 
            // colMONEY
            // 
            this.colMONEY.FieldName = "MONEY";
            this.colMONEY.Name = "colMONEY";
            // 
            // colTABLE_ID
            // 
            this.colTABLE_ID.FieldName = "TABLE_ID";
            this.colTABLE_ID.Name = "colTABLE_ID";
            // 
            // colCHEF_ID
            // 
            this.colCHEF_ID.FieldName = "CHEF_ID";
            this.colCHEF_ID.Name = "colCHEF_ID";
            // 
            // colBILLING_DETAILS
            // 
            this.colBILLING_DETAILS.FieldName = "BILLING_DETAILS";
            this.colBILLING_DETAILS.Name = "colBILLING_DETAILS";
            // 
            // colTABLES_INFO
            // 
            this.colTABLES_INFO.FieldName = "TABLES_INFO";
            this.colTABLES_INFO.Name = "colTABLES_INFO";
            // 
            // colCHEF_INFO
            // 
            this.colCHEF_INFO.FieldName = "CHEF_INFO";
            this.colCHEF_INFO.Name = "colCHEF_INFO";
            // 
            // comConnection1
            // 
            this.comConnection1.Location = new System.Drawing.Point(632, 62);
            this.comConnection1.Name = "comConnection1";
            this.comConnection1.PortBaudRate = 9600;
            this.comConnection1.PortDataBits = 8;
            this.comConnection1.PortName = "COM4";
            this.comConnection1.PortParity = System.IO.Ports.Parity.None;
            this.comConnection1.PortStopBits = System.IO.Ports.StopBits.One;
            this.comConnection1.Size = new System.Drawing.Size(31, 27);
            this.comConnection1.TabIndex = 1;
            this.comConnection1.DataReceived += new SMS_Management.COMConnection.DataReceivedEventHandler(this.comConnection1_DataReceived);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TABLE_NAME,
            this.DISH_NAME,
            this.DISH_AMOUNT,
            this.WAITER_NAME,
            this.CHEF_NAME,
            this.STATUS});
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 230);
            this.dataGridView1.TabIndex = 2;
            // 
            // TABLE_NAME
            // 
            this.TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.TABLE_NAME.HeaderText = "Bàn số";
            this.TABLE_NAME.Name = "TABLE_NAME";
            this.TABLE_NAME.ReadOnly = true;
            this.TABLE_NAME.Width = 70;
            // 
            // DISH_NAME
            // 
            this.DISH_NAME.DataPropertyName = "DISH_NAME";
            this.DISH_NAME.HeaderText = "Tên món ăn";
            this.DISH_NAME.Name = "DISH_NAME";
            this.DISH_NAME.ReadOnly = true;
            this.DISH_NAME.Width = 150;
            // 
            // DISH_AMOUNT
            // 
            this.DISH_AMOUNT.DataPropertyName = "DISH_AMOUNT";
            this.DISH_AMOUNT.HeaderText = "Số lượng";
            this.DISH_AMOUNT.Name = "DISH_AMOUNT";
            this.DISH_AMOUNT.ReadOnly = true;
            this.DISH_AMOUNT.Width = 80;
            // 
            // WAITER_NAME
            // 
            this.WAITER_NAME.DataPropertyName = "WAITER_NAME";
            this.WAITER_NAME.HeaderText = "Nhân viên phục vụ";
            this.WAITER_NAME.Name = "WAITER_NAME";
            this.WAITER_NAME.ReadOnly = true;
            this.WAITER_NAME.Width = 120;
            // 
            // CHEF_NAME
            // 
            this.CHEF_NAME.DataPropertyName = "CHEF_NAME";
            this.CHEF_NAME.HeaderText = "Đầu bếp";
            this.CHEF_NAME.Name = "CHEF_NAME";
            this.CHEF_NAME.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comConnection1);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "SMS Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSELL_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colMONEY;
        private DevExpress.XtraGrid.Columns.GridColumn colTABLE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCHEF_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBILLING_DETAILS;
        private DevExpress.XtraGrid.Columns.GridColumn colTABLES_INFO;
        private DevExpress.XtraGrid.Columns.GridColumn colCHEF_INFO;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private COMConnection comConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISH_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISH_AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WAITER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHEF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}