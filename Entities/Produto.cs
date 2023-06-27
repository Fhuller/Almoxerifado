using System.Globalization;

namespace Entities
{
    public class Produto
    {
        private string? _nome;
        private string? _identificacao;
        private double _preco;
        private double _dimensao;
        private double _peso;
        private string? _categoria;

        public Produto(string nome, string identificacao, double preco, double dimensao, double peso, string categoria)
        {
            Nome = nome;
            Identificacao = identificacao;
            Preco = preco;
            Dimensao = dimensao;
            Peso = peso;
            Categoria = categoria;
        }

        public string? Categoria { get => _categoria; set => _categoria = value; }
        public double Peso { get => _peso; set => _peso = value; }
        public double Dimensao { get => _dimensao; set => _dimensao = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public string? Identificacao { get => _identificacao; set => _identificacao = value; }
        public string? Nome { get => _nome; set => _nome = value; }
    }
}