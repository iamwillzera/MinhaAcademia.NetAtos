namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            Console.WriteLine("Informe o título do livro: ");
            livro.titulo = Console.ReadLine();

            Console.WriteLine("ISBN: ");
            livro.isbn = Console.ReadLine();

            Console.WriteLine("Autor: ");
            livro.autor = Console.ReadLine();

            Console.WriteLine("Quantidade de páginas: ");
            livro.qtdePaginas = int.Parse(Console.ReadLine());

        }
    }
}