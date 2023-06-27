using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Movimentacao
    {
        private int _idFuncionario;
        private string? _idProduto;
        private string? _qtd;
        private DateTime _dtMovimentacao;

        public Movimentacao(int idFuncionario, string idProduto, string qtd, DateTime dtMovimentacao)
        {
            IdFuncionario = idFuncionario;
            IdProduto = idProduto;
            Qtd = qtd;
            DtMovimentacao = dtMovimentacao;
        }

        public int IdFuncionario { get => _idFuncionario; set => _idFuncionario = value; }
        public string? IdProduto { get => _idProduto; set => _idProduto = value; }
        public string? Qtd { get => _qtd; set => _qtd = value; }
        public DateTime DtMovimentacao { get => _dtMovimentacao; set => _dtMovimentacao = value; }
    }
}
