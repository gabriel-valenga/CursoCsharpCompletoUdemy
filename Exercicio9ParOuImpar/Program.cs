using System;

namespace Exercicio9ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número:");

            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {

                Console.WriteLine("PAR");

            }
            else {

                Console.WriteLine("IMPAR");

            }
        }
    }
}
