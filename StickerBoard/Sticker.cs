using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerBoard
{
    public abstract class Sticker
    {
        private int posX { get; set; }
        private int posY { get; set; }
        private int tamaño { get; set; }
        public abstract void Dibujar( int posX, int posY, int tamaño );
    }
}
