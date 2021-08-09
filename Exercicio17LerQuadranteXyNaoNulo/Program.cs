using System;

namespace Exercicio17LerQuadranteXyNaoNulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double eixoX = -1;
            double eixoY = -1;
            string[] valoresEixos;
            

            while (eixoX != 0 && eixoY != 0) {

                Console.WriteLine("Digite os valores dos eixos:");
                valoresEixos = Console.ReadLine().Split(' ');
                eixoX = Double.Parse(valoresEixos[0]);
                eixoY = Double.Parse(valoresEixos[1]);

                if (eixoX > 0 && eixoY > 0) {

                    Console.WriteLine("primeiro");

                } 
                else if (eixoX < 0 && eixoY > 0 ) {

                    Console.WriteLine("segundo");

                }
                else if (eixoX < 0 && eixoY < 0) {

                    Console.WriteLine("terceiro");

                }
                else if (eixoX > 0 && eixoY < 0) {

                    Console.WriteLine("quarto");

                }


            }



        }
    }
}
