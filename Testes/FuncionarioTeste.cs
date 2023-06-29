using Entities;
using ExpectedObjects;
using Xunit;

namespace TesteUnitarioAlmoxerifado
{
    public class FuncionarioTeste
    {
        public static List<Funcionario> funcionarios = new List<Funcionario>();

        [Fact]
        public void CadastroFuncionario()
        {
            Funcionario teste = new Funcionario("Xusto", 123, "Alexundro", "Desempregado");
            
            Funcionario funcionarioTeste = new Funcionario(teste.Nome, teste.Matricula, teste.Assinatura, teste.Cargo);

            teste.ToExpectedObject().ShouldEqual(funcionarioTeste);

            funcionarios.Add(funcionarioTeste);
        }

        [Fact]
        public void DeletaFuncionario()
        {
            // Arrange
            Funcionario funcionario = new("Felipe", 321, "epilef", "Programador");

            funcionarios.Add(funcionario);

            funcionarios.Remove(funcionario);

            // Assert
            Assert.DoesNotContain(funcionario, funcionarios);
        }

        [Fact]
        public void AtualizarFuncionario()
        {
            var matricula = 1234123;

            var funcionario = new Funcionario("João Silva", 1234123, "Desenvolvedor", "TI");
            var novoCargo = "Analista";

            funcionario.Cargo = novoCargo;

            funcionarios.Add(funcionario);

            var funcionarioAtualizado = funcionarios.Find(x => x.Matricula == matricula);

            Assert.Equal(novoCargo, funcionarioAtualizado.Cargo);
        }

        [Fact]
        public void CriarFuncionarioNomeVazio()
        {
            string nome = ""; // Nome vazio

            Assert.Throws<ArgumentNullException>(() => new Funcionario(nome, 31223, "Teste", "Essesaco"));
        }
    }
}