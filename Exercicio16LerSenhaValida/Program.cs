using System;

namespace Exercicio16LerSenhaValida
{
    class Program
    {
        static void Main(string[] args)
        {

            String senha = "";
            while (senha != "2002") {

                Console.WriteLine("Digite a senha: ");
                senha = Console.ReadLine();

                Console.WriteLine("Senha inválida");

            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
