using System;

namespace Exercicio30ProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Digite o nome do produto:");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto:");
            produto.QuantidadeEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine(produto.MostrarDadosProduto());


            Console.WriteLine("Digite a quantidade de " + produto.Nome + " a ser adicionada no estoque:");
            int quantidadeAdicionar = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidadeAdicionar);
            Console.WriteLine(produto.MostrarDadosProduto());

            Console.WriteLine("Digite a quantidade de " + produto.Nome + " a ser removida do estoque:");
            int quantidadeRemover = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidadeRemover);
            Console.WriteLine(produto.MostrarDadosProduto());

        }
    }
}
