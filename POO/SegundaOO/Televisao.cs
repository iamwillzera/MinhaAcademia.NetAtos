using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaOO
{
    internal class Televisao : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Iniciando a TV!");
            //this.ligado = true;
            this.Ligado = true;
        }
    }
}
