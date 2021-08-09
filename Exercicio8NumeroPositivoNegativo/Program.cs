using System;

namespace Exercicio8NumeroPositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Digite o número:");

            numero = int.Parse(Console.ReadLine());

            if (numero >= 0) {

                Console.WriteLine("POSITIVO");
            
            } 
            else {
                
                Console.WriteLine("NEGATIVO");

            }

        }
    }
}
