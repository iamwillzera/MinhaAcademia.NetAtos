using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
            //NA 2ª coluna, some 10 aos elementos da 1ª coluna.
            //Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            //int[,] matriz = new int[5, 3];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Informe o valor  para a coluna 0: ");
            //    matriz[i, 0] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 1] = matriz[i, 0] + 10;
            //    matriz[i, 2] = matriz[i, 0] * 2;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + " ");
            //}
            //    Console.WriteLine();
            //}
            //--------------------------------------------------------------------------------------------------//

            //2) Solicite ao usuário, preencher uma Matriz 3x3

            //            Informe ao usuário:
            //            *A soma dos elementos de cada linha
            // -Ex: Linha 1: 30
            //Linha 2: 17

            //* A soma dos elementos de cada coluna

            //-Ex: Coluna 1: 23
            //Coluna 2: 36

            //----------------------------------------------------------------------------------------//

            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            //int[,] matriz = new int[4, 4];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine("Informe o valor da linha " + (i + 1) + " da coluna " + (j + 1));
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.WriteLine("[ " + i + " , " + j + " ] = " + matriz[i, j]);
            //        }
            //    }
            //}
            //--------------------------------------------------------------------------------------------//

            //4) Popule uma matriz 5x5 e informe:
            //-Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            //int[,] matriz = new int[5, 5];
            //int pares = 0, impares = 0, positivos = 0, negativos = 0, qtdeZero = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("Informe o valor da linha " + (i + 1) + " na coluna " + (j + 1));
            //        matriz[i, j] = int.Parse(Console.ReadLine());

            //        if (matriz[i, j] % 2 == 0)
            //        {
            //            pares++;
            //        }
            //        else
            //        {
            //            impares++;
            //        }
            //        if (matriz[i,j] > 0) { positivos++; }
            //        if (matriz[i,j] < 0) { negativos++; }
            //        if (matriz[i, j] == 0) { qtdeZero++; }
            //    }
            //}

            //Console.WriteLine("Pares na matriz: "+pares);
            //Console.WriteLine("Ímpares na matriz: "+impares);
            //Console.WriteLine("Positivos na matriz: "+positivos);
            //Console.WriteLine("Negativos na matriz: "+negativos);
            //Console.WriteLine("Quantidade de vezez que o número zero aparece na matriz: "+qtdeZero);
            //--------------------------------------------------------------------------------------------//

            //5) Leia duas matrizes 2x3 de números double. 
            //Imprima a soma destas duas matrizes.

            //double[,] primeiraMatriz = new double[2, 3];
            //double[,] segundaMatriz = new double[2, 3];
            //double somaPrimeira = 0, somaSegunda = 0, somaTotal = 0;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Informe o valor da linha "+(i+1)+" da coluna "+(j+1)+" da primeira matriz");
            //        primeiraMatriz[i, j] = double.Parse(Console.ReadLine());
            //        somaPrimeira = primeiraMatriz[i,j] + somaPrimeira;
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Informe o valor da linha " + (i + 1) + " da coluna " + (j + 1) + " da segunda matriz");
            //        segundaMatriz[i, j] = double.Parse(Console.ReadLine());
            //        somaSegunda = somaSegunda + segundaMatriz[i,j];
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Soma dos valores da primeira matriz: "+somaPrimeira);
            //Console.WriteLine("Soma dos valores da segunda matriz: "+somaSegunda);

            //somaTotal = somaPrimeira + somaSegunda;

            //Console.WriteLine("Soma da Primeira Matriz com a Segunda Matriz: "+somaTotal);

            //-------------------------------------------------------------------------------------//

            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0 - 9.
            //Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            //Random aleatorio = new Random();
            //int[,] matriz = new int[4, 4];
            //int maior = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matriz[i, j] = aleatorio.Next(0, 9);
            //        if (matriz[i,j] > maior)
            //        {
            //            maior = matriz[i, j];
            //        }
            //    }
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine("[ " + i + " , " + j + " ] = " + matriz[i, j]);
            //    }
            //}

            //Console.WriteLine("O maior elemento da matriz é: " + maior);

            //--------------------------------------------------------------------------------//

            // 7) Leia duas matrizes A e B com 3x3 elementos. 
            //Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            //int[,] matrizA = new int[3, 3];
            //int[,] matrizB = new int[3, 3];
            //int[,] matrizC = new int[3, 3];

            //Console.WriteLine("--- Leitura dos valores da primeira matriz. ----");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Informe o elemento da linha " + i + " na coluna " + j);
            //        matrizA[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n--- Leitura dos valores da segunda matriz. ----");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Informe o elemento da linha " + i + " na coluna " + j);
            //        matrizB[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nMatriz resultante da subtração (segunda matriz - primeira matriz)");
            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
            //        Console.WriteLine(i + " , " + j + " = " + matrizC[i, j]);
            //    }
            //}
            //--------------------------------------------------------------------------------------------//

            //8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe o valor da linha"+i+" da coluna "+j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(matriz[i, j]);
                }
            }

        }
    }
}
