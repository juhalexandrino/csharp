using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public abstract class Produto
    {
        private int id, tipo;
        private string nome;
        private decimal preco;

        public Produto(int id, int tipo, string nome, decimal preco)
        {
            this.id = id;
            this.tipo = tipo;
            this.nome = nome;
            this.preco = preco;
        }

        public int GetId() { 
            return id; 
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetTipo()
        {
            return tipo;
        }

        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("\n");
            Console.WriteLine("========= Informações do produto =========");
            Console.WriteLine($"ID do produto: {this.id}");
            Console.WriteLine($"Nome do produto: {this.nome}");
            Console.WriteLine($"Tipo do produto: {this.tipo}");
            Console.WriteLine($"Preço do produto: " + (this.preco).ToString("C"));


        }
    }
}
