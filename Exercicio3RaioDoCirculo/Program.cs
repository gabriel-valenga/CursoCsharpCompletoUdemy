using System;

namespace Exercicio3RaioDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159; 
            Console.WriteLine("Digite o raio do círculo: ");
            double raioCirculo = double.Parse(Console.ReadLine());
            double areaCirculo = pi * Math.Pow(raioCirculo,2);
            Console.WriteLine("Area do círculo: " + areaCirculo.ToString("F4"));
        }
    }
}
