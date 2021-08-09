using System;

namespace Exercicio5CalculoSalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            string idFuncionario;
            int horasTrabalhadas;
            double valorHora, salario;

            Console.WriteLine("Digite o ID do funcionário:");
            idFuncionario = Console.ReadLine();
            Console.WriteLine("Digite o número de horas trabalhadas:");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor pago por hora:");
            valorHora = double.Parse(Console.ReadLine());

            salario = valorHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = " + idFuncionario);
            Console.WriteLine("SALARY = U$ {0:F2}", salario);
        }
    }
}
