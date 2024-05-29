using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class PoligonoR : figura
    {
        private float apo, n;
        public float Apo
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    apo = 0;
                }//no existen lado negativos
                else
                {
                    apo = value;
                }
            }
            get
            {
                return apo;//ingresa el valor en de la variable lado1
            }
        }
        public float N
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    n = 0;
                }//no existen lado negativos
                else
                {
                    n = value;
                }
            }
            get
            {
                return n;//ingresa el valor en de la variable lado1
            }
        }
        public PoligonoR(float lado, float apo, float n)
        {
            Lado1 = lado;
            Apo = apo;
            N = n;
        }
        public float area(float peri)
        {
            return (peri*apo)/2;
        }
        public override float perimetro()
        {
            float peri;
            peri = n * Lado1;
            return peri;
        }
        public override float area()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
