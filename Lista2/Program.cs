using System.Drawing;
using System;
using System.Net;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

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

            //string profUm, profDois;
            //double qtdeUm = 0, qtdeDois = 0, valorHoraUm = 0, valorHoraDois = 0, totalUm = 0, totalDois = 0;

            //Console.WriteLine("Informe o nome do(a) professor(a): ");
            //profUm = Console.ReadLine();

            //Console.WriteLine("Qual o valor da hora aula do(a) professor(a) " + profUm + "?");
            //valorHoraUm = double.Parse(Console.ReadLine());

            //Console.WriteLine("Quantas horas o(a) " + profUm + " trabalhou?");
            //qtdeUm = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o nome do(a) professor(a): ");
            //profDois = Console.ReadLine();

            //Console.WriteLine("Qual o valor da hora aula do(a) professor(a) " + profDois + "?");
            //valorHoraDois = double.Parse(Console.ReadLine());

            //Console.WriteLine("Quantas horas o(a) " + profDois + " trabalhou?");
            //qtdeDois = double.Parse(Console.ReadLine());

            //totalUm = (qtdeUm * valorHoraUm);
            //totalDois = (qtdeDois * valorHoraDois);

            //if (totalUm == totalDois)
            //{
            //    Console.WriteLine(profUm + " e " + profDois + " receberam R$" + totalUm + " por um total de " + qtdeUm + " horas trabalhadas!");
            //}
            //else

            //if (totalUm > totalDois)
            //{
            //    Console.WriteLine("\n\nO(a) professor(a) " + profUm + " teve o maior salário, sendo um total de R$" + totalUm + ", por " + qtdeUm + " horas aula!");
            //}
            //else
            //{
            //    Console.WriteLine("\n\nO(a) professor(a) " + profDois + " teve o maior salário, sendo um total de R$" + totalDois + ", por " + qtdeDois + " horas aula!");
            //}

            //--------------------------------------------------------------------------------------------------------//

            //            //5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //            //se a média das duas notas for maior ou igual a 7, 0.
            //            Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            //            é a média entre a nota do exame e a média das 2 notas.
            //            Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
            //             escrever “Reprovado”.

            //Console.WriteLine("Informe a nota 1: ");
            //double nota1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe a nota 2: ");
            //double nota2 = double.Parse(Console.ReadLine());

            //double media = (nota1 + nota2) / 2;

            //if (media >= 7)
            //{
            //    Console.WriteLine("Aprovado!");
            //}
            //else if (media >= 5 && media < 7)
            //{
            //    Console.WriteLine("Informe a nota obtida no exame: ");
            //    double exame = double.Parse(Console.ReadLine());

            //    media = (nota1 + nota2 + exame) / 3;

            //    if(media>= 5)
            //    {
            //        Console.WriteLine("Aprovado!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reprovado!");
            //    }
            //} else if (media < 5) { 
            //    Console.WriteLine("Reprovado!");
            //}

            //-----------------------------------------------------------------------------------------//
            //6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros)
            //e o peso (kg) de uma pessoa.
            //O programa deve calcular o Indice de Massa Corpórea(IMC),
            //exibi - lo ao usuário e informar sua situação conforme a tabela.
            //O cálculo do imc = peso / (altura * altura)

            //IMC
            //menor que 18->baixo peso
            //maior que 18 e menor que 25->peso normal
            //maior que 25 e menor que 30->sobrepeso
            //maior que 30 e menor que 35->obesidade
            //maior que 35->obesidade grau sério

            //Console.WriteLine("Nome: ");
            //string nome = Console.ReadLine().ToUpper();

            //Console.WriteLine($"\n{nome}, favor informe a altura (metros):");
            //double altura = double.Parse(Console.ReadLine());

            //Console.WriteLine("Agora, informe o peso (kg): ");
            //double peso = double.Parse(Console.ReadLine());

            //double imc = peso / (altura * altura);

            //Console.WriteLine();

            //if (imc >= 35)
            //{
            //    Console.WriteLine("Obesidade grau sério!");
            //}
            //else if (imc < 35 && imc >= 30)
            //{
            //    Console.WriteLine("Obesidade!");
            //} else if(imc < 30 && imc >= 25)
            //{
            //    Console.WriteLine("Sobrepeso!");
            //} else if (imc <25 && imc > 18)
            //{
            //    Console.WriteLine("Peso normal!");
            //}
            //else
            //{
            //    Console.WriteLine("Baixo peso!");
            //}

            //----------------------------------------------------------------------------------------------------------//
            //7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

            //Console.WriteLine("Digite uma frase: ");
            //string frase = Console.ReadLine().ToLower();

            //Console.WriteLine("Informe a palavra para localizar na frase: ");
            //string palavra = Console.ReadLine().ToLower();

            //List<string> lista = new List<string>();
            //lista.Add(frase);

            //if (frase.Contains(palavra))
            //{
            //    Console.WriteLine($"A palavra '{palavra.ToUpper()}' está contida na frase!");
            //}
            //else
            //{
            //    Console.WriteLine($"A palavra '{palavra.ToUpper()}' não encontra-se na frase informada!");
            //}
            //---------------------------------------------------------------------------------------------------
            //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00,
            //adicionar ao seu salário final 10 % do total de vendas.

            //Console.WriteLine("Vendedor: ");
            //string vendedor = Console.ReadLine();

            //Console.WriteLine("Salário base: ");
            //double salarioBase = double.Parse(Console.ReadLine());

            //Console.WriteLine("Valor total de vendas no mês: ");
            //double totalVendas = double.Parse(Console.ReadLine());

            //double salarioFinal = 0;

            //if (totalVendas > 500)
            //{
            //    salarioFinal = salarioBase + (totalVendas * 0.05);
            //} else if (totalVendas > 1000)
            //{
            //    salarioFinal = salarioBase + (totalVendas * 0.07);
            //} else if (totalVendas > 5000)
            //{
            //    salarioFinal = salarioBase + (totalVendas * 0.10);
            //}
            //else
            //{
            //    salarioFinal = salarioBase;
            //}

            //Console.WriteLine($"O salário do(a) vendedor(a) {vendedor} ao final do mês foi igual a {salarioFinal}");

            //----------------------------------------------------------------------------------------------------------
            //9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            //diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.

            //Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for
            //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.

            //Console.WriteLine("Primeiro valor da glicemia em jejum: ");
            //double glicemia1 = double.Parse(Console.ReadLine());

            //if (glicemia1 < 65)
            //{
            //    Console.WriteLine("Risco de hipoglicemia!");
            //}
            //else if (glicemia1 > 250)
            //{
            //    Console.WriteLine("Risco de hiperglicemia!");
            //}


            //Console.WriteLine("\nSegundo valor da glicemia em jejum: ");
            //double glicemia2 = double.Parse(Console.ReadLine());

            //if (glicemia2 < 65)
            //{
            //    Console.WriteLine("Risco de hipoglicemia!");
            //}
            //else if (glicemia2 > 250)
            //{
            //    Console.WriteLine("Risco de hiperglicemia!");
            //}

            //Console.WriteLine("\nTerceiro valor da glicemia em jejum: ");
            //double glicemia3 = double.Parse(Console.ReadLine());

            //if (glicemia3 < 65)
            //{
            //    Console.WriteLine("Risco de hipoglicemia!");
            //}
            //else if (glicemia3 > 250)
            //{
            //    Console.WriteLine("Risco de hiperglicemia!");
            //}

            //double mediaGlicemia = (glicemia1 + glicemia2 + glicemia3) / 3;

            //if (mediaGlicemia < 80)
            //{
            //    Console.WriteLine("\nNecessário reduzir 2 unidades de insulina!");
            //} else if(mediaGlicemia > 150)
            //{
            //    Console.WriteLine("\nNecessário adicionar 2 unidades de insulina!");
            //}

            //-----------------------------------------------------------------------------//
            //10 - Faça um programa no VS que receba dados de dois atletas(nome, idade e altura).
            //O programa deve mostrar os dados do atleta mais novo e mais alto.

            //Console.WriteLine("Nome do atleta 1: ");
            //string atleta1 = Console.ReadLine();
            //Console.WriteLine("Nome do atleta 2: ");
            //string atleta2 = Console.ReadLine();
            //Console.WriteLine($"Idade de {atleta1}");
            //int idade1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Idade de {atleta2}");
            //int idade2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Altura de {atleta1}");
            //double altura1 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Altura de {atleta2}");
            //double altura2 = double.Parse(Console.ReadLine());

            //if(altura1 > altura2)
            //{
            //    Console.WriteLine($"Atleta mais alto: {atleta1}");
            //}
            //else
            //{
            //    Console.WriteLine($"Atleta mais alto: {atleta2}");
            //}

            //if(idade1 < idade2)
            //{
            //    Console.WriteLine($"Atleta mais novo: {atleta1}");
            //}
            //else
            //{
            //    Console.WriteLine($"Atleta mais novo: {atleta2}");
            //}
            //----------------------------------------------------------------------------------//
            //12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e
            //número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo - se que ele ganha
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            //armazenando - o na variável "extra", caso contrário zerar tal variável.
            //A hora excedente de trabalho vale R$ 20,00.
            //No final do processamento, exibir o salário total e o salário excedente do operário.



        }
    }
}