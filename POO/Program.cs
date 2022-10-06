using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
            //Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e
            //que não esteja na lista.Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e
            //exibir a lista ordenada.

            //List<string> nomeLista = new List<string>();
            //string[] dadosNome;
            //string nome;
            //int continuar = 1;

            //do
            //{

            //    do
            //    {
            //        Console.WriteLine("Informe o nome completo: ");
            //        nome = Console.ReadLine().ToUpper();
            //        dadosNome = nome.Split(' ');
            //    } while (dadosNome.Length <= 1);

            //    if (nomeLista.Contains(nome))
            //    {
            //        Console.WriteLine("O nome digitado já está cadastrado!");
            //    }
            //    else
            //    {
            //        nomeLista.Add(nome);
            //    }

            //    Console.WriteLine("Digite 1 para continuar / Digite 2 para sair:");
            //    continuar = int.Parse(Console.ReadLine());

            //} while (continuar == 1);

            //nomeLista.Sort();
            //Console.WriteLine("\nPessoas cadastradas: ");

            //foreach (var pessoa in nomeLista)
            //{
            //    Console.WriteLine(pessoa);
            //}

            //------------------------------------------------------------------------------------------//

            //2.Fazer um programa em VS que popule uma lista com números inteiros(0 a 1000) que sejam sorteados
            //randomicamente.O programa deve pedir ao usuário quantos números deseja armazenar. Ao final, o programa
            //deve exibir os números populados na lista.

            //int numero = 0;
            //List<int> listaNumeros = new List<int>();
            //Random aleatorio = new Random();

            //Console.WriteLine("Quantos números deseja armazenar na lista?");
            //int qtdeNumeros = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= qtdeNumeros; i++)
            //{
            //    numero = aleatorio.Next(0, 1000);

            //    listaNumeros.Add(numero);
            //}

            //Console.WriteLine();

            //foreach (var numerosSorteados in listaNumeros)
            //{
            //    Console.WriteLine(numerosSorteados);
            //}

            //-----------------------------------------------------------//
            //3.Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
            //Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
            //o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
            //lista, o programa deve listar os domínios de emails cadastrados no programa.

            //Menu
            //1 - Cadastrar email
            //2 - Listar
            //3 - Sair
            //Opção:

            int opcao = 0;
            string email = "";
            List<string> listaEmail = new List<string>();
            List<string> listaDominios = new List<string>();

            do
            {
                Console.WriteLine("\n====================" +
                    "\n1 - Cadastrar e-mail" +
                    "\n2 - Listar" +
                    "\n3 - Sair" +
                    "\n====================");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Informe o e-mail: ");
                    email = (Console.ReadLine());

                    if (listaEmail.Contains(email))
                    {
                        Console.WriteLine("E-mail já cadastrado!");
                    }
                    else
                    {
                        listaEmail.Add(email);
                    }

                }
                else if (opcao == 2)
                {
                    listaEmail.Sort();
                    foreach (var emailListado in listaEmail)
                    {
                        Console.WriteLine(emailListado);
                    }
                }

            } while (opcao != 3);


        }
    }
}
