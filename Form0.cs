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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text + " was runned. ";
            Form1 newForm = new Form1();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text + " was runned. ";
            Form2 newForm = new Form2();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text + " was runned. ";
            Form3 newForm = new Form3();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text + " was runned. ";
            Form4 newForm = new Form4();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = button5.Text + " was runned. ";
            Form5 newForm = new Form5();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = button6.Text + " was runned. ";
            this.WindowState = FormWindowState.Minimized;
            Form6 newForm = new Form6();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
