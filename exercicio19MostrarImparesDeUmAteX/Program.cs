using System;

namespace exercicio19MostrarImparesDeUmAteX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1000) {

                for (int i = 0; i <= numero; i++)
                {

                    if (i % 2 != 0) {

                        Console.WriteLine(i);

                    }
                    
                }

            }

        }
    }
}
