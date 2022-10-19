using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaOO
{
    internal class PlayStation : Eletronico
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando o  PlayStation!");
            //this.ligado = true;
            this.Ligado = true;
        }
    }
}
