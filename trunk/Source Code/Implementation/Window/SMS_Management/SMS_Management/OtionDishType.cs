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
    public partial class OtionDishType : FormBase
    {
        private Guid PKEY;
        SMSRepostitory rep = new SMSRepostitory();
        public OtionDishType()
        {
            InitializeComponent();
            panel1.Enabled = false;
            toolStripButton4.Enabled = false;
            toolStripButton5.Enabled = false;
            LoadDataThucDon();
        }
        private void LoadDataThucDon()
        {
            List<DISH_TYPE> lst = rep.GetDishType();


            qlthucdonGridView.DataSource = lst;

        }
        private void BindDataThucDon()
        {
            if (qlthucdonGridView.SelectedRows.Count == 0) return;
            PKEY = new Guid(qlthucdonGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            textBox1.Text = qlthucdonGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            FormState = FormStateType.New;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {


                rep.DeleteDishType(PKEY);
                LoadDataThucDon();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.Edit;
            panel1.Enabled = true;
            BindDataThucDon();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
