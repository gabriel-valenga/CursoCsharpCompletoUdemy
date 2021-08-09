using System;

namespace Exercicio25NumerosQuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas a serem calculadas:");
            int linhas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= linhas; i++)
            {
                
                Console.WriteLine(i + " " + Math.Pow(i,2) + " " + Math.Pow(i,3) );

            }
        }
    }
}
