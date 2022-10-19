using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class Aviao
    {
        private string modelo, marca;
        private double velocidade, altitude;

        public void descer()
        {
            Console.WriteLine("Baixando altitude!");
            altitude--;
        }

        public void subir()
        {
            Console.WriteLine("Aumentando altitude!");
            altitude++;
        }

        public void reduzir()
        {
            Console.WriteLine("Reduzindo velocidade!");
        }

        public void acelerar()
        {
            Console.WriteLine("Aumentando velocidade!");
        }

        
    }
}
