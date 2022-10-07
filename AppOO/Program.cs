using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Apresentando classes, métodos e orientação a objetos básica.");
            //Lampada l1;
            //l1 = new Lampada();
            //l1.ligar();
            //Console.WriteLine("Status da lâmpada: "+l1.estaLigada());
            //l1.desligar();
            //Console.WriteLine("Status da lâmpada: "+l1.estaLigada());

            //Aviao b737;
            //b737 = new Aviao();

            //b737.subir();
            //b737.descer();

            TransacaoBancaria banco = new TransacaoBancaria();

            banco.conta = "1234";
            banco.agencia = "567";
            banco.valor = 1212.00;
            banco.tipo = 2;
            banco.exibirDados();
            banco.sacar();
            banco.consultarSaldo();
            banco.depositar();
            banco.exibirDados();

        }
    }
}
