using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickerBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbColor.BackColor = colorDialog1.Color;
            }
        }

        private void pbLienzo_Paint(object sender, PaintEventArgs e)
        {
            btnCrear_Click(sender, e);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
