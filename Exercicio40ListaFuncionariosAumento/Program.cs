using System;
using System.Collections.Generic;

namespace Exercicio40ListaFuncionariosAumento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Digite o número de funcionários que serão registrados:");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroFuncionarios; i++)
            {
                Console.WriteLine("Digite o id do funcionário:");
                int idFuncionario = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do funcionário:");
                string nomeFuncionario = Console.ReadLine();
                Console.WriteLine("Digite o salário do funcionário:");
                double salarioFuncionario = double.Parse(Console.ReadLine());

                Funcionario funcionario = new Funcionario(idFuncionario, nomeFuncionario, salarioFuncionario);
                funcionarios.Add(funcionario);

            }

            Console.WriteLine("Digite o id do funcionário que receberá aumento:");
            int idAumento = int.Parse(Console.ReadLine());
            Funcionario funcionarioAumento = funcionarios.Find(x => x.Id == idAumento);

            if (funcionarioAumento != null) 
            {
                Console.WriteLine("Digite a porcentagem do aumento:");
                double porcentagemAumento = double.Parse(Console.ReadLine());
                funcionarioAumento.AumentarSalario(porcentagemAumento);

            }
            else
            {
                Console.WriteLine("Esse ID não existe.");
           
            }    

            Console.WriteLine("Lista de funcionários atualizada:");

            foreach (Funcionario funcionario in funcionarios)
            {
                
                Console.WriteLine(funcionario);

            }
        }
    }
}
