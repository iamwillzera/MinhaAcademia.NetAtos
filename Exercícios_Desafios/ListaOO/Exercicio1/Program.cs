namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tituloLivro = "";
            string codIsbn = "";
            string nomeAutor = "";
            int qtPaginas = 0;

            Livro livro = new Livro(tituloLivro, qtPaginas, nomeAutor, codIsbn);

            livro.dadosLivro(/*tituloLivro, codIsbn, nomeAutor, qtPaginas*/);

            Console.WriteLine();
            Console.WriteLine("--- Dados do livro ---");
            Console.WriteLine();

            Console.WriteLine($"Título: {livro.titulo}" +
                $"\nCódigo ISBN: {livro.isbn}" +
                $"\nAutor: {livro.autor}" +
                $"\nQuantidade de páginas: {livro.qtdePaginas}");

        }
    }
}