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
    public partial class Form5Vertex : Form
    {
        int[] points = new int[5];
        public Form5Vertex()
        {
            InitializeComponent();
            label1.Text = "X1";
            label2.Text = "Y1";
            label3.Text = "X2";
            label4.Text = "Y2";
        }

        private void Form5Vertex_Load(object sender, EventArgs e)
        {
            this.Text = "Drawing Vertex";
            button1.Text = "Draw";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points[1] = Convert.ToInt32(textBox1.Text);
            points[2] = Convert.ToInt32(textBox2.Text);
            points[3] = Convert.ToInt32(textBox3.Text);
            points[4] = Convert.ToInt32(textBox4.Text);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(System.Drawing.Pens.Green, points[1], points[2], points[3], points[4]);
        }
    }
}
