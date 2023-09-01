namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte t1 = new Transporte(5);
            t1.Visualizar();

            Console.WriteLine();

            Terrestre t2 = new Terrestre(4, 4, 100);
            t2.Visualizar();

            Console.WriteLine();

            Automovel a1 = new Automovel(12, 6, 300, "Vermelho", 3, "A1BC34", 7);
            a1.Visualizar();
        }
    }
}