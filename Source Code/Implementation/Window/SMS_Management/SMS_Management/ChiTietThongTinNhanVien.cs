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
using System.Runtime.InteropServices;
using System.Security;

namespace SMS_Management
{
    public partial class ChiTietThongTinNhanVien : Form
    {
        FormBase.FormStateType formstate;
        Guid Pkey;
        public ChiTietThongTinNhanVien(string name ,string birthday, string phone, string adress,Guid PkeyG,FormBase.FormStateType state )
        {
            InitializeComponent();
            formstate = state;
            Pkey = PkeyG;
            if (name != null)
            {
                textBox1.Text = name.ToString();
              //  textBox2.Text = birthday.ToString();
                textBox3.Text = phone.ToString();
                textBox4.Text = adress.ToString();
               
            }


        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            SMSRepostitory rep = new SMSRepostitory();
            WAITER_INFO dt = new WAITER_INFO();
            if (formstate == FormBase.FormStateType.New )
            {
                dt.NAME = textBox1.Text.Trim();
                //dt.BIRTHDAY = textBox2.Text.Trim();
                dt.ADDRESS = textBox3.Text.Trim();
                dt.PHONE = textBox4.Text.Trim();


                rep.InsertWaiter(dt);
            }
            else if (formstate == FormBase.FormStateType.Edit)
            {
                dt.Id = Pkey;
                dt.NAME = textBox1.Text.Trim();
                //dt.BIRTHDAY = textBox2.Text.Trim();
                dt.ADDRESS = textBox3.Text.Trim();
                dt.PHONE = textBox4.Text.Trim();
                rep.UpdateWaiter(dt);
            }
            formstate = FormBase.FormStateType.Normal;
            
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietThongTinNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
