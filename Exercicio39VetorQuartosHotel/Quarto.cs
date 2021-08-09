namespace Exercicio39VetorQuartosHotel
{
    public class Quarto
    {
        public string NomePessoaAlugou{get; private set;}
        public string EmailPessoaAlugou{get; private set;}

        public override string ToString() {
            
            return "Nome: " + NomePessoaAlugou + "; Email: " + EmailPessoaAlugou + ".";  
        
        }

        public void AlugarQuarto(string nome, string email) {

            NomePessoaAlugou = nome;
            EmailPessoaAlugou = email;

        }
       
    }
}