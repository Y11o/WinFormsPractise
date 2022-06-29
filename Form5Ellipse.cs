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
    public partial class Form5Ellipse : Form
    {
        int index;
        int[] points = new int[5];
        public Form5Ellipse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
            points[1] = Convert.ToInt32(textBox1.Text);
            points[2] = Convert.ToInt32(textBox2.Text);
            points[3] = Convert.ToInt32(textBox3.Text);
            points[4] = Convert.ToInt32(textBox4.Text);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (index == 1) {
                Pen Перо = new Pen(Color.Black);
                e.Graphics.DrawEllipse(Перо, points[1], points[2], points[3], points[4]);
            }
        }
    }
}
