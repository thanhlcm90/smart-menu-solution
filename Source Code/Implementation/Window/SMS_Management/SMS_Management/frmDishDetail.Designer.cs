namespace SMS_Management
{
    partial class frmDishDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTABLE_NAME = new System.Windows.Forms.TextBox();
            this.txtWAITER_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtREQUEST_COUNT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtADD_TIME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCHEF_NAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCOMMENT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grvDISH = new System.Windows.Forms.DataGridView();
            this.DISH_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISH_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvDISH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn số:";
            // 
            // txtTABLE_NAME
            // 
            this.txtTABLE_NAME.Location = new System.Drawing.Point(110, 26);
            this.txtTABLE_NAME.Name = "txtTABLE_NAME";
            this.txtTABLE_NAME.ReadOnly = true;
            this.txtTABLE_NAME.Size = new System.Drawing.Size(188, 20);
            this.txtTABLE_NAME.TabIndex = 1;
            // 
            // txtWAITER_NAME
            // 
            this.txtWAITER_NAME.Location = new System.Drawing.Point(110, 52);
            this.txtWAITER_NAME.Name = "txtWAITER_NAME";
            this.txtWAITER_NAME.ReadOnly = true;
            this.txtWAITER_NAME.Size = new System.Drawing.Size(188, 20);
            this.txtWAITER_NAME.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người phục vụ:";
            // 
            // txtREQUEST_COUNT
            // 
            this.txtREQUEST_COUNT.Location = new System.Drawing.Point(110, 78);
            this.txtREQUEST_COUNT.Name = "txtREQUEST_COUNT";
            this.txtREQUEST_COUNT.ReadOnly = true;
            this.txtREQUEST_COUNT.Size = new System.Drawing.Size(188, 20);
            this.txtREQUEST_COUNT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng sổ món:";
            // 
            // txtADD_TIME
            // 
            this.txtADD_TIME.Location = new System.Drawing.Point(421, 26);
            this.txtADD_TIME.Name = "txtADD_TIME";
            this.txtADD_TIME.ReadOnly = true;
            this.txtADD_TIME.Size = new System.Drawing.Size(188, 20);
            this.txtADD_TIME.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giờ vào:";
            // 
            // txtCHEF_NAME
            // 
            this.txtCHEF_NAME.Location = new System.Drawing.Point(421, 52);
            this.txtCHEF_NAME.Name = "txtCHEF_NAME";
            this.txtCHEF_NAME.ReadOnly = true;
            this.txtCHEF_NAME.Size = new System.Drawing.Size(188, 20);
            this.txtCHEF_NAME.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đầu bếp:";
            // 
            // txtCOMMENT
            // 
            this.txtCOMMENT.Location = new System.Drawing.Point(110, 104);
            this.txtCOMMENT.Name = "txtCOMMENT";
            this.txtCOMMENT.Size = new System.Drawing.Size(499, 20);
            this.txtCOMMENT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ghi chú";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grvDISH
            // 
            this.grvDISH.AllowUserToAddRows = false;
            this.grvDISH.AllowUserToDeleteRows = false;
            this.grvDISH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvDISH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDISH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DISH_NAME,
            this.DISH_TYPE,
            this.AREA,
            this.MATERIAL,
            this.PRICE,
            this.AMOUNT,
            this.MONEY,
            this.ID,
            this.COMMENT});
            this.grvDISH.Location = new System.Drawing.Point(12, 134);
            this.grvDISH.Name = "grvDISH";
            this.grvDISH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDISH.Size = new System.Drawing.Size(683, 317);
            this.grvDISH.TabIndex = 15;
            this.grvDISH.SelectionChanged += new System.EventHandler(this.grvDISH_SelectionChanged);
            // 
            // DISH_NAME
            // 
            this.DISH_NAME.DataPropertyName = "DISH_NAME";
            this.DISH_NAME.HeaderText = "Tên món";
            this.DISH_NAME.Name = "DISH_NAME";
            this.DISH_NAME.ReadOnly = true;
            // 
            // DISH_TYPE
            // 
            this.DISH_TYPE.DataPropertyName = "DISH_TYPE";
            this.DISH_TYPE.HeaderText = "Thực đơn";
            this.DISH_TYPE.Name = "DISH_TYPE";
            this.DISH_TYPE.ReadOnly = true;
            // 
            // AREA
            // 
            this.AREA.DataPropertyName = "AREA";
            this.AREA.HeaderText = "Vùng";
            this.AREA.Name = "AREA";
            this.AREA.ReadOnly = true;
            // 
            // MATERIAL
            // 
            this.MATERIAL.DataPropertyName = "MATERIAL";
            this.MATERIAL.HeaderText = "Nguyên liệu chính";
            this.MATERIAL.Name = "MATERIAL";
            this.MATERIAL.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            dataGridViewCellStyle7.Format = "###,###,###,##0";
            this.PRICE.DefaultCellStyle = dataGridViewCellStyle7;
            this.PRICE.HeaderText = "Đơn giá";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 70;
            // 
            // AMOUNT
            // 
            this.AMOUNT.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle8.NullValue = null;
            this.AMOUNT.DefaultCellStyle = dataGridViewCellStyle8;
            this.AMOUNT.HeaderText = "Số lượng";
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Width = 70;
            // 
            // MONEY
            // 
            this.MONEY.DataPropertyName = "MONEY";
            dataGridViewCellStyle9.Format = "###,###,###,##0";
            this.MONEY.DefaultCellStyle = dataGridViewCellStyle9;
            this.MONEY.HeaderText = "Thành tiền";
            this.MONEY.Name = "MONEY";
            this.MONEY.ReadOnly = true;
            this.MONEY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MONEY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // COMMENT
            // 
            this.COMMENT.DataPropertyName = "COMMENT";
            this.COMMENT.HeaderText = "COMMENT";
            this.COMMENT.Name = "COMMENT";
            this.COMMENT.Visible = false;
            // 
            // frmDishDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 463);
            this.Controls.Add(this.grvDISH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCOMMENT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCHEF_NAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtADD_TIME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtREQUEST_COUNT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWAITER_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTABLE_NAME);
            this.Controls.Add(this.label1);
            this.Name = "frmDishDetail";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin chi tiết bàn ăn";
            this.Load += new System.EventHandler(this.frmDishDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDISH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTABLE_NAME;
        private System.Windows.Forms.TextBox txtWAITER_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtREQUEST_COUNT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtADD_TIME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCHEF_NAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCOMMENT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grvDISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISH_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISH_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMMENT;
    }
}