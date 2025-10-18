using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using StickerBoard.Entities;
using StickerBoard.Factory;

namespace StickerBoard.Entities
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
            /// Validar que el sticker quepa en el lienzo
            if (posX < 0 || posY < 0 ||
                posX + tamaño > 858 /*ancho del lienzo*/ ||
                posY + tamaño > 487 /*alto del lienzo*/)
            {
                MessageBox.Show("Su sticker se sale de los límites del lienzo." +
                    "El sticker DEBE caber entero en él.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
