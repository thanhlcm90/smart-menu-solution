namespace SMS_Management
{
    partial class frmOptionTableInfo
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
            this.grvTableInfo = new System.Windows.Forms.DataGridView();
            this.grv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_WaiterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvTableInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.grvTableInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvTableInfo.Location = new System.Drawing.Point(0, 89);
            this.grvTableInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvTableInfo.Name = "grvTableInfo";
            this.grvTableInfo.RowTemplate.Height = 24;
            this.grvTableInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvTableInfo.Size = new System.Drawing.Size(682, 335);
            this.grvTableInfo.TabIndex = 9;
            this.grvTableInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTableInfo_CellClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 25);
            this.panel2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 1);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 1);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 22);
            this.textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(377, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nhân viên phục vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên bàn";
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
            this.toolStrip1.Size = new System.Drawing.Size(682, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsAddNew
            // 
            this.tbsAddNew.Image = global::SMS_Management.Properties.Resources.add;
            this.tbsAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAddNew.Name = "tbsAddNew";
            this.tbsAddNew.Size = new System.Drawing.Size(57, 24);
            this.tbsAddNew.Text = "Add";
            this.tbsAddNew.Click += new System.EventHandler(this.tsbAddNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::SMS_Management.Properties.Resources.edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(55, 24);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSave
            // 
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = global::SMS_Management.Properties.Resources.save;
            this.tsbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(60, 24);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = global::SMS_Management.Properties.Resources.cancel;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(73, 24);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::SMS_Management.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(73, 24);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // frmOptionTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 424);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grvTableInfo);
            this.Controls.Add(this.panel2);
            this.Name = "frmOptionTableInfo";
            this.Text = "frmOptionTableInfo";
            ((System.ComponentModel.ISupportInitialize)(this.grvTableInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grvTableInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_WaiterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_CODE;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbsAddNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}