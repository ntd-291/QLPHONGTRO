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
    public partial class rangeForm : Form
    {
        int soLuong = 2;
        int dem;
        int tong;
        int tinh;
        MotelManagerEntities data = new MotelManagerEntities();
        public rangeForm()
        {
            InitializeComponent();
            loadData(0,soLuong);
            dem = 0;
        }
        public void loadData(int b,int e)
        {
            var list = (from d in data.USP_PageRange(b,e) select d).ToList();
            listRange.Columns.Add("ID Khu vực", 100);
            listRange.Columns.Add("Tên Khu Vực", 140);
            foreach (var a in list)
            {
                ListViewItem item = new ListViewItem(a.ID.ToString());
                item.SubItems.Add(a.RangeName);
                listRange.Items.Add(item);
            }
            var temp2 = (from c in data.USP_CountRange() select c).ToList();
            tong = int.Parse(temp2[0].ToString());
            if (tong % soLuong != 0)
            {
                tinh = tong / soLuong + 1;
            }
            else
            {
                tinh = tong / soLuong;
            }

            labPage.Text = "Trang 1/" + tinh;
        }

        private void listRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            textIDRange.Text= listRange.FocusedItem.Text;
            int a = int.Parse(textIDRange.Text);
            ROOMRANGE b = data.ROOMRANGEs.Find(a);
            textRangeName.Text = b.RangeName;
        }
        public void saveData()
        {
            ROOMRANGE temp = new ROOMRANGE() { RangeName = textRangeName.Text };
            data.ROOMRANGEs.Add(temp);
            data.SaveChanges();
        }
        public void updateData()
        {
            ROOMRANGE a = data.ROOMRANGEs.Find(int.Parse(textIDRange.Text));
            a.RangeName = textRangeName.Text;
            data.SaveChanges();
        }
      
        private void buttUpdate_Click(object sender, EventArgs e)
        {
            if (textRangeName.Text == "")
            {
                MessageBox.Show("Hay nhap ten khu vuc!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }

            if (textIDRange.Text!="")
            {
                DialogResult result = MessageBox.Show("Ban co chac chinh sua khu vuc co ID = " +textIDRange.Text  + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { updateData(); listRange.Clear();
                            loadData(0,soLuong);
                            dem = 0;
                            break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Ban co chac them khu vuc  khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { saveData(); listRange.Clear();
                            loadData(0,soLuong);
                            dem = 0;
                            break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }
            
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if(textIDRange.Text=="")
            {
                MessageBox.Show("Hay chon id can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Ban co chac xoa khu vuc co ID = " + textIDRange.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Cancel: return;
                case DialogResult.Yes:
                    {
                        ROOMRANGE temp = data.ROOMRANGEs.Find(int.Parse(textIDRange.Text));
                        data.ROOMRANGEs.Remove(temp);
                        data.SaveChanges();
                        listRange.Clear();
                        loadData(0,soLuong);
                        dem = 0;
                        break;
                    }
                case DialogResult.No: return;

                default:
                    break;

            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            textIDRange.Text = "";
            textRangeName.Text = "";
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRange.Clear();
            labPage.Text = "Trang 1/1";
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                String temp = textSearch.Text;
                List<ROOMRANGE> list = (from a in data.ROOMRANGEs where a.RangeName.Contains(temp) || a.ID.ToString().Contains(temp)  select a).ToList();
                listRange.Columns.Add("ID Khu vực", 100);
                listRange.Columns.Add("Tên Khu Vực", 140);
                foreach (ROOMRANGE a in list)
                {
                    ListViewItem item = new ListViewItem(a.ID.ToString());
                    item.SubItems.Add(a.RangeName);
                    listRange.Items.Add(item);
                }

            }
        }

        private void butRight_Click(object sender, EventArgs e)
        {
            if (tong % soLuong != 0)
            {
                tinh = tong / soLuong + 1;
            }
            else
            {
                tinh = tong / soLuong;
            }

            if (dem + 1 < tinh)
            {
                dem = dem + 1;
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
        }

        private void butLeft_Click(object sender, EventArgs e)
        {
            if (tong % soLuong != 0)
            {
                tinh = tong / soLuong + 1;
            }
            else
            {
                tinh = tong / soLuong;
            }

            if (dem - 1 >= 0)
            {
                dem = dem - 1;
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listRange.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Return)
            {
                listRange.Clear();
                labPage.Text = "Trang 1/1";
                using (MotelManagerEntities data = new MotelManagerEntities())
                {
                    String temp = textSearch.Text;
                    List<ROOMRANGE> list = (from a in data.ROOMRANGEs where a.RangeName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                    listRange.Columns.Add("ID Khu vực", 100);
                    listRange.Columns.Add("Tên Khu Vực", 140);
                    foreach (ROOMRANGE a in list)
                    {
                        ListViewItem item = new ListViewItem(a.ID.ToString());
                        item.SubItems.Add(a.RangeName);
                        listRange.Items.Add(item);
                    }

                }
            }
        }
    }
}
