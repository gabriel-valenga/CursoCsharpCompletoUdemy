namespace Exercicio35ConversorMoedaDolar
{
    public class ConversorMoedaDolar
    {

        public static double ValorEmReaisSemIOF;
        public static double TaxaIOF(double valorEmDolar) {
            
            return valorEmDolar * 0.06;
        
        }

        public static void CalculaValorEmReaisSemIOF(double cotacaoDolar, double quantosDolares) {

            ValorEmReaisSemIOF =  cotacaoDolar * quantosDolares;

        }

        public static double ValorTotalEmReais(double cotacaoDolar, double quantosDolares) {

            CalculaValorEmReaisSemIOF(cotacaoDolar, quantosDolares);
            return ValorEmReaisSemIOF + TaxaIOF(ValorEmReaisSemIOF);

        }
    }
}