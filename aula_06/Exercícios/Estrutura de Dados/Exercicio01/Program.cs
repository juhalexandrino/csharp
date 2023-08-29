namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cliente = new Queue<string>();
            string? nomeCliente;
            int entrada;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1 - Adicionar cliente na fila");
            Console.WriteLine("2 - Listar todos os clientes");
            Console.WriteLine("3 - Retirar cliente da fila");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Escolha a opção desejada: ");
            entrada = Convert.ToInt32(Console.ReadLine());

            switch (entrada){
                case 1:
                    Console.WriteLine("Digite o nome: ");
                    nomeCliente = Console.ReadLine();
                    cliente.Enqueue(nomeCliente);
                    Console.WriteLine("Fila atual: ");
                    Console.Write(nomeCliente);
                    Console.WriteLine("Cliente adicionado!");
                    break;
            }
        }
    }
}