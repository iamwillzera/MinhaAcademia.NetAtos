using OrientacaoObjetos;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Carro carro = new Carro();
            //carro.ligar();

            //carro.setCor("azul");

            ////string x = carro.placa;

            //Console.WriteLine(carro.getCor());

            //bool status = carro.getLigado();

            //if (status)
            //{
            //    Console.WriteLine("O carro está ligado.");
            //}
            //else
            //{
            //    Console.WriteLine("O carro está desligado.");
            ////}

            //Console.WriteLine("Digite uma temperatura em fahrenheit: ");
            //Temperatura temp = new Temperatura();
            //temp.setCelsius(double.Parse(Console.ReadLine()));

            //Console.WriteLine("----------------------");
            //Console.WriteLine(temp.getCelsius());
            Cliente cliente = new Cliente();
            cliente.nome = "William";
            cliente.idade = 30;
            Conta c = new Conta(cliente, 2100, "Corrente");

            while (true)
            {
                Console.WriteLine("Digite 1 para sacar, 2 para depositar, " +
                    "3 para consultar o saldo e 0 para sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do saque: ");
                        c.debitar(double.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor do saque: ");
                        c.creditar(double.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.WriteLine("O saldo é de R$"+c.getSaldo());
                        break;

                    default:
                Console.WriteLine("O cliente "+c.cliente.nome+" tem saldo de R$"+c.getSaldo());
                        return;
                }

            }








        }
    }
}