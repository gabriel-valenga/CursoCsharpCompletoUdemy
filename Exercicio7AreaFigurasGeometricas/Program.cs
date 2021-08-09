using System;

namespace Exercicio7AreaFigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            string[] medidas;
            double valorA, valorB, valorC;
            double areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo; 
            Console.WriteLine("Digite os valores das medidas:");
            medidas = Console.ReadLine().Split(' ');

            valorA = double.Parse(medidas[0]);
            valorB = double.Parse(medidas[1]);
            valorC = double.Parse(medidas[2]);

            areaTriangulo = (valorA * valorC) / 2;
            areaCirculo = pi * Math.Pow(valorC,2);
            areaTrapezio = ((valorA + valorB) * valorC) / 2;
            areaQuadrado = Math.Pow(valorB,2);
            areaRetangulo = valorA * valorB;

            Console.WriteLine("TRIANGULO: {0:F3}", areaTriangulo);
            Console.WriteLine("CIRCULO: {0:F3}", areaCirculo);
            Console.WriteLine("TRAPEZIO: {0:F3}", areaTrapezio);
            Console.WriteLine("QUADRADO: {0:F3}", areaQuadrado);
            Console.WriteLine("RETANGULO: {0:F3}", areaRetangulo);

        }
    }
}
