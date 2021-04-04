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
    public partial class roomOpenForm : Form
    {
        MotelManagerEntities data = new MotelManagerEntities();

        public callFunction goiHam;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if(goiHam!=null)
            {
                goiHam();
            }
        }
        public roomOpenForm()
        {
            InitializeComponent();
            loadComboBox();
        }
        public roomOpenForm(String a)
        {
            InitializeComponent();
            loadComboBox();
            loadData(a);
            
        }
        public bool catchData()
        {
            
            if(textRoomName.Text=="")
            {
                MessageBox.Show("Hay nhap ten phong!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(comBoxIDRank.Text=="")
            {
                MessageBox.Show("Hay chon id loai!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (comBoxIDRange.Text == "")
            {
                MessageBox.Show("Hay chon id khu vuc!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void loadComboBox()
        {
            List<ROOMRANK> list1 = (from a in data.ROOMRANKs select a).ToList();
            List<ROOMRANGE> list2 = (from b in data.ROOMRANGEs select b).ToList();
            foreach(ROOMRANK a in list1)
            {
                comBoxIDRank.Items.Add(a.ID.ToString());
            }
            foreach (ROOMRANGE a in list2)
            {
                comBoxIDRange.Items.Add(a.ID.ToString());
            }
        }
        public void loadData(String a)
        {
            MOTELROOM c = data.MOTELROOMs.Find(int.Parse(a));
            labIDRoomShow.Text = c.ID.ToString();
            textRoomName.Text = c.RoomName;
            if (c.StateRoom.Value == true)
            {
                labStateShow.Text="phòng đã được thuê";
            }
            else
            {
                labStateShow.Text="phòng trống";
            }           
            comBoxIDRank.Text = c.IDRoomRank.ToString();
            ROOMRANK d = data.ROOMRANKs.Find(c.IDRoomRank);
            textRankName.Text = d.RankName;        
            comBoxIDRange.Text = c.IDRoomRange.ToString();
            ROOMRANGE b = data.ROOMRANGEs.Find(c.IDRoomRange);
            textRangeName.Text = b.RangeName;
          
        }

        public void saveDate()
        {

            MOTELROOM room = new MOTELROOM() {RoomName=textRoomName.Text,StateRoom=false,IDRoomRank=int.Parse(comBoxIDRank.Text), IDRoomRange = int.Parse(comBoxIDRange.Text) };
            data.MOTELROOMs.Add(room);
            data.SaveChanges();
        }
        public void updateData()
        {
            MOTELROOM temp = data.MOTELROOMs.Find(int.Parse(labIDRoomShow.Text));
            temp.RoomName = textRoomName.Text;
            temp.IDRoomRank = int.Parse(comBoxIDRank.Text);
            temp.IDRoomRange = int.Parse(comBoxIDRange.Text);
            
            data.SaveChanges();

        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (catchData() == false) return;
            
            if (labIDRoomShow.Text!="loading")
            {
                DialogResult result = MessageBox.Show("Ban co chac chinh sua phong co ID = " + labIDRoomShow.Text + " khong ? (tat ca cac du lieu lien quan deu se thay doi!)", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { updateData(); break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Ban co chac them phong co ID =" + labIDRoomShow.Text + " khong?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                switch (result)
                {
                    case DialogResult.Cancel: return;
                    case DialogResult.Yes: { saveDate(); break; }
                    case DialogResult.No: return;

                    default:
                        break;

                }

            }

            this.Close();
        }

       

        private void roomOpenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void comBoxIDRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            ROOMRANK d = data.ROOMRANKs.Find(int.Parse(comBoxIDRank.Text));
            textRankName.Text = d.RankName;
        }

        private void comBoxIDRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            ROOMRANGE d = data.ROOMRANGEs.Find(int.Parse(comBoxIDRange.Text));
            textRangeName.Text = d.RangeName;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
