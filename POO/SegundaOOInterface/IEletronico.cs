using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaOOInterface
{
    internal interface IEletronico
    {
        //private int _volts;
        //private int _potencia;
        //private bool _ligado; // INTERFACE NÃO TEM ATRIBUTOS. SOMENTE MÉTODOS!

        public void Ligar();

        public void Desligar();
    }
}
