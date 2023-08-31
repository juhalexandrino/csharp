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
        private string cargo = string.Empty;
        private decimal salario;
        private int tempoTrabalho;

        public Funcionario(int id, string nome, string cargo, decimal salario, int tempoTrabalho)
        {
            this.id = id;
            this.nome = nome;
            this.cargo = cargo;
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

        public string GetCargo()
        {
            return nome;
        }

        public void SetCargo(string cargo)
        {
            this.cargo = cargo;
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

        public void Visualizar()
    {
        Console.WriteLine("===== Dados do funcionário(a) =====");
        Console.WriteLine($"ID do(a) funcionário(a): {this.id}");
        Console.WriteLine($"Nome do(a) funcionário(a): {this.nome}");
        Console.WriteLine($"Cargo do(a) funcionário(a): {this.cargo}");
        Console.WriteLine($"Salário do(a) funcionário(a): " + (this.salario).ToString("C"));
        Console.WriteLine($"Tempo na empresa: {this.tempoTrabalho} ano(s)");
    }  
    
    }

        

    
}
