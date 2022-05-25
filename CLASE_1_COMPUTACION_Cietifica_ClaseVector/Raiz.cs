using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
    internal class Raiz : Circunferencia
    {
        public override void Encender(Bitmap lienzo)
        {
            double t, dt;
            //base.Encender(lienzo);
            Clasevector objRaiz = new Clasevector();
            t = 0;
            dt = 0.001;
            do
            {
                objRaiz.x0 = x0 + Radio * (Math.Sin(2 * t));
                objRaiz.y0 = y0 + Radio * (Math.Cos(3 * t));
                objRaiz.color0 = color0;
                objRaiz.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 2* Math.PI);
        }
    }
}
