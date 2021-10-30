using Course.Entities.Enums;
using Course.Entities;

namespace Course.Entities
{
    abstract class Forma
    {
        // metodo
        public Color Color { get; set; }
        //Construtor
        public Forma(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}