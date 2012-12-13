using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SMS_Management.DataObject;
using SMS_Management.Database;
using System.Drawing;

namespace SMS_Management
{
    public partial class frmMain : FormBase
    {
        OrderRepostitory repOO = new OrderRepostitory();
        delegate void SetgrvOrderDataSourceCallback(object lst);
        delegate void SetgrvProccessingDataSourceCallback(object lst);
        delegate void SetgrvProccessFinishDataSourceCallback(object lst);
        delegate void SetgrvBillingDataSourceCallback(object lst);
        private Guid PKEY,PKEY1;
        private bool data_recieve = false;
        string name, birthday, phone, diachi;
        SMSRepostitory rep = new SMSRepostitory();
        List<OrderDTO> lstor = new List<OrderDTO>();
        public frmMain()
        {
            InitializeComponent();
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) {refreshgrvOrder(); }
            else if (tabControl1.SelectedIndex == 1) { refreshgrvProccessing(); refreshgrvProccessFinish();  }
            else if (tabControl1.SelectedIndex == 2) { }
            else if (tabControl1.SelectedIndex == 3) { refreshgrvBilling(); }
            else if (tabControl1.SelectedIndex == 4) { LoadDataThucDonMau(); }

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            comConnection1.PortOpen();
            grvOrder.AutoGenerateColumns = false;
            grvProccessing.AutoGenerateColumns = false;
            grvProccessFinish.AutoGenerateColumns = false;
            grvBilling.AutoGenerateColumns = false;
            refreshgrvOrder();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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

        private void refreshgrvOrder()
        {
            OrderRepostitory repO = new OrderRepostitory();
            List<OrderDTO> lst = repO.GetOrderList();
            SetgrvOrderDataSource(lst);
            data_recieve = false;
        }

        private void refreshgrvProccessing()
        {
            ProccessRepostitory repO = new ProccessRepostitory();
            List<ProccessingDTO> lst = repO.GetProccessingList();
            SetgrvProccessingDataSource(lst);
            data_recieve = false;
        }

        private void refreshgrvProccessFinish()
        {
            ProccessRepostitory repO = new ProccessRepostitory();
            List<ProccessingDTO> lst = repO.GetProccessingFinishCancelList();
            SetgrvProccessFinishDataSource(lst);
            data_recieve = false;
        }

        private void refreshgrvBilling()
        {
            PayRepostitory repO = new PayRepostitory();
            List<BillingDTO> lst = repO.GetPayment();
            SetgrvBillingDataSource(lst);
            data_recieve = false;
        }

        private void comConnection1_DataReceived(string data)
        {
            if (data.Length == 8)
            {
                //Lấy thông tin món ăn vừa order
                OrderRepostitory repO = new OrderRepostitory();
                OrderDetailDTO item;
                item = repO.GetOrderDetailFromCode(data);
                if (item != null)
                {
                    repO.InsertOrdered(item);
                    refreshgrvOrder();
                }
            }
            else if (data.Length == 2)
            {
                int p = int.Parse(data[1].ToString());
                ProccessRepostitory repP = new ProccessRepostitory();
                //Finish
                if (data[0] == '5')
                {
                    repP.FinishProcessing(p);
                    refreshgrvProccessing();
                    refreshgrvProccessFinish();
                }
                else if (data[0] == '6')
                {
                    repP.CancelProcessing(p);
                    refreshgrvProccessing();
                    refreshgrvProccessFinish();
                }
            }
            data_recieve = true;
        }      

        private void tabControl2_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.Normal;
            if (tabControl2.SelectedIndex == 0) { LoadDataThucDonMau(); }
            else if (tabControl2.SelectedIndex == 1) { LoadDataThucDon(); }
            else if (tabControl2.SelectedIndex == 2) { LoadDataNhanVien(); }
            else if (tabControl2.SelectedIndex == 3) { LoadDataDauBep(); }
            else if (tabControl2.SelectedIndex == 4) { LoadDataTable();
            }

