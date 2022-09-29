using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;
            int[] b = new int[5];
            Console.WriteLine("------ Leitura dos valores: ------");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o valor " + i + ":");
                b[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Valore índice " + i + " é igual a " + b[i]);
            }

        }
    }
}
