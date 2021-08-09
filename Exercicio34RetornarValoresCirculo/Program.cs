using System;

namespace Exercicio34RetornarValoresCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("RAIO: " + raio.ToString("F2") +
                              " CIRCUNFERÊNCIA: " + Circulo.Circunferencia(raio).ToString("F2") + 
                              " VOLUME: " + Circulo.Volume(raio).ToString("F2") + 
                              " PI: " + Circulo.Pi.ToString());
        }
    }
}
