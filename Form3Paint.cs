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
    public partial class Form3Paint : Form
    {
        public Form3Paint()
        {
            InitializeComponent();
        }

        private void Form3Paint_Load(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold);
            button1.Text = "Paint";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Text = String.Format("{0}", textBox1.Text);
            Brush Кисть = new SolidBrush(Color.LimeGreen);
            Graphics G = pictureBox1.CreateGraphics();
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            G.DrawString(Text, Font, Кисть, 150, 50);
        }
    }
}
