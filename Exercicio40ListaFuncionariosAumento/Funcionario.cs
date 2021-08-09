namespace Exercicio40ListaFuncionariosAumento
{
    public class Funcionario
    {
        public int Id{get;set;}
        public string Nome{get;set;}
        public double Salario{get;private set;}

        public Funcionario(int id, string nome, double salario)
        {

            Id = id;
            Nome = nome;
            Salario = salario;            

        }

        public override string ToString()
        {
            return Id.ToString() + ", " + Nome + ", " + Salario.ToString("F2");
        }

        public void AumentarSalario(double porcentagem) 
        {

            Salario += Salario * (porcentagem / 100);

        }
    }
}