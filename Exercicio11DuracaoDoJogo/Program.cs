using System;

namespace Exercicio11DuracaoDoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaInicio, horaFinal;
            int duracaoJogo;
            Console.WriteLine("Digite o horário de início do jogo:");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite o horário do final do jogo");
            horaFinal = DateTime.Parse(Console.ReadLine());

            duracaoJogo = horaFinal.Hour - horaInicio.Hour;

            if(duracaoJogo < 1 || duracaoJogo > 24) {

                Console.WriteLine("Duração do jogo inválida, digite novamente.");
            
            }
            else {

                Console.WriteLine("O jogo durou " + duracaoJogo.ToString() + " hora(s)" );

            } 


        }
    }
}
