using Entities;
using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitarioAlmoxerifado
{
    public class MovimentacaoTeste
    {
        List<Movimentacao> movimentacoes = new List<Movimentacao>();

        [Fact]
        public void CadastroFuncionario()
        {
            Movimentacao teste = new Movimentacao(123, 123, 2, DateTime.Now);

            Movimentacao movimentacaoTeste = new Movimentacao(teste.IdFuncionario, teste.IdProduto, teste.Qtd, teste.DtMovimentacao);

            teste.ToExpectedObject().ShouldEqual(movimentacaoTeste);

            movimentacoes.Add(movimentacaoTeste);
        }
    }
}
