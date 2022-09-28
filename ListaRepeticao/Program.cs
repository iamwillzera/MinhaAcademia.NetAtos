using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando uma entrada de dados
            //(informando se ele está errado e repetindo a solicitação até que seja correto).
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número especificado pelo usuário.
            //
            //Exemplo:
            //Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Número digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            //int numero = 0;

            //do
            //{
            //    Console.WriteLine("Digite um número inteiro positivo: ");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero < 0)
            //    {
            //        Console.WriteLine("Número inválido. Favor digitar um número inteiro positivo.");
            //    }
            //} while (numero < 0);

            //Console.Write("Números pares entre 1 e " + numero + ": ");

            //for (int i = 1; i < numero; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + ", ");
            //    }
            //}


            // -----------------------------------------------------------------------//

            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //Um outro número.Caso positivo, o programa em VS deve ser repetido.


            //Exemplo:
            //            Digite um número inteiro positivo: 8
            //Número digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.


            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Número digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

            //Deseja informar outro número(s/ n)? N


            //int numero = 0;
            //char opcao = 's';

            //while (opcao == 's')
            //{

            //    do
            //    {
            //        Console.WriteLine("Digite um número inteiro positivo: ");
            //        numero = int.Parse(Console.ReadLine());

            //        if (numero < 0)
            //        {
            //            Console.WriteLine("Número inválido. Favor digitar um número inteiro positivo.");
            //        }
            //    } while (numero < 0);

            //    Console.Write("Números pares entre 1 e " + numero + ": ");

            //    for (int i = 1; i < numero; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i + ", ");
            //        }
            //    }

            //    Console.WriteLine("\n\nDeseja informar outro número? (s/n)");
            //    opcao = char.Parse(Console.ReadLine()); ;

            //}

            //--------------------------------------------------------------------------------------//

            //3.Fazer um laço(repetição) que fique solicitando números ao usuário.
            //Se o usuário digitar 0 ou programa em VS deve parar.
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            //double numero = 0;

            //do
            //{
            //    Console.WriteLine("Informe um número (digite 0 p/ parar): ");
            //    numero = double.Parse(Console.ReadLine());

            //    if (numero == 0)
            //    {
            //        break;
            //    }

            //    int divisores = 0;
            //    for (int i = 1; i <= numero; i++)
            //    {

            //        if (numero % i == 0)
            //        {
            //            divisores++;
            //        }
            //    }

            //    if (divisores == 2)
            //    {
            //        Console.WriteLine(numero + " é primo!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(numero + " não é primo!");
            //    }

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(numero + " é par!\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine(numero + " é ímpar!\n");
            //    }

            //} while (numero != 0);

            //-------------------------------------------------------------------------------------//

            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA.
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser representados como de votos para um dos números eo número
            //de votos em branco..

            //string voto = "";
            //double joao = 0, zeca = 0, branco = 0;


            //do
            //{
            //    Console.WriteLine("Digite o seu voto (JOAO / ZECA ou BRANCO). Para terminar digite FIM");
            //    voto = Console.ReadLine().ToUpper();

            //    if (voto == "JOAO")
            //    {
            //        joao++;
            //    } else if (voto == "ZECA")
            //    {
            //        zeca++;
            //    } else if (voto == "BRANCO")
            //    {
            //        branco++;
            //    }
            //} while (voto != "FIM");

            //Console.WriteLine("João: " + joao + " votos.");
            //Console.WriteLine("Zeca: " + zeca + " votos.");
            //Console.WriteLine("Brancos: " + branco + " votos.");

            //-----------------------------------------------------------------------------//

            //5.Modifique o programa em VS anterior para aceitar votos nulos
            //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos
            //e o número de pessoas que votaram.

            //string voto = "";
            //double joao = 0, zeca = 0, branco = 0, nulo = 0, total = 0;


            //do
            //{
            //    Console.WriteLine("Digite o seu voto (JOAO / ZECA ou BRANCO). Para terminar digite FIM");
            //    voto = Console.ReadLine().ToUpper();

            //    switch (voto)
            //    {
            //        case "JOAO":
            //            joao++;
            //            break;

            //        case "ZECA":
            //            zeca++;
            //            break;

            //        case "BRANCO":
            //            branco++;
            //            break;

            //        case "FIM":
            //            break;

            //        default:
            //            nulo++;
            //            break;
            //    }

            //    total++;

            //    } while (voto != "FIM");

            //if (joao > zeca)
            //{
            //    Console.WriteLine("O vencedor foi o candidato João com " + joao + " votos!");
            //} else if (zeca > joao)
            //{
            //    Console.WriteLine("O vencedor foi o candidato Zeca com " + zeca + " votos!");
            //} else if (joao == zeca)
            //{
            //    Console.WriteLine("Houve um empate. Ambos os candidatos obtiveram " + joao + " votos!");
            //}

            //Console.WriteLine("Quantidade de eleitores: " + total);
            //Console.WriteLine("Votos nulos: " + nulo);

        }
    }
}
