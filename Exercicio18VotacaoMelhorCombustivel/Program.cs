using System;

namespace Exercicio18VotacaoMelhorCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (codigo != 4) {

                Console.WriteLine("Digite o combustível de sua preferência:");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1) {

                    alcool += 1;

                }
                else if (codigo == 2) {

                    gasolina += 1;

                }
                else if (codigo == 3) {

                    diesel += 1;

                }
                else if (codigo == 4) {
                    
                    break;
                
                }
                else {

                    Console.WriteLine("Digite um código válido!");
                    continue;

                }

                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);

            }

        }
    }
}
