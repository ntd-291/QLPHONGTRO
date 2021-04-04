﻿using System;
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
    public partial class serviceForm : Form
    {
        int soLuong = 2;
        int dem;
        int tong;
        int tinh;
        MotelManagerEntities data = new MotelManagerEntities();
        public serviceForm()
        {
            InitializeComponent();
            loadData(0,soLuong);
            dem = 0;
        }
        public void loadData(int b, int e)
        {
            var list = (from d in data.USP_PageService(b,e) select d).ToList();
            listService.Columns.Add("ID Dịch vụ", 100);
            listService.Columns.Add("Tên Dịch Vụ", 140);
            listService.Columns.Add("Đơn Giá", 140);
            foreach (var a in list)
            {
                ListViewItem item = new ListViewItem(a.ID.ToString());
                item.SubItems.Add(a.ServiceName);
                item.SubItems.Add(a.Price.ToString());
                listService.Items.Add(item);
            }
            var temp2 = (from c in data.USP_CountService() select c).ToList();
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

        private void listService_SelectedIndexChanged(object sender, EventArgs e)
        {
            textIDService.Text = listService.FocusedItem.Text;
            int a = int.Parse(textIDService.Text);
            SERVICE b = data.SERVICEs.Find(a);
            textServiceName.Text = b.ServiceName;
            textPrice.Text = b.Price.ToString();
        }
        public void saveData()
        {
            decimal a = decimal.Parse(textPrice.Text);
            SERVICE temp = new SERVICE() { ServiceName=textServiceName.Text, Price=a  };
            data.SERVICEs.Add(temp);
            data.SaveChanges();
        }
        public void updateData()
        {
            SERVICE a = data.SERVICEs.Find(int.Parse(textIDService.Text));
            a.ServiceName = textServiceName.Text;
            decimal b = decimal.Parse(textPrice.Text);
            a.Price = b;
            data.SaveChanges();
        }

        private void buttUpdate_Click(object sender, EventArgs e)
        {
            if (textServiceName.Text == "")
            {
                MessageBox.Show("Hay nhap ten dich vu!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textPrice.Text, "[^0-9.]"))
            {
                MessageBox.Show("Chi nhap so vao don gia!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textPrice.Text = "";
                return;
            }
            if (textIDService.Text != "")
            {
                DialogResult result = MessageBox.Show("Ban co chac chinh sua dich vu co ID = " + textIDService.Text + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes:
                        {
                            updateData(); listService.Clear();
                            loadData(0,soLuong);
                            dem = 0;
                            break;
                        }
                    case DialogResult.No: return;

                    default:
                        break;

                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Ban co chac them dich vu khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes:
                        {
                            saveData(); listService.Clear();
                            loadData(0,soLuong);
                            dem = 0;
                            break;
                        }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }

        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (textIDService.Text == "")
            {
                MessageBox.Show("Hay chon id can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Ban co chac xoa dich vu co ID = " + textIDService.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Cancel: return;
                case DialogResult.Yes:
                    {
                        SERVICE temp = data.SERVICEs.Find(int.Parse(textIDService.Text));
                        data.SERVICEs.Remove(temp);
                        data.SaveChanges();
                        listService.Clear();
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
            textIDService.Text = "";
            textServiceName.Text = "";
            textPrice.Text = "";
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listService.Clear();
            labPage.Text = "Trang 1/1";
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                String temp = textSearch.Text;
                List<SERVICE> list = (from a in data.SERVICEs where a.ServiceName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();
                
                listService.Columns.Add("ID Dịch vụ", 100);
                listService.Columns.Add("Tên Dịch Vụ", 140);
                listService.Columns.Add("Đơn Giá", 140);
                foreach (SERVICE a in list)
                {
                    ListViewItem item = new ListViewItem(a.ID.ToString());
                    item.SubItems.Add(a.ServiceName);
                    item.SubItems.Add(a.Price.ToString());
                    listService.Items.Add(item);
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
                listService.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listService.Clear();
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
                listService.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listService.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Return)
            {
                listService.Clear();
                labPage.Text = "Trang 1/1";
                using (MotelManagerEntities data = new MotelManagerEntities())
                {
                    String temp = textSearch.Text;
                    List<SERVICE> list = (from a in data.SERVICEs where a.ServiceName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                    listService.Columns.Add("ID Dịch vụ", 100);
                    listService.Columns.Add("Tên Dịch Vụ", 140);
                    listService.Columns.Add("Đơn Giá", 140);
                    foreach (SERVICE a in list)
                    {
                        ListViewItem item = new ListViewItem(a.ID.ToString());
                        item.SubItems.Add(a.ServiceName);
                        item.SubItems.Add(a.Price.ToString());
                        listService.Items.Add(item);
                    }


                }
            }
        }
    }
}
