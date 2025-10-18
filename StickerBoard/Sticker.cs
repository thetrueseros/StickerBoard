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
        protected Sticker(int posX, int posY, int tamaño, Color color)
        {
            if (tamaño <= 0) throw new ArgumentOutOfRangeException(nameof(tamaño), "El tamaño debe ser mayor que cero.");
            this.posX = posX;
            this.posY = posY;
            this.tamaño = tamaño;
            this.color = color;
        }

        // Helper: rectángulo que ocupa el sticker.
        // Aquí se decide que posX,posY son el centro de la figura.
        protected Rectangle GetBounds()
        {
            int half = tamaño / 2;
            return new Rectangle(posX - half, posY - half, tamaño, tamaño);
        }

        // Cada subclase debe implementar cómo se dibuja usando Graphics
        public abstract void Dibujar(Graphics g);
    }
}
