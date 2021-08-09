using System;

namespace Exercicio4DiferencaProdutoInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC, valorD, diferenca;

            Console.WriteLine("Digite o valor A:");
            valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B:");
            valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor C:");
            valorC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor D:");
            valorD = int.Parse(Console.ReadLine());

            diferenca = (valorA * valorB) - (valorC * valorD);

            Console.WriteLine("DIFERENÇA: " + diferenca.ToString());
        }
    }
}
