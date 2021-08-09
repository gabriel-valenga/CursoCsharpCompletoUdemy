using System;

namespace Exercicio13VerificarSeNumeroEstaNoIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Digite um número:");

            numero = double.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 25) {

                Console.WriteLine("Intervalo [0,25]");

            }
            else if (numero > 25 && numero <= 50) {

                Console.WriteLine("Intervalo [26,50]");

            }
        }
    }
}
