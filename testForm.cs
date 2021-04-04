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
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
            loadCustomer();
        }

        public void loadCustomer()
        {
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                listKhach.Columns.Add("ID", 100);
                listKhach.Columns.Add("Họ Tên", 150);
                listKhach.Columns.Add("Ngày Sinh", 100);
                listKhach.Columns.Add("Địa Chỉ", 200);
                listKhach.Columns.Add("Số điện thoại", 100);
                listKhach.Columns.Add("Giới Tính", 70);
                var ds = (from a in data.USP_PageCustomer(0,2) select a ).ToList();
                
                foreach (var c in ds)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.CustomerName);
                    String[] temp = c.DateOfBirth.ToString().Split(' ');
                    item.SubItems.Add(temp[0]);
                    item.SubItems.Add(c.Address);
                    item.SubItems.Add(c.NumberPhone.ToString());
                    item.SubItems.Add(c.Sexual.ToString());
                    listKhach.Items.Add(item);
                }
            }
        }
        private void loadList()
        {
            listKhach.Clear();
            loadCustomer();
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            guestOpenForm gOF = new guestOpenForm();
            gOF.goiHam = loadList;
            gOF.ShowDialog();


        }


        private void butSua_Click(object sender, EventArgs e)
        {
            if (listKhach.SelectedItems.Count > 0)
            {
                String temp = listKhach.FocusedItem.Text;


                guestOpenForm gOF = new guestOpenForm(temp);
                gOF.goiHam = loadList;
                gOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay chon khach can sua tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listKhach_DoubleClick(object sender, EventArgs e)
        {
            String temp = listKhach.FocusedItem.Text;


            guestOpenForm gOF = new guestOpenForm(temp);
            gOF.goiHam = loadList;
            gOF.ShowDialog();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (listKhach.SelectedItems.Count > 0)
            {
                using (MotelManagerEntities data = new MotelManagerEntities())
                {
                    DialogResult result = MessageBox.Show("Ban co chac xoa khach co ID = " + listKhach.FocusedItem.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {
                                CUSTOMER temp = data.CUSTOMERs.Find(listKhach.FocusedItem.Text);
                                data.CUSTOMERs.Remove(temp);
                                data.SaveChanges();
                                listKhach.Clear();
                                loadCustomer();
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
            //using(MotelManagerEntities data =new MotelManagerEntities())
            //{
            //    String temp = textSearch.Text;
                
            //    List<CUSTOMER> list = (from a in data.CUSTOMERs where a.CustomerName.Contains(temp)   select a).ToList();
            //    listKhach.Clear();
            //    listKhach.Columns.Add("ID", 100);
            //    listKhach.Columns.Add("Họ Tên", 150);
            //    listKhach.Columns.Add("Ngày Sinh", 100);
            //    listKhach.Columns.Add("Địa Chỉ", 200);
            //    listKhach.Columns.Add("Số điện thoại", 100);
            //    listKhach.Columns.Add("Giới Tính", 70);               
            //    foreach (CUSTOMER c in list)
            //    {
            //        ListViewItem item = new ListViewItem(c.ID.ToString());
            //        item.SubItems.Add(c.CustomerName);
            //        String[] temp1 = c.DateOfBirth.ToString().Split(' ');
            //        item.SubItems.Add(temp1[0]);
            //        item.SubItems.Add(c.Address);
            //        item.SubItems.Add(c.NumberPhone.ToString());
            //        item.SubItems.Add(c.Sexual.ToString());
            //        listKhach.Items.Add(item);
            //    }

            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                String temp = textSearch.Text;

                //List<String> name = data.USP_ChangeLanguage(temp).ToList();
                //MessageBox.Show(name[0]);
                //temp = name[0];
                List<CUSTOMER> list = (from a in data.CUSTOMERs where a.CustomerName.Contains(temp) select a).ToList();
                listKhach.Clear();
                listKhach.Columns.Add("ID", 100);
                listKhach.Columns.Add("Họ Tên", 150);
                listKhach.Columns.Add("Ngày Sinh", 100);
                listKhach.Columns.Add("Địa Chỉ", 200);
                listKhach.Columns.Add("Số điện thoại", 100);
                listKhach.Columns.Add("Giới Tính", 70);
                foreach (CUSTOMER c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.CustomerName);
                    String[] temp1 = c.DateOfBirth.ToString().Split(' ');
                    item.SubItems.Add(temp1[0]);
                    item.SubItems.Add(c.Address);
                    item.SubItems.Add(c.NumberPhone.ToString());
                    item.SubItems.Add(c.Sexual.ToString());
                    listKhach.Items.Add(item);
                }
            }
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                MessageBox.Show("show");
            }
        }
    }
}
