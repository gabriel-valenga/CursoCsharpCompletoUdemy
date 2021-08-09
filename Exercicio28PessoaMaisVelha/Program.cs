using System;

namespace Exercicio28PessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa:");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            y.Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa:");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade) {
            
                Console.WriteLine("Pessoa mais velha " + x.Nome);

            }
            else if (y.Idade > x.Idade) {

                Console.WriteLine("Pessoa mais velha " + y.Idade);

            } 
            else {

                Console.WriteLine("Mesma idade");

            }
        }
    }
}
