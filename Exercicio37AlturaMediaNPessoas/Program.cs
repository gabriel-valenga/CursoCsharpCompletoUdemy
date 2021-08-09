using System;

namespace Exercicio37AlturaMediaNPessoas
{
    class Program
    {
        static void Main(string[] args)
        {

            double alturaMedia;
            double somaAlturas = 0;

            Console.WriteLine("Digite o número de pessoas:");
            int numeroPessoas = int.Parse(Console.ReadLine());

            double[] alturaPessoas = new double[numeroPessoas];
            

            for (int i = 0; i < numeroPessoas; i++)
            {
                
                Console.WriteLine("Digite a altura: ");
                alturaPessoas[i] = double.Parse(Console.ReadLine());

            }

            foreach (double altura in alturaPessoas)
            {
                
                somaAlturas += altura;
            
            }

            alturaMedia = somaAlturas / numeroPessoas;

            Console.WriteLine("Altura média: " + alturaMedia.ToString("F2"));
        }
    }
}
