using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class TransacaoBancaria
    {
        public string agencia;
        public int tipo;
        public double valor;
        public string conta;

        public void depositar()
        {
            valor = valor + 100;
            Console.WriteLine("Deposito realizado. Saldo: " + valor);
        }
        public void sacar()
        {
            valor = valor - 100;
            Console.WriteLine("Saque realizado. Saldo: " + valor);
        }

        public void consultarSaldo()
        {
            Console.WriteLine("O saldo da conta é: "+valor);
        }

        public void exibirDados()
        {
            Console.WriteLine("Agência: "+agencia);
            Console.WriteLine("Conta: "+conta);
            Console.WriteLine("Tipo: "+tipo);
            Console.WriteLine("Saldo: "+valor);
        }
    }
}
