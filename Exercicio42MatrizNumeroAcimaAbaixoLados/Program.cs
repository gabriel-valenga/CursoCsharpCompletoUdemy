using System;

namespace Exercicio42MatrizNumeroAcimaAbaixoLados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor N1:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor N2:");
            int n2 = int.Parse(Console.ReadLine());

            int [,] matrizN = new int[n1,n2];

            for (int i = 0; i < n1; i++)
            {                
                for (int j = 0; j < n2; j++)
                {
                    Console.WriteLine("Digite o número para a posição [" + 
                                      i.ToString() + "," + j.ToString() + "]");

                    matrizN[i,j] = int.Parse(Console.ReadLine());

                }

            }

            Console.WriteLine("Digite o número para verificar as posições próximas:");
            int numeroVerificacaoProximos = int.Parse(Console.ReadLine());

            for (int k = 0; k < n1; k++)
            {
                for (int l = 0; l < n2; l++)
                {
                   if (numeroVerificacaoProximos == matrizN[k,l])
                   {    
                        Console.WriteLine("Posição " + k.ToString() + ", " + l.ToString() + ":");
                        Console.WriteLine();

                        if ( (l-1) > -1 )  //ESQUERDA
                        {
                            Console.WriteLine("Esquerda: " + matrizN[k,l-1].ToString());

                        }

                        if ( (l+1) < n2 ) //DIREITA
                        {
                            Console.WriteLine("Direita: " + matrizN[k,l+1].ToString());

                        }
                        
                        if ( (k-1) > -1 ) //ACIMA
                        {
                            Console.WriteLine("Acima: " + matrizN[k-1,l].ToString());
                        
                        } 

                        if ( (k+1) < n1 ) //ABAIXO
                        {
                            Console.WriteLine("Abaixo: " + matrizN[k+1,l].ToString());

                        }

                    }

                }

            }
        }
    }
}
