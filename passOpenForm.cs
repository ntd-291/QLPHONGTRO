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
    public partial class passOpenForm : Form
    {
        MotelManagerEntities data = new MotelManagerEntities();
        
        public passOpenForm()
        {
            InitializeComponent();
        }
        public passOpenForm(String a)
        {
            InitializeComponent();
            
            STAFF temp = data.STAFFs.Find(a);
            textStaffName.Text = temp.StaffName;
            textUserName.Text = temp.UserName;
            USER user = data.USERs.Find(textUserName.Text);
            textOldPass.Text = user.Password;

        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void updateData()
        {
            USER temp = data.USERs.Find(textUserName.Text);
            temp.Password = textNewPass.Text;
            data.SaveChanges();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {

            USER temp = data.USERs.Find(textUserName.Text);
            if(temp.Password==textOldPass.Text)
            {
                if(textNewPass.Text==textPrePass.Text)
                {
                    DialogResult result = MessageBox.Show("Ban co chac chinh sua mat khau co ten user = " + textUserName.Text + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    switch (result)
                    {
                        case DialogResult.Cancel: return;
                        case DialogResult.Yes: { updateData(); this.Close(); break; }
                        case DialogResult.No: return;

                        default:
                            break;

                    }
                }
                else
                {
                    MessageBox.Show("nhap khau moi va nhap lai khong giong nhau!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("sai nhap khau cu!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butShow1_Click(object sender, EventArgs e)
        {
            if (textOldPass.UseSystemPasswordChar == true)
            { textOldPass.UseSystemPasswordChar = false; }
            else
            {
                textOldPass.UseSystemPasswordChar = true;
            }
            
        }

        private void butShow2_Click(object sender, EventArgs e)
        {
            if (textNewPass.UseSystemPasswordChar == true)
            { textNewPass.UseSystemPasswordChar = false; }
            else
            {
                textNewPass.UseSystemPasswordChar = true;
            }
        }
    }
}
