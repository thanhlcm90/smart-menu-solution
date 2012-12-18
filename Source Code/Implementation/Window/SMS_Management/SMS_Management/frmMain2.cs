using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SMS_Management.DataObject;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls.UI;

namespace SMS_Management
{
    public partial class frmMain2 : Telerik.WinControls.UI.RadRibbonForm
    {
        List<OrderDetailDTO> lstOrderDetail=new List<OrderDetailDTO>();
        public frmMain2()
        {
            InitializeComponent();
            this.AllowAero = false;
            this.IsMdiContainer = true;
            this.radDock1.AutoDetectMdiChildren = true;
            this.documentContainer1.SendToBack();
            this.radDock1.DocumentManager.BoldActiveDocument = true;
        }

        private void comConnection1_DataReceived(string data)
        {
                OrderRepostitory repO = new OrderRepostitory();
                ProccessRepostitory repP = new ProccessRepostitory();
                OrderDetailDTO item;
                short table_code;
                string table_name;
                RadDesktopAlert radDesktopAlert;

                switch (data[0])
                {
                    case '1':
                        if (data.Length == 8)
                        {
                            //Lấy thông tin món ăn vừa order
                            item = repO.GetOrderDetailFromCode(data);
                            if (item != null)
                            {
                                lstOrderDetail.Add(item);
                            }
                        }
                        break;
                    case '9': //Xác nhận hoàn thành gọi món
                        if (data.Length==3)
                        {
                            table_code = Convert.ToInt16(data.Substring(1, 2));
                            repO.InsertOrdered(lstOrderDetail,table_code);
                        }
                        break;
                    case '2': //Hủy món
                        if (data.Length == 8)
                        {
                            item = repO.GetOrderDetailFromCode(data);
                            if (item != null)
                            {
                                repO.CancelOrdered(item);
                            }
                            break;
                        }
                        break;
                    case '3': //Gọi bồi bàn
                        if (data.Length == 3)
                        {
                            table_code = Convert.ToInt16(data.Substring(1, 2));
                            table_name = repO.GetTableName(table_code);
                            radDesktopAlert = new RadDesktopAlert(this.components);
                            radDesktopAlert.FixedSize = new System.Drawing.Size(329, 120);
                            radDesktopAlert.ContentImage = Properties.Resources.waiter;
                            radDesktopAlert.ContentText = table_name + ": gọi nhân viên phục vụ";
                            radDesktopAlert.CaptionText = "Gọi nhân viên";
                            radDesktopAlert.Show();
                        }
                        break;
                    case '4': //Thanh toán
                        if (data.Length == 3)
                        {
                            table_code = Convert.ToInt16(data.Substring(1, 2));
                            table_name = repO.GetTableName(table_code);

                            PayRepostitory repPa = new PayRepostitory();
                            repPa.SendToPayment(table_code);

                            radDesktopAlert = new RadDesktopAlert(this.components);
                            radDesktopAlert.FixedSize = new System.Drawing.Size(329, 120);
                            radDesktopAlert.ContentImage = Properties.Resources.waiter;
                            radDesktopAlert.ContentText = table_name + ": tính tiền";
                            radDesktopAlert.CaptionText = "Thanh toán";
                            radDesktopAlert.Show();
                        }
                        break;
                    case '5':
                        if (data.Length == 2)
                        {
                            int p = int.Parse(data[1].ToString());
                            repP.FinishProcessing(p);
                        }
                        break;
                    case '6':
                        if (data.Length == 2)
                        {
                            int p = int.Parse(data[1].ToString());
                            repP.CancelProcessing(p);
                        }
                        break;
                }
            Form frm = ((HostWindow)this.radDock1.DocumentManager.ActiveDocument).MdiChild;
            ((FormBase)frm).RefreshData();
        }

        private void frmMain2_Load(object sender, EventArgs e)
        {
            Common.openform("frmOrder", this,this.radDock1, FormType.Mdi);
        }


        private void rtOrder_Click(object sender, EventArgs e)
        {
            Common.openform("frmOrder", this, this.radDock1, FormType.Mdi);
        }

        private void rtKitchen_Click(object sender, EventArgs e)
        {
            Common.openform("frmKitchen", this, this.radDock1, FormType.Mdi);
        }

        private void rtBilling_Click(object sender, EventArgs e)
        {
            Common.openform("frmBilling", this, this.radDock1, FormType.Mdi);
        }

