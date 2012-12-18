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
    public partial class frmKitchen : FormBase
    {
        delegate void SetgrvProccessingDataSourceCallback(object lst);
        delegate void SetgrvProccessFinishDataSourceCallback(object lst);
        public frmKitchen()
        {
            InitializeComponent();
        }
        private void SetgrvProccessingDataSource(object lst)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.grvProccessing.InvokeRequired)
            {
                SetgrvProccessingDataSourceCallback d = new SetgrvProccessingDataSourceCallback(SetgrvProccessingDataSource);
                this.Invoke(d, new object[] { lst });
            }
            else
            {
                this.grvProccessing.DataSource = null;
                this.grvProccessing.DataSource = lst;
            }
        }

        private void SetgrvProccessFinishDataSource(object lst)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.grvProccessFinish.InvokeRequired)
            {
                SetgrvProccessFinishDataSourceCallback d = new SetgrvProccessFinishDataSourceCallback(SetgrvProccessFinishDataSource);
                this.Invoke(d, new object[] { lst });
            }
            else
            {
                this.grvProccessFinish.DataSource = null;
                this.grvProccessFinish.DataSource = lst;
            }
        }

        private void frmKitchen_Load(object sender, EventArgs e)
        {
            grvProccessing.AutoGenerateColumns = false;
            grvProccessFinish.AutoGenerateColumns = false;
            RefreshData();
        }

        private void refreshgrvProccessing()
        {
            ProccessRepostitory repO = new ProccessRepostitory();
            List<ProccessingDTO> lst = repO.GetProccessingList();
            SetgrvProccessingDataSource(lst);
        }

        private void refreshgrvProccessFinish()
        {
            ProccessRepostitory repO = new ProccessRepostitory();
            List<ProccessingDTO> lst = repO.GetProccessingFinishCancelList();
            SetgrvProccessFinishDataSource(lst);
        }

        public override void RefreshData()
        {
            refreshgrvProccessing();
            refreshgrvProccessFinish();
        }
    }
}
