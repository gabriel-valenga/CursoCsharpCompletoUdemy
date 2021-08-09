using System;

namespace Exercicio20LerNumerosInOutIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de valores a serem lidos a seguir:");
            int quantidadeValores = int.Parse(Console.ReadLine());
            int valor = 0;
            int inIntervalo = 0;
            int outIntervalo = 0;

            for (int i = 1; i <= quantidadeValores; i++)
            {

                Console.WriteLine("Digite o  " + i + "º valor:" );
                valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <=20) {

                    inIntervalo +=1;

                }
                else {

                    outIntervalo +=1;

                }
                
            }

            Console.WriteLine( inIntervalo + " in");
            Console.WriteLine( outIntervalo + " out");
            
        }
    }
}