        private void rbtShowDetail_Click(object sender, EventArgs e)
        {
            Form frm = ((HostWindow)this.radDock1.DocumentManager.ActiveDocument).MdiChild;
            DataGridView grv= ((frmOrder)frm).grvOrder;
            if (grv.CurrentRow == null) return;
            {
                Guid id = Guid.Parse(grv.CurrentRow.Cells["grvOrder_ID"].Value.ToString());
                string table_name = grv.CurrentRow.Cells["grvOrder_TABLE_NAME"].Value.ToString();
                string chef_name = grv.CurrentRow.Cells["grvOrder_CHEF_NAME"].Value.ToString();
                string waiter_name = grv.CurrentRow.Cells["grvOrder_WAITER_NAME"].Value.ToString();
                string request_count = grv.CurrentRow.Cells["grvOrder_REQUEST_COUNT"].Value.ToString();
                string add_time = grv.CurrentRow.Cells["grvOrder_ADD_TIME"].Value.ToString();
                frmDishDetail frm1 = new frmDishDetail(id, table_name, chef_name, waiter_name, add_time, request_count);
                frm1.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            if (Common.InputBox("Test", "Nhập đoạn mã yêu cầu", ref str) == DialogResult.OK)
            {
                comConnection1_DataReceived(str);
            }
        }

        private void rbtSendToKitchen_Click(object sender, EventArgs e)
        {
            ProccessRepostitory repP = new ProccessRepostitory();
            Form frm = ((HostWindow)this.radDock1.DocumentManager.ActiveDocument).MdiChild;
            DataGridView grv = ((frmOrder)frm).grvOrder;
            foreach (DataGridViewRow row in grv.SelectedRows)
            {
                repP.SendToChicken(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
            }
            ((FormBase)frm).RefreshData();
        }

        private void rbtSendBilling_Click(object sender, EventArgs e)
        {
            PayRepostitory repP = new PayRepostitory();
            Form frm = ((HostWindow)this.radDock1.DocumentManager.ActiveDocument).MdiChild;
            DataGridView grv = ((frmOrder)frm).grvOrder;
            foreach (DataGridViewRow row in grv.SelectedRows)
            {
                if (!repP.CheckPay(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString())))
                {
                    if (MessageBox.Show(row.Cells["grvOrder_TABLE_NAME"].Value.ToString() + " chưa hoàn thành xong các món ăn. Bạn có muốn thanh toán không?", "Cảnh báo!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        repP.SendToPayment(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
                    }
                }
                else
                {
                    repP.SendToPayment(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
                }
            }
            ((FormBase)frm).RefreshData();
        }

        private void rtbConfirmFinish_Click(object sender, EventArgs e)
        {
            ProccessRepostitory repP = new ProccessRepostitory();
            Form frm = ((HostWindow)this.radDock1.DocumentManager.ActiveDocument).MdiChild;
            DataGridView grv = ((frmKitchen)frm).grvProccessFinish;
            foreach (DataGridViewRow row in grv.SelectedRows)
            {
                repP.ConfirmFinishProcessing(Guid.Parse(row.Cells["grvProccessFinish_ID"].Value.ToString()));
            }
            ((FormBase)frm).RefreshData();
        }

        private void rtbConfirmCancel_Click(object sender, EventArgs e)
        {
            ProccessRepostitory repP = new ProccessRepostitory();
            Form frm = ((HostWindow)this.radDock1.DocumentManager.ActiveDocument).MdiChild;
            DataGridView grv = ((frmKitchen)frm).grvProccessFinish;
            foreach (DataGridViewRow row in grv.SelectedRows)
            {
                repP.ConfirmCancelProcessing(Guid.Parse(row.Cells["grvProccessFinish_ID"].Value.ToString()));
            }
            ((FormBase)frm).RefreshData();
        }

        private void rtbConfirmBilling_Click(object sender, EventArgs e)
        {
            PayRepostitory repP = new PayRepostitory();
            Form frm = ((HostWindow)this.radDock1.DocumentManager.ActiveDocument).MdiChild;
            DataGridView grv = ((frmBilling)frm).grvBilling;
            foreach (DataGridViewRow row in grv.SelectedRows)
            {
                if (!repP.CheckPay(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString())))
                {
                    if (MessageBox.Show(row.Cells["grvOrder_TABLE_NAME"].Value.ToString() + " chưa hoàn thành xong các món ăn. Bạn có muốn thanh toán không?", "Cảnh báo!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        repP.SendToPayment(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
                    }
                }
                else
                {
                    repP.SendToPayment(Guid.Parse(row.Cells["grvOrder_ID"].Value.ToString()));
                }
            }
            ((FormBase)frm).RefreshData();
        }



    }
}
