using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS_Management
{
    public partial class frmMain1 : FormBase 
    {
        public frmMain1()
        {
            InitializeComponent();
        }

        private void frmMain1_Load(object sender, EventArgs e)
        {

        }


        private void btnShowDetail_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            frmDishDetail frm = new frmDishDetail();
            openform(frm, this, FormType.Mdi);
        }
    }
}
