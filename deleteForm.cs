using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTest
{
    public partial class deleteForm : Form
    {
        
        MotelManagerEntities data = new MotelManagerEntities();
        public deleteForm()
        {
            InitializeComponent();
            loadRoom();
            
        }
        public void loadRoom()
        {
            listRoom.Clear();
            datePickerCheckOut.Value = DateTime.Now;
            var listRent = (from a in data.REINTINFORs where a.CheckOutDate.Value.ToString()=="" select a).ToList();
       
            listRoom.Columns.Add("ID", 100);
            listRoom.Columns.Add("Tên Phòng", 150);
            listRoom.Columns.Add("Trạng Thái", 120);
            listRoom.Columns.Add("Loại phòng", 140);
            listRoom.Columns.Add("Tên Khu Vực ", 200);
            List<MOTELROOM> listMotel=new List<MOTELROOM>();
            
            int dem = 0;
            foreach (var a in listRent)
            {
                if (listMotel.Count > 0)
                {
                    for (int i = 0; i < listMotel.Count; i++)
                    {
                        if (a.IDRoom.Equals(listMotel[i].ID))
                        {

                            dem = 1;

                        }
                    }
                    if (dem == 0)
                    {
                        MOTELROOM b = data.MOTELROOMs.Find(a.IDRoom);
                        listMotel.Add(b);
                    }
                }
                else
                {
                    MOTELROOM b = data.MOTELROOMs.Find(a.IDRoom);
                    listMotel.Add(b);
                   
                }
                dem = 0;
            }
            foreach(MOTELROOM b in listMotel )
            {
                ListViewItem item = new ListViewItem(b.ID.ToString());
                item.SubItems.Add(b.RoomName);
                if (b.StateRoom.Value == true)
                {
                    item.SubItems.Add("phòng đã được thuê");
                }
                else
                {
                    item.SubItems.Add("phòng trống");
                }
                ROOMRANK c = data.ROOMRANKs.Find(b.IDRoomRank);
                item.SubItems.Add(c.RankName.ToString());
                ROOMRANGE d = data.ROOMRANGEs.Find(b.IDRoomRange);
                item.SubItems.Add(d.RangeName.ToString());
                listRoom.Items.Add(item);
            }
            


        }

        private void listRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            listGuest.Clear();
            String temp = listRoom.FocusedItem.Text;
            MOTELROOM a = data.MOTELROOMs.Find(int.Parse(temp));
            List<REINTINFOR> listRent = (from b in data.REINTINFORs where b.IDRoom==a.ID && b.CheckOutDate.Value.ToString().Equals("") select b).ToList();
            
            listGuest.Columns.Add("ID", 100);
            listGuest.Columns.Add("Họ Tên", 150);
            foreach(REINTINFOR c in listRent)
            {
                CUSTOMER d = data.CUSTOMERs.Find(c.IDCustomer);
                ListViewItem item = new ListViewItem(d.ID.ToString());
                item.SubItems.Add(d.CustomerName);
                listGuest.Items.Add(item);
            }
        }
        private void clearShow()
        {
            textIDRoom.Text = "";
            textPhone.Text = "";
            textAddress.Text = "";
            textHoTen.Text = "";
            textIDGuest.Text = "";
            textRoomName.Text = "";
            textSexual.Text= "";
            textBirth.Text = "";
            textCheckIn.Text = "";
        }

        private void listGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearShow();
            String temp = listGuest.FocusedItem.Text;                     
            CUSTOMER customer = data.CUSTOMERs.Find(temp);
            textIDGuest.Text = customer.ID.ToString();
            textPhone.Text = customer.NumberPhone.ToString();
            textAddress.Text = customer.Address;
            textHoTen.Text = customer.CustomerName;
            textSexual.Text = customer.Sexual.ToString();
            textBirth.Text = customer.DateOfBirth.ToString();           
            List<REINTINFOR> a = (from d in data.REINTINFORs where d.IDCustomer==temp select d).ToList();
            MOTELROOM b = data.MOTELROOMs.Find(a[0].IDRoom);
            textIDRoom.Text = b.ID.ToString();
            textRoomName.Text = b.RoomName;
            textCheckIn.Text = a[0].CheckInDate.ToString();
            datePickerCheckOut.Value = DateTime.Now;
        }

        private void butComfirm_Click(object sender, EventArgs e)
        {
            if (listRoom.SelectedItems.Count > 0 && listGuest.SelectedItems.Count>0)
            {
                
                 DialogResult result = MessageBox.Show("Ban co chac khach co ID = " + listGuest.FocusedItem.Text + " tra phong khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes:
                        {
                            REINTINFOR temp = data.REINTINFORs.Find(textIDGuest.Text, int.Parse(textIDRoom.Text));
                            temp.CheckOutDate = datePickerCheckOut.Value;
                            data.SaveChanges();
                            clearShow();
                            listGuest.Clear();
                            loadRoom();
                            
                            break;
                        }
                    case DialogResult.No: return;

                    default:
                        break;


                }
            }
            else
            {
                MessageBox.Show("hay chon phong va khach tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRoom.Clear();
            
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                String temp = textSearch.Text;
                List<REINTINFOR> listRent = (from a in data.REINTINFORs where a.CheckOutDate.Value.ToString() == "" select a).ToList();

                listRoom.Columns.Add("ID", 100);
                listRoom.Columns.Add("Tên Phòng", 150);
                listRoom.Columns.Add("Trạng Thái", 120);
                listRoom.Columns.Add("Loại phòng", 140);
                listRoom.Columns.Add("Tên Khu Vực ", 200);
                List<MOTELROOM> listMotel = new List<MOTELROOM>();

                int dem = 0;
                foreach (REINTINFOR a in listRent)
                {
                    if (listMotel.Count > 0)
                    {
                        for (int i = 0; i < listMotel.Count; i++)
                        {
                            if (a.IDRoom.Equals(listMotel[i].ID))
                            {

                                dem = 1;

                            }
                        }
                        if (dem == 0)
                        {
                            MOTELROOM b = data.MOTELROOMs.Find(a.IDRoom);
                            listMotel.Add(b);
                        }
                    }
                    else
                    {
                        MOTELROOM b = data.MOTELROOMs.Find(a.IDRoom);
                        listMotel.Add(b);

                    }
                    dem = 0;
                }
                List<MOTELROOM> listMotel2 = (from a in listMotel where a.RoomName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                foreach (MOTELROOM b in listMotel2)
                {
                    ListViewItem item = new ListViewItem(b.ID.ToString());
                    item.SubItems.Add(b.RoomName);
                    if (b.StateRoom.Value == true)
                    {
                        item.SubItems.Add("phòng đã được thuê");
                    }
                    else
                    {
                        item.SubItems.Add("phòng trống");
                    }
                    ROOMRANK c = data.ROOMRANKs.Find(b.IDRoomRank);
                    item.SubItems.Add(c.RankName.ToString());
                    ROOMRANGE d = data.ROOMRANGEs.Find(b.IDRoomRange);
                    item.SubItems.Add(d.RangeName.ToString());
                    listRoom.Items.Add(item);
                }


            }
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Return)
            {
                listRoom.Clear();
                
                using (MotelManagerEntities data = new MotelManagerEntities())
                {
                    String temp = textSearch.Text;
                    List<REINTINFOR> listRent = (from a in data.REINTINFORs where a.CheckOutDate.Value.ToString() == "" select a).ToList();

                    listRoom.Columns.Add("ID", 100);
                    listRoom.Columns.Add("Tên Phòng", 150);
                    listRoom.Columns.Add("Trạng Thái", 120);
                    listRoom.Columns.Add("Loại phòng", 140);
                    listRoom.Columns.Add("Tên Khu Vực ", 200);
                    List<MOTELROOM> listMotel = new List<MOTELROOM>();

                    int dem = 0;
                    foreach (REINTINFOR a in listRent)
                    {
                        if (listMotel.Count > 0)
                        {
                            for (int i = 0; i < listMotel.Count; i++)
                            {
                                if (a.IDRoom.Equals(listMotel[i].ID))
                                {

                                    dem = 1;

                                }
                            }
                            if (dem == 0)
                            {
                                MOTELROOM b = data.MOTELROOMs.Find(a.IDRoom);
                                listMotel.Add(b);
                            }
                        }
                        else
                        {
                            MOTELROOM b = data.MOTELROOMs.Find(a.IDRoom);
                            listMotel.Add(b);

                        }
                        dem = 0;
                    }
                    List<MOTELROOM> listMotel2 = (from a in listMotel where a.RoomName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                    foreach (MOTELROOM b in listMotel2)
                    {
                        ListViewItem item = new ListViewItem(b.ID.ToString());
                        item.SubItems.Add(b.RoomName);
                        if (b.StateRoom.Value == true)
                        {
                            item.SubItems.Add("phòng đã được thuê");
                        }
                        else
                        {
                            item.SubItems.Add("phòng trống");
                        }
                        ROOMRANK c = data.ROOMRANKs.Find(b.IDRoomRank);
                        item.SubItems.Add(c.RankName.ToString());
                        ROOMRANGE d = data.ROOMRANGEs.Find(b.IDRoomRange);
                        item.SubItems.Add(d.RangeName.ToString());
                        listRoom.Items.Add(item);
                    }


                }
            }
        }

   
    }
}
