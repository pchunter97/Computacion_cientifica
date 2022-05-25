using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
    internal class Lazo: Circunferencia
    {
        public Lazo() { }

        public override void Encender(Bitmap lienzo)
        {
            double t, dt;
            //int a = 26;
            //int b = 39;
            //int c = 47;
            Clasevector objCircun = new Clasevector(0, 0, color0);

            t = 0;
            dt = 0.001;
            do
            {
                objCircun.x0 = x0 + Radio * (Math.Cos(2 * t));
                objCircun.y0 = y0 + Radio * (Math.Sin(3 * t));
                objCircun.color0 = color0;
                objCircun.Encender(lienzo);
                t = t + dt;

            }
            while (t <= 3 * Math.PI);
            //while (t <= c);
        }
    }
    
}
