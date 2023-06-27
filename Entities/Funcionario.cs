using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Funcionario
    {
        private string? _nome;
        private int _matricula;
        private string? _assinatura;
        private string? _cargo;

        public Funcionario()
        {
        }

        public Funcionario(string nome, int matricula, string assinatura, string cargo)
        {
            Nome = nome;
            Matricula = matricula;
            Assinatura = assinatura;
            Cargo = cargo;
        }

        public string? Nome { get => _nome; set => _nome = value; }
        public int Matricula { get => _matricula; set => _matricula = value; }
        public string? Assinatura { get => _assinatura; set => _assinatura = value; }
        public string? Cargo { get => _cargo; set => _cargo = value; }
    }
}
