using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickerBoard
{
    public class StickerFactory
    {
        public enum TipoSticker
        {
            Circulo,
            Rectangulo
        }
        public static Sticker CrearSticker(TipoSticker tipo, int posX, int posY, int tamaño, System.Drawing.Color color)
        {
            switch (tipo)
            {
                case TipoSticker.Circulo:
                    return new StickerCirculo(posX, posY, tamaño, color);
                case TipoSticker.Rectangulo:
                    return new StickerRectangulo(posX, posY, tamaño, color);
                default:
                    throw new ArgumentException("Tipo de sticker no válido");
            }
        }
    }
}
