using System;
using Course.Entities.Enums;

namespace Course.Entities
{
    //ele ta herdando as informaçoes que vem da classe forma 
    class Circulo : Forma{

        //Declarações das variáveis e uso do encapsulamento
        public double Raio { get; set; }

        //Criação do construtor
        public Circulo(double raio, Color cor) : base(cor)
    {
        Raio = raio;
    }

        public override double Area()
    {
        return Math.PI * Raio * Raio;
    }
}
}