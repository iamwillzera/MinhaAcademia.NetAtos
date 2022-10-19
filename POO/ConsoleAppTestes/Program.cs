using System.ComponentModel.DataAnnotations;

namespace ConsoleAppTestes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //	int x;
            //	Console.WriteLine("Informe um valor para x: ");
            //	x = int.Parse(Console.ReadLine());
            //	Console.WriteLine("O valor de X é: "x);
            //	Console.WriteLine("O valor de 50 dividido por "+x+" é igual a "+(50/x));

            //}
            //catch (DivideByZeroException ex)
            //{
            //	Console.WriteLine("Não é possível dividir por zero!");
            //}
            //catch(FormatException ex)
            //{
            //	Console.WriteLine("Por favor, informe somente números.");
            //}
            //catch(Exception ex)
            //{
            //	Console.WriteLine(ex.Message);
            //}

            //StreamWriter writer = new StreamWriter(@"C:\Users\thayl\OneDrive\Área de Trabalho\atos.txt");
            ////StreamWriter writer = new StreamWriter("C:\\Users\\thayl\\OneDrive\\Área de Trabalho\\atos.txt");

            //writer.WriteLine("Academia .NET Atos/UFN");
            //writer.WriteLine("Hoje é segunda-feira!");
            //writer.WriteLine("\n\n\n\n");
            //writer.WriteLine("17/10/2022");

            //writer.Close();


            //Nome, idade, sexo, email, telefone, estado civil, casa propria ou não, valor aluguel
            //Gerar um arquivo, utilizando o ; como caractere delimitador para cada uma dessas informações.
            //Todas as informações, ficam na mesma linha - cada linha é uma pessoa
            //apenas nome, idade e casa propria são campos obrigatórios
            //EXEMPLO
            //Fabrício;21;;;;;sim;0

            /*Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o sexo");
            string sexo = Console.ReadLine();
            Console.WriteLine("Informe o email");
            string email = Console.ReadLine();
            Console.WriteLine("Informe o fone");
            string fone = Console.ReadLine();
            Console.WriteLine("Informe o estado civil");
            string estado = Console.ReadLine();
            Console.WriteLine("Tem casa propria? (1 = SIM, 2 = NÃO");
            int casa = int.Parse(Console.ReadLine());
            double aluguel = 0;
            if (casa == 2)
            {
                Console.WriteLine("Informe o aluguel");
                aluguel = double.Parse(Console.ReadLine());
            }
            StreamWriter writer = new StreamWriter(@"C:\Users\thayl\OneDrive\Área de Trabalho\exemplo1.txt");
            //Nome, idade, sexo, email, telefone, estado civil, casa propria ou não, valor aluguel
            writer.Write(nome);
            writer.Write(";");
            writer.Write(idade);
            writer.Write(";");
            writer.Write(sexo + ";" + email + ";" + fone + ";" + estado + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel + Environment.NewLine);
            writer.Close();*/

            StreamReader reader = new StreamReader(@"C:\Users\thayl\OneDrive\Área de Trabalho\atos.txt");

            string linha = "";

            Console.WriteLine("------------------------------------------------------");

            linha = reader.ReadLine();

            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = reader.ReadLine();
            }

            Console.WriteLine("---------------------------------");

            reader.Close();
        }
    }
}