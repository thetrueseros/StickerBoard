using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using StickerBoard.Factory;
using StickerBoard.Forms;
using System.Windows.Forms;

namespace StickerBoard.Entities
{
    public class StickerNube : Sticker
    {
        public StickerNube(int posX, int posY, int tamaño, Color color) : base(posX, posY, tamaño, color)
        {
        }
        public override void Dibujar(Graphics g, int posX, int posY, int tamaño, Color color)
        {
            SolidBrush b = new SolidBrush(color);
            g.FillEllipse(b,
                posX,
                posY + tamaño / 4,
                tamaño / 2,
                tamaño / 2);//elipse izquierda 
            g.FillEllipse(b,
                posX + tamaño / 4,
                posY,
                tamaño / 2,
                tamaño / 2);//elipse de arriba
            g.FillEllipse(b,
                posX + tamaño * 2 / 5,
                posY + tamaño / 4,
                tamaño / 2,
                tamaño / 2);//elipse derecha
            g.FillEllipse(b,
                posX + tamaño / 8,
                posY + tamaño / 3,
                tamaño * 3 / 4,
                tamaño / 2);//elipse grande abajo
        }
        public override bool Validar(int posX, int posY, int tamaño, PictureBox pbLienzo)
        {
            /// Validar que el sticker quepa en el lienzo
            if (posX < 0 || posY < 0 ||
                posX + (tamaño * 2 / 5) + tamaño / 2 > 858 /*ancho del lienzo*/ ||
                posY + tamaño / 3 + (tamaño /2) > 487 /*alto del lienzo*/)
            {
                MessageBox.Show("Su sticker se sale de los límites del lienzo. " +
                    "El sticker DEBE caber entero en él.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
