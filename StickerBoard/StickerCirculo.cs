using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
