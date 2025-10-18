using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerBoard
{
    public class StickerRectangulo : Sticker
    {
        public StickerRectangulo(int posX, int posY, int tamaño, Color color) : base(posX, posY, tamaño, color)
        {
        }
        public override void Dibujar(Graphics g, int posX, int posY, int tamaño, Color color)
        {
            //Graphics g = Graphics.FromImage(bmp); (tener en cuenta para Factory o interfaz)
            SolidBrush b = new SolidBrush(color);
            g.FillRectangle(b, posX, posY, tamaño * 2, tamaño);
            g.DrawRectangle(Pens.Black, posX, posY, tamaño * 2, tamaño);
            g.Dispose();
        }
    }
}
    

