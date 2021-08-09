using System;

namespace Exercicio14QuadrantesEixoXY
{
    class Program
    {
        static void Main(string[] args)
        {
            double eixoX, eixoY;
            string[] valoresEixos;
            Console.WriteLine("Digite os valores dos eixos:");

            valoresEixos = Console.ReadLine().Split(' ');

            eixoX = double.Parse(valoresEixos[0]);
            eixoY = double.Parse(valoresEixos[1]);

            if (eixoX == 0 && eixoY == 0) {

                Console.WriteLine("Origem");

            }
            else if (eixoX == 0) {

                Console.WriteLine("Eixo X");

            }
            else if (eixoY == 0) {

                Console.WriteLine("Eixo Y");

            }
            else if (eixoX > 0 && eixoY > 0) {

                Console.WriteLine("Q1");

            }
            else if (eixoX < 0 && eixoY > 0) {
                
                Console.WriteLine("Q2");
            
            }
            else if (eixoX < 0 && eixoY < 0) {

                Console.WriteLine("Q3");
            
            }
            else if (eixoX > 0 && eixoY < 0) {

                Console.WriteLine("Q4");

            }

        }
    }
}
