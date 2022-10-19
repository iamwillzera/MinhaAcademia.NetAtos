namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.fabricante = "BMW";
            carro.placa = "ABC12D3";
            carro.setCor("Preto");

            Cliente cliente = new Cliente();
            cliente.idade = 25;
            cliente.nome = "William";

            Aluguel aluguel = new Aluguel();
            aluguel.seguro = true;
            aluguel.inicio = new DateTime(2022, 10, 10, 14, 0, 0);
            aluguel.termino = new DateTime(2022, 10, 15, 18, 0, 0);
            aluguel.valorDiaria = 240;
            aluguel.carro = carro;
            aluguel.cliente = cliente;
        }
    }
}