
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SMS_Management.DataObject;


namespace SMS_Management
{
    public partial class frmOptionTableInfo : FormBase
    {
        private Guid PKEY,PKEY1;
        string name, code, nhanvien;
       
        WaiterRepostitory rep = new WaiterRepostitory();
        TableRepostitory repT = new TableRepostitory();
        public frmOptionTableInfo()
        {
            InitializeComponent();
    
            panel2.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            LoadDataBanan();
        }
        private void BindDataTable()
        {
            if (grvTableInfo.SelectedRows.Count == 0) return;
            PKEY = new Guid(grvTableInfo.SelectedRows[0].Cells["grv_ID"].Value.ToString());
            name = grvTableInfo.SelectedRows[0].Cells["grv_NAME"].Value.ToString();
            code = grvTableInfo.SelectedRows[0].Cells["grv_CODE"].Value.ToString();
            nhanvien = grvTableInfo.SelectedRows[0].Cells["grv_WaiterName"].Value.ToString();


        }
        void LoadDataBanan()
        {
           grvTableInfo.DataSource = repT.GetTableList();
        }
        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.New;
            textBox2.Text = "";
            textBox3.Text = "";
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tbsAddNew.Enabled = false;
            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;
            List<string> waitername = rep.GetWaiterNameList();
            comboBox1.DataSource = waitername;
            panel2.Enabled = true;

        }

        private void tsbCancel_Click(object sender, System.EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            panel2.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            tbsAddNew.Enabled = true;
            tsbEdit.Enabled = true;
            tsbDelete.Enabled = true;
        }

        private void tsbDelete_Click(object sender, System.EventArgs e)
        {
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                BindDataTable();
                repT.DeleteTable(PKEY);
                LoadDataBanan();
            }
        }

        private void tsbEdit_Click(object sender, System.EventArgs e)
        {
            FormState = FormStateType.Edit;
            panel2.Enabled = true;
            BindDataTable();
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tbsAddNew.Enabled = false;
            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;
            textBox2.Text = name.ToString();
            textBox3.Text = code.ToString();
            comboBox1.Text = nhanvien.ToString();
        }

        private void tsbSave_Click(object sender, System.EventArgs e)
        {
            TableDTO dt = new TableDTO();
            if (FormState == FormStateType.New)
            {
                dt.NAME = textBox2.Text.Trim();
                dt.code = Convert.ToInt32(textBox3.Text);
                dt.WaiterName = comboBox1.SelectedValue.ToString();
                repT.InsertTable(dt);
            }
            else if (FormState == FormStateType.Edit)
            {
                dt.ID = PKEY;
                dt.NAME = textBox2.Text.Trim();
                dt.code = Convert.ToInt32(textBox3.Text);
                dt.WaiterName = comboBox1.SelectedText;
                repT.UpdateTable(dt);
            }
            FormState = FormStateType.Normal;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            tbsAddNew.Enabled = true;
            tsbEdit.Enabled = true;
            tsbDelete.Enabled = true;
            LoadDataBanan();
        }

        private void grvTableInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            BindDataTable();
         
            textBox2.Text = name.ToString();
            textBox3.Text = code.ToString();
            comboBox1.Text = nhanvien.ToString();
        }
    }
}
