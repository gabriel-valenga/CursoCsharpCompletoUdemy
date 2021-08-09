using System;

namespace Exercicio35ConversorMoedaDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacaoDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantosDolares = double.Parse(Console.ReadLine());
            Console.WriteLine(" Valor a ser pago em reais: " + 
                              ConversorMoedaDolar.ValorTotalEmReais(cotacaoDolar, quantosDolares).ToString("F2"));
        }
    }
}
