using System;
using System.Collections.Generic;

using System.Windows.Forms;
//using DevExpress.XtraEditors;
using SMS_Management.DataObject;
using SMS_Management.Database;

namespace SMS_Management
{
    public partial class frmMain : FormBase
    {
        delegate void SetDataSourceCallback(object lst);
        private Guid PKEY,PKEY1;
        string name, birthday, phone, diachi;
        SMSRepostitory rep = new SMSRepostitory();
        OrderDTO item = new OrderDTO();
        List<OrderDTO> lstor = new List<OrderDTO>();
        public frmMain()
        {
            InitializeComponent();
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) { }
            else if (tabControl1.SelectedIndex == 1) { }
            else if (tabControl1.SelectedIndex == 2) { }
            else if (tabControl1.SelectedIndex == 3) { }
            else if (tabControl1.SelectedIndex == 4) { LoadDataThucDonMau(); }

        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            comConnection1.PortOpen();
            OrderRepostitory rep = new OrderRepostitory();
            OrderDTO item = rep.GetFromCode("10110101");
            goimonGridView.AutoGenerateColumns = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void SetDatasource(object lst)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.goimonGridView.InvokeRequired)
            {
                SetDataSourceCallback d = new SetDataSourceCallback(SetDatasource);
                this.Invoke(d, new object[] { lst });
            }
            else
            {
                this.goimonGridView.DataSource = null;
                this.goimonGridView.DataSource = lst;
            }
        }

        private void comConnection1_DataReceived(string data)
        {
            OrderRepostitory repO = new OrderRepostitory();
            if (data.Length != 8)
            {
            }
            else
            {
                item = repO.GetFromCode(data);
                ORDER newOD = new ORDER { TABLE_ID = rep.GetTableID(item.TABLE_NAME.ToString()), STATUS = 1, ADD_TIME = System.DateTime.Now };
                repO.InsertOrdered(newOD);
                if (item != null)
                {
                    List<OrderDTO> lst = (List<OrderDTO>)goimonGridView.DataSource;
                    if (lst == null)
                    {
                        lst = new List<OrderDTO>();
                        lst.Add(item);
                        SetDatasource(lst);
                    }
                    else
                    {
                        lst.Add(item);
                        lstor = lst;
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
        string orid, orDishID, orST, orAm, orChefID, ODID;
        private void BindDataTableOrder()
        {
            if (goimonGridView.SelectedRows.Count == 0) return;
           // PKEY = new Guid(goimonGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            name = goimonGridView.SelectedRows[0].Cells["TABLE_NAME"].Value.ToString();
           // phone = goimonGridView.SelectedRows[0].Cells["CODE"].Value.ToString();

            PKEY1 = rep.GetTableID(name);

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
            BindDataTableOrder();
            
          
            using (ChiTietOrderBanAn ChiTietOrderBanAn = new ChiTietOrderBanAn(PKEY1))
            {
                if (ChiTietOrderBanAn.ShowDialog(this.ParentForm) == DialogResult.OK)
                {

                    LoadDataNhanVien();
                }
            }
        }
        

    
    }
}