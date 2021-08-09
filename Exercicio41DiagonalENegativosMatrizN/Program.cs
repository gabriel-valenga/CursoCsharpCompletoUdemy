using System;

namespace Exercicio41DiagonalENegativosMatrizN
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorNegativos = 0;
            Console.WriteLine("Digite a quantidade N:");
            int quantidadeN = int.Parse(Console.ReadLine());

            int [,] matrizN = new int[3,3];
            int tamanhoMatriz = quantidadeN * 3;

            for (int i = 0; i < quantidadeN; i++)
            {
                for (int j = 0; j < quantidadeN; j++) 
                {
                    Console.WriteLine("Digite o numero para a posição " +
                                      "[ " + i.ToString() + ", " + j.ToString() + "]:");
                    matrizN[i,j] = int.Parse(Console.ReadLine());

                }
                
            }

            for (int k = 0; k < quantidadeN; k++)
            {
                for (int l = 0; l < quantidadeN; l++)
                {
                    Console.Write(" " + matrizN[k,l].ToString());
                    if ( matrizN[k,l] < 0 ) 
                    {
                        contadorNegativos += 1;

                    }
                    
                }
                Console.WriteLine();
                
            }

            Console.WriteLine("Diagonal principal:");

            for (int m = 0; m < quantidadeN; m++)
            {
               Console.Write(" " + matrizN[m,m].ToString());
                
            }
            Console.WriteLine();
            Console.WriteLine("Negativos: " + contadorNegativos.ToString());

        }
    }
}
