using System;

namespace Exercicio27CalcularAreaTrianguloComOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite as medidas do triângulo X:");
            
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as medidas do triângulo Y:");

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            // double pX = (x.A + x.B + x.C) / 2;
            // double areaX = Math.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));

            // double pY = (y.A + y.B + y.C) / 2;
            // double areaY = Math.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

            Console.WriteLine("Area triangulo X: " + x.Area().ToString("F4"));
            Console.WriteLine("Area triangulo Y: " + y.Area().ToString("F4"));

            
        }
    }
}
