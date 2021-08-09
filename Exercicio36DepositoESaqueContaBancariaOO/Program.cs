using System;

namespace Exercicio36DepositoESaqueContaBancariaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.WriteLine("Digite o número da conta:");
            string numeroConta = Console.ReadLine();
            Console.WriteLine("Digite o nome do titular:");
            string nomeTitular = Console.ReadLine();
            Console.WriteLine("Deseja fazer depósito inicial? (S/N)");
            string opcaoDepositoInicial = Console.ReadLine();

            if (opcaoDepositoInicial == "S") {

                Console.WriteLine("Digite o valor do depósito inicial:");
                double valorDepositoInicial = double.Parse(Console.ReadLine());
                contaBancaria = new ContaBancaria(numeroConta, nomeTitular, valorDepositoInicial);

            }
            else {

                contaBancaria = new ContaBancaria(numeroConta, nomeTitular);

            }

            Console.WriteLine(contaBancaria);
            Console.WriteLine("Digite um valor para depósito:");
            double valorDeposito = double.Parse(Console.ReadLine());
            contaBancaria.Depositar(valorDeposito);
            Console.WriteLine(contaBancaria);

            Console.WriteLine("Digite um valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine());
            Console.WriteLine(contaBancaria);

            if (!(contaBancaria.Sacar(valorSaque))) {

                Console.WriteLine("Não foi possível realizar o saque, saldo insuficiente.");

            }
            Console.WriteLine(contaBancaria);
        }

    }
}
