using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
    internal class Circunferencia: Clasevector

    {
        public Circunferencia()
        {

        }
        public override void Encender(Bitmap lienzo)
        {
            base.Encender(lienzo);
            double t = 0;
            double dt = 0.001;
            Clasevector v = new Clasevector();
            do
            {
                v.x0 = x0 + (Radio * (Math.Cos(t)));
                v.y0 = y0 + (Radio * (Math.Sin(t)));
                v.color0 = color0;
                v.Encender(lienzo);
                t = t + dt;
            } while(t <= 2 * Math.PI);
        }
    }
}
