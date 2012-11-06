using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SMS_Management.DataObject;

namespace SMS_Management
{
    public partial class frmMain : FormBase
    {
        delegate void SetDataSourceCallback(object lst);

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            comConnection1.PortOpen();
            OrderRepostitory rep = new OrderRepostitory();
            OrderDTO item = rep.GetFromCode("10110101");
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void SetDatasource(object lst)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.dataGridView1.InvokeRequired)
            {
                SetDataSourceCallback d = new SetDataSourceCallback(SetDatasource);
                this.Invoke(d, new object[] { lst });
            }
            else
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = lst;
            }
        }

        private void comConnection1_DataReceived(string data)
        {
            OrderRepostitory rep = new OrderRepostitory();
            if (data.Length != 8)
            {
            }
            else
            {
                OrderDTO item = rep.GetFromCode(data);
                if (item != null)
                {
                    List<OrderDTO> lst = (List<OrderDTO>)dataGridView1.DataSource;
                    if (lst == null)
                    {
                        lst = new List<OrderDTO>();
                        lst.Add(item);
                        SetDatasource(lst);
                    }
                    else
                    {
                        lst.Add(item);
                        SetDatasource(lst);
                    }
                    comConnection1.SendData(item.DISH_NAME);
                }
                else
                {
                    comConnection1.SendData("not_found");
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            comConnection1.SendData("123");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            comConnection1.SendData("234");
        }
    }
}