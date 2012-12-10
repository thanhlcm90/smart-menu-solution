using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMS_Management.Database;

namespace SMS_Management
{
    public partial class ChiTietThongTinDauBep : Form
    {   FormBase.FormStateType formstate;
        Guid Pkey;
        public ChiTietThongTinDauBep(string name, string birthday, string phone, string adress, Guid PkeyG, FormBase.FormStateType state)
        {
            InitializeComponent();
            formstate = state;
            Pkey = PkeyG;
            if (name != null)
            {
                textBox1.Text = name.ToString();
                // textBox2.Text = birthday.ToString();
                textBox3.Text = phone.ToString();
                textBox4.Text = adress.ToString();
            }


        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            SMSRepostitory rep = new SMSRepostitory();;
            CHEF_INFO dt = new CHEF_INFO();
            if (formstate == FormBase.FormStateType.New )
            {
                dt.NAME = textBox1.Text.Trim();
                //dt.BIRTHDAY = textBox2.Text.Trim();
                dt.ADDRESS = textBox3.Text.Trim();
                dt.PHONE = textBox4.Text.Trim();


                rep.InsertCheft(dt);
            }
            else if (formstate == FormBase.FormStateType.Edit)
            {
                dt.Id = Pkey;
                dt.NAME = textBox1.Text.Trim();
                //dt.BIRTHDAY = textBox2.Text.Trim();
                dt.ADDRESS = textBox3.Text.Trim();
                dt.PHONE = textBox4.Text.Trim();
                rep.UpdateChef(dt);
            }
            formstate = FormBase.FormStateType.Normal;
        
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
