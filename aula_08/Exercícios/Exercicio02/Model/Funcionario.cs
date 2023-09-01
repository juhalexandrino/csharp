using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Namespace02
{
    public class Funcionario
    {
        private int id;
        private string nome = string.Empty;
        private bool ativo;
        private decimal salario;
        private int tempoTrabalho;

        public Funcionario(int id, string nome, bool ativo, decimal salario, int tempoTrabalho)
        {
            this.id = id;
            this.nome = nome;
            this.ativo = ativo;
            this.salario = salario;
            this.tempoTrabalho = tempoTrabalho;
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

        public bool GetAtivo()
        {
            return ativo;
        }

        public void SetAtivo(bool ativo)
        {
            this.ativo = ativo;
        }

        public decimal GetSalario()
        {
            return salario;
        }

        public void SetSalario(decimal salario)
        {
            this.salario = salario;
        }

        public int GetTempoTrabalho()
        {
            return tempoTrabalho;
        }

        public void SetTempoTrabalho (int TempoTrabalho)
        {
            this.tempoTrabalho= TempoTrabalho;
        }

        public virtual void Visualizar()
    {
        Console.WriteLine("===== Dados do(a) funcionário(a) =====");
        Console.WriteLine($"ID do(a) funcionário(a): {this.id}");
        Console.WriteLine($"Nome do(a) funcionário(a): {this.nome}");
        Console.WriteLine($"Esse(a) funcionário(a) está em atividade? {this.ativo}");
        Console.WriteLine($"Salário do(a) funcionário(a): " + (this.salario).ToString("C"));
        Console.WriteLine($"Tempo na empresa: {this.tempoTrabalho} ano(s)");
    }  
    
    }

        

    
}
