using System;

namespace Exercicio39VetorQuartosHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] hotel = new Quarto[10];
            Console.WriteLine("Digite o número de estudantes que irão alugar os quartos:");
            int numeroEstudantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroEstudantes; i++)
            {
                
                Console.WriteLine("Digite o nome:");
                string nomeEstudanteAux = Console.ReadLine();
                Console.WriteLine("Digite o email:");
                string emailEstudanteAux = Console.ReadLine();
                Console.WriteLine("Digite qual quarto deseja  alugar:");
                int idQuarto = int.Parse(Console.ReadLine());

                Quarto quarto = new Quarto();
                quarto.AlugarQuarto(nomeEstudanteAux, emailEstudanteAux);
                hotel[idQuarto] = quarto;
               
            }

            Console.WriteLine("Relação dos quartos alugados:");

            for (int i = 0; i < hotel.Length; i++)
            {

                if (hotel[i] != null) {

                    Console.WriteLine(i.ToString() + ": " + hotel[i]);

                }

            }
            
        }
    }
}
