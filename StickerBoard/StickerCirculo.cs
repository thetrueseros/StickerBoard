using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickerBoard
{
    public class StickerCirculo : Sticker
    {
        public StickerCirculo(int posX, int posY, int tamaño, Color color) : base(posX, posY, tamaño, color)
        {
        }
        public override void Dibujar(Graphics g, int posX, int posY, int tamaño, Color color)
        {
            //Graphics g = Graphics.FromImage(bmp); (tener en cuenta para Factory o interfaz)
            SolidBrush b = new SolidBrush(color);
            g.FillEllipse(b, posX, posY, tamaño, tamaño);
            g.DrawEllipse(Pens.Black, posX, posY, tamaño, tamaño);
            g.Dispose();
        }
        public override bool Validar(int posX, int posY, int tamaño, PictureBox pbLienzo)
        {
            if (posX < 0 || posY < 0 ||
                posX + tamaño > 858 /*ancho del lienzo*/ ||
                posY + tamaño > 487 /*alto del lienzo*/)
            {
                MessageBox.Show("Su sticker es muy grande." +
                    "El sticker DEBE caber entero en el lienzo.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
