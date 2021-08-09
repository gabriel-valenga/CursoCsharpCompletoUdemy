using System;

namespace Exercicio22DividirNNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiroNumero = 0;
            double segundoNumero = 0;
            double resultadoDivisao = 0;
            string[] numeros;

            Console.WriteLine("Digite o número de pares de números que serão divididos:");
            int vezes = int.Parse(Console.ReadLine());

            for (int i = 0; i < vezes; i++)
            {
                
                Console.WriteLine("Digite o par de números: ");
                numeros = Console.ReadLine().Split(' ');

                primeiroNumero = double.Parse(numeros[0]);
                segundoNumero = double.Parse(numeros[1]);

                if (segundoNumero != 0) {

                    resultadoDivisao = primeiroNumero / segundoNumero;
                    Console.WriteLine("{0:F1}",resultadoDivisao);

                }
                else {

                    Console.WriteLine("Divisão impossível");

                }

            }
        }
    }
}
