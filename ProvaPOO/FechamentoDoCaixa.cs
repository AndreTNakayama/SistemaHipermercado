using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO
{
    class FechamentoDoCaixa
    {
        public static double ValorDia { get; set; }

        public FechamentoDoCaixa(double valor)
        {
            ValorDia += valor;
        }


    }
}
