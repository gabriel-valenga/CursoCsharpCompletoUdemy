using System;

namespace Exercicio29MediaSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();
            
            Console.WriteLine("Digite o nome do primeiro funcionário:");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do primeiro funcionário:");
            x.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo funcionário");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do segundo funcionário:");
            y.Salario = double.Parse(Console.ReadLine());

            double mediaSalarial = (x.Salario + y.Salario) / 2;

            Console.WriteLine("Salário médio: " + mediaSalarial.ToString("F2"));

        }
    }
}
