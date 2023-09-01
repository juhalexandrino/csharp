using Exercicio03.Model;
using Exercicio03.Namespace02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Model
{
    public class Gerente : Funcionario
    {
        private string tipo;
        public Gerente(int id, string nome, bool ativo, decimal salario, int tempoTrabalho, string tipo) : base(id, nome, ativo, salario, tempoTrabalho)
        {
            this.tipo = tipo;
        }

        public string getTipo() { 
            return tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Tipo de Gerente: {this.tipo}");
        }
    }
}
