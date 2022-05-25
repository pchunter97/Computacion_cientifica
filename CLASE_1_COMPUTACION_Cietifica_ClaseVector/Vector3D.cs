using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
    internal class Vector3D: Clasevector
    {
       
        public double z0;
       
        public Vector3D() { }
        public Vector3D(double x0, double y0, double z0, Color color)
        { 
            this.x0 = x0;
            this.y0 = y0;
            this.z0 = z0;
            this.color0 = color;
        }
        public override void Encender(Bitmap lienzo)
        {
            double ax, ay;
            int sx, sy;
            
            axonometria(x0, y0, z0,out ax, out ay);
            
            Procesos.pantalla(ax, ay, out sx, out sy);
            if (sx > 0 && sx < 700 && sy > 0 && sy < 420)
            {
                lienzo.SetPixel(sx, sy, color0);
            }

        }
        public void axonometria(double x0,double y0, double z0,out double ax,out double ay)
        {
            ax = y0 - (x0 / 2) * Math.Cos(Math.PI / 4);
            ay = z0 - (x0 / 2) * Math.Sin(Math.PI / 4);
        }
    }
}
