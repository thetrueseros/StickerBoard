using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StickerBoard.Factory;
using StickerBoard.Entities;

namespace StickerBoard.Forms
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
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cmbSticker.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de sticker.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sticker sticker = StickerFactory.CrearSticker((Factory.StickerFactory.TipoSticker)cmbSticker.SelectedIndex,
                (int)nudX.Value, (int)nudY.Value, (int)nudSize.Value,
                pbColor.BackColor);
            if (sticker.Tamaño <= 0)
            {
                MessageBox.Show("Tamaño inválido.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sticker.Validar((int)nudX.Value, (int)nudY.Value, (int)nudSize.Value, pbLienzo))
            {
                sticker.Dibujar(pbLienzo.CreateGraphics(), sticker.PosX, sticker.PosY, sticker.Tamaño, sticker.Color);
                txtContador.Text = (int.Parse(txtContador.Text) + 1).ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pbLienzo.Invalidate();
            txtContador.Text = "0";
        }
    }
}
