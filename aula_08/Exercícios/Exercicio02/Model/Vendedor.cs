using Exercicio03.Model;
using Exercicio03.Namespace02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Model
{
    public class Vendedor : Funcionario
    {
        private int metas;
        public Vendedor(int id, string nome, bool ativo, decimal salario, int tempoTrabalho, int metas) : base(id, nome, ativo, salario, tempoTrabalho)
        {
            this.metas = metas;
        }

        public int GetMetas()
        {
            return this.metas;
        }

        public void SetMetas (int metas)
        {
            this.metas = metas;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Metas de vendas para nesse mês: {this.metas}");
        }
    }
}
