using System;

namespace Exercicio21MediaPonderadaTresValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos conjuntos de valores serão inseridos a seguir: ");
            int quantidadeConjuntoValores = int.Parse(Console.ReadLine());
            double valor1 = 0;
            double valor2 = 0;
            double valor3 = 0;
            double[] mediaPonderada = new double[quantidadeConjuntoValores];
            string[] conjuntoValores;

            for (int i = 0; i < quantidadeConjuntoValores; i++)
            {
                conjuntoValores = Console.ReadLine().Split(' ');
                valor1 = double.Parse(conjuntoValores[0]) * 2;
                valor2 = double.Parse(conjuntoValores[1]) * 3;
                valor3 = double.Parse(conjuntoValores[2]) * 5;

                mediaPonderada[i] = (valor1 + valor2 + valor3) / 10;

            }

            for (int i = 0; i < mediaPonderada.Length; i++)
            {

                Console.WriteLine("{0:F1}",mediaPonderada[i]);

            }

        }
    }
}
