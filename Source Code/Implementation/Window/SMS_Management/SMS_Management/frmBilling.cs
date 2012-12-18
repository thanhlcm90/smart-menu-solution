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
    public partial class frmBilling : FormBase
    {
        delegate void SetgrvBillingDataSourceCallback(object lst);
        public frmBilling()
        {
            InitializeComponent();
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {
            grvBilling.AutoGenerateColumns = false;
            RefreshData();
        }

        private void SetgrvBillingDataSource(object lst)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.grvBilling.InvokeRequired)
            {
                SetgrvBillingDataSourceCallback d = new SetgrvBillingDataSourceCallback(SetgrvBillingDataSource);
                this.Invoke(d, new object[] { lst });
            }
            else
            {
                this.grvBilling.DataSource = null;
                this.grvBilling.DataSource = lst;
            }
        }

        private void refreshgrvBilling()
        {
            PayRepostitory repO = new PayRepostitory();
            List<BillingDTO> lst = repO.GetPayment();
            SetgrvBillingDataSource(lst);
        }

        public override void RefreshData()
        {
            refreshgrvBilling();
        }
    }
}
