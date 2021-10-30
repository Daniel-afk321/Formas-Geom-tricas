using System;
using Course.Entities.Enums;



namespace Course.Entities
{
    //ele ta erdando as informaçoes que vem da classe Forma 
    class Retangulo : Forma{

      //Declarações das variáveis e uso do encapsulamento
      public double Largura { get; set; }
      public double Altura { get; set; }

      //Criação do construtor
      public Retangulo(double largura, double altura, Color cor) : base(cor)
    {
        Largura = largura;
        Altura = altura;
    }
      public override double Area()
    {
        return Largura * Altura;
    }
}
}