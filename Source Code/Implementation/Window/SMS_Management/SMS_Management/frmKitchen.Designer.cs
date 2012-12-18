namespace SMS_Management
{
    partial class frmKitchen
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.grvProccessing = new System.Windows.Forms.DataGridView();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.grvProccessFinish = new System.Windows.Forms.DataGridView();
            this.grvProccessFinish_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessFinish_DISH_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessFinish_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessFinish_CHEF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessFinish_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessFinish_COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessFinish_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_PRIORITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_DISH_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_CHEF_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvProccessing_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProccessing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProccessFinish)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(729, 534);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radGroupBox1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(363, 534);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.grvProccessing);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Danh sách món ăn đang làm và chờ làm";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(363, 534);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Danh sách món ăn đang làm và chờ làm";
            // 
            // grvProccessing
            // 
            this.grvProccessing.AllowUserToAddRows = false;
            this.grvProccessing.AllowUserToDeleteRows = false;
            this.grvProccessing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProccessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProccessing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvProccessing_PRIORITY,
            this.grvProccessing_TABLE_NAME,
            this.grvProccessing_DISH_NAME,
            this.grvProccessing_AMOUNT,
            this.grvProccessing_CHEF_NAME,
            this.grvProccessing_STATUS,
            this.grvProccessing_COMMENT,
            this.grvProccessing_ID});
            this.grvProccessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvProccessing.Location = new System.Drawing.Point(2, 18);
            this.grvProccessing.Margin = new System.Windows.Forms.Padding(2);
            this.grvProccessing.Name = "grvProccessing";
            this.grvProccessing.RowHeadersVisible = false;
            this.grvProccessing.RowTemplate.Height = 24;
            this.grvProccessing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvProccessing.Size = new System.Drawing.Size(359, 514);
            this.grvProccessing.TabIndex = 3;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radGroupBox2);
            this.splitPanel2.Location = new System.Drawing.Point(366, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(363, 534);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.grvProccessFinish);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Danh sách món ăn đã hoàn thành và từ chối";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(363, 534);
            this.radGroupBox2.TabIndex = 0;
            this.radGroupBox2.Text = "Danh sách món ăn đã hoàn thành và từ chối";
            // 
            // grvProccessFinish
            // 
            this.grvProccessFinish.AllowUserToAddRows = false;
            this.grvProccessFinish.AllowUserToDeleteRows = false;
            this.grvProccessFinish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProccessFinish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProccessFinish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvProccessFinish_TABLE_NAME,
            this.grvProccessFinish_DISH_NAME,
            this.grvProccessFinish_AMOUNT,
            this.grvProccessFinish_CHEF_NAME,
            this.grvProccessFinish_STATUS,
            this.grvProccessFinish_COMMENT,
            this.grvProccessFinish_ID});
            this.grvProccessFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvProccessFinish.Location = new System.Drawing.Point(2, 18);
            this.grvProccessFinish.Margin = new System.Windows.Forms.Padding(2);
            this.grvProccessFinish.Name = "grvProccessFinish";
            this.grvProccessFinish.RowHeadersVisible = false;
            this.grvProccessFinish.RowTemplate.Height = 24;
            this.grvProccessFinish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvProccessFinish.Size = new System.Drawing.Size(359, 514);
            this.grvProccessFinish.TabIndex = 5;
            // 
            // grvProccessFinish_TABLE_NAME
            // 
            this.grvProccessFinish_TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.grvProccessFinish_TABLE_NAME.HeaderText = "Bàn số";
            this.grvProccessFinish_TABLE_NAME.Name = "grvProccessFinish_TABLE_NAME";
            this.grvProccessFinish_TABLE_NAME.ReadOnly = true;
            // 
            // grvProccessFinish_DISH_NAME
            // 
            this.grvProccessFinish_DISH_NAME.DataPropertyName = "DISH_NAME";
            this.grvProccessFinish_DISH_NAME.HeaderText = "Món yêu cầu";
            this.grvProccessFinish_DISH_NAME.Name = "grvProccessFinish_DISH_NAME";
            this.grvProccessFinish_DISH_NAME.ReadOnly = true;
            // 
            // grvProccessFinish_AMOUNT
            // 
            this.grvProccessFinish_AMOUNT.DataPropertyName = "AMOUNT";
            this.grvProccessFinish_AMOUNT.HeaderText = "Số lượng";
            this.grvProccessFinish_AMOUNT.Name = "grvProccessFinish_AMOUNT";
            this.grvProccessFinish_AMOUNT.ReadOnly = true;
            // 
            // grvProccessFinish_CHEF_NAME
            // 
            this.grvProccessFinish_CHEF_NAME.DataPropertyName = "CHEF_NAME";
            this.grvProccessFinish_CHEF_NAME.HeaderText = "Đầu bếp";
            this.grvProccessFinish_CHEF_NAME.Name = "grvProccessFinish_CHEF_NAME";
            this.grvProccessFinish_CHEF_NAME.ReadOnly = true;
            // 
            // grvProccessFinish_STATUS
            // 
            this.grvProccessFinish_STATUS.DataPropertyName = "STATUS";
            this.grvProccessFinish_STATUS.HeaderText = "Trạng thái";
            this.grvProccessFinish_STATUS.Name = "grvProccessFinish_STATUS";
            this.grvProccessFinish_STATUS.ReadOnly = true;
            // 
            // grvProccessFinish_COMMENT
            // 
            this.grvProccessFinish_COMMENT.DataPropertyName = "COMMENT";
            this.grvProccessFinish_COMMENT.HeaderText = "Ghi chú";
            this.grvProccessFinish_COMMENT.Name = "grvProccessFinish_COMMENT";
            this.grvProccessFinish_COMMENT.ReadOnly = true;
            // 
            // grvProccessFinish_ID
            // 
            this.grvProccessFinish_ID.DataPropertyName = "ID";
            this.grvProccessFinish_ID.HeaderText = "ID";
            this.grvProccessFinish_ID.Name = "grvProccessFinish_ID";
            this.grvProccessFinish_ID.ReadOnly = true;
            this.grvProccessFinish_ID.Visible = false;
            // 
            // grvProccessing_PRIORITY
            // 
            this.grvProccessing_PRIORITY.DataPropertyName = "PRIORITY";
            this.grvProccessing_PRIORITY.HeaderText = "Thứ tự";
            this.grvProccessing_PRIORITY.Name = "grvProccessing_PRIORITY";
            // 
            // grvProccessing_TABLE_NAME
            // 
            this.grvProccessing_TABLE_NAME.DataPropertyName = "TABLE_NAME";
            this.grvProccessing_TABLE_NAME.HeaderText = "Bàn số";
            this.grvProccessing_TABLE_NAME.Name = "grvProccessing_TABLE_NAME";
            this.grvProccessing_TABLE_NAME.ReadOnly = true;
            // 
            // grvProccessing_DISH_NAME
            // 
            this.grvProccessing_DISH_NAME.DataPropertyName = "DISH_NAME";
            this.grvProccessing_DISH_NAME.HeaderText = "Món yêu cầu";
            this.grvProccessing_DISH_NAME.Name = "grvProccessing_DISH_NAME";
            this.grvProccessing_DISH_NAME.ReadOnly = true;
            // 
            // grvProccessing_AMOUNT
            // 
            this.grvProccessing_AMOUNT.DataPropertyName = "AMOUNT";
            this.grvProccessing_AMOUNT.HeaderText = "Số lượng";
            this.grvProccessing_AMOUNT.Name = "grvProccessing_AMOUNT";
            this.grvProccessing_AMOUNT.ReadOnly = true;
            // 
            // grvProccessing_CHEF_NAME
            // 
            this.grvProccessing_CHEF_NAME.DataPropertyName = "CHEF_NAME";
            this.grvProccessing_CHEF_NAME.HeaderText = "Đầu bếp";
            this.grvProccessing_CHEF_NAME.Name = "grvProccessing_CHEF_NAME";
            this.grvProccessing_CHEF_NAME.ReadOnly = true;
            // 
            // grvProccessing_STATUS
            // 
            this.grvProccessing_STATUS.DataPropertyName = "STATUS";
            this.grvProccessing_STATUS.HeaderText = "Trạng thái";
            this.grvProccessing_STATUS.Name = "grvProccessing_STATUS";
            this.grvProccessing_STATUS.ReadOnly = true;
            // 
            // grvProccessing_COMMENT
            // 
            this.grvProccessing_COMMENT.DataPropertyName = "COMMENT";
            this.grvProccessing_COMMENT.HeaderText = "Ghi chú";
            this.grvProccessing_COMMENT.Name = "grvProccessing_COMMENT";
            this.grvProccessing_COMMENT.ReadOnly = true;
            // 
            // grvProccessing_ID
            // 
            this.grvProccessing_ID.DataPropertyName = "ID";
            this.grvProccessing_ID.HeaderText = "ID";
            this.grvProccessing_ID.Name = "grvProccessing_ID";
            this.grvProccessing_ID.ReadOnly = true;
            this.grvProccessing_ID.Visible = false;
            // 
            // frmKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 534);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "frmKitchen";
            this.Text = "Nhà bếp";
            this.Load += new System.EventHandler(this.frmKitchen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvProccessing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvProccessFinish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public System.Windows.Forms.DataGridView grvProccessing;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        public System.Windows.Forms.DataGridView grvProccessFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessFinish_TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessFinish_DISH_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessFinish_AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessFinish_CHEF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessFinish_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessFinish_COMMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessFinish_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_PRIORITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_DISH_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_CHEF_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_COMMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvProccessing_ID;

    }
}