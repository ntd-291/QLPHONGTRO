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
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            using (MotelManagerEntities data = new MotelManagerEntities())
            {
                listStaff.Columns.Add("ID", 100);
                listStaff.Columns.Add("Họ Tên", 150);
                listStaff.Columns.Add("Ngày Sinh", 100);
                listStaff.Columns.Add("Địa Chỉ", 200);
                listStaff.Columns.Add("Số điện thoại", 100);
                listStaff.Columns.Add("Tên User", 100);
                listStaff.Columns.Add("Giới Tính", 70);
                List<STAFF> list = data.STAFFs.ToList();

                foreach (STAFF c in list)
                {
                    ListViewItem item = new ListViewItem(c.ID.ToString());
                    item.SubItems.Add(c.StaffName);
                    String[] temp = c.DateOfBirth.ToString().Split(' ');
                    item.SubItems.Add(temp[0]);
                    item.SubItems.Add(c.Address);
                    item.SubItems.Add(c.NumberPhone.ToString());
                    item.SubItems.Add(c.UserName);
                    item.SubItems.Add(c.Sexual.ToString());
                    listStaff.Items.Add(item);
                }
            }
        }
        private void loadList()
        {
            listStaff.Clear();
            loadData();
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            staffOpenForm sOF = new staffOpenForm();
            sOF.goiHam = loadList;
            sOF.ShowDialog();


        }


        private void butSua_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                String temp = listStaff.FocusedItem.Text;


                staffOpenForm sOF = new staffOpenForm(temp);
                sOF.goiHam = loadList;
                sOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay chon quan ly can sua tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listStaff_DoubleClick(object sender, EventArgs e)
        {
            String temp = listStaff.FocusedItem.Text;


            staffOpenForm sOF = new staffOpenForm(temp);
            sOF.goiHam = loadList;
            sOF.ShowDialog();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                using (MotelManagerEntities data = new MotelManagerEntities())
                {
                    DialogResult result = MessageBox.Show("Ban co chac xoa quan ly co ID = " + listStaff.FocusedItem.Text + " khong? (tat ca cac du lieu lien quan deu se bi xoa!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes:
                            {
                                STAFF temp = data.STAFFs.Find(listStaff.FocusedItem.Text);
                                data.STAFFs.Remove(temp);
                                data.SaveChanges();
                                listStaff.Clear();
                                loadData();
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
                MessageBox.Show("Hay chon quan ly can xoa tu danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    

        private void butUser_Click(object sender, EventArgs e)
        {
            if (listStaff.SelectedItems.Count > 0)
            {
                passOpenForm pOF = new passOpenForm(listStaff.FocusedItem.Text);
                pOF.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay chon quan ly can dat mat khau danh sach!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}
