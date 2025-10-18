using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StickerBoard.Entities;
using StickerBoard.Forms;

namespace StickerBoard.Factory
{
    public class StickerFactory
    {
        public enum TipoSticker
        {
            Circulo,
            Rectangulo,
            Estrella,
            Nube
        }
        /// <summary>
        /// Método de Factory para crear stickers.
        /// </summary>
        public static Sticker CrearSticker(TipoSticker tipo, int posX, int posY, int tamaño, System.Drawing.Color color)
        {
            switch (tipo)
            {
                case TipoSticker.Circulo:
                    return new StickerCirculo(posX, posY, tamaño, color);
                case TipoSticker.Rectangulo:
                    return new StickerRectangulo(posX, posY, tamaño, color);
                case TipoSticker Estrella:
                    return new StickerEstrella(posX, posY, tamaño, color);
                /*case TipoSticker Nube:
                    return new StickerNube(posX, posY, tamaño, color);*/
                default:
                    Console.WriteLine("Tipo de sticker no reconocido.");
                    return null;
            }
        }
    }
}