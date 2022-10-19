using System.Security.Cryptography;

namespace ConsoleApp3
{
    internal class Program

    {

        static List<Pessoa> pessoas;

        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Ricardo", 40));
            pessoas.Add(new Pessoa("Jefferson", 25));
            pessoas.Add(new Pessoa("Miriam", 45));

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }
            Console.ReadKey();

        }
    }
}