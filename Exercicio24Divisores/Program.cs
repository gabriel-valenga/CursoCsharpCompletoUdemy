using System; 
using System.Collections.Generic;

namespace Exercicio24Divisores
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite o número:");
            int numero = int.Parse(Console.ReadLine());
            List<int> divisores = new List<int>();

            for (int i = 1; i <= numero; i++)
            {

                if (numero % i == 0 ) {

                    divisores.Add(i);
               
                }
                
            }

            foreach (int divisor in divisores)
            {

              Console.WriteLine(divisor);

            }   

      //      Console.WriteLine(divisores.IndexOf(6));   
   
        }
    }
}
