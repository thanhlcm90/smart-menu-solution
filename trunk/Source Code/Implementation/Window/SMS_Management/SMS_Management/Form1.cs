using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using SMS_Management.Database;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

using SMS_Management.DataObject;

namespace SMS_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindData();
            LoadData();
        }


        private Guid PKEY;


        private void BindData()
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            PKEY = new Guid(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
        }

        private void LoadData()
        {
            List<DISH_TYPE> lst;
            SMSRepostitory rep = new SMSRepostitory();
            lst = rep.GetDishType();
            //grdData.DataSource = lst;
            dataGridView1.DataSource = lst;
        }
        }
    }

