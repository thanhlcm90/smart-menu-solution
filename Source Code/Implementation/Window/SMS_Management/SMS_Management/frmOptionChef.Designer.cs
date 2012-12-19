namespace SMS_Management
{
    partial class frmOptionChef
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
            this.tbsAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grvChefInfo = new System.Windows.Forms.DataGridView();
            this.grvDishType_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvDishType_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_BIRTHDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvChefInfo)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(662, 27);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 143);
            this.panel3.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 22);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 22);
            this.textBox3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày tháng năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên";
            // 
            // grvChefInfo
            // 
            this.grvChefInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvChefInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvChefInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvDishType_ID,
            this.grvDishType_NAME,
            this.grv_ADDRESS,
            this.grv_PHONE,
            this.grv_BIRTHDAY});
            this.grvChefInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvChefInfo.Location = new System.Drawing.Point(0, 176);
            this.grvChefInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvChefInfo.Name = "grvChefInfo";
            this.grvChefInfo.RowTemplate.Height = 24;
            this.grvChefInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvChefInfo.Size = new System.Drawing.Size(662, 213);
            this.grvChefInfo.TabIndex = 6;
            this.grvChefInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvChefInfo_CellClick);
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
            this.grvDishType_NAME.HeaderText = "Họ tên";
            this.grvDishType_NAME.Name = "grvDishType_NAME";
            // 
            // grv_ADDRESS
            // 
            this.grv_ADDRESS.DataPropertyName = "ADDRESS";
            this.grv_ADDRESS.HeaderText = "Địa chỉ";
            this.grv_ADDRESS.Name = "grv_ADDRESS";
            // 
            // grv_PHONE
            // 
            this.grv_PHONE.DataPropertyName = "PHONE";
            this.grv_PHONE.HeaderText = "Phone";
            this.grv_PHONE.Name = "grv_PHONE";
            // 
            // grv_BIRTHDAY
            // 
            this.grv_BIRTHDAY.DataPropertyName = "BIRTHDAY";
            this.grv_BIRTHDAY.HeaderText = "Ngày sinh";
            this.grv_BIRTHDAY.Name = "grv_BIRTHDAY";
            // 
            // frmOptionChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 389);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grvChefInfo);
            this.Name = "frmOptionChef";
            this.Text = "Option Chefs";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvChefInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvChefInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvDishType_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvDishType_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_BIRTHDAY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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