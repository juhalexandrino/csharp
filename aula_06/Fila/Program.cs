namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            // adicionando pessoas na fila
            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");

            // remove o primeiro elemento da fila
            fila.Dequeue();

            // mostrando os nomes
            foreach (var nome in fila) {
              Console.WriteLine(nome);
            }

            // verificando o primeiro da fila sem tirar
            Console.WriteLine("Quem é o primeiro da fila? " + fila.Peek());

            // verificando se exite um nome na fila
            Console.WriteLine("O Gaspar entrou na fila? " + fila.Contains("Gaspar"));

            // contando quantos elementos tem na fila
            Console.WriteLine("Número de pessoas na fila " + fila.Count);
        }
    }
}