using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_1_COMPUTACION_Cietifica_ClaseVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap lienzo = new Bitmap(700, 420);

        //  Btn Segmentos
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clasevector V = new Clasevector();
            V.x0 = 0;
            V.y0 = 1;
            V.color0 = Color.Red;
            V.Encender(lienzo);
            V.x0 = -1;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(lienzo);
            V.x0 = 1;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(lienzo);
            V.x0 = 0;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(lienzo);
            V.x0 = 0;
            V.y0 = 3;
            V.color0 = Color.Red;
            V.Encender(lienzo);
            V.x0 = 5;
            V.y0 = 0;
            V.color0 = Color.Red;
            V.Encender(lienzo);
            pictureBox2.Image = lienzo;
            
        }

        private void btnSegmento_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -10;
            S.xf = 10;
            S.y0 = 0;
            S.yf = 0;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            S.x0 = 0;
            S.y0 = -5.98;
            S.xf = 0;
            S.yf = 5.98;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            pictureBox2.Image = lienzo;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Clasevector v = new Clasevector();
            Bitmap lienzo = new Bitmap(700, 420);
            v.apagar(lienzo);
            pictureBox2.Image = lienzo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia();
            c.Radio = 1;
            c.x0 = 0;
            c.y0 = 1;
            c.color0 = Color.Red;
            c.Encender(lienzo);
            pictureBox2.Image = lienzo;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lazo l = new Lazo();
            l.Radio = 1;
            l.x0 = 0;
            l.y0 = 2;
            l.color0 = Color.Red;
            l.Encender(lienzo);
            pictureBox2.Image = lienzo;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -10;
            S.xf = 10;
            S.y0 = 0;
            S.yf = 0;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            S.x0 = 0;
            S.y0 = -5.98;
            S.xf = 0;
            S.yf = 5.98;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            pictureBox2.Image = lienzo;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Segmento S = new Segmento();
            S.x0 = -7;
            S.xf = 3;
            S.y0 = 2;
            S.yf = 4;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            S.x0 = -7;
            S.y0 = -2;
            S.xf = 3;
            S.yf = 4;
            S.color0 = Color.Red;
            S.Encender(lienzo);
            pictureBox2.Image = lienzo;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Segmentos
            Segmento segmento = new Segmento();
            segmento.x0 = -3;
            segmento.y0 = -5;
            segmento.xf = 3;
            segmento.yf = 0.5;
            segmento.color0 = Color.Red;
            segmento.Encender(lienzo);

            Segmento segmento2 = new Segmento();
            segmento2.x0 = -5;
            segmento2.y0 = 5;
            segmento2.xf = 3;
            segmento2.yf = 0.5;
            segmento2.color0 = Color.Red;
            segmento2.Encender(lienzo);

            


            // Circunferencias
            Circunferencia circunferencia = new Circunferencia();
            circunferencia.x0 = -5;
            circunferencia.y0 = 1.2;
            circunferencia.Radio = 2;
            circunferencia.color0= Color.Blue;
            circunferencia.Encender(lienzo);

            Circunferencia circunferencia2 = new Circunferencia();
            circunferencia2.x0 = 3;
            circunferencia2.y0 = 0.5;
            circunferencia2.Radio = 1.2;
            circunferencia2.color0 = Color.Magenta;
            circunferencia2.Encender(lienzo);

            //Laso
            Lazo lazo = new Lazo();
            lazo.x0 = 2;
            lazo.y0 = -2;
            lazo.Radio = 0.7;
            lazo.color0 = Color.Black;
            lazo.Encender(lienzo);

            //Raiz
            Raiz raiz = new Raiz();
            raiz.x0 = 1;
            raiz.y0 = 4;
            raiz.Radio = 0.5;
            raiz.color0 = Color.Black;
            raiz.Encender(lienzo);


            pictureBox2.Image = lienzo;
            //MessageBox.Show("Pintado");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vector3D vect = new Vector3D();
            double h=0;
            do
            {
                vect.x0 = 2 + 2 * Math.Cos(h);
                vect.y0 = 1 + 3 * Math.Sin(h);
                vect.z0 = 2 + (h / 5);
                vect.color0 = Color.Black;
                vect.Encender(lienzo);
                h = h + 0.002;
            } while (h<=15);
            pictureBox2.Image = lienzo;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Eje Z
            Segmento3D s3dz = new Segmento3D();
            s3dz.x0 = 0;
            s3dz.y0 = 0;
            s3dz.z0 = 0;
            s3dz.xf = 0;
            s3dz.yf = 0;
            s3dz.zf = 5;
            s3dz.color0 = Color.Red;
            s3dz.Encender(lienzo);
            pictureBox2.Image = lienzo;


            //Eje Y
            Segmento3D s3dy = new Segmento3D();
            s3dy.x0 = 0;
            s3dy.y0 = 0;
            s3dy.z0 = 0;
            s3dy.xf = 0;
            s3dy.yf = 5;
            s3dy.zf = 0;
            s3dy.color0 = Color.Red;
            s3dy.Encender(lienzo);
            //pictureBox2.Image = lienzo;

            //Eje X
            Segmento3D s3dx = new Segmento3D();
            s3dx.x0 = 0;
            s3dx.y0 = 0;
            s3dx.z0 = 0;
            s3dx.xf = 8;
            s3dx.yf = 0;
            s3dx.zf = 0;
            s3dx.color0 = Color.Red;
            s3dx.Encender(lienzo);
            //pictureBox2.Image = lienzo;

            //8
            //Segmento3D s8 = new Segmento3D();
            s3dx.x0 = 0;
            s3dx.y0 = 0;
            s3dx.z0 = 5;

            s3dx.xf = 8;
            s3dx.yf = 0;
            s3dx.zf = 5;
            s3dx.color0 = Color.Red;
            s3dx.Encender(lienzo);
           // s8.Encender(lienzo);
            //pictureBox2.Image = lienzo;

            //9
            Segmento3D s9 = new Segmento3D();
            s9.x0 = 8;
            s9.y0 = 0;
            s9.z0 = 5;

            s9.xf = 8;
            s9.yf = 0;
            s9.zf = 0;
            s9.color0 =Color.Red;
            s9.Encender(lienzo);

            //4
            //Segmento3D s9 = new Segmento3D();
            s9.x0 = 8;
            s9.y0 = 0;
            s9.z0 = 0;

            s9.xf = 8;
            s9.yf = 5;
            s9.zf = 0;
            s9.color0 = Color.Red;
            s9.Encender(lienzo);

            //5
            //Segmento3D s9 = new Segmento3D();
            s9.x0 = 8;
            s9.y0 = 5;
            s9.z0 = 0;

            s9.xf = 0;
            s9.yf = 5;
            s9.zf = 0;
            s9.color0 = Color.Red;
            s9.Encender(lienzo);

            //6
            //Segmento3D s9 = new Segmento3D();
            s9.x0 = 0;
            s9.y0 = 5;
            s9.z0 = 0;

            s9.xf = 0;
            s9.yf = 5;
            s9.zf = 5;
            s9.color0 = Color.Red;
            s9.Encender(lienzo);

            //7
            // Segmento3D s9 = new Segmento3D();
            s9.x0 = 0;
            s9.y0 = 0;
            s9.z0 = 5;

            s9.xf = 0;
            s9.yf = 0;
            s9.zf = 5;
            s9.color0 = Color.Red;
            s9.Encender(lienzo);

            //S1
            s9.x0 = 0;
            s9.y0 = 0;
            s9.z0 = 5;

            s9.xf = 0;
            s9.yf = 5;
            s9.zf = 5;
            s9.color0 = Color.Red;
            s9.Encender(lienzo);
            ///s9.Encender(lienzo);
           // pictureBox2.Image = lienzo;

        }

        //Interpolacion de azul
        private void button9_Click(object sender, EventArgs e)
        {
            /*for (int i =0;i<700;i++)
            {
                for (int j = 0;j<420;j++)
                {
                   // if (i <=350)
                    //{
                        lienzo.SetPixel(i, j, Color.FromArgb(255, (255 * (i - 700) / -700), ((255 * (i - 700)) / -700), 255*i/700));
                    pictureBox2.Image = lienzo;
                    //}
                    //else
                    //{
                     //   lienzo.SetPixel(i, j, Color.Green);
                      //  pictureBox2.Image = lienzo;
                    //}
                    
                }
            }*/

            for (int i = 0; i < 350; i++)
            {
                for (int j = 0; j < 420; j++)
                {                   
                    lienzo.SetPixel(i, j, Color.FromArgb(((255*(i-350))/-350)+((255*i)/350), ((255 * (i - 350)) / -350) + ((255 * i) / 350),(255*i)/350));
                    pictureBox2.Image = lienzo;
                }
            }

            for (int i = 350; i < 700; i++)
            {
                for (int j = 0; j < 420; j++)
                {
                    lienzo.SetPixel(i, j, Color.FromArgb(255*(i-700)/-350, 255*(i - 700) / -350,((255*((i-700)/-350))+(255*((i-350)/350)))));
                    pictureBox2.Image = lienzo;
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Vector3D vect3d = new Vector3D();
            vect3d.color0 = Color.Red;
            double t = -5;
            do
            {
                double h = -4;
                do
                {
                    vect3d.x0 = t;
                    vect3d.y0 = h;
                    vect3d.z0 = .19 * ((t * t) + (h * h)-25);
                    
                    vect3d.Encender(lienzo);
                    h = h + 0.1;
                } while (h <= 4);
                t = t + 0.1;
            } while (t <= 5);
            pictureBox2.Image = lienzo;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Vector3D vect3d = new Vector3D();
            vect3d.color0 = Color.Red;
            double t = -5;
            do
            {
                double h = -4;
                do
                {
                    vect3d.x0 = t;
                    vect3d.y0 = h;
                    vect3d.z0 = .19 * ((t * t) - (h * h) - 7);

                    vect3d.Encender(lienzo);
                    h = h + 0.1;
                } while (h <= 4);
                t = t + 0.1;
            } while (t <= 5);
            pictureBox2.Image = lienzo;
        }
    }
    
}
