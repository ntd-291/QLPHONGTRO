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
    public partial class rankForm : Form
    {
        int soLuong = 2;
        int dem;
        int tong;
        int tinh;
        public rankForm()
        {
            InitializeComponent();
            loadData(0,soLuong);
            dem = 0;
        }
        public void loadData(int a,int b)
        {
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                listRank.Columns.Add("ID loại phòng", 100);
                listRank.Columns.Add("Tên loại phòng", 150);
                listRank.Columns.Add("Giá Phòng", 100);
                listRank.Columns.Add("Tiền Cọc", 200);
                listRank.Columns.Add("Ghi Chú", 100);

                var list = (from d in data.USP_PageRank(a, b) select d).ToList();


                foreach (var c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.RankName);
                    
                    item.SubItems.Add(c.Price.ToString());
                    item.SubItems.Add(c.Deposits.ToString());
                    item.SubItems.Add(c.About);
                   
                    listRank.Items.Add(item);
                }
                var temp2 = (from c in data.USP_CountRank() select c).ToList();
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
        }
        private void loadList()
        {
            listRank.Clear();
            loadData(0,soLuong);
            dem = 0;
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            rankOpenForm rOF = new rankOpenForm();
            rOF.goiHam = loadList;
            rOF.ShowDialog();


        }


        private void butSua_Click(object sender, EventArgs e)
        {
            if (listRank.SelectedItems.Count > 0)
            {
                String temp = listRank.FocusedItem.Text;


                rankOpenForm rOF = new rankOpenForm(temp);
                rOF.goiHam = loadList;
                rOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay chon khach can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listRank_DoubleClick(object sender, EventArgs e)
        {
            String temp = listRank.FocusedItem.Text;


            rankOpenForm rOF = new rankOpenForm(temp);
            rOF.goiHam = loadList;
            rOF.ShowDialog();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (listRank.SelectedItems.Count > 0)
            {
                using (MotelManagerEntities data = new MotelManagerEntities())
                {
                    DialogResult result = MessageBox.Show("Ban co chac xoa khach co ID = " + listRank.FocusedItem.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {
                              
                                ROOMRANK temp = data.ROOMRANKs.Find(int.Parse(listRank.FocusedItem.Text));
                                data.ROOMRANKs.Remove(temp);
                                data.SaveChanges();
                                listRank.Clear();
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
            else
            {
                MessageBox.Show("Hay chon khach can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            listRank.Clear();
            labPage.Text = "Trang 1/1";
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                String temp = textSearch.Text;
                List<ROOMRANK> list = (from a in data.ROOMRANKs where a.RankName.Contains(temp) || a.ID.ToString().Contains(temp)  select a).ToList();

                listRank.Columns.Add("ID loại phòng", 100);
                listRank.Columns.Add("Tên loại phòng", 150);
                listRank.Columns.Add("Giá Phòng", 100);
                listRank.Columns.Add("Tiền Cọc", 200);
                listRank.Columns.Add("Ghi Chú", 100);
               

                foreach (ROOMRANK c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.RankName);

                    item.SubItems.Add(c.Price.ToString());
                    item.SubItems.Add(c.Deposits.ToString());
                    item.SubItems.Add(c.About);

                    listRank.Items.Add(item);
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
                listRank.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = 0;
                listRank.Clear();
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
                listRank.Clear();
                loadData(dem * soLuong, soLuong);
            }
            else
            {
                dem = tinh - 1;
                listRank.Clear();
                loadData(dem * soLuong, soLuong);
            }
            labPage.Text = "Trang " + (dem + 1) + "/" + tinh;
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Return)
            {
                listRank.Clear();
                labPage.Text = "Trang 1/1";
                using (MotelManagerEntities data = new MotelManagerEntities())
                {
                    String temp = textSearch.Text;
                    List<ROOMRANK> list = (from a in data.ROOMRANKs where a.RankName.Contains(temp) || a.ID.ToString().Contains(temp) select a).ToList();

                    listRank.Columns.Add("ID loại phòng", 100);
                    listRank.Columns.Add("Tên loại phòng", 150);
                    listRank.Columns.Add("Giá Phòng", 100);
                    listRank.Columns.Add("Tiền Cọc", 200);
                    listRank.Columns.Add("Ghi Chú", 100);


                    foreach (ROOMRANK c in list)
                    {
                        ListViewItem item = new ListViewItem(c.ID.ToString());
                        item.SubItems.Add(c.RankName);

                        item.SubItems.Add(c.Price.ToString());
                        item.SubItems.Add(c.Deposits.ToString());
                        item.SubItems.Add(c.About);

                        listRank.Items.Add(item);
                    }

                }
            }
        }
    }
}
