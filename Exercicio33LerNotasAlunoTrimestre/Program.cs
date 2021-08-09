using System;

namespace Exercicio33LerNotasAlunoTrimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Digite a primeira nota: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno.ToString());
            
        }
    }
}
