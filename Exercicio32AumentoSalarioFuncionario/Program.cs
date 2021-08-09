using System;

namespace Exercicio32AumentoSalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            
            Console.WriteLine("Digite o nome do funcionário:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário bruto do funcionário:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine(funcionario.ToString());

            Console.WriteLine("Digite a porcentagem de aumento do salário:");
            double porcentagemAumento = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagemAumento);
            Console.WriteLine(funcionario.ToString());


        }
    }
}
