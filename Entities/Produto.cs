using System.Globalization;

namespace Entities
{
    public class Produto
    {
        private int _id;
        private string? _nome;
        private string? _identificacao;
        private double _preco;
        private double _dimensao;
        private double _peso;
        private string? _categoria;
        private int _qtd;

        public Produto(int id, string nome, string identificacao, double preco, double dimensao, double peso, string categoria, int qtd)
        {
            Nome = nome;
            Identificacao = identificacao;
            Preco = preco;
            Dimensao = dimensao;
            Peso = peso;
            Categoria = categoria;
            Id = id;
            Qtd = qtd;
        }

        public string? Categoria { get => _categoria; set => _categoria = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public double Dimensao { get => _dimensao; set => _dimensao = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public string? Identificacao { get => _identificacao; set => _identificacao = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public int Id { get => _id; set => _id = value; }
        public int Qtd { get => _qtd; set => _qtd = value; }

        public void RetiraProduto(int qtdRetirada)
        {
            if (qtdRetirada > Qtd)
                throw new Exception("Quantidade de retirada maior que a quantidade de produtos!");

            _qtd = _qtd - qtdRetirada;
        }
    }
}