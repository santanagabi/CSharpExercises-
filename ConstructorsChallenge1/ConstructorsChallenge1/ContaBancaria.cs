using System.Globalization;

namespace ConstructorsChallenge1
{
    class ContaBancaria
    {
        // propiedades
        // número da conta não pode ser alterado após criado
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // construtores
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            // Encapsulamento
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        // toString()
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
