using System;

namespace Exercicio15ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salario:");
            double salario;
           salario = double.Parse(Console.ReadLine());
            double restoSalario = salario;
            double impostoDeRenda = 0.00;

            if (salario < 2000.01) {
            
                Console.WriteLine("ISENTO");
            
            }
            else {

                restoSalario = restoSalario - 2000;
            
                if (restoSalario > 0) {          //maior que 2000 e menor que 3000.01
    
                    if (restoSalario < 1000) { 

                        impostoDeRenda = impostoDeRenda + (restoSalario * 0.08);
                        
                    }
                    else {

                        impostoDeRenda = impostoDeRenda + (1000 * 0.08);
                    }

                    restoSalario = restoSalario - 1000;
                }
            
                if (restoSalario > 0) {          //maior que 3000 e menor que 4500.01

                    if (restoSalario < 1500) {
                    
                        impostoDeRenda = impostoDeRenda + (restoSalario * 0.18);

                    }
                    else { 

                        impostoDeRenda = impostoDeRenda + (1500 * 0.18);

                    }

                    restoSalario = restoSalario - 1500;

                }
                
                if (restoSalario > 0) {                                   // maior que 4500

                    impostoDeRenda = impostoDeRenda + (restoSalario * 0.28);
                }

                Console.WriteLine("R$ {0:F2} ", impostoDeRenda );

            }

        }
    }
}
