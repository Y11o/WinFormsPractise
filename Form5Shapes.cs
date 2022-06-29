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
    public partial class Form5Shapes : Form
    {
        public Form5Shapes()
        {
            InitializeComponent();
        }

        private void Form5Shapes_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics Графика = pictureBox1.CreateGraphics();
            Brush Заливка = new SolidBrush(Color.Orange);
            pictureBox1.Refresh();
            switch (comboBox1.SelectedIndex) {
                case 0:
                    Графика.FillRectangle(Заливка, 60, 60, 120, 180); break;
                case 1:
                    Графика.FillEllipse(Заливка, 60, 60, 120, 180); break;
                case 2:
                    Графика.FillEllipse(Заливка, 60, 60, 120, 120); break;
            }
        }
    }
}
