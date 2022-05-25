using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
    internal class Segmento3D:Vector3D
    {
        public double xf { get; set; }
        public double yf { get; set; }
        public double zf { get; set; }

        public Segmento3D()
        {

        }

        public virtual void Encender(Bitmap lienzo)
        {
            //base.Encender(lienzo);
            double t = 0;
            double dt = 0.001;
            Vector3D v3d = new Vector3D(0, 0,0, color0);
            do
            {
                v3d.x0 = x0 * (1 - t) + xf * t;
                v3d.y0 = y0 * (1 - t) + yf * t;
                v3d.z0 = z0 * (1 - t) + zf * t;
                v3d.Encender(lienzo);
                t = t + dt;
            } while (t <= 1);
        }
    }
}
