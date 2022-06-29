using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPractise
{
    public partial class Form5Triangle : Form
    {
        int index;
        int[] points = new int[7];
        public Form5Triangle()
        {
            InitializeComponent();
        }

        private void Form5Triangle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            points[1] = Convert.ToInt32(textBox1.Text);
            points[2] = Convert.ToInt32(textBox2.Text);
            points[3] = Convert.ToInt32(textBox3.Text);
            points[4] = Convert.ToInt32(textBox4.Text);
            points[5] = Convert.ToInt32(textBox5.Text);
            points[6] = Convert.ToInt32(textBox6.Text);
            index = 1;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(System.Drawing.Pens.Black, points[1], points[2], points[3], points[4]);
            e.Graphics.DrawLine(System.Drawing.Pens.Red, points[3], points[4], points[5], points[6]);
            e.Graphics.DrawLine(System.Drawing.Pens.Green, points[5], points[6], points[1], points[2]);
        }
    }
}
