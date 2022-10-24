using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1
            //double media, n1, n2 = 0;

            //Console.WriteLine("Digite o primeiro valor: ");
            //n1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor: ");
            //n2 = double.Parse(Console.ReadLine());

            //media = (n1 + n2) / 2;

            //Console.WriteLine("A média aritmética entre " + n1 + " e " + n2 + " é igual a " + media);

            //Exercício 2
            //double media, n1, n2, n3, n4 = 0;

            //Console.WriteLine("Digite o primeiro valor: ");
            //n1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor: ");
            //n2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o terceiro valor: ");
            //n3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o quarto valor: ");
            //n4 = double.Parse(Console.ReadLine());


            //media = (n1 + n2 + n3 + n4) / 4;

            //Console.WriteLine("A média aritmética entre " + n1 + ", " + n2 + ", " + n3 + " e " + n4 + " é igual a " + media);

            //Exercício 3
            //Console.WriteLine("Digite o valor de A: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de B: ");
            //int b = int.Parse(Console.ReadLine());

            //int c = a;
            //a = b;
            //b = c;

            //Console.WriteLine("Após a inversão. A = " + a + ", B = " + b);

            //Exercício 4
            //Console.WriteLine("Digite dia (DD): ");
            //int dia = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o mês (MM): ");
            //int mes = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o ano (AAAA): ");
            //int ano = int.Parse(Console.ReadLine());

            //Console.WriteLine("Data no formato AAAAMMDD: " + ano + "/" + mes + "/" + dia);

            //Console.WriteLine("Data no formato AAMMDD: " + ano % 100 + "/" + mes + "/" + dia);

            //Exercicio5
            //Console.WriteLine("Digite a distância percorrida (km): ");
            //double distancia = double.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o consumo do veículo? (litros)");
            //double litros = double.Parse(Console.ReadLine());

            //double consumo = distancia / litros;

            //Console.WriteLine("O consumo de combustível foi de: " + consumo + " km/l");

            ////Exercicio 6
            //Console.WriteLine("Digite o código do parafuso A: ");
            //int parafusoA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o código do parafuso B: ");
            //int parafusoB = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a quantidade do parafuso A: ");
            //int qtdeA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade do parafuso B: ");
            //int qtdeB = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o preço unitário do parafuso A: ");
            //double valorA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o preço unitário do parafuso B: ");
            //double valorB = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe a alíquota de IPI do parafuso A: ");
            //double ipiA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a alíquota de IPI do parafuso B: ");
            //double ipiB = double.Parse(Console.ReadLine());

            //double totalA = qtdeA * valorA;
            //totalA = totalA + (totalA * (ipiA / 100));

            //double totalB = qtdeB * valorB;
            //totalB = totalB + (totalB * (ipiB / 100));

            //Console.WriteLine("Custo total dos parafusos A: " + totalA);
            //Console.WriteLine("Custo total dos parafusos B: " + totalB);

            //Exercício7
            //Console.WriteLine("Digite o código do vendedor: ");
            //int codVendedor = int.Parse(Console.ReadLine());

            //Console.WriteLine("Agora digite o salário fixo do vendedor " + codVendedor + ".");
            //double salarioVendedor = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor das vendas realizadas pelo vendedor " + codVendedor + ".");
            //int totalVendas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o percentual de comissão do vendedor " + codVendedor + ".");
            //double percentComissao = double.Parse(Console.ReadLine());

            //double salarioTotal = 0; 
            //salarioTotal = salarioVendedor + totalVendas * (percentComissao / 100);

            //Console.WriteLine("Vendedor: " + codVendedor +"\nSalário total (fixo + comissão): " + salarioTotal);

            //Exercício 9
            //Console.WriteLine("Informe a temperatura em °C: ");
            //double grausC = double.Parse(Console.ReadLine());

            //double grausF = (9 * grausC + 160) / 5;

            //Console.WriteLine(grausC+"°C correspondem a " + grausF+"°F.");

            //Exercício 9
            //Console.WriteLine("Informe o valor do produto: ");
            //double produto = double.Parse(Console.ReadLine());

            //double parcela = 0;

            //double resto = produto % 3;
            //produto = produto - resto;

            //parcela = produto / 3;

            //double entrada = parcela + resto;

            //Console.WriteLine("Entrada de R$" + entrada + " e 2x de R$" + parcela);

            //Exercício 10
            //double saque = 0;

            //int total200 = 0, total100 = 0, total50 = 0, total20 = 0, total10 = 0, total5 = 0, total2 = 0, total1 = 0;

            //Console.WriteLine("Informar o valor do saque:");
            //saque = double.Parse(Console.ReadLine());

            //total200 = (int)(saque / 200);
            //Console.WriteLine("Notas de 200: " + total200);
            //saque = saque - (200 * total200);

            //total100 = (int)(saque / 100);
            //Console.WriteLine("Notas de 100: " + total100);
            //saque = saque - (100 * total100);

            //total50 = (int)(saque / 50);
            //Console.WriteLine("Notas de 50: " + total50);
            //saque = saque - (50 * total50);

            //total20 = (int)(saque / 20);
            //Console.WriteLine("Notas de 20: " + total20);
            //saque = saque - (20 * total20);

            //total10 = (int)(saque / 10);
            //Console.WriteLine("Notas de 10: " + total10);
            //saque = saque - (10 * total10);

            //total5 = (int)(saque / 5);
            //Console.WriteLine("Notas de 5: " + total5);
            //saque = saque - (5 * total5);

            //total2 = (int)(saque / 2);
            //Console.WriteLine("Notas de 2: " + total2);
            //saque = saque - (2 * total2);

            //total1 = (int)(saque / 1);
            //Console.WriteLine("Notas de 1: " + total1);
            //saque = saque - (1 * total1);

            //Exercício 11
            //Console.WriteLine("Informe a quantidade de eleitores: ");
            //int qtdeEleitores = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite os votos válidos: ");
            //int qtdeValidos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite os votos nulos: ");
            //int qtdeNulos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite os votos em branco: ");
            //int qtdeBrancos = int.Parse(Console.ReadLine());

            //double porcentValidos = (qtdeValidos * 100) / qtdeEleitores;
            //double porcentNulos = (qtdeNulos *100) / qtdeEleitores;
            //double porcentBrancos = (qtdeBrancos * 100) / qtdeEleitores;

            //Console.WriteLine("Votos válidos: " + porcentValidos + "%" +
            //    "\nVotos Nulos: " + porcentNulos + "%" +
            //    "\nVotos brancos: " + porcentBrancos + "%");

            //Exercício 12
            //Console.WriteLine("Digite o Km do início do dia: ");
            //double kmInicio = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o Km do fim do dia: ");
            //double kmFim = double.Parse(Console.ReadLine());
            //Console.WriteLine("Informe quantos litros de combustível foram consumidos: ");
            //double litros = double.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o valor total recebido no dia: ");
            //double recebido = double.Parse(Console.ReadLine());

            //double kmPercorrido = kmFim - kmInicio;

            //double mediaConsumo = kmPercorrido / litros;

            //double lucro = recebido - (litros * 6.90);

            //Console.WriteLine("Média de consumo: " + mediaConsumo + "km/l\n" +
            //    "Lucro do dia: R$" + lucro);


            //Exercício 13
            double salarioMinimo = 0;
            double comissao = 0, custo = 0;
            int qtdadeBike = 0;

            Console.WriteLine("Informe o salário mínimo atual:");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de custo da bike:");
            custo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de bikes vendidas:");
            qtdadeBike = int.Parse(Console.ReadLine());

            double venda = custo + (custo * 0.5);
            comissao = (qtdadeBike * venda) * 0.15;
            double salario = (salarioMinimo * 2) + comissao;

            Console.WriteLine("O salário resultou em: " + salario);


        }
    }
}
