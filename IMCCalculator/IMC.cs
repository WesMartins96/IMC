using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCCalculator
{
    class IMC
    {
        public double Peso;
        public double Altura;

        public double CalcIMC()
        {
            return Peso / (Altura * Altura); 
        }


    }
}
