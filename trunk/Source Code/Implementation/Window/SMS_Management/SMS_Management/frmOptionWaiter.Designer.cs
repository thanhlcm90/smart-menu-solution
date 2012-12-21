namespace SMS_Management
{
    partial class frmOptionWaiter
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grvWaiterInfo = new System.Windows.Forms.DataGridView();
            this.grvDishType_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvDishType_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_BIRTHDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvWaiterInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 81);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 11);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 116);
            this.panel1.TabIndex = 7;
            // 
            // grvWaiterInfo
            // 
            this.grvWaiterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvWaiterInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvWaiterInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvWaiterInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grvDishType_ID,
            this.grvDishType_NAME,
            this.grv_ADDRESS,
            this.grv_PHONE,
            this.grv_BIRTHDAY});
            this.grvWaiterInfo.Location = new System.Drawing.Point(0, 143);
            this.grvWaiterInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grvWaiterInfo.Name = "grvWaiterInfo";
            this.grvWaiterInfo.RowTemplate.Height = 24;
            this.grvWaiterInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvWaiterInfo.Size = new System.Drawing.Size(483, 167);
            this.grvWaiterInfo.TabIndex = 8;
            this.grvWaiterInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvWaiterInfo_CellContentClick);
            this.grvWaiterInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvWaiterInfo_CellContentClick);
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
            this.grvDishType_NAME.HeaderText = "Name";
            this.grvDishType_NAME.Name = "grvDishType_NAME";
            // 
            // grv_ADDRESS
            // 
            this.grv_ADDRESS.DataPropertyName = "ADDRESS";
            this.grv_ADDRESS.HeaderText = "Address";
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
            this.grv_BIRTHDAY.HeaderText = "Bỉthday";
            this.grv_BIRTHDAY.Name = "grv_BIRTHDAY";
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
            this.toolStrip1.Size = new System.Drawing.Size(483, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsAddNew
            // 
            this.tbsAddNew.Image = global::SMS_Management.Properties.Resources.add;
            this.tbsAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAddNew.Name = "tbsAddNew";
            this.tbsAddNew.Size = new System.Drawing.Size(49, 22);
            this.tbsAddNew.Text = "Add";
            this.tbsAddNew.Click += new System.EventHandler(this.tsbAddNew_Click);
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
            // frmOptionWaiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 310);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grvWaiterInfo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOptionWaiter";
            this.Text = "frmOptionWaiter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvWaiterInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grvWaiterInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbsAddNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvDishType_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grvDishType_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn grv_BIRTHDAY;
    }
}