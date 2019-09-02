using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiloVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillData();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillData()
        {
            //first column
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Photo";
            imgCol.Name = "Photo";
            dataGridView1.Columns.Add(imgCol);

            //second
            DataGridViewImageColumn imgCol1 = new DataGridViewImageColumn();
            imgCol1.HeaderText = "Album";
            dataGridView1.Columns.Add(imgCol1);

            //third
            DataGridViewImageColumn imgCol2 = new DataGridViewImageColumn();
            dataGridView1.Columns.Add(imgCol2);

            //data
            //first row
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("https://loremflickr.com/320/240");
            MemoryStream ms = new MemoryStream(bytes);

            Image img = System.Drawing.Image.FromStream(ms);
            //Image img1 = Image.FromFile("@caminho");
            //Image img2= Image.FromFile("@caminho");
            Object[] row = new Object[] { img };
            dataGridView1.Rows.Add(row);

            ////secd row
            //img = Image.FromFile("@caminho");
            //img1 = Image.FromFile("@caminho");
            //img2 = Image.FromFile("@caminho");
            //row = new Object[] { img, img1, img2 };
            //dataGridView1.Rows.Add(row);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
