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
    public partial class rankOpenForm : Form
    {
        MotelManagerEntities data = new MotelManagerEntities();
        public callFunction goiHam;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (goiHam != null)
                goiHam();
        }
        public rankOpenForm()
        {
            InitializeComponent();
        }
        public rankOpenForm(String a)
        {
            InitializeComponent();
            this.labIDShow.Text = a;          
            loadData(a);
        }
        public bool catchData()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textPrice.Text, "[^0-9.]"))
            {
                MessageBox.Show("Chi nhap so vao don gia!","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textPrice.Text = "";
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textDeposit.Text, "[^0-9.]"))
            {
                MessageBox.Show("Chi nhap so vao don gia!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDeposit.Text = "";
                return false;
            }
            return true;
        }
        public void loadData(String a)
        {


            ROOMRANK c = data.ROOMRANKs.Find(int.Parse(a));
            textRankName.Text = c.RankName;
            textPrice.Text = c.Price.ToString();
            textDeposit.Text = c.Deposits.ToString();
            textAbout.Text = c.About;           
            
        }

        public void saveDate()
        {

            ROOMRANK temp = new ROOMRANK() { RankName=textRankName.Text,Price=int.Parse(textPrice.Text),Deposits=int.Parse(textDeposit.Text),About=textAbout.Text };
            data.ROOMRANKs.Add(temp);
            data.SaveChanges();
        }
        public void updateData()
        {
            ROOMRANK temp = data.ROOMRANKs.Find(int.Parse(labIDShow.Text));
            temp.RankName = textRankName.Text;
             decimal a = decimal.Parse(textPrice.Text);
            temp.Price = a;
            a = decimal.Parse(textDeposit.Text);
            temp.Deposits =a;
            temp.About = textAbout.Text;
            
            data.SaveChanges();

        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (catchData() == false) return;
          
            
            if (labIDShow.Text!="update")
            {
                DialogResult result = MessageBox.Show("Ban co chac chinh sua loai phong co ID = " + labIDShow.Text + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
                DialogResult result = MessageBox.Show("Ban co chac them loai phong khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { saveDate(); this.Close(); break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }


        }

       

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
