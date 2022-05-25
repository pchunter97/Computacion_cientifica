using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
     class Clasevector
    {
        /*const int Sx1 = 0;
        const int Sx2 = 700;
        const int Sy1 = 0;
        const int Sy2 = 420;
        const int X1 = -10;
        const int X2 = 10;
        const double y1 = -5.98;
        const double y2 = 5.98;
        public Color color0;*/
        public static int sx1 = 0;
        public static int sx2 = 700;
        public static int sy1 = 0;
        public static int sy2 = 420;
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -5.98;
        public static double y2 = 5.98;
        public double Radio;
        public double x0 { get; set; }
        public double y0 { get; set; }
        public Color color0 { get; set; }
        public Clasevector() { }
        public  Clasevector(double x0, double y0, Color color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
        }
        public virtual void Encender(Bitmap lienzo)
        {
            int sx, sy;

            Procesos.pantalla(this.x0, this.y0, out sx, out sy);
            if (sx > 0 && sx < 700 && sy > 0 && sy < 420)
            {
                lienzo.SetPixel(sx, sy, color0);
            }

        }
        public virtual void apagar(Bitmap lienzo)
        {

            this.color0 = Color.Yellow;
            Encender(lienzo);

        }
    }
}
