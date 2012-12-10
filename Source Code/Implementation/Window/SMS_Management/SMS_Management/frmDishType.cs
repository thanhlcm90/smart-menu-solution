using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS_Management.Database;

namespace SMS_Management
{
    public class frmDishType : FormBase    {

        #region Windows Form Designer generated code
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.lblNAME = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolEdit,
            this.toolStripSeparator1,
            this.toolSave,
            this.toolCancel,
            this.toolStripSeparator2,
            this.toolDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(350, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAdd
            // 
            this.toolAdd.Image = global::SMS_Management.Properties.Resources.add;
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(58, 22);
            this.toolAdd.Text = "Thêm";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolEdit
            // 
            this.toolEdit.Image = global::SMS_Management.Properties.Resources.edit;
            this.toolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(46, 22);
            this.toolEdit.Text = "Sửa";
            this.toolEdit.Click += new System.EventHandler(this.toolEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = global::SMS_Management.Properties.Resources.save;
            this.toolSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(47, 22);
            this.toolSave.Text = "Lưu";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = global::SMS_Management.Properties.Resources.cancel;
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(49, 22);
            this.toolCancel.Text = "Hủy";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = global::SMS_Management.Properties.Resources.delete;
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(47, 22);
            this.toolDelete.Text = "Xóa";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNAME);
            this.groupBox1.Controls.Add(this.lblNAME);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại món ăn";
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(78, 25);
            this.txtNAME.MaxLength = 250;
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(220, 20);
            this.txtNAME.TabIndex = 1;
            // 
            // lblNAME
            // 
            this.lblNAME.AutoSize = true;
            this.lblNAME.Location = new System.Drawing.Point(12, 28);
            this.lblNAME.Name = "lblNAME";
            this.lblNAME.Size = new System.Drawing.Size(45, 13);
            this.lblNAME.TabIndex = 0;
            this.lblNAME.Text = "Tên loại";
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NAME});
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(0, 95);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.ShowEditingIcon = false;
            this.grdData.Size = new System.Drawing.Size(350, 247);
            this.grdData.TabIndex = 2;
            this.grdData.SelectionChanged += new System.EventHandler(this.grdData_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Tên loại";
            this.NAME.MaxInputLength = 250;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 200;
            // 
            // frmDishType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 342);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDishType";
            this.Text = "Danh mục các loại món ăn";
            this.Load += new System.EventHandler(this.frmDishType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.Label lblNAME;
        private ToolStripButton toolAdd;
        private ToolStripButton toolEdit;
        private ToolStripButton toolSave;
        private ToolStripButton toolCancel;
        private ToolStripButton toolDelete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NAME;

        private Guid PKEY;

        public frmDishType()
        {
            InitializeComponent();

        }


        //Khởi tạo các control trên form
        private void InitControl()
        {
            txtNAME.Text = "";
        }

        //Thay đổi trạng thai các control trên form
        private void ChangeControlStatus()
        {
            if (FormState == FormStateType.Normal)
            {
                toolSave.Enabled = false;
                toolCancel.Enabled = false;
                toolAdd.Enabled = true;
                toolEdit.Enabled = true;
                toolDelete.Enabled = true;

                txtNAME.Enabled = false;
            }
            else
            {
                toolSave.Enabled = true;
                toolCancel.Enabled = true;
                toolAdd.Enabled = false;
                toolEdit.Enabled = false;
                toolDelete.Enabled = false;

                txtNAME.Enabled=true;
            }
        }

        //Bind dữ liệu từ lưới lên control
        private void BindData()
        {
            if (grdData.SelectedRows.Count == 0) return;
            PKEY = new Guid(grdData.SelectedRows[0].Cells["Id"].Value.ToString());
            txtNAME.Text = grdData.SelectedRows[0].Cells["NAME"].Value.ToString();
        }

        //Lấy dữ liệu từ Database và đưa vào lưới dữ liệu
        private void LoadData()
        {
            List<DISH_TYPE> lst;
            SMSRepostitory rep = new SMSRepostitory();;
            lst = rep.GetDishType();
            grdData.DataSource = lst;
        }

        private void frmDishType_Load(object sender, EventArgs e)
        {
            ChangeControlStatus();
            InitControl();
            LoadData();
        }

        private void grdData_SelectionChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.New;
            InitControl();
            ChangeControlStatus();
        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.Edit;
            ChangeControlStatus();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            SMSRepostitory rep = new SMSRepostitory();;
            DISH_TYPE dt = new DISH_TYPE();
            if (FormState == FormStateType.New)
            {
                dt.NAME = txtNAME.Text.Trim();
                rep.InsertDishType(dt);
            }
            else if (FormState == FormStateType.Edit)
            {
                dt.Id = PKEY;
                dt.NAME=txtNAME.Text.Trim();
                rep.UpdateDishType(dt);
            }
            FormState = FormStateType.Normal;
            ChangeControlStatus();
            LoadData();
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.Normal;
            ChangeControlStatus();
            LoadData();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SMSRepostitory rep = new SMSRepostitory();;
                List<Guid> lst = new List<Guid>();
                lst.Add(PKEY);
                rep.DeleteDishType(PKEY);
                LoadData();
            }
        }

    }
}
