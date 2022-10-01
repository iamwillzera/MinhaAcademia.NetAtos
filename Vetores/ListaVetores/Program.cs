using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e
            //então mostre na tela a quantidade de números pares e ímpares.

            //int[] vetor = new int[10];
            //int i, somaPar = 0, somaImpar = 0;

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Informe o valor do " + (i + 1) + "° elemento: ");
            //    vetor[i] = int.Parse(Console.ReadLine());

            //    if (vetor[i] % 2 == 0)
            //    {
            //        somaPar++;
            //    }
            //    else
            //    {
            //        somaImpar++;
            //    }
            //}

            //Console.WriteLine("No vetor existem " + somaPar + " números pares e " + somaImpar + " valores ímpares.");

            //---------------------------------------------------------------------------------//

            //2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize
            //a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

            //double[] vetorA = new double[20], vetorB = new double[20];
            //double[] soma = new double[20];
            //int i;

            //Console.WriteLine("---- Coleta de dados - Vetor A ----");
            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Informe o " + (i + 1) + "° elemento do vetor A: ");
            //    vetorA[i] = double.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\n---- Coleta de dados - Vetor B ----");
            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Informe o " + (i + 1) + "° elemento do vetor B: ");
            //    vetorB[i] = double.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 20; i++)
            //{
            //    soma[i] = vetorA[i] + vetorB[i];
            //    Console.WriteLine("Soma dos elementos das posição " + i + ": " + soma[i]);
            //}

            //----------------------------------------------------------------------------------------//

            //Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então
            //mostre na tela o índice da posição dos valores correspondentes a números primos.

            //int[] vetor = new int[20];
            //int i;

            //for (i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("Informe o valor da posição " + (i + 1) + ": ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 20; i++)
            //{
            //    int divisores = 0; //declarando dentro do for para que, a cada laço, o valor volte a zero

            //    for (int x = 1; x <= vetor[i]; x++)
            //    {
            //        if (vetor[i] % x == 0)
            //        {
            //            divisores++;
            //        }
            //    }
            //    if (divisores == 2)
            //    {
            //        Console.WriteLine("A posição "+(i+1)+" tem o valor " + vetor[i]+" que é um número primo!");
            //    }
            //}

            //----------------------------------------------------------------------------------------//

            //4. Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos
            //elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

            //int[] vetorA = new int[10], vetorB = new int[10], resultado = new int[10];
            //int i;

            //Console.WriteLine("Coleta de valores do Vetor A:");
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Informe o valor: ");
            //    vetorA[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nColeta de valores do Vetor B: ");
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Informe o valor: ");
            //    vetorB[i] = int.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 10; i++)
            //{
            //    resultado[i] = vetorA[i] * vetorB[i];
            //    Console.WriteLine(resultado[i]);
            //}

            //-----------------------------------------------------------------------------------------//

            //5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. 
            //Encontre e mostre o menor elemento e a sua posição.

            //int[] vetor = new int[80];
            //int i, maior = 0, menor = 0;

            //for (i = 0; i < 80; i++)
            //{
            //    Console.WriteLine("Informe o valor do " + (i + 1) + "° valor: ");
            //    vetor[i] = int.Parse(Console.ReadLine());

            //}

            //maior = vetor[0];
            //menor = vetor[0];
            //for (i = 0; i < 80; i++)
            //{
            //    if (vetor[i] > maior)
            //    {
            //        maior = vetor[i];
            //    }

            //    if (vetor[i] < menor)
            //    {
            //        menor = vetor[i];
            //    }
            //}

            //Console.WriteLine("O maior valor digitado é: " + maior);
            //Console.WriteLine("O menor valor digitado é: " + menor);

            //-----------------------------------------------------------------------------------------//

            //            6.Fazer um algoritmo que leia dez números e escreva-os na
            //            ordem contrária à ordem de leitura. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            //int i;
            //int[] vetor = new int[10];

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Informe o " + (i + 1) + "° elemento: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("| ");
            //for (i = 0; i < 10; i++)
            //{
            //    Console.Write(vetor[i] + " | ");
            //}

            //Console.Write("\n| ");
            //for (i = 9; i >= 0; i--)
            //{
            //    Console.Write(vetor[i] + " | ");
            //}

            //--------------------------------------------------------------------------------------//
            //7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

            //int i;
            //int[] vetor = new int[10];

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Informe o valor: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("\n|");
            //for (i = 0; i < 10; i++)
            //{
            //    if (vetor[i] % 2 == 0)
            //    {
            //        Console.Write(" " + vetor[i] + " |");
            //    }
            //}

            //for (i = 0; i < 10; i++)
            //{
            //    if (vetor[i] % 2 == 1)
            //    {
            //        Console.Write(" " + vetor[i]+" |");
            //    }
            //}

            //----------------------------------------------------------------------------------//

            ////8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva 
            ///a posição de cada número menor que zero desse vetor. Exemplo:
            //a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            //b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

            //double[] vetor = new double[30];
            //int i, posicaoNegativo;

            //for (i = 0; i < 30; i++)
            //{
            //    Console.WriteLine("Informe o valor: ");
            //    vetor[i] = double.Parse(Console.ReadLine());
            //}

            //Console.Write("| ");
            //for (i = 0; i < 30; i++)
            //{
            //    if (vetor[i] < 0)
            //    {
            //        posicaoNegativo = i;
            //        Console.Write((posicaoNegativo + 1) + " | ");
            //    }
            //}

            //-----------------------------------------------------------------------------------//

            //9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos, 
            //e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

            //int i;
            //int[] vetor = new int[10], resultado = new int[10];

            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Informe o valor: ");
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(vetor);

            //foreach (int crescente in vetor)
            //{
            //    Console.WriteLine(crescente);

            //}

            //-----------------------------------------------------------------------------------------//
            //10.Escreva um algoritmo que leia um vetor inteiro de 20 posições.
            //Crie um segundo vetor, substituindo os valores nulos por 2.
            //Mostre os vetores lidos e o vetor resultado.

            //-----------------------------------------------------------------------------------------//
            //11.	Escreva um programa que leia valores em um vetor de 5 posições.
            //Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

            //int[] vetor = new int[5];

            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine("Informe o valor da posição "+(i+1));
            //    vetor[i] = int.Parse(Console.ReadLine());

            //}

            //Console.Write("\n|");
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(" "+vetor[i]+" |");
            //}

            //Console.Write("\n|");
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.Write(" " + vetor[i] + " |");
            //}

            //------------------------------------------------------------------------------------------//
            //12.Faça um algoritmo que leia um vetor V de 10 posições e,
            //após, verifica se um número N, fornecido pelo usuário, existe no vetor. 
            //Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".
            int[] vetor = { 7, 9, 10, 12, 14, 17, 31, 68, 92, 97 };
            int[] posicao = new int[vetor.Length];
            int igual, cont = 0, i = 0;

            Console.WriteLine("Informe um valor: ");
            int numero = int.Parse(Console.ReadLine());

            for (i = 0; i < vetor.Length; i++)
            {
                if (numero == vetor[i])
                {
                    igual = numero;
                    cont++;
                    posicao[i] = i;

                }


            }

            if (cont > 0)
            {
                Console.WriteLine("O número " + numero + " encontra-se no vetor.");
            }
            else
            {
                Console.WriteLine("O número " + numero + " não faz parte do vetor.");
            }


        }
    }
}
