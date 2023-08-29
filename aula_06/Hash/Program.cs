namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criando um HashSet de nomes
            HashSet<string> setNomes = new HashSet<string>(){
                "Allan",
                "Robson",
                "João",
                "Ingrid",
                "Allan",
                "Robson",
            };

            // mostra os nomes
            foreach (var nome in setNomes) { 
                Console.WriteLine(nome);
            }

            Console.WriteLine();

            // adicionando novos nomes
            setNomes.Add("Samantha");
            setNomes.Add(null); // elemento nulo
            setNomes.Add("Julia");

            foreach (var nome in setNomes){
                Console.WriteLine(nome);
            }

            // verificando se o elemento existe
            Console.WriteLine("\nO nome Julia existe? " + setNomes.Contains("Julia"));

            Console.WriteLine();

            // remove um nome
            setNomes.Remove("João");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }


        }
    }
}
