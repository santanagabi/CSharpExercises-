using System;
using System.Globalization;

namespace CurrencyConverter;
class Program
{
    static void Main(string[] args)
    {
        /* Faça um programa para ler a cotação do dólar, e depois um valor em dólares a 
         * ser comprado por uma pessoa em reais. Informar quantos reais a pessoa vai pagar
         * pelos dólares, considerando ainda que a pessoa terá que pagar 6 % de IOF sobre 
         * o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos 
         * cálculos.
        */

        Console.WriteLine("Qual é sua cotação em dólar?");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Quantos dólares você vai comprar?");
        double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double valorPago = ConversorDeMoeda.DolarParaReal(cotacao,dolar);

       Console.WriteLine("Valor a ser pago em reais = " + valorPago.ToString("F2", CultureInfo.InvariantCulture));
    }
}