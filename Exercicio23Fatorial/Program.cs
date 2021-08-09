using System;

namespace Exercicio23Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número:");
            int numero = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {

                resultado = resultado * i;
                
            }

            Console.WriteLine(resultado);

        }
    }
}
