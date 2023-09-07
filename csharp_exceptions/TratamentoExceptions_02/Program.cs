namespace TratamentoExceptions_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite uma idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            ValidarIdade(idade);
        }

        public static void ValidarIdade(int idade)
        {

            if (idade < 18)
                throw new ArithmeticException("A pessoa não pode dirigir!");
            else
                Console.WriteLine("A pessoa pode dirigir!");

        }

    }
}