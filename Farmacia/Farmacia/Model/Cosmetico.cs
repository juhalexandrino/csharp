using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Cosmetico : Produto
    {
        private string fragrancia = string.Empty;
        public Cosmetico(int id, int tipo, string nome, decimal preco, string fragrancia) : base(id, tipo, nome, preco)
        {
            this.fragrancia = fragrancia;
        }

        public string GetFragrancia() {
            return fragrancia;
        }

        public void SetFragrancia(string fragrancia)
        {
            this.fragrancia = fragrancia;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.Write($"Nome da fragrância: {this.fragrancia}");
        }
    }
}
