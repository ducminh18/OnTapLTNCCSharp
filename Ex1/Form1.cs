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
                listView1.Items.Add(_item);
            }
            listView1.View = View.Details;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