            panel2.Enabled = false;
            panel1.Enabled = false;
           
        }
     //load data thuc don cho form mon an
        private void LoadDataThucDonMau() {

            dataThucdonGridView1.DataSource = rep.GetDishType();
        }
        private void LoadDataMonAn()
        {

            var lst = rep.GetDishInfo(BindDataThucDonMau());
            qlmonanGridView.DataSource = lst;
           
        }

        private Guid BindDataThucDonMau()
        {
            if (dataThucdonGridView1.SelectedRows.Count == 0) return PKEY;
            PKEY1 = new Guid(dataThucdonGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            return PKEY1;
        }
        
        
        //tab cấu hình thực đơn
        private void BindDataThucDon()
        {
            if (qlthucdonGridView.SelectedRows.Count == 0) return;
            PKEY = new Guid(qlthucdonGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            textBox1.Text = qlthucdonGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
        }
        private void LoadDataThucDon()
        {
            List<DISH_TYPE> lst = rep.GetDishType();


            qlthucdonGridView.DataSource = lst;
        }
   

        private void thucdonADD_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            FormState = FormStateType.New;
        }

        private void thucdonSAVE_Click(object sender, EventArgs e)
        {
            
            DISH_TYPE dt = new DISH_TYPE();
            if (FormState == FormStateType.New)
            {
                dt.NAME = textBox1.Text.Trim();
                rep.InsertDishType(dt);
            }
            else if (FormState == FormStateType.Edit)
            {
                dt.Id = PKEY;
                dt.NAME = textBox1.Text.Trim();
                rep.UpdateDishType(dt);
            }
            FormState = FormStateType.Normal;
            
            LoadDataThucDon();
        }

        private void thucdonEDIT_Click(object sender, EventArgs e)
        {
             
         FormState = FormStateType.Edit;
            panel1.Enabled = true;
            BindDataThucDon();
          
        }

        private void thucdonDELETE_Click(object sender, EventArgs e)
        {

            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
              
                rep.DeleteDishType(PKEY);
                LoadDataThucDon();
            }
        }

