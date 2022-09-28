using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Usando o for 10x!");
            //}

            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //int contador = 0;
            //for (int i = 56; i < 127; i++)
            //{
            //    contador++;    
            //}

            //Console.WriteLine(contador);

            //int soma = 0;
            //for (int i = 56; i < 127; i++)
            //{
            //    soma = i + soma;
            //}

            //Console.WriteLine(soma);

            //int contagem = 0;
            //double salario = 1000;

            //for (; salario < 5000; salario = salario + 700)
            //{
            //    contagem++;
            //}

            //Console.WriteLine(contagem);
            //Console.WriteLine(salario);
            //int contador = 0;

            //for (int i = 56; i < 127; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        contador++;
            //    }

            //}

            //Console.WriteLine(contador);

            //int pares = 0;
            //int impares = 0;

            //for (int i = 56; i < 127; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        pares += i;
            //    }
            //    else
            //    {
            //        impares++;
            //    }
            //}

            //Console.WriteLine(pares);
            //Console.WriteLine(impares);

            //Console.WriteLine("Digite o valor inicial");

            //int inicio = int.Parse(Console.ReadLine());
            //int fim = 0;

            //while (inicio > fim)
            //{
            //    Console.WriteLine("Digite o valor final");
            //    fim = int.Parse(Console.ReadLine());
            //}

            //int contagem = 0;
            //int soma = 0;

            //for (int i = (inicio + 1); i < fim; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        contagem++;
            //    }
            //    else
            //    {
            //        soma += i;
            //    }
            //}
            //Console.WriteLine("Contém " + contagem + " números " + "impares e a soma dos pares resulta em " + soma);

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            int contador = 0;
            int valor = 0;

            while (valor >= 0)
            {
                Console.WriteLine("Informe um valor: ");
                valor = int.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    break;
                }

                if (valor % 2 == 0)
                {
                    contador++;
                }

                Console.WriteLine(contador);
            }

        }
    }
}
