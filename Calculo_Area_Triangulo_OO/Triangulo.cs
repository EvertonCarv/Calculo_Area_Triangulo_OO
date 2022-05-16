using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Area_Triangulo_OO
{
    public class Triangulo
    {
        public float @base;
        public float altura;
        public float area;

        public float calculeArea(float @base, float altura)
        {
            return this.area =  (@base * altura) / 2;
        }

    }
}
