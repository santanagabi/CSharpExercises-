using System.Globalization;
namespace Construtor
{
    class Produto
    {
        /* Atributos */
        // Encapsulamento = não possa expor atributo ou operação que possa prejudicar
        // a integridade do meu produto
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // Construtor padrão
        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Propeties / Propiedades
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) { _nome = value; }
                // value = o valor que chega ao set
            }
        }

        /* Método */
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade+= quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}