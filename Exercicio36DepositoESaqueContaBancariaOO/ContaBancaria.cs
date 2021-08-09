namespace Exercicio36DepositoESaqueContaBancariaOO
{
    public class ContaBancaria
    {
        private string _nomeTitular;
        private double _taxaSaque = 5.00;
        public string NumeroConta {get; private set;}
        public double Saldo {get; private set;}

        public ContaBancaria(string numeroConta, string nomeTitular) {

            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;

        }

        public ContaBancaria(string numeroConta, string nomeTitular, double depositoInicial) {

            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
            Depositar(depositoInicial);

        }
        public string NomeTitular {

            get {return _nomeTitular;}
            set {
                 if (value.Length > 1) {
                     _nomeTitular = value;
                     }
                 } 
                 
        }
       
        public override string ToString()
        {

            return "Dados da conta: \r\n Conta: " + NumeroConta + " Titular: " + NomeTitular +
                   " Saldo: " + Saldo.ToString("F2");
        
        }

        public void Depositar(double valorDeposito) {

            Saldo += valorDeposito;

        }

        public bool Sacar(double valorSaque) {

            double saldoAuxiliar = Saldo - valorSaque - _taxaSaque;

            if (saldoAuxiliar >= 0) {
            
                Saldo = saldoAuxiliar;
                return true;

            }
            else {

                return false;

            }
        }       
    }
}