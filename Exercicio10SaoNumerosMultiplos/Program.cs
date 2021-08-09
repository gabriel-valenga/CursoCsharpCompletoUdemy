using System;

namespace Exercicio10SaoNumerosMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero;
            Console.WriteLine("Digite o primeiro número:");

            primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");

            segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero % segundoNumero == 0 || segundoNumero % primeiroNumero == 0) {

                Console.WriteLine("São múltiplos");

            }
            else {

                Console.WriteLine("Não são múltiplos");
                
            }
        }
    }
}
