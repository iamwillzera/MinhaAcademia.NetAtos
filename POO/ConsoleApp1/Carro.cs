using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class Carro
    {
        public double velocidadeMax { get; set; }
        private string modelo;
        private string cor;
        public string placa;
        public string fabricante;
        private bool ligado = false;

        //getter e setter

        public string getCor()
        {
            return cor;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public bool getLigado()
        {
            return ligado;
        }

        public void ligar()
        {
            ligado = true;
            Console.WriteLine("O carro foi ligado.");
        }

        public void desligar()
        {
            ligado = false;
            Console.WriteLine("O carro foi desligado.");
        }



    }
}
