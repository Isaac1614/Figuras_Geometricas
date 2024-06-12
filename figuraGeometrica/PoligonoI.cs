using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    abstract class PoligonoI
    {
        private float lado1;
        public float Lado1
        {
            set //poner valor
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado1 = 0; //manda el valor a 0
                } //NO EXISTEN LADOS NEGATIVOS
                else
                {
                    lado1 = value;
                    //value es el valor del textbox
                }
            }
            get //obtener el valor
            {
                return lado1; //regresa o cacha el valor de la variable lado1
            }
        }
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();       
    }
    class Rombo : PoligonoI
    {
        private float diagonalmen;
        private float diagonalmay;
        public float Diagonalmen
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    diagonalmen = 0;
                }//no existen lado negativos
                else
                {
                    diagonalmen = value;
                }
            }
            get
            {
                return diagonalmen;//ingresa el valor en de la variable lado1
            }
        }
        public float Diagonalmay
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    diagonalmay = 0;
                }//no existen lado negativos
                else
                {
                    diagonalmay = value;
                }
            }
            get
            {
                return diagonalmay;//ingresa el valor en de la variable lado1
            }
        }
        public Rombo(float lado1, float diagonalMen, float diagonalMay)
        {
            this.Diagonalmay = diagonalMay;
            this.Diagonalmen = diagonalMen;
            this.Lado1 = lado1;
        }
        public override float area()
        {
            return (diagonalmen * diagonalmay) / 2;
        }
        public override float perimetro()
        {
            return Lado1 * 4;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
    class trapecio : PoligonoI
    {
        private float base1;
        private float base2;
        private float altura;
        public float Base1
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    base1 = 0;
                }//no existen lado negativos
                else
                {
                    base1 = value;
                }
            }
            get
            {
                return base1;//ingresa el valor en de la variable lado1
            }
        }
        public float Base2
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    base2 = 0;
                }//no existen lado negativos
                else
                {
                    base2 = value;
                }
            }
            get
            {
                return base2;//ingresa el valor en de la variable lado1
            }
        }
        public float Altura
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    altura = 0;
                }//no existen lado negativos
                else
                {
                    altura = value;
                }
            }
            get
            {
                return altura;//ingresa el valor en de la variable lado1
            }
        }
        public trapecio(float Lado1, float base1, float base2, float altura)
        {
            this.Base1 = base1;
            this.Base2 = base2;
            this.Altura = altura;
            this.Lado1 = Lado1;
        }
        public override float area()
        {
            return ((Base1 + Base2) + Altura) / 2;
        }
        public override float perimetro()
        {
            return 2 * Lado1 * Base1 * Base2;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
