using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            OrderRepostitory rep = new OrderRepostitory();
            if (data.Length != 8)
            {
            }
            else
            {
                OrderDTO item = rep.GetFromCode(data);
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
            else if (tabControl2.SelectedIndex == 4) { LoadDataTable(); }
            
            
            panel1.Enabled = false;
           
        }
     //load data thuc don cho form mon an
        private void LoadDataThucDonMau() {

            List<DISH_TYPE> lst;
            SMSRepostitory rep = new SMSRepostitory();
            lst = rep.GetDishType();
            dataThucdonGridView1.DataSource = lst;
        }
        private void LoadDataMonAn()
        {

            List<DISH> lst;
            SMSRepostitory rep = new SMSRepostitory();
            lst = rep.GetDishInfo(BindDataThucDonMau());
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
            List<DISH_TYPE> lst;
            SMSRepostitory rep = new SMSRepostitory();
            lst = rep.GetDishType();


            qlthucdonGridView.DataSource = lst;
        }
   

        private void thucdonADD_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            FormState = FormStateType.New;
        }

        private void thucdonSAVE_Click(object sender, EventArgs e)
        {
            SMSRepostitory rep = new SMSRepostitory();
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
                SMSRepostitory rep = new SMSRepostitory();
                List<Guid> lst = new List<Guid>();
                lst.Add(PKEY);
                rep.DeleteDishType(lst);
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
            List<WAITER_INFO> lst;
            SMSRepostitory rep = new SMSRepostitory();
            lst = rep.GetWaterInfo();


            qlnhanvienGridView.DataSource = lst;
        }
       
        private void BindDataNhanVien()
        {
            if (qlnhanvienGridView.SelectedRows.Count == 0) return;
            PKEY = new Guid(qlnhanvienGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            name = qlnhanvienGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
            birthday = qlnhanvienGridView.SelectedRows[0].Cells["BIRTHDAY"].Value.ToString();
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
        {  if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SMSRepostitory rep = new SMSRepostitory();
                List<Guid> lst = new List<Guid>();
                lst.Add(PKEY);
                rep.DeleteWaiter(lst);
                LoadDataNhanVien();
            }

        }

        private void nhanvienEDIT_click(object sender, EventArgs e)
        {
            BindDataNhanVien();
            ChiTietThongTinNhanVien show = new ChiTietThongTinNhanVien(name, birthday, phone, diachi, PKEY, FormStateType.Edit);
            show.Show();
        }
        //tab dau bep
        private void BindDataDauBep()
        {
            if (qldaubepGridView.SelectedRows.Count == 0) return;
            PKEY = new Guid(qldaubepGridView.SelectedRows[0].Cells["Id"].Value.ToString());
            name = qldaubepGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
            birthday = qldaubepGridView.SelectedRows[0].Cells["BIRTHDAY"].Value.ToString();
            phone = qldaubepGridView.SelectedRows[0].Cells["PHONE"].Value.ToString();
            // diachi = qlnhanvienGridView.SelectedRows[0].Cells["ADDRESS"].Value.ToString();
            diachi = "alo";
        }
         void LoadDataDauBep()
        {
            List<CHEF_INFO> lst;
            SMSRepostitory rep = new SMSRepostitory();
            lst = rep.GetChefInfo();


            qldaubepGridView.DataSource = lst;
        }


        private void daubepADDbt_Click(object sender, EventArgs e)
        {
            ChiTietThongTinDauBep show = new ChiTietThongTinDauBep(null, null, null, null, PKEY, FormStateType.New);
            show.Show();

        }

        private void daubepDELETEbt_Click(object sender, EventArgs e)
        {
            if (PKEY == null) { MessageBox.Show("Bạn chưa chọn đối tượng nào", "Cảnh báo"); }
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SMSRepostitory rep = new SMSRepostitory();
                List<Guid> lst = new List<Guid>();
                lst.Add(PKEY);
                rep.DeleteChef(lst);
                LoadDataDauBep();
            }
        }

        private void daubepEDITbt_Click(object sender, EventArgs e)
        {
            BindDataDauBep();
            ChiTietThongTinDauBep show = new ChiTietThongTinDauBep(name, birthday, phone, diachi, PKEY, FormStateType.Edit);
            show.Show();
        }

        //tab ban an
        public void LoadDataTable()
        {
            List<TABLES_INFO> lst;
            SMSRepostitory rep = new SMSRepostitory();
            lst = rep.GetTableInfo();


            qlbananGridView.DataSource = lst;
        }

        private void dataThucdonGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataMonAn();
        }

    
    }
}