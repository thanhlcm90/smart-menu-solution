
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS_Management.DataObject;
namespace SMS_Management
{
    public partial class frmOptionWaiter : FormBase
    {
   
           private Guid PKEY;
        string name, phone, diachi;
        DateTime birthday;
        WaiterRepostitory rep = new WaiterRepostitory();
        public frmOptionWaiter()
        {
            InitializeComponent();
            panel1.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            LoadDataPhucVu();
        }
        private void BindDataPhucVu()
        {
            if (grvWaiterInfo.SelectedRows.Count == 0) return;
            PKEY = new Guid(grvWaiterInfo.SelectedRows[0].Cells["grvDishType_ID"].Value.ToString());
            name = grvWaiterInfo.SelectedRows[0].Cells["grvDishType_NAME"].Value.ToString();
            birthday = DateTime.Parse(grvWaiterInfo.SelectedRows[0].Cells["grv_BIRTHDAY"].Value.ToString());
            phone = grvWaiterInfo.SelectedRows[0].Cells["grv_PHONE"].Value.ToString();
            diachi = grvWaiterInfo.SelectedRows[0].Cells["grv_ADDRESS"].Value.ToString();

        }
        void LoadDataPhucVu()
        {
            grvWaiterInfo.DataSource = rep.GetWaiterList();
        }
        //private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            BindDataPhucVu();
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                rep.DeleteWaiter(PKEY);
                LoadDataPhucVu();
            }

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            BindDataPhucVu();
            panel1.Enabled = true;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            textBox3.Text = name;
            dateTimePicker1.Value = birthday;
            textBox1.Text = phone;
            textBox2.Text = diachi;
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            FormState = FormBase.FormStateType.Normal;
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
        }

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            FormState = FormStateType.New;
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            BindDataPhucVu();

            WaiterDTO dt = new WaiterDTO();
            if (FormState == FormBase.FormStateType.New)
            {
                dt.NAME = textBox3.Text.Trim();
                dt.BIRTHDAY = dateTimePicker1.Value;
                dt.ADDRESS = textBox2.Text.Trim();
                dt.PHONE = textBox1.Text.Trim();
                
                rep.InsertWaiter(dt);
            }
            else if (FormState == FormBase.FormStateType.Edit)
            {
                dt.ID = PKEY;
                dt.NAME = textBox3.Text.Trim();
                dt.BIRTHDAY = dateTimePicker1.Value;
                dt.ADDRESS = textBox2.Text.Trim();
                dt.PHONE = textBox1.Text.Trim();
                
                rep.UpdateWaiter(dt);
            }
            FormState = FormStateType.Normal;
            panel1.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            LoadDataPhucVu();
        }
    }
    
}
