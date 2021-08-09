using System;

namespace Exercicio6SomarValorPecas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1;
            string[] peca2;
            double valorAPagar, valorTotalPeca1, valorTotalPeca2; 

            Console.WriteLine("Digite as informações da peça 1:");
            peca1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Digite as informações da peça 2:");
            peca2 = Console.ReadLine().Split(' ');

            valorTotalPeca1 = int.Parse(peca1[1]) * double.Parse(peca1[2]);
            valorTotalPeca2 = int.Parse(peca2[1]) * double.Parse(peca2[2]);
            
            valorAPagar = valorTotalPeca1 + valorTotalPeca2;

            Console.WriteLine("VALOR A PAGAR: {0:F2}",valorAPagar);

        }
    }
}
