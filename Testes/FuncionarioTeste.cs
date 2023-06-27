using Entities;
using ExpectedObjects;
using Xunit;

namespace TesteUnitarioAlmoxerifado
{
    public class FuncionarioTeste
    {
        public List<Funcionario> funcionarios;

        [Fact]
        public void CadastroFuncionario()
        {
            Funcionario teste = new ("Xusto", 123, "Alexundro", "Desempregado");
            
            Funcionario funcionarioTeste = new(teste.Nome, teste.Matricula, teste.Assinatura, teste.Cargo);

            teste.ToExpectedObject().ShouldEqual(funcionarioTeste);
        }

        [Fact]
        public void DeletaFuncionario()
        {
            // Arrange
            Funcionario funcionario = new("Felipe", 321, "epilef", "Programador");

            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            listaFuncionarios.Add(funcionario);

            listaFuncionarios.Remove(funcionario);

            // Assert
            Assert.DoesNotContain(funcionario, listaFuncionarios);
        }

        [Fact]
        public void AtualizarFuncionario()
        {

            var funcionario = new Funcionario("João Silva", 321, "Desenvolvedor", "TI");
            var novoCargo = "Analista";

            funcionario.Cargo = novoCargo;

            funcionarios

            var funcionarioAtualizado = funcionariosController.BuscarFuncionarioPorNome(funcionario.Nome);
            Assert.Equal(novoCargo, funcionarioAtualizado.Cargo);
        }
    }
}