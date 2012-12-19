namespace SMS_Management
{
    partial class frmBilling
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
            this.grvBilling = new System.Windows.Forms.DataGridView();
            this.grvBilling_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvBilling_REQUEST_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvBilling_MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvBilling_WAITER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvBilling_CHEF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvBilling_SELL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvBilling_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvBilling_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // grvBilling
            // 
            this.grvBilling.AllowUserToAddRows = false;
            this.grvBilling.AllowUserToDeleteRows = false;
            this.grvBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvBilling_TABLE_NAME,
            this.grvBilling_REQUEST_COUNT,
            this.grvBilling_MONEY,
            this.grvBilling_WAITER_NAME,
            this.grvBilling_CHEF_NAME,
            this.grvBilling_SELL_DATE,
            this.grvBilling_STATUS,
            this.grvBilling_ID});
            this.grvBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvBilling.Location = new System.Drawing.Point(0, 0);
            this.grvBilling.Name = "grvBilling";
            this.grvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvBilling.Size = new System.Drawing.Size(638, 470);
            this.grvBilling.TabIndex = 4;
            // 
            // grvBilling_TABLE_NAME
            // 
            this.grvBilling_TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.grvBilling_TABLE_NAME.HeaderText = "Table No";
            this.grvBilling_TABLE_NAME.Name = "grvBilling_TABLE_NAME";
            this.grvBilling_TABLE_NAME.ReadOnly = true;
            // 
            // grvBilling_REQUEST_COUNT
            // 
            this.grvBilling_REQUEST_COUNT.DataPropertyName = "REQUEST_COUNT";
            this.grvBilling_REQUEST_COUNT.HeaderText = "Amount";
            this.grvBilling_REQUEST_COUNT.Name = "grvBilling_REQUEST_COUNT";
            this.grvBilling_REQUEST_COUNT.ReadOnly = true;
            // 
            // grvBilling_MONEY
            // 
            this.grvBilling_MONEY.DataPropertyName = "MONEY";
            dataGridViewCellStyle1.Format = "###,###,###,##0";
            dataGridViewCellStyle1.NullValue = "0";
            this.grvBilling_MONEY.DefaultCellStyle = dataGridViewCellStyle1;
            this.grvBilling_MONEY.HeaderText = "Total Price";
            this.grvBilling_MONEY.Name = "grvBilling_MONEY";
            // 
            // grvBilling_WAITER_NAME
            // 
            this.grvBilling_WAITER_NAME.DataPropertyName = "WAITER_NAME";
            this.grvBilling_WAITER_NAME.HeaderText = "Staff Name";
            this.grvBilling_WAITER_NAME.Name = "grvBilling_WAITER_NAME";
            this.grvBilling_WAITER_NAME.ReadOnly = true;
            // 
            // grvBilling_CHEF_NAME
            // 
            this.grvBilling_CHEF_NAME.DataPropertyName = "CHEF_NAME";
            this.grvBilling_CHEF_NAME.HeaderText = "Chef Name";
            this.grvBilling_CHEF_NAME.Name = "grvBilling_CHEF_NAME";
            this.grvBilling_CHEF_NAME.ReadOnly = true;
            // 
            // grvBilling_SELL_DATE
            // 
            this.grvBilling_SELL_DATE.DataPropertyName = "SELL_DATE";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy hh:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.grvBilling_SELL_DATE.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvBilling_SELL_DATE.HeaderText = "Time Payment";
            this.grvBilling_SELL_DATE.Name = "grvBilling_SELL_DATE";
            // 
            // grvBilling_STATUS
            // 
            this.grvBilling_STATUS.DataPropertyName = "STATUS";
            this.grvBilling_STATUS.HeaderText = "Status";
            this.grvBilling_STATUS.Name = "grvBilling_STATUS";
            this.grvBilling_STATUS.ReadOnly = true;
            this.grvBilling_STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBilling_STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grvBilling_ID
            // 
            this.grvBilling_ID.DataPropertyName = "ID";
            this.grvBilling_ID.HeaderText = "ID";
            this.grvBilling_ID.Name = "grvBilling_ID";
            this.grvBilling_ID.Visible = false;
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 470);
            this.Controls.Add(this.grvBilling);
            this.Name = "frmBilling";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grvBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_REQUEST_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_WAITER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_CHEF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_SELL_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvBilling_ID;

    }
}