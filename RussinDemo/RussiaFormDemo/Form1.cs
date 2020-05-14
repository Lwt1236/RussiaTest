using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussiaFormDemo
{
    public partial class Form1 : Form
    {
        private Russia myRussia = new Russia();
        Point firstPoint = new Point(140, 20);
        Point previewPoint = new Point(64, 41);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            myRussia.CreateCake(panel3, rd.Next(1, 8), previewPoint);
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Enabled = true;
            btnStart.Enabled = false;
        }

        

        private void btnPause_Click(object sender, EventArgs e)
        {
            MessageBox.Show(panel3.Location.X.ToString() + "  " + panel3.Location.Y.ToString());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
