using StickerBoard.Factory;
using StickerBoard.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StickerBoard.Entities
{
    public class StickerEstrella:Sticker
    {
        public StickerEstrella(int posX, int posY, int tamaño, Color color) : base(posX, posY, tamaño, color)
        {
        }
        public override void Dibujar(Graphics g, int posX, int posY, int tamaño, Color color)
        {
            SolidBrush b = new SolidBrush(color);
            g.FillPolygon(b, new PointF[]
            {
                new PointF(posX + tamaño * 0.5f, posY),
                new PointF(posX + tamaño * 0.61f, posY + tamaño * 0.35f),
                new PointF(posX + tamaño, posY + tamaño * 0.35f),
                new PointF(posX + tamaño * 0.68f, posY + tamaño * 0.57f),
                new PointF(posX + tamaño * 0.79f, posY + tamaño),
                new PointF(posX + tamaño * 0.5f, posY + tamaño * 0.72f),
                new PointF(posX + tamaño * 0.21f, posY + tamaño),
                new PointF(posX + tamaño * 0.32f, posY + tamaño * 0.57f),
                new PointF(posX, posY + tamaño * 0.35f),
                new PointF(posX + tamaño * 0.39f, posY + tamaño * 0.35f)
            });
        }
        public override bool Validar(int posX, int posY, int tamaño, PictureBox pbLienzo)
        {
            if (posX < 0 || posY < 0 ||
                posX + tamaño > 858 /*ancho del lienzo*/ ||
                posY + tamaño > 487 /*alto del lienzo*/)
            {
                MessageBox.Show("Su sticker se sale de los límites del lienzo. " +
                    "El sticker DEBE caber entero en él.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
