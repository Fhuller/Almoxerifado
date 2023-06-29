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
        private int _idProduto;
        private int _qtd;
        private DateTime _dtMovimentacao;

        public Movimentacao(int idFuncionario, int idProduto, int qtd, DateTime dtMovimentacao)
        {
            IdFuncionario = idFuncionario;
            IdProduto = idProduto;
            Qtd = qtd;
            DtMovimentacao = dtMovimentacao;
        }

        public int IdFuncionario { get => _idFuncionario; set => _idFuncionario = value; }

        public DateTime DtMovimentacao { get => _dtMovimentacao; set => _dtMovimentacao = value; }
        public int IdProduto { get => _idProduto; set => _idProduto = value; }
        public int Qtd { get => _qtd; set => _qtd = value; }
    }
}