        private void qlthucdonGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataThucDon();
        }
    
        //tab cấu hình nhan vien
        public void LoadDataNhanVien()
        {
            qlnhanvienGridView.DataSource = rep.GetWaterInfo();
        }
       
        private void BindDataNhanVien()
        {
            if (qlnhanvienGridView.SelectedRows.Count == 0) return;
            PKEY = new Guid(qlnhanvienGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            name = qlnhanvienGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
           // birthday = qlnhanvienGridView.SelectedRows[0].Cells["BIRTHDAY"].ToString("MMMM dd, yyyy") + ".");
            phone = qlnhanvienGridView.SelectedRows[0].Cells["PHONE"].Value.ToString();
           // diachi = qlnhanvienGridView.SelectedRows[0].Cells["ADDRESS"].Value.ToString();
            diachi="alo";
        }


        private void nhanvienADD_Click(object sender, EventArgs e)
        {
         ////  BindDataNhanVien();
         //   ChiTietThongTinNhanVien show = new ChiTietThongTinNhanVien(null, null, null, null, PKEY, FormStateType.New);
         //   show.Show();

            using (ChiTietThongTinNhanVien chitietthongtinnhanvien = new ChiTietThongTinNhanVien(null, null, null, null, PKEY, FormStateType.New))
            {
                if (chitietthongtinnhanvien.ShowDialog(this.ParentForm) == DialogResult.OK)
                {

                    LoadDataNhanVien();
                }
            }
          
        }

        private void nhanvienDELETE_click(object sender, EventArgs e)
        {
            BindDataNhanVien();
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                //List<Guid> lst = new List<Guid>();
                //lst.Add(PKEY);
                rep.DeleteWaiter(PKEY);
                LoadDataNhanVien();
            }

        }

        private void nhanvienEDIT_click(object sender, EventArgs e)
        {
            //BindDataNhanVien();
            //ChiTietThongTinNhanVien show = new ChiTietThongTinNhanVien(name, birthday, phone, diachi, PKEY, FormStateType.Edit);
            //show.Show();
            using (ChiTietThongTinNhanVien chitietthongtinnhanvien = new ChiTietThongTinNhanVien(name, birthday, phone, diachi, PKEY, FormStateType.Edit))
            {
                if (chitietthongtinnhanvien.ShowDialog(this.ParentForm) == DialogResult.OK)
                {

                    LoadDataNhanVien();
                }
            }
        }
        //tab dau bep
        private void BindDataDauBep()
        {
            if (qldaubepGridView.SelectedRows.Count == 0) return;
            PKEY = new Guid(qldaubepGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            name = qldaubepGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
           // birthday = qldaubepGridView.SelectedRows[0].Cells["BIRTHDAY"].Value.ToString();
            phone = qldaubepGridView.SelectedRows[0].Cells["PHONE"].Value.ToString();
            // diachi = qlnhanvienGridView.SelectedRows[0].Cells["ADDRESS"].Value.ToString();
            diachi = "alo";
        }
         void LoadDataDauBep()
        {
            qldaubepGridView.DataSource = rep.GetChefInfo();
        }


        private void daubepADDbt_Click(object sender, EventArgs e)
        {
            //ChiTietThongTinDauBep show = new ChiTietThongTinDauBep(null, null, null, null, PKEY, FormStateType.New);
            //show.Show();
            using (ChiTietThongTinDauBep ChiTietThongTinDauBep = new ChiTietThongTinDauBep(null, null, null, null, PKEY, FormStateType.New))
            {
                if (ChiTietThongTinDauBep.ShowDialog(this.ParentForm) == DialogResult.OK)
                {

                    LoadDataDauBep();
                }
            }
           

        }

        private void daubepDELETEbt_Click(object sender, EventArgs e)
        {
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                BindDataDauBep();
                
               
               
                rep.DeleteChef(PKEY);
                LoadDataDauBep();
            }
        }

        private void daubepEDITbt_Click(object sender, EventArgs e)
        {
            BindDataDauBep();
            //ChiTietThongTinDauBep show = new ChiTietThongTinDauBep(name, birthday, phone, diachi, PKEY, FormStateType.Edit);
            //show.Show();
            using (ChiTietThongTinDauBep ChiTietThongTinDauBep = new ChiTietThongTinDauBep(name, birthday, phone, diachi, PKEY, FormStateType.Edit))
            {
                if (ChiTietThongTinDauBep.ShowDialog(this.ParentForm) == DialogResult.OK)
                {

                    LoadDataDauBep();
                }
            }
        }

        //tab ban an
        public void LoadDataTable()
        {
            qlbananGridView.DataSource = rep.GetTableInfo();
        }
    
        private void BindDataTable()
        {
            if (qlbananGridView.SelectedRows.Count == 0) return;
            PKEY = new Guid(qlbananGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            name = qlbananGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
            // birthday = qlnhanvienGridView.SelectedRows[0].Cells["BIRTHDAY"].ToString("MMMM dd, yyyy") + ".");
            phone = qlbananGridView.SelectedRows[0].Cells["CODE"].Value.ToString();
            PKEY1 = new Guid(qlbananGridView.SelectedRows[0].Cells["WAITER_ID"].Value.ToString());
            
            WAITER_INFO nameW = rep.GetWaterName(PKEY1);
            diachi = nameW.NAME.ToString();
            
           // diachi = qlbananGridView.SelectedRows[0].Cells["WAITER_ID"].Value.ToString();
          
            // diachi = "alo";
        }

        private void dataThucdonGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataMonAn();
        }

        private void qlbananGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataTable();
            textBox2.Text = name.ToString();
            textBox3.Text = phone.ToString();
            comboBox1.Text = diachi.ToString();
        }

        private void bananADDbt_Click(object sender, EventArgs e)
        {
           FormState = FormStateType.New;
            textBox2.Text = "";
            textBox3.Text ="";
            
            List<string> waitername = rep.GetWaiterNameList();
            comboBox1.DataSource = waitername;
            panel2.Enabled = true;

        }

        private void bananCANCELbt_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            panel2.Enabled = false;
        }

        private void bananEDITbt_Click(object sender, EventArgs e)
        {
            FormState = FormStateType.Edit;
            panel2.Enabled = true;
            BindDataTable();
            textBox2.Text = name.ToString();
            textBox3.Text = phone.ToString();
            comboBox1.Text = diachi.ToString();
        }

        private void bananSAVEbt_Click(object sender, EventArgs e)
        {
            
            TABLES_INFO dt = new TABLES_INFO();
            if (FormState == FormStateType.New)
            {
                dt.NAME = textBox2.Text.Trim();
                dt.CODE = Convert.ToInt32(textBox3.Text);

                dt.WAITER_ID = rep.GetWaiterNameID(comboBox1.SelectedValue.ToString());

                rep.InsertTable(dt);
            }
            else if (FormState == FormStateType.Edit)
            {
                dt.Id = PKEY;
                dt.NAME = textBox1.Text.Trim();
                dt.CODE = Convert.ToInt32(textBox3.Text);
                dt.WAITER_ID = rep.GetWaiterNameID(comboBox1.SelectedText);
                rep.UpdateTable(dt);
            }
            FormState = FormStateType.Normal;

            LoadDataTable();
        }

        private void bananDELETEbt_Click(object sender, EventArgs e)
        {
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                BindDataTable();
                


                rep.DeleteTable(PKEY);
                LoadDataTable();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grvOrder.CurrentRow==null) return;
            {
                Guid id=Guid.Parse(grvOrder.CurrentRow.Cells["grvOrder_ID"].Value.ToString());
                string table_name = grvOrder.CurrentRow.Cells["grvOrder_TABLE_NAME"].Value.ToString();
                string chef_name = grvOrder.CurrentRow.Cells["grvOrder_CHEF_NAME"].Value.ToString();
                string waiter_name = grvOrder.CurrentRow.Cells["grvOrder_WAITER_NAME"].Value.ToString();
                string request_count = grvOrder.CurrentRow.Cells["grvOrder_REQUEST_COUNT"].Value.ToString();
                string add_time = grvOrder.CurrentRow.Cells["grvOrder_ADD_TIME"].Value.ToString();
                frmDishDetail frm = new frmDishDetail(id,table_name,chef_name,waiter_name,add_time,request_count );
                frm.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string str="";
            if (InputBox("Test", "Nhập đoạn mã yêu cầu", ref str) == DialogResult.OK)
            {
                comConnection1_DataReceived(str);
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProccessRepostitory repP = new ProccessRepostitory();
            foreach (DataGridViewRow row in grvOrder.SelectedRows)
            {
                repP.SendToChicken(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
            }
            refreshgrvOrder();
            //
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ProccessRepostitory repP = new ProccessRepostitory();
            foreach (DataGridViewRow row in grvProccessFinish.SelectedRows)
            {
                repP.ConfirmFinishProcessing(Guid.Parse(row.Cells["grvProccessFinish_ID"].Value.ToString()));
            }
            refreshgrvProccessFinish();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ProccessRepostitory repP = new ProccessRepostitory();
            foreach (DataGridViewRow row in grvProccessFinish.SelectedRows)
            {
                repP.ConfirmCancelProcessing(Guid.Parse(row.Cells["grvProccessFinish_ID"].Value.ToString()));
            }
            refreshgrvProccessFinish();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button9_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            PayRepostitory repP = new PayRepostitory();
            foreach (DataGridViewRow row in grvBilling.SelectedRows)
            {
                repP.pay(Guid.Parse(row.Cells["grvBilling_ID"].Value.ToString()));
            }
            refreshgrvBilling();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PayRepostitory repP = new PayRepostitory();
            foreach (DataGridViewRow row in grvOrder.SelectedRows)
            {
                if (!repP.CheckPay(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString())))
                {
                    if (MessageBox.Show(row.Cells["grvOrder_TABLE_NAME"].Value.ToString() + " chưa hoàn thành xong các món ăn. Bạn có muốn thanh toán không?", "Cảnh báo!",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        repP.SendToPayment(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
                    }
                }
                else
                {
                    repP.SendToPayment(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
                }
            }
            refreshgrvOrder();
        }
    
    }
}