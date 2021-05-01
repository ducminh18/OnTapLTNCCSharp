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
            StreamReader strRead = new StreamReader(Application.StartupPath + "\\CongNgheNET.txt");
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
                lviCongNgheNET.Items.Add(_item);
            }
            lviCongNgheNET.View = View.Details;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string masv = txtID.Text;
            if (masv.Length == 0)
            {
                MessageBox.Show("Chưa chọn sinh viên");
                return;
            }   
            foreach (ListViewItem it in lviCongNgheNET.Items)
            {
                if (it.Text == masv)
                {
                    it.Remove();
                    MessageBox.Show("Xoá thành công");
                    return;
                }    
            }
            MessageBox.Show("Không tìm thấy dữ liệu cần xoá");
        }

        private void lviCongNgheNET_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lviCongNgheNET_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            txtID.Text = item.Text;           
            txtName.Text = item.SubItems[1].Text;
            txtClass.Text = item.SubItems[2].Text;
            mtbDatebirth.Text = item.SubItems[3].Text;
            txtGender.Text = item.SubItems[4].Text;
            txtAddress.Text = item.SubItems[5].Text;
        }
    }
}
