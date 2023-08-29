using System.Collections.Generic;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cliente = new Queue<string>();
            string? nomeCliente;
            int entrada;

            do{
                Console.WriteLine("===============================================");
                Console.WriteLine("       1 - Adicionar cliente na fila");
                Console.WriteLine("       2 - Listar todos os clientes");
                Console.WriteLine("       3 - Retirar cliente da fila");
                Console.WriteLine("       0 - Sair");
                Console.WriteLine("===============================================");

                Console.Write("\nEscolha a opção desejada: ");
                entrada = Convert.ToInt32(Console.ReadLine());

                if (entrada == 0)
                    Console.WriteLine("Programa finalizado!");
                else if (entrada < 0 || entrada >= 4)
                    Console.WriteLine("Digite uma opção válida.");
                
                switch (entrada){
                   
                    case 1:
                        Console.Write("Digite o nome: ");
                        nomeCliente = Console.ReadLine();
                        cliente.Enqueue(nomeCliente);
                        
                        Console.WriteLine("\nFila atual: ");
                        foreach (var todosClientes in cliente){
                            
                            Console.WriteLine(todosClientes);
                        }
                        Console.Write("\n\nCliente adicionado com sucesso!\n");
                    break;

                    case 2:
                        foreach (var todosClientes in cliente){
                        Console.WriteLine("" + todosClientes);
                        }

                        if (cliente.Count == 0)
                            Console.WriteLine("A fila está vazia!");
                    break;

                    case 3:
                        
                        cliente.Dequeue();
                        foreach (var todosClientes in cliente){
                            Console.WriteLine("" + todosClientes);
                        }

                        Console.WriteLine("Cliente foi chamado!");

                        if (cliente.Count == 0)
                            Console.WriteLine("A fila está vazia!");
                    break;
                }

            }while (entrada > 0 && entrada <=3);            
        }
    }
}