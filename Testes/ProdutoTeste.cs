using Entities;
using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitarioAlmoxerifado
{
    public class ProdutoTeste
    {
        List<Produto> produtos = new List<Produto>();

        [Fact]
        public void CadastroProduto()
        {
            Produto teste = new Produto(123, "Computador", "Eletronico", 5000, 30, 6, "Gamer", 32);

            Produto produtoTeste = new Produto(teste.Id, teste.Nome, teste.Identificacao, teste.Preco, teste.Dimensao, teste.Peso, teste.Categoria, teste.Qtd);

            teste.ToExpectedObject().ShouldEqual(produtoTeste);

            produtos.Add(produtoTeste);
        }

        [Theory]
        [InlineData(100, 55)]
        [InlineData(900, 680)]
        public void RetiradaProduto(int quantidadeProduto, int quantidadeRetirada)
        {
            Produto papel = new Produto(123, "Papel Higienico", "Normal", 2, 2, 0.4, "Material de Higiene", quantidadeProduto);

            papel.RetiraProduto(quantidadeRetirada);

            papel.Qtd.Equals(quantidadeProduto - quantidadeRetirada);

            produtos.Add(papel);
        }

        [Theory]
        [InlineData(8, 10)]
        public void RetiradaProdutoQuantidadeInvalida(int quantidadeProduto, int quantidadeRetirada)
        {
            Produto sal = new Produto(123, "Sal", "Conservante", 1, 1, 0.4, "Alimento", quantidadeProduto);

            Assert.Throws<Exception>(() => sal.RetiraProduto(quantidadeRetirada));

            produtos.Add(sal);
        }
    }
}
