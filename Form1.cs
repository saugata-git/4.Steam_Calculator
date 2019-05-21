using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steamtable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                double T;
                T = double.Parse(textBox1.Text);
               
                
                if (T <= 647 && T >= 273.16)
                {
                    double P;
                    double A = 5.4266514;
                    double B = -2005.1;
                    double C = .00013869;
                    double D = .000000000011965;
                    double K = 293700;
                    double E = -.0044;
                    double F = -.0057148;
                    double t = T - 273.16;
                    double Tr = T / 647.14;
                    double y = 374.11 - t;
                    double T1 = Math.Pow(T, 2);
                    double x = T1 - K;
                    double x1 = Math.Pow(x, 2);
                    double D1 = D * x1;
                    double y1 = Math.Pow(y, 1.25);
                    double y2 = F * y1;
                    double A1 = Math.Pow(10, D1) - 1;
                    double A2 = C * x;
                    double A3 = Math.Pow(10, y2);
                    P = Math.Pow(10, (A + B / T + (A2 * A1) / T + E * A3));
                    textBox2.Text = P.ToString();




                    double e1 = 64.87678;
                    double e2 = 11.76476;
                    double e3 = -11.94431;
                    double e4 = 6.29015;
                    double e5 = -.99893;
                    // double Tr = T / 647.14;
                    double f1 = 1 / Tr;
                    double f2 = Math.Log(f1);
                    double f3 = Math.Pow(f2, .35);
                    double f4 = Math.Pow(Tr, 2);
                    double f5 = Math.Pow(Tr, 3);
                    double f6 = Math.Pow(Tr, 4);
                    double h1 = e1 + e2 * f3 + e3 / f4 + e4 / f5 + e5 / f6;
                    double h2 = Math.Sqrt(h1);
                    double hg = Math.Exp(h2);
                    double hgg = hg + 1.3;
                    if (T <= 423.16 || T >= 323.16)
                    {
                        textBox3.Text = hgg.ToString();
                    }
                    else
                    {
                        textBox3.Text = hg.ToString();
                    }



                    double a1 = -7.85823;
                    double a2 = 1.83991;
                    double a3 = -11.7811;
                    double a4 = 22.6705;
                    double a5 = -15.9393;
                    double a6 = 1.77516;
                    double b1 = 1.99206;
                    double b2 = 1.10123;
                    double b3 = -.512506;
                    double b4 = -1.75263;
                    double b5 = -45.4485;
                    double b6 = -675615;
                    double d0 = -1135.481;
                    double d1 = -.0000000571756;
                    double d2 = 2689.81;
                    double d3 = 129.889;
                    double d4 = -137.181;
                    double d5 = 0.968874;
                    double p2 = P * .101325;
                    double g1 = -p2 / T;
                    double g2 = Math.Log(p2 / 22.064);
                    double T4 = 1 - Tr;
                    double g3 = Math.Sqrt(T4);
                    double g4 = Math.Pow(T4, 2);
                    double g5 = Math.Pow(T4, 2.5);
                    double g6 = Math.Pow(T4, 3);
                    double g7 = Math.Pow(T4, 6.5);
                    double p3 = (g2 + a1 + 1.5 * a2 * g3 + 3 * a3 * g4 + 3.5 * a4 * g5 + 4 * a5 * g6 + 7.5 * a6 * g7);
                    double p4 = g1 * p3; //value of dP/dT

                    // Density of water

                    double g8 = Math.Pow(T4, 0.33333);
                    double g9 = Math.Pow(T4, 0.66667);
                    double k1 = Math.Pow(T4, 1.66667);
                    double k2 = Math.Pow(T4, 5.33333);
                    double k3 = Math.Pow(T4, 14.3333);
                    double k4 = Math.Pow(T4, 36.6667);
                    double k5 = (1 + b1 * g8 + b2 * g9 + b3 * k1 + b4 * k3 + b5 * k3 + b6 * k4);
                    double k6 = 322 * k5; //Value of density

                    //α/α0 value determination

                    double k7 = Math.Pow(Tr, -19);
                    double k8 = Math.Pow(Tr, 4.5);
                    double k9 = Math.Pow(Tr, 5);
                    double c1 = Math.Pow(Tr, 54.5);
                    double c2 = d0 + d1 * k7 + d2 * Tr + d3 * k8 + d4 * k9 + d5 * c1; //value of α/α0
                    double c3 = T / k6;
                    double hf = c2 + 1000 * c3 * p4 - 1;


                    textBox4.Text = hf.ToString();


                    double h4 = hg - hf;// value of h(fg).

                    textBox5.Text = h4.ToString();

                    textBox6.Text = " ";



                    double n0 = 1.47735;
                    double n1 = 0.53242;
                    double n2 = -0.01923;
                    double n3 = 0.02974;
                    double n4 = -.00802;
                    double s1 = n0 + n1 * f3 + n2 / f4 + n3 / f6 + n4 / k9;
                    double s2 = Math.Exp(s1);
                    double sg = s2 * .00002 + s2;

                    textBox7.Text = sg.ToString();

                    double n5 = h4 / T;
                    double sf = sg - n5;
                    textBox8.Text = sf.ToString();

                    /*Determination of entropy of water-vapor mixture */

                    double s3 = sg - sf;
                    textBox9.Text = s3.ToString();
                    /*Determination of specific volume of steam */

                    double a7 = -7.75883;
                    double a8 = 3.23753;
                    double a9 = 2.05755;
                    double n6 = -.06052;
                    double n7 = .00529;
                    double n8 = Math.Pow(f2, 0.4);
                    double v1 = a7 + a8 * n8 + a9 / f4 + n6 / f6 + n7 / k9;
                    double vg = Math.Exp(v1);

                    textBox10.Text = vg.ToString();


                }

                else
                {
                    string hx = "Please  enter the temparature between 273K<T<647K ";
                    textBox6.Text = hx.ToString();


                }



            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text=" ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox1.Focus();
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
