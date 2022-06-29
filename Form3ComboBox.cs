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
    public partial class Form3ComboBox : Form
    {
        public Form3ComboBox()
        {
            InitializeComponent();
        }

        private void Form3ComboBox_Load(object sender, EventArgs e)
        {
            this.Text = "Photo Gallerey";
            label1.Text = "";
            comboBox1.Text = "Список";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) {
                case 0: pictureBox1.Image = Image.FromFile("D:\\My projects\\VS repos\\WinFormsPractise\\Images\\Mountain.jpg");
                    label1.Text = "Mountain"; break;
                case 1: pictureBox1.Image = Image.FromFile("D:\\My projects\\VS repos\\WinFormsPractise\\Images\\Flower.jpg");
                    label1.Text = "Flower"; break;
                case 2: pictureBox1.Image = Image.FromFile("D:\\My projects\\VS repos\\WinFormsPractise\\Images\\Jellyfish.jpg");
                    label1.Text = "Jellyfish"; break;
                case 3: pictureBox1.Image = Image.FromFile("D:\\My projects\\VS repos\\WinFormsPractise\\Images\\Koala.jpg");
                    label1.Text = "Koala"; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3Paint newForm = new Form3Paint();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
