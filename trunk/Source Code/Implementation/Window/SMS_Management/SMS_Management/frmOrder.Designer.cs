namespace SMS_Management
{
    partial class frmOrder
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
            this.grvOrder = new System.Windows.Forms.DataGridView();
            this.grvOrder_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvOrder_REQUEST_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvOrder_PROCCESSING_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvOrder_WAITER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvOrder_CHEF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvOrder_ADD_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvOrder_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvOrder_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // grvOrder
            // 
            this.grvOrder.AllowUserToAddRows = false;
            this.grvOrder.AllowUserToDeleteRows = false;
            this.grvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvOrder_TABLE_NAME,
            this.grvOrder_REQUEST_COUNT,
            this.grvOrder_PROCCESSING_COUNT,
            this.grvOrder_WAITER_NAME,
            this.grvOrder_CHEF_NAME,
            this.grvOrder_ADD_TIME,
            this.grvOrder_STATUS,
            this.grvOrder_ID});
            this.grvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvOrder.Location = new System.Drawing.Point(0, 0);
            this.grvOrder.Name = "grvOrder";
            this.grvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvOrder.Size = new System.Drawing.Size(794, 437);
            this.grvOrder.TabIndex = 3;
            // 
            // grvOrder_TABLE_NAME
            // 
            this.grvOrder_TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.grvOrder_TABLE_NAME.HeaderText = "Bàn số";
            this.grvOrder_TABLE_NAME.Name = "grvOrder_TABLE_NAME";
            this.grvOrder_TABLE_NAME.ReadOnly = true;
            // 
            // grvOrder_REQUEST_COUNT
            // 
            this.grvOrder_REQUEST_COUNT.DataPropertyName = "REQUEST_COUNT";
            this.grvOrder_REQUEST_COUNT.HeaderText = "Số lượng món yêu cầu";
            this.grvOrder_REQUEST_COUNT.Name = "grvOrder_REQUEST_COUNT";
            this.grvOrder_REQUEST_COUNT.ReadOnly = true;
            // 
            // grvOrder_PROCCESSING_COUNT
            // 
            this.grvOrder_PROCCESSING_COUNT.DataPropertyName = "PROCCESSING_COUNT";
            this.grvOrder_PROCCESSING_COUNT.HeaderText = "Số món đang làm";
            this.grvOrder_PROCCESSING_COUNT.Name = "grvOrder_PROCCESSING_COUNT";
            this.grvOrder_PROCCESSING_COUNT.ReadOnly = true;
            // 
            // grvOrder_WAITER_NAME
            // 
            this.grvOrder_WAITER_NAME.DataPropertyName = "WAITER_NAME";
            this.grvOrder_WAITER_NAME.HeaderText = "Nhân viên";
            this.grvOrder_WAITER_NAME.Name = "grvOrder_WAITER_NAME";
            this.grvOrder_WAITER_NAME.ReadOnly = true;
            // 
            // grvOrder_CHEF_NAME
            // 
            this.grvOrder_CHEF_NAME.DataPropertyName = "CHEF_NAME";
            this.grvOrder_CHEF_NAME.HeaderText = "Đầu bếp";
            this.grvOrder_CHEF_NAME.Name = "grvOrder_CHEF_NAME";
            this.grvOrder_CHEF_NAME.ReadOnly = true;
            // 
            // grvOrder_ADD_TIME
            // 
            this.grvOrder_ADD_TIME.DataPropertyName = "ADD_TIME";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy hh:mm";
            dataGridViewCellStyle1.NullValue = null;
            this.grvOrder_ADD_TIME.DefaultCellStyle = dataGridViewCellStyle1;
            this.grvOrder_ADD_TIME.HeaderText = "Giờ vào";
            this.grvOrder_ADD_TIME.Name = "grvOrder_ADD_TIME";
            // 
            // grvOrder_STATUS
            // 
            this.grvOrder_STATUS.DataPropertyName = "STATUS";
            this.grvOrder_STATUS.HeaderText = "Trạng thái";
            this.grvOrder_STATUS.Name = "grvOrder_STATUS";
            this.grvOrder_STATUS.ReadOnly = true;
            this.grvOrder_STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grvOrder_STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grvOrder_ID
            // 
            this.grvOrder_ID.DataPropertyName = "ID";
            this.grvOrder_ID.HeaderText = "ID";
            this.grvOrder_ID.Name = "grvOrder_ID";
            this.grvOrder_ID.Visible = false;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 437);
            this.Controls.Add(this.grvOrder);
            this.Name = "frmOrder";
            this.Text = "Gọi món";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_REQUEST_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_PROCCESSING_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_WAITER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_CHEF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_ADD_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvOrder_ID;

    }
}