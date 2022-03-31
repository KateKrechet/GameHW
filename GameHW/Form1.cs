using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameHW
{
    
    public partial class Form1 : Form
    {
        int N = 5;//первоначальное значение трек-бара
        public Form1()
        {
            InitializeComponent();
            CreateGrid(N);
        }

        void CreateGrid(int n)
        {
            int r, g, b;
            Random rnd = new Random();
            
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = n;
            int w = dataGridView1.Width > dataGridView1.Height ? 
                dataGridView1.Height : dataGridView1.Width;
            for(int i=0;i<n;i++)
            {
                dataGridView1.Rows[i].Height = w / n;
                dataGridView1.Columns[i].Width = w / n;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    r = rnd.Next(255);
                    g = rnd.Next(255);
                    b = rnd.Next(255);
                   dataGridView1[j, i].Style.BackColor = Color.FromArgb(r,g,b);
                }
            }

            dataGridView1.ClearSelection();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            N = trackBar1.Value;
            CreateGrid(N);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CreateGrid(N);
        }

        
    }
}
