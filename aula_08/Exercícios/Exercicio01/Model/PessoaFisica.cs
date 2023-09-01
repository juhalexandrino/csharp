using Exercicio01.Model;
using Exercicio01.Namespace01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaFisica : Cliente
    {
        private int anosFidelidade;
        public PessoaFisica(int id, string nome, string email, string telefone, string endereco, int anosFidelidade) : base(id, nome, email, telefone, endereco)
        {
            this.anosFidelidade = anosFidelidade;
        }

        public int getAnosFidelidade()
        {
            return this.anosFidelidade;
        }

        public void SetAnosFidelidade (int anosFidelidade)
        {
            this.anosFidelidade = anosFidelidade;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Anos de fidelidade: {this.anosFidelidade}");
        }
    }
}
