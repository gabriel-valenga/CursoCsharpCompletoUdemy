using System;
using System.Globalization;

namespace Exercicio1SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: \r\n {0} cujo preço é ${1:F2} \r\n {2} cujo preço é ${3:F2} \r\n", produto1, preco1, produto2, preco2);
            Console.WriteLine("Registro: {0} de idade, código {1}, e gênero: {2} \r\n", idade, codigo, genero);
            Console.WriteLine("Medida com 8 casas decimais: {0} \r\n Arredondado com 3 casas decimais: {0:F3} \r\n", medida);
            Console.WriteLine("Separador decimal com InvariantCulture: " + medida.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}
