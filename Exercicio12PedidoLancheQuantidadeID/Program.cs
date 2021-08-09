using System;

namespace Exercicio12PedidoLancheQuantidadeID

{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lanche;
            string idLanche;
            int quantidadeLanche;
            double valorTotal;

            valorTotal = 0.00;

            Console.WriteLine("Digite as informações do pedido:");
            lanche = Console.ReadLine().Split(' ');

            idLanche = lanche[0];
            quantidadeLanche = int.Parse(lanche[1]);

            if (idLanche == "1" ) {

                valorTotal = 4.00 * quantidadeLanche;         

            }
            else if (idLanche == "2") {

                valorTotal = 4.50 * quantidadeLanche;

            }
            else if (idLanche == "3") {

                valorTotal = 5.00 * quantidadeLanche;

            }
            else if (idLanche == "4") {

                valorTotal = 2.00 * quantidadeLanche;

            }

            Console.WriteLine("TOTAL = {0:F2}", valorTotal);

        }
    }
}
