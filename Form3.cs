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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Доска объявлений";
            label1.Text = "";
            toolTip1.SetToolTip(button2, "Open \nphoto gallerey");
            toolTip1.IsBalloon = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3ComboBox newForm = new Form3ComboBox();
            newForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
