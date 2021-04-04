using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTest
{
    public partial class guestOpenForm : Form
    {
        MotelManagerEntities data = new MotelManagerEntities();
        public callFunction goiHam;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
                goiHam();
        }

        public guestOpenForm()
        {
            InitializeComponent();
            datePickerCheckIn.Visible = false;
            datePickerCheckOut.Visible = false;
            label1.Visible = true;
            label2.Visible = true;

        }
        public guestOpenForm(String a)
        {
            InitializeComponent();
            this.textIDCus.Text = a;
            label1.Visible = false;
            label2.Visible = false;
            loadData(a);
        }
        public bool catchData()
        {
            textIDCus.Text = textIDCus.Text.Trim();
            textSDT.Text = textSDT.Text.Trim();
            Regex reg = new Regex( @"[0-9]{9}");
            Match result = reg.Match(textIDCus.Text);
            if(result.Length==0 || textSDT.Text.Length > 10)
            {
                MessageBox.Show("Nhap dung ID!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            reg = new Regex(@"0[0-9]{9}");
            result = reg.Match(textSDT.Text);
            if (result.Length == 0 || textSDT.Text.Length>10)
            {
                MessageBox.Show("Nhap dung so dien thoai!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //format ho ten
            String temp = textHoTen.Text;           
            temp = temp.Trim();           
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"\s+", " "); ;          
            String[] change = temp.Split(' ');
            temp ="";
            for(int i=0;i< change.Length;i++)
            {
                String a = change[i].Substring(0,1);
                String b = change[i].Substring(1);
               
                a=a.ToUpper();
                
                b=b.ToLower();
                temp =temp+ a + b+" ";
            }
            temp = temp.Trim();
            textHoTen.Text = temp;

            //format address
            temp = textAddress.Text;
            temp = temp.Trim();
            temp = System.Text.RegularExpressions.Regex.Replace(temp, @"\s+", " ");
            change = temp.Split(',');
            temp = "";
            for (int i = 0; i < change.Length; i++)
            {
                if(change[i]!=" ")
                {
                    change[i].Trim();
                    if(change[i].Substring(change[i].Length-1).ToString()==" ")
                    {
                        change[i] = change[i].Substring(0, change[i].Length - 1);
                    }
                    if (change[i].Substring(0,1).ToString() == " ")
                    {
                        change[i] = change[i].Substring(1);
                    }
                    temp =temp+ change[i] + ", ";
                }

               
            }
            temp = temp.Substring(0, temp.Length - 2);
            
            
            change = temp.Split(' ');
            temp = "";
            for (int i = 0; i < change.Length; i++)
            {
                String a = change[i].Substring(0, 1);
                String b = change[i].Substring(1);

                a = a.ToUpper();

                b = b.ToLower();
                temp = temp + a + b + " ";
            }
            temp = temp.Trim();
            textAddress.Text = temp;

            return true;          
        }
        public void loadData(String a)
        {

            
            CUSTOMER c = data.CUSTOMERs.Find(a);
            textHoTen.Text = c.CustomerName.ToString();
            textAddress.Text = c.Address.ToString();
            textSDT.Text = c.NumberPhone.ToString();
            comBoxSexual.Text = c.Sexual.ToString();
            datePickerBirth.Value = c.DateOfBirth.GetValueOrDefault();
            List<REINTINFOR> list = (from b in data.REINTINFORs where b.IDCustomer == a select b).ToList();
            if(list.Count>0)
            {
                labIDRoomShow.Text = list[0].IDRoom.ToString();
                datePickerCheckIn.Value = list[0].CheckInDate.GetValueOrDefault();
                if (list[0].CheckOutDate.GetValueOrDefault().Year == 0001) { datePickerCheckOut.Value = datePickerCheckOut.MinDate; }
                else
                {
                    datePickerCheckOut.Value = list[0].CheckOutDate.GetValueOrDefault();
                }
            }
            else
            {
                datePickerCheckIn.Visible = false;
                datePickerCheckOut.Visible = false;
            }
          
            

        }
      
        public void saveDate()
        {
            
            CUSTOMER customer = new CUSTOMER() {ID=textIDCus.Text, CustomerName = textHoTen.Text,DateOfBirth=datePickerBirth.Value,Address=textAddress.Text,NumberPhone=textSDT.Text,Sexual=comBoxSexual.Text};
            data.CUSTOMERs.Add(customer);
            data.SaveChanges();
        }
        public void updateData()
        {
            CUSTOMER temp = data.CUSTOMERs.Find(textIDCus.Text);
            temp.CustomerName = textHoTen.Text;
            temp.DateOfBirth = datePickerBirth.Value;
            temp.Address = textAddress.Text;
            temp.NumberPhone = textSDT.Text;
            temp.Sexual = comBoxSexual.Text;
            data.SaveChanges();
            
        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (catchData() == false) return;
            List<CUSTOMER> list = (from b in data.CUSTOMERs where b.ID == textIDCus.Text select b).ToList();
            if(list.Count>0)
            {
                DialogResult result = MessageBox.Show("Ban co chac chinh sua khach co ID = "+textIDCus.Text+" khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch(result)
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
                DialogResult result = MessageBox.Show("Ban co chac them khach co ID ="+textIDCus.Text+" khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { saveDate();this.Close(); break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }
                
            }
            
            
        }

        private void guestOpenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
