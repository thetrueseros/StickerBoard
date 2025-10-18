using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StickerBoard
{
    public abstract class Sticker
    {
        // Propiedades protegidas accesibles por las clases derivadas
        protected int posX { get; set; }
        protected int posY { get; set; }
        protected int tamaño { get; set; }
        protected Color color { get; set; }

        // Propiedades públicas de sólo lectura (útiles para la interfaz / Factory)
        public int PosX => posX;
        public int PosY => posY;
        public int Tamaño => tamaño;
        public Color Color => color;

        // Constructor principal usado por Factory
        public Sticker(int posX, int posY, int tamaño, Color color)
        {
            this.posX = posX;
            this.posY = posY;
            this.tamaño = tamaño;
            this.color = color;
        }

        // Cada subclase debe implementar cómo se dibuja usando Graphics
        public abstract void Dibujar(Graphics g, int posX, int posY, int tamaño, Color color);
    }
}
