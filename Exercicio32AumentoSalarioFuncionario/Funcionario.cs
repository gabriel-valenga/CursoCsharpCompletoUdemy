namespace Exercicio32AumentoSalarioFuncionario
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        
        public override string ToString()
        {
            return "Funcionário: " + Nome + ", $ " + SalarioLiquido().ToString("F2");
        }

        public double SalarioLiquido() {

            return SalarioBruto - Imposto;

        }

    
        public void AumentarSalario(double porcentagem) {

            SalarioBruto += SalarioBruto * (porcentagem / 100);

        }

    }
}