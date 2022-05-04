using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminWF
{
    class Triangulo
    {
        public double Base;
        public double Altura;

        public double CalcTriangulo() 
        {
            return Base * Altura / 2.0;
        }
        public void TrianguloEscaleno() { }
        public void TrianguloIsoscele() { }



    }
}
