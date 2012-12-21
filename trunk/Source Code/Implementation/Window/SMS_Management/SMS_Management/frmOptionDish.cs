using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
    public partial class frmOptionDish : FormBase
    {
        private Guid PKEY,PKEY1;
        DishTypeRepostitory rep = new DishTypeRepostitory();
        DishRepostitory repM = new DishRepostitory();
        string namevn, nameen;
        decimal price;
        int code;
        public frmOptionDish()
        {
            InitializeComponent();
            LoadDataThucDon();
            panel5.Enabled = false;
        }

        private void LoadDataThucDon()
        {
            List<DishTypeDTO> lst = rep.GetDishTypeList();
            grvDishType.DataSource = lst;

        }




        private void LoadDataMonAn()
        {
            if (grvDishType.SelectedRows.Count == 0) return;
            List<DishInMenuDTO> lst = repM.GetDishMenuList(PKEY1);
            grvDishInfo.DataSource = lst;

        }
        private void BindDataDishTypeMenu()
        {
            if (grvDishType.SelectedRows.Count == 0) return;
            PKEY1 = new Guid(grvDishType.SelectedRows[0].Cells["grvDishType_ID"].Value.ToString());
           

        }
        private void BindDataDishMenu()
        {
            if (grvDishInfo.SelectedRows.Count == 0) return;
            PKEY = new Guid(grvDishInfo.SelectedRows[0].Cells["grv_ID"].Value.ToString());
            namevn = grvDishInfo.SelectedRows[0].Cells["grv_VN"].Value.ToString();
            nameen = grvDishInfo.SelectedRows[0].Cells["grv_EN"].Value.ToString();
            code = int.Parse(grvDishInfo.SelectedRows[0].Cells["grv_CODE"].Value.ToString());
            price = decimal.Parse(grvDishInfo.SelectedRows[0].Cells["grv_PRICE"].Value.ToString());
            if (grvDishType.SelectedRows.Count != 0)
            {
                PKEY1 = new Guid(grvDishType.SelectedRows[0].Cells["grvDishType_ID"].Value.ToString());
            }
           
     
           
        }
        private void tbsAddNew_Click(object sender, EventArgs e)
        {
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tbsAddNew.Enabled = false;
            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;
            panel5.Enabled = true;
            FormState = FormStateType.New;
            panel5.Enabled = true;
            tbCode.Text = "";
            tbNameEn.Text = "";
            tbPrice.Text = "";
            tbNameVn.Text = "";
        }

        

        private void grvDishType_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            BindDataDishTypeMenu();
            LoadDataMonAn();
        }

        private void grvDishInfo_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            BindDataDishMenu();
            tbCode.Text = code.ToString() ;
            tbNameEn.Text = nameen;
            tbPrice.Text = price.ToString();
            tbNameVn.Text = namevn.ToString();
        }

        private void tsbDelete_Click(object sender, System.EventArgs e)
        {
            BindDataDishMenu();
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                repM.DeleteDish(PKEY);
               
                LoadDataMonAn();
            }
        }

        private void tsbEdit_Click(object sender, System.EventArgs e)
        {
            FormState = FormStateType.Edit;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tbsAddNew.Enabled = false;
            tsbEdit.Enabled = false;
            tsbDelete.Enabled = false;
            panel5.Enabled = true;
            BindDataDishMenu();
        }

        private void tsbSave_Click(object sender, System.EventArgs e)
        {
            BindDataDishMenu();

            DishInMenuDTO dt = new DishInMenuDTO();
            if (FormState == FormBase.FormStateType.New)
            {
                dt.CODE = int.Parse(tbCode.Text);
                dt.NAME_VN = tbNameVn.Text;
                dt.NAME_EN = tbNameEn.Text;
                dt.PRICE = decimal.Parse(tbPrice.Text);
                dt.DISHTYPE_ID = PKEY1;

                repM.InsertDish(dt);
            }
            else if (FormState == FormBase.FormStateType.Edit)
            {
                dt.ID = PKEY;
                dt.CODE = int.Parse(tbCode.Text);
                dt.NAME_VN = tbNameVn.Text;
                dt.NAME_EN = tbNameEn.Text;
                dt.PRICE = decimal.Parse(tbPrice.Text);
                dt.DISHTYPE_ID = PKEY1;
                repM.UpdateDish(dt);
            }
            FormState = FormBase.FormStateType.Normal;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            tbsAddNew.Enabled = true;
            tsbEdit.Enabled = true;
            tsbDelete.Enabled = true;
            LoadDataMonAn();
        }

        private void tsbCancel_Click(object sender, System.EventArgs e)
        {

            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
            tbsAddNew.Enabled = true;
            tsbEdit.Enabled = true;
            tsbDelete.Enabled = true;
        }

     
    }
}
