using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de forma que pode criar
            List<Forma> list = new List<Forma>();
            //Usuario vai entra com o numeros de formas 
            Console.WriteLine("Entre com o número de formas: ");
            //N sera o numero que o usuario vai colocar
            int n = int.Parse(Console.ReadLine());

            //N tem que ser maior ou igual a i pro codigo parar
            for (int i = 1; i <= n; i++)
            {
                //Forma vai mostra a ordem dela Ex:Forma #1
                Console.WriteLine($"Forma #{i}:");
                //Usuario vai te que escolher entre Retangulo ou Circulo
                Console.Write("Retângulo ou Circulo(R / C) ? ");
                // o char esta sendo usado para verificar o que o usuario coloco
                char ch = char.Parse(Console.ReadLine());
                //Vai pergunta qual Cor o usuario vai querer 
                Console.Write("Cor: (Preto / Azul / Vermelho): ");
                //identifica a Cor que tem na Classe Cor
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                //ele vai identifica oque é o R quando ele aperta e oque é o C quando ele aperta
                if (ch == 'R')
                {
                    //Usuario vai entra com o valor da Largura
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Usuario vai entra com o valor da Altura
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Vai adicionar na lista o Retangulo
                    list.Add(new Retangulo(largura, altura, cor));
                }

                else
                {
                    //Usuario vai entra com o valor do Raio
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //vai Adicionar o Circulo na lista
                    list.Add(new Circulo(raio, cor));
                }
                Console.WriteLine();
                //Area das Formas
                Console.WriteLine("Área de cada forma: ");
                //Vai imprimir a Resposta da lista pro usuario
                foreach (Forma forma in list)
                {
                    Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}