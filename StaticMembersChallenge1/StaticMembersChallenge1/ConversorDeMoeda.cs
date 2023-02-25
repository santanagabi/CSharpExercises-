namespace CurrencyConverter
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double dolar, double cotacao)
        {
            double total = dolar * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
