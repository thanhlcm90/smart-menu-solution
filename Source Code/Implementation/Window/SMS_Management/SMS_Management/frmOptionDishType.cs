using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS_Management.DataObject;
using SMS_Management.Database;


namespace SMS_Management
{
    public partial class frmOptionDishType : FormBase
    {
        private Guid PKEY;
        DishTypeRepostitory rep = new DishTypeRepostitory();
        public frmOptionDishType()
        {
            InitializeComponent();
            panel1.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            LoadDataThucDon();
        }
        private void LoadDataThucDon()
        {
            List<DishTypeDTO> lst = rep.GetDishTypeList();
            grvDishType.DataSource = lst;

        }
        private void BindDataThucDon()
        {
            if (grvDishType.SelectedRows.Count == 0) return;
            PKEY = new Guid(grvDishType.SelectedRows[0].Cells["grvDishType_ID"].Value.ToString());
            textBox1.Text = grvDishType.SelectedRows[0].Cells["grvDishType_NAME"].Value.ToString();
        }
        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            FormState = FormStateType.New;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tsbAddNew.Enabled = false;
            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            BindDataThucDon();
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {


                rep.DeleteDishType(PKEY);
                LoadDataThucDon();
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.Edit;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tsbAddNew.Enabled = false;
            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;
            panel1.Enabled = true;
            BindDataThucDon();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {

            DishTypeDTO dt = new DishTypeDTO();
            if (FormState == FormStateType.New)
            {
                dt.NAME = textBox1.Text.Trim();
                rep.InsertDishType(dt);
            }
            else if (FormState == FormStateType.Edit)
            {
                dt.ID = PKEY;
                dt.NAME = textBox1.Text.Trim();
                rep.UpdateDishType(dt);
            }
            FormState = FormStateType.Normal;
            panel1.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            tsbAddNew.Enabled = true;
            tsbEdit.Enabled = true;
            tsbDelete.Enabled = true;
            LoadDataThucDon();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            FormState = FormBase.FormStateType.Normal;
            textBox1.Text = "";
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            tsbAddNew.Enabled = true;
            tsbEdit.Enabled = true;
            tsbDelete.Enabled = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grvDishType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataThucDon();
        }

        private void grvDishType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataThucDon();
        }
    }
}
