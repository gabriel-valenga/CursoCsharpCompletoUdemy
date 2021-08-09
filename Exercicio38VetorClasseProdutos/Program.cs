using System;

namespace Exercicio38VetorClasseProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAux;
            double precoAux;
            Produto produtoAux;
            double somaPrecosProdutos = 0;

            Console.WriteLine("Digite o número de produtos:");
            int numeroProdutos = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[numeroProdutos];

            for (int i = 0; i < numeroProdutos; i++)
            {
                
                Console.WriteLine("Digite o nome do produto:");
                nomeAux = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto:");
                precoAux = double.Parse(Console.ReadLine());

                produtoAux = new Produto(nomeAux, precoAux);
                produtos[i] = produtoAux;

            }

            foreach (Produto produto in produtos)
            {
                
                somaPrecosProdutos += produto.Preco; 

            }
            
            double precoMedioProdutos = somaPrecosProdutos / numeroProdutos; 

            Console.WriteLine("Preço médio produtos: " + precoMedioProdutos.ToString("F2"));
        }
    }
}
