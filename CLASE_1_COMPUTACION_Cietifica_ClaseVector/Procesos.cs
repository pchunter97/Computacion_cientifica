﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
    class Procesos
    {
        public static int sx1 = 0;
        public static int sx2 = 700;
        public static int sy1 = 0;
        public static int sy2 = 420;
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -5.98;
        public static double y2 = 5.98;
        public Procesos() { }
        public static void pantalla(double x, double y, out int sx, out int sy)
        {
            /* sx = (int)((((sx1 - sx2) / (x1 - x2)) * (x - x2)) + sx2);
             sy = (int)((((sy1 - sy2) / (y2 - y1)) * (y - y1)) + sy2);
             sx = (int)((((x2 - x1) * (x - sx2)) / (sx2 - sx1)) + x2);
             sy = (int)((((y - y1) * (sy1 - sy2)) / (y2 - y1)) + sy2);*/
            sx = (int)(((x - x1) / (x1 - x2)) * (sx1 - sx2)) + sx1;
            sy = (int)(((y - y2) / (y2 - y1)) * (sy1 - sy2)) + sy1;
        }
        /*
        public static void transforma(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2;
            y = (((sy - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2;
        }*/
        
        public static void RealXY(int sx, int sy, out double x, out double y)
        {
            /*x = (((sx - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2;
            y = (((sy - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2;

            x = (((sx2 * (sx - x1)) + (sx1 * (x2 - sx))) / (x2 - x1));
            y = ((sy - sy2) * ((y2 - y1) / (sy1 - sy2))) + y1;*/
            x = (((sx - sx1) / (sx1 - sx2)) * (x1 - x2)) + x1;
            y = (((sy - sy1) / (sy1 - sy2)) * (y2 - y1)) + y2;
        }
        /*
        public static void asonometria(double X0, double Y0, double Z0, out double AX, out double AY)
        {
            AX = X0 + (0.5) * Y0 * Math.Cos(0.8);
            AY = (0.5) * Y0 * Math.Sin(0.8) + Z0;
        }
        */


    }
}