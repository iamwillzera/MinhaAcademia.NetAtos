using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Pessoa
    {

        public string nome;
        public Pessoa(string nomePessoa)
        {
            this.nome = nomePessoa;
        }

        public static void cadastrarNome()
        {
            string nome;
            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();

        }
    }
}
