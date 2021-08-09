using System;

namespace Exercicio26CalcularAreaTrianguloSemOO
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");

            yA = Double.Parse(Console.ReadLine());
            yB = Double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double pX = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(pX * (pX - xA) * (pX - xB) * (pX - xC));

            double pY = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(pY * (pY - yA) * (pY - yB) * (pY - yC));

            Console.WriteLine("Área de X: " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4"));

            if (areaX > areaY) {

                Console.WriteLine("Maior área: X");
            
            }
            else if (areaY > areaX) {

                Console.WriteLine("Maior área: Y");
            }
            else {

                Console.WriteLine("Áreas iguais");
                
            }

        }
    }
}
