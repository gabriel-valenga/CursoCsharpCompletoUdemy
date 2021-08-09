using System;

namespace Exercicio31AreaPerimetroDiagonalRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a altura e largura do retângulo:");
            string[] medidasRetangulo = Console.ReadLine().Split(' ');

            retangulo.Altura = double.Parse(medidasRetangulo[0]);
            retangulo.Largura = double.Parse(medidasRetangulo[1]);

            Console.WriteLine(retangulo.ToString());

        }
    }
}
