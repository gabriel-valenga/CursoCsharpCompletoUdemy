namespace Exercicio30ProdutoEstoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;

        public double ValorTotalEmEstoque() {

            return Preco * QuantidadeEstoque;

        }

        public void AdicionarProdutos(int quantidade) {

            QuantidadeEstoque += quantidade;

        }

        public void RemoverProdutos(int quantidade) {

            QuantidadeEstoque -= quantidade;

        }

        public string MostrarDadosProduto() {

            return "Nome: " + Nome + " / Preço:" + Preco.ToString("F2") +
                   " / Quantidade no estoque: " + QuantidadeEstoque.ToString() + " / Valor total: " + ValorTotalEmEstoque().ToString("F2");

        }
    }
}