using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaOO
{
    internal class Celular : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Iniando o Android!");
            //this.ligado = true;
            this.Ligado = true;
        }
    }
}
