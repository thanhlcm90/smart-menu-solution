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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.grvTableInfo = new System.Windows.Forms.DataGridView();
            this.grv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_WaiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNew,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbSave,
            this.tsbCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddNew
            // 
            this.tsbAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddNew.Image = global::SMS_Management.Properties.Resources.add;
            this.tsbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNew.Name = "tsbAddNew";
            this.tsbAddNew.Size = new System.Drawing.Size(23, 22);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::SMS_Management.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "tsbDelete";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::SMS_Management.Properties.Resources.edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "tsbEdit";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::SMS_Management.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "tsbSave";
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = global::SMS_Management.Properties.Resources.cancel;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(23, 22);
            this.tsbCancel.Text = "tsbCancel";
            // 
            // grvTableInfo
            // 
            this.grvTableInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTableInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grv_ID,
            this.grv_NAME,
            this.grv_WaiterName,
            this.grv_CODE});
            this.grvTableInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grvTableInfo.Location = new System.Drawing.Point(0, 25);
            this.grvTableInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvTableInfo.Name = "grvTableInfo";
            this.grvTableInfo.RowTemplate.Height = 24;
            this.grvTableInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvTableInfo.Size = new System.Drawing.Size(313, 348);
            this.grvTableInfo.TabIndex = 10;
            // 
            // grv_ID
            // 
            this.grv_ID.DataPropertyName = "ID";
            this.grv_ID.HeaderText = "ID";
            this.grv_ID.Name = "grv_ID";
            this.grv_ID.Visible = false;
            // 
            // grv_NAME
            // 
            this.grv_NAME.DataPropertyName = "NAME";
            this.grv_NAME.HeaderText = "Họ tên";
            this.grv_NAME.Name = "grv_NAME";
            // 
            // grv_WaiterName
            // 
            this.grv_WaiterName.DataPropertyName = "WaiterName";
            this.grv_WaiterName.HeaderText = "Tên nhân viên phụ trách";
            this.grv_WaiterName.Name = "grv_WaiterName";
            // 
            // grv_CODE
            // 
            this.grv_CODE.DataPropertyName = "code";
            this.grv_CODE.HeaderText = "Mã bàn";
            this.grv_CODE.Name = "grv_CODE";
            // 
            // frmOptionDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 373);
            this.Controls.Add(this.grvTableInfo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOptionDish";
            this.Text = "frmOptionDish";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTableInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.DataGridView grvTableInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_WaiterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_CODE;
    }
}