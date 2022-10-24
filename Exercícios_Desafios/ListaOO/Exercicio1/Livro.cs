using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Livro
    {
        public string titulo;
        public int qtdePaginas;
        public string autor;
        public string isbn;

        public Livro(string titulo, int qtdePaginas, string autor, string isbn)
        {
            this.titulo = titulo;
            this.qtdePaginas = qtdePaginas;
            this.autor = autor;
            this.isbn = isbn;
        }

        public void dadosLivro(/*string titulo,string isbn,string autor,int qtdePaginas*/)
        {
            Console.WriteLine("Informe o título do livro: ");
            titulo = Console.ReadLine();

            Console.WriteLine("ISBN: ");
            isbn = Console.ReadLine();

            Console.WriteLine("Autor: ");
            autor = Console.ReadLine();

            Console.WriteLine("Quantidade de páginas: ");
            qtdePaginas = int.Parse(Console.ReadLine());
        }
    }
}
