using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SMS_Management.DataObject;
using SMS_Management.Database;
using System.Drawing;

namespace SMS_Management
{
    public partial class frmDishDetail : Form
    {
        private Guid  order_id;
        private Guid PKEY;
        public frmDishDetail()
        {
            InitializeComponent();
        }
        public frmDishDetail(Guid order_id, string table_name, string chef_name, string waiter_name, string add_time, string request_count)
        {
            InitializeComponent();
            this.order_id = order_id;
            txtTABLE_NAME.Text = table_name;
            txtCHEF_NAME.Text = chef_name;
            txtWAITER_NAME.Text = waiter_name;
            txtADD_TIME.Text  = add_time;
            txtREQUEST_COUNT.Text  = request_count;
        }
        private void frmDishDetail_Load(object sender, EventArgs e)
        {
            DishRepostitory rep = new DishRepostitory();
            List<DishDTO> lst= rep.GetDishList(order_id);
            grvDISH.DataSource = lst;
        }

        private void BindData()
        {
            if (grvDISH.CurrentRow == null) return;
            PKEY = Guid.Parse (grvDISH.CurrentRow.Cells["ID"].Value.ToString());
            txtCOMMENT.Text = grvDISH.CurrentRow.Cells["COMMENT"].Value == null ? "" : grvDISH.CurrentRow.Cells["COMMENT"].Value.ToString();
        }

        private void grvDISH_SelectionChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
