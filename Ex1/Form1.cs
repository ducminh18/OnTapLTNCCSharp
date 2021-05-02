using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex1
{
    public partial class frmCongNgheNET : Form
    {
        public frmCongNgheNET()
        {
            InitializeComponent();
        }

        private void frmCongNgheNET_Load(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader(Environment.CurrentDirectory + "\\CongNgheNET.txt");
            while(!strRead.EndOfStream)
            {
                string _str = strRead.ReadLine();

                string[] _array = _str.Split(',');

                ListViewItem _item = new ListViewItem(_array[0]);
                _item.SubItems.Add(_array[1]);
                _item.SubItems.Add(_array[2]);
                _item.SubItems.Add(_array[3]);
                _item.SubItems.Add(_array[4]);
                _item.SubItems.Add(_array[5]);
                lvCongNgheNET.Items.Add(_item);
            }
            lvCongNgheNET.View = View.Details;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            for (int index = lvCongNgheNET.CheckedIndices.Count - 1; index >= 0; index--)
            {
                lvCongNgheNET.Items.RemoveAt(lvCongNgheNET.CheckedIndices[index]);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvCongNgheNET.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvCongNgheNET.SelectedItems[0];
                txtID.Text = selectedItem.Text;
                txtName.Text = selectedItem.SubItems[1].Text;
                txtClass.Text = selectedItem.SubItems[2].Text;
                mtbDatebirth.Text = selectedItem.SubItems[3].Text;
                txtGender.Text = selectedItem.SubItems[4].Text;
                txtAddress.Text = selectedItem.SubItems[5].Text;
            }
            else
            {
                txtID.Text = "";
                txtName.Text = "";
                txtClass.Text = "";
                mtbDatebirth.Text = "";
                txtGender.Text = "";
                txtAddress.Text = "";
            }
        }        
    }
}
