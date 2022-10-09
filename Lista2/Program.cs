using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.

            //double baseTriangulo, altura;
            //do
            //{
            //    Console.WriteLine("Informe a base do triângulo: ");
            //    baseTriangulo = double.Parse(Console.ReadLine());
            //} while (baseTriangulo == 0);

            //Console.WriteLine("Informe a altura do triângulo: ");
            //altura = double.Parse(Console.ReadLine());

            //double areaTriangulo = (baseTriangulo * altura) / 2;

            //Console.WriteLine("A área do triângulo é igual a " + areaTriangulo);

            //----------------------------------------------------------------------//

            //2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

            //double numero;

            //Console.WriteLine("Informe um número: ");
            //numero = double.Parse(Console.ReadLine());

            //if(numero % 2 == 0)
            //{
            //    Console.WriteLine(numero + " é um número par!");
            //}
            //else
            //{
            //    Console.WriteLine(numero + " não é um número par!");
            //}

            //------------------------------------------------------------------------------//

            //3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,
            //    e escrever na tela os que são superiores à média.

            //int n1, n2, n3, n4, media;

            //Console.WriteLine("Informe o primeiro valor: ");
            //n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o segundo valor: ");
            //n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o terceiro valor: ");
            //n3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o quarto valor: ");
            //n4 = int.Parse(Console.ReadLine());

            //media = (n1 + n2 + n3 + n4) / 4;

            //Console.WriteLine("O valor da média é "+media);

            //if (n1 > media) { Console.WriteLine(n1 + " está acima da média."); }
            //if (n2 > media) { Console.WriteLine(n2 + " está acima da média."); }
            //if (n3 > media) { Console.WriteLine(n3 + " está acima da média."); }
            //if (n4 > media) { Console.WriteLine(n4 + " está acima da média."); }

            //--------------------------------------------------------------------------//

            //4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois
            //professores e o valor por hora recebido por cada um deles.
            //Mostrar na tela qual dos professores tem o maior salário total.

            string profUm, profDois;
            double qtdeUm = 0, qtdeDois = 0, valorHoraUm = 0, valorHoraDois = 0, totalUm = 0, totalDois = 0;

            Console.WriteLine("Informe o nome do(a) professor(a): ");
            profUm = Console.ReadLine();

            Console.WriteLine("Qual o valor da hora aula do(a) professor(a) " + profUm + "?");
            valorHoraUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas o(a) " + profUm + " trabalhou?");
            qtdeUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do(a) professor(a): ");
            profDois = Console.ReadLine();

            Console.WriteLine("Qual o valor da hora aula do(a) professor(a) " + profDois + "?");
            valorHoraDois = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas o(a) " + profDois + " trabalhou?");
            qtdeDois = double.Parse(Console.ReadLine());

            totalUm = (qtdeUm * valorHoraUm);
            totalDois = (qtdeDois * valorHoraDois);

            if (totalUm == totalDois)
            {
                Console.WriteLine(profUm + " e " + profDois + " receberam R$" + totalUm + " por um total de " + qtdeUm + " horas trabalhadas!");
            }
            else

            if (totalUm > totalDois)
            {
                Console.WriteLine("\n\nO(a) professor(a) " + profUm + " teve o maior salário, sendo um total de R$" + totalUm + ", por " + qtdeUm + " horas aula!");
            }
            else
            {
                Console.WriteLine("\n\nO(a) professor(a) " + profDois + " teve o maior salário, sendo um total de R$" + totalDois + ", por " + qtdeDois + " horas aula!");
            }


        }
    }
}