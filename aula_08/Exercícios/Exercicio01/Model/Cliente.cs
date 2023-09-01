using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio01.Namespace01
{
    public class Cliente
    {
        private int id;
        private string nome = string.Empty;
        private string email = string.Empty;
        private string telefone = string.Empty;
        private string endereco = string.Empty;

        public Cliente(int id, string nome, string email, string telefone, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public void SetTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("==== Dados do(a) cliente =====");
            Console.WriteLine($"ID do(a) cliente: {this.id}");
            Console.WriteLine($"Nome do(a) cliente: {this.nome}");
            Console.WriteLine($"E-mail do(a) cliente: {this.email}");
            Console.WriteLine($"Telefone do(a) cliente: {this.telefone}");
            Console.WriteLine($"Endereço do(a) cliente: {this.endereco}");
        }
    }
}
