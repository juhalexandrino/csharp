using Exercicio01.Namespace01;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1, "Clara", "emailclara@email.com", "11 1234-5678", "Rua de Pedra, 01");
            Cliente cliente2 = new Cliente(2, "Fabiana", "emailfabiana@email.com", "22 8765-4321", "Rua de Barro, 02");
            
            cliente.Visualizar();
            Console.WriteLine("");
            cliente2.Visualizar();
        }
    }
}