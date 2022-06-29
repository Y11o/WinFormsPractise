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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Painting " + button1.Text;
            Form5Vertex newForm = new Form5Vertex();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Painting " + button2.Text;
            Form5Triangle newForm = new Form5Triangle();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Painting " + button3.Text;
            Form5Ellipse newForm = new Form5Ellipse();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Painting " + button4.Text;
            Form5Shapes newForm = new Form5Shapes();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
