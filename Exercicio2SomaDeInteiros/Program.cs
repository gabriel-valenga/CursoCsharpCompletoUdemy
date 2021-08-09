using System;

namespace Exercicio2SomaDeInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
                     
            Console.WriteLine("Digite o primeiro número:");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int segundoNumero = int.Parse(Console.ReadLine());
            int soma = primeiroNumero + segundoNumero;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
