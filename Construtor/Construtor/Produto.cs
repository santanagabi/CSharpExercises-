using System.Globalization;
namespace Construtor
{
    class Produto
    {
        /* Atributos */
        // Encapsulamento = não possa expor atributo ou operação que possa prejudicar
        // a integridade do meu produto
        private string _nome;
        private double _preco;
        private int _quantidade;

        // Construtor padrão
        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        /* Método */
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}