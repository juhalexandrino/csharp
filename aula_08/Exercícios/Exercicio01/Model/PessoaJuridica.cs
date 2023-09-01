using Exercicio01.Namespace01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaJuridica : Cliente
    {
        private string representanteLegal;
        public PessoaJuridica(int id, string nome, string email, string telefone, string endereco, string representanteLegal) : base(id, nome, email, telefone, endereco)
        {
            this.representanteLegal = representanteLegal;
        }

        public string GetRepresentanteLegal()
        {
            return this.representanteLegal;
        }

        public void SetRepresentanteLegal (string representanteLegal)
        {
            this.representanteLegal = representanteLegal;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Representante Legal: {this.representanteLegal}");
        }
    }
}
