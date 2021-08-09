namespace Exercicio33LerNotasAlunoTrimestre
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal;
        public double NotaFaltante;

        public override string ToString()
        {
            return Aprovacao();
        }

        public void PreencheNotaFinal() {

            NotaFinal = Nota1 + Nota2 + Nota3;

        }

        public string Aprovacao() {

            PreencheNotaFinal();

            if (NotaFinal >= 60) {

                return "NOTA FINAL: " + NotaFinal.ToString() + "\r\n" + "APROVADO";
            }
            else {

                NotaFaltante = 60 - NotaFinal;    
                return "NOTA FINAL: " + NotaFinal.ToString() + "\r\n" + "REPROVADO \r\n FALTARAM " + NotaFaltante + " PONTOS";

            }

        }

    }
}