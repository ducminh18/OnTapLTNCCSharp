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

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader(Environment.CurrentDirectory + "\\CongNgheNET.txt");
            string Search = txtSearch.Text;
            dgvMain.Rows.Clear();
            while (!strRead.EndOfStream)
            {
                string _str = strRead.ReadLine();

                string[] _array = _str.Split(',');
                if (_array[2].ToLower().Contains(Search.ToLower()) || Search == "@ALL")
                {
                    dgvMain.Rows.Add(_array);
                }
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection Cell = dgvMain.SelectedRows[0].Cells;
            string Result = $"Mã SV : {Cell[0].Value} - Tên SV: {Cell[1].Value}\nLớp : {Cell[2].Value} - Ngày sinh : {Cell[3].Value}" +
                $"\nGiới tính : {Cell[4].Value} - Quê quán : {Cell[5].Value}";
                MessageBox.Show(Result, "Chi tiết") ;

        }
    }
}
