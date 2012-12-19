﻿using System;
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
    public partial class frmOptionChef : FormBase
    {
        private Guid PKEY;
        string name, phone, diachi;
        DateTime birthday;
        ChefRepostitory rep = new ChefRepostitory();
        public frmOptionChef()
        {
            InitializeComponent();
            panel3.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            LoadDataDauBep();
        }
        private void BindDataDauBep()
        {
            if (grvChefInfo.SelectedRows.Count == 0) return;
            PKEY = new Guid(grvChefInfo.SelectedRows[0].Cells["grvDishType_ID"].Value.ToString());
            name = grvChefInfo.SelectedRows[0].Cells["grvDishType_NAME"].Value.ToString();
            birthday = DateTime.Parse(grvChefInfo.SelectedRows[0].Cells["grv_BIRTHDAY"].Value.ToString());
            phone = grvChefInfo.SelectedRows[0].Cells["grv_PHONE"].Value.ToString();
            diachi = grvChefInfo.SelectedRows[0].Cells["grv_ADDRESS"].Value.ToString();

        }
        void LoadDataDauBep()
        {
            grvChefInfo.DataSource = rep.GetChefList();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            BindDataDauBep();
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

             
                rep.DeleteChef(PKEY);
                LoadDataDauBep();
            }

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            BindDataDauBep();
            panel3.Enabled = true;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            textBox1.Text = name;
            dateTimePicker1.Value = birthday;
            textBox2.Text = phone;
            textBox1.Text = diachi;
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            FormState = FormBase.FormStateType.Normal;
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
        }

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            FormState = FormStateType.New;
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            BindDataDauBep();

            ChefDTO dt = new ChefDTO();
            if (FormState == FormBase.FormStateType.New)
            {
                dt.NAME = textBox1.Text.Trim();
                dt.BIRTHDAY = dateTimePicker1.Value;
                dt.ADDRESS = textBox1.Text.Trim();
                dt.PHONE = textBox2.Text.Trim();


                rep.InsertChef(dt);
            }
            else if (FormState == FormBase.FormStateType.Edit)
            {
                dt.ID = PKEY;
                dt.NAME = textBox1.Text.Trim();
                dt.BIRTHDAY = dateTimePicker1.Value;
                dt.ADDRESS = textBox1.Text.Trim();
                dt.PHONE = textBox2.Text.Trim();
                rep.UpdateChef(dt);
            }


            FormState = FormStateType.Normal;
            panel3.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            LoadDataDauBep();
        }
    }
}