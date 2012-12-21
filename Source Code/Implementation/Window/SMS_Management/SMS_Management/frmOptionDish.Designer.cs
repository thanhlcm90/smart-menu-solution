namespace SMS_Management
{
    partial class frmOptionDish
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
            this.grvDishInfo = new System.Windows.Forms.DataGridView();
            this.grv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishtypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_VN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvDishType = new System.Windows.Forms.DataGridView();
            this.grvDishType_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvDishType_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.tbNameEn = new System.Windows.Forms.TextBox();
            this.tbNameVn = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvDishInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDishType)).BeginInit();
            this.panel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDishInfo
            // 
            this.grvDishInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvDishInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvDishInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDishInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grv_ID,
            this.dishtypeid,
            this.grv_CODE,
            this.grv_VN,
            this.grv_EN,
            this.grv_PRICE});
            this.grvDishInfo.Location = new System.Drawing.Point(235, 147);
            this.grvDishInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grvDishInfo.Name = "grvDishInfo";
            this.grvDishInfo.RowTemplate.Height = 24;
            this.grvDishInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDishInfo.Size = new System.Drawing.Size(513, 145);
            this.grvDishInfo.TabIndex = 20;
            this.grvDishInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDishInfo_CellClick);
            // 
            // grv_ID
            // 
            this.grv_ID.DataPropertyName = "ID";
            this.grv_ID.HeaderText = "ID";
            this.grv_ID.Name = "grv_ID";
            this.grv_ID.Visible = false;
            // 
            // dishtypeid
            // 
            this.dishtypeid.DataPropertyName = "DISHTYPE_ID";
            this.dishtypeid.HeaderText = "dtid";
            this.dishtypeid.Name = "dishtypeid";
            this.dishtypeid.Visible = false;
            // 
            // grv_CODE
            // 
            this.grv_CODE.DataPropertyName = "CODE";
            this.grv_CODE.HeaderText = "Code";
            this.grv_CODE.Name = "grv_CODE";
            // 
            // grv_VN
            // 
            this.grv_VN.DataPropertyName = "NAME_VN";
            this.grv_VN.HeaderText = "VI Name";
            this.grv_VN.Name = "grv_VN";
            // 
            // grv_EN
            // 
            this.grv_EN.DataPropertyName = "NAME_EN";
            this.grv_EN.HeaderText = "EN Name";
            this.grv_EN.Name = "grv_EN";
            // 
            // grv_PRICE
            // 
            this.grv_PRICE.DataPropertyName = "PRICE";
            this.grv_PRICE.HeaderText = "Price";
            this.grv_PRICE.Name = "grv_PRICE";
            // 
            // grvDishType
            // 
            this.grvDishType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grvDishType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDishType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvDishType_ID,
            this.grvDishType_NAME});
            this.grvDishType.Location = new System.Drawing.Point(12, 56);
            this.grvDishType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grvDishType.Name = "grvDishType";
            this.grvDishType.RowTemplate.Height = 24;
            this.grvDishType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDishType.Size = new System.Drawing.Size(210, 238);
            this.grvDishType.TabIndex = 19;
            this.grvDishType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDishType_CellClick);
            // 
            // grvDishType_ID
            // 
            this.grvDishType_ID.DataPropertyName = "ID";
            this.grvDishType_ID.HeaderText = "ID";
            this.grvDishType_ID.Name = "grvDishType_ID";
            this.grvDishType_ID.Visible = false;
            // 
            // grvDishType_NAME
            // 
            this.grvDishType_NAME.DataPropertyName = "NAME";
            this.grvDishType_NAME.HeaderText = "Tên thực đơn";
            this.grvDishType_NAME.Name = "grvDishType_NAME";
            this.grvDishType_NAME.Width = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dishes in menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Menu list";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.tbNameEn);
            this.panel5.Controls.Add(this.tbNameVn);
            this.panel5.Controls.Add(this.tbCode);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.tbPrice);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Location = new System.Drawing.Point(235, 56);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(513, 67);
            this.panel5.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(222, 41);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "VI Name";
            // 
            // tbNameEn
            // 
            this.tbNameEn.Location = new System.Drawing.Point(274, 39);
            this.tbNameEn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameEn.Name = "tbNameEn";
            this.tbNameEn.Size = new System.Drawing.Size(131, 20);
            this.tbNameEn.TabIndex = 12;
            // 
            // tbNameVn
            // 
            this.tbNameVn.Location = new System.Drawing.Point(274, 12);
            this.tbNameVn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNameVn.Name = "tbNameVn";
            this.tbNameVn.Size = new System.Drawing.Size(131, 20);
            this.tbNameVn.TabIndex = 14;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(65, 12);
            this.tbCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(137, 20);
            this.tbCode.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 40);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Price";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(222, 16);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "EN Name";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(65, 37);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(137, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 12);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Code";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsAddNew,
            this.tsbEdit,
            this.toolStripSeparator1,
            this.tsbSave,
            this.tsbCancel,
            this.toolStripSeparator2,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsAddNew
            // 
            this.tbsAddNew.Image = global::SMS_Management.Properties.Resources.add;
            this.tbsAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAddNew.Name = "tbsAddNew";
            this.tbsAddNew.Size = new System.Drawing.Size(49, 22);
            this.tbsAddNew.Text = "Add";
            this.tbsAddNew.Click += new System.EventHandler(this.tbsAddNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::SMS_Management.Properties.Resources.edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(47, 22);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = global::SMS_Management.Properties.Resources.save;
            this.tsbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(51, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = global::SMS_Management.Properties.Resources.cancel;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(63, 22);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::SMS_Management.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // frmOptionDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 303);
            this.Controls.Add(this.grvDishInfo);
            this.Controls.Add(this.grvDishType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOptionDish";
            this.Text = "Option Dish Menu";
            ((System.ComponentModel.ISupportInitialize)(this.grvDishInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDishType)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbsAddNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbNameEn;
        private System.Windows.Forms.TextBox tbNameVn;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grvDishType;
        private System.Windows.Forms.DataGridView grvDishInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvDishType_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvDishType_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishtypeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_VN;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_PRICE;
    }
}