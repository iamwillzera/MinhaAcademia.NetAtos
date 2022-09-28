git push using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRepeticao
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int divisor = 0;

            while (numero != 0)
            {
                Console.WriteLine("Digite um n° ou pressione 0 para encerrar: ");
                numero = int.Parse(Console.ReadLine());

                for (int i = 1; i < numero; i++)
                {

                    if (numero % 1 == 0)
                    {
                        divisor++;
                    }

                }

                if (divisor == 2)
                {
                    Console.WriteLine("O número é primo!");
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par!");
                }
                else
                {
                    Console.WriteLine("O número é ímpar!");
                }
            }

        }
    }
}
