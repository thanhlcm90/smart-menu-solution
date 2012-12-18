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
    public partial class frmOrder : FormBase
    {
        delegate void SetgrvOrderDataSourceCallback(object lst);

        public frmOrder()
        {
            InitializeComponent();
        }

        private void refreshgrvOrder()
        {
            OrderRepostitory repO = new OrderRepostitory();
            List<OrderDTO> lst = repO.GetOrderList();
            SetgrvOrderDataSource(lst);
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            grvOrder.AutoGenerateColumns = false;
            refreshgrvOrder();
        }

        private void SetgrvOrderDataSource(object lst)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.grvOrder.InvokeRequired)
            {
                SetgrvOrderDataSourceCallback d = new SetgrvOrderDataSourceCallback(SetgrvOrderDataSource);
                this.Invoke(d, new object[] { lst });
            }
            else
            {
                this.grvOrder.DataSource = null;
                this.grvOrder.DataSource = lst;
            }
        }
        public override void RefreshData()
        {
            refreshgrvOrder();
        }
    }
}
