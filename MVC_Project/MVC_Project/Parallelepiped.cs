using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project
{
    class Parallelepiped
    {
        double a;
        double b;
        double h;
        public Parallelepiped()
        {
            a = 8;
            b = 9;
            h = 10;
        }
        public Parallelepiped(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }
        public double A { get; set; }
        public double B { get; set; }
        public double H { get; set; }
        private double P_o
        {
            get { return 2 * (a + b); }
        }
        private double S_b
        {
            get { return P_o * h; }
        }
        private double S_o
        {
            get { return a * b; }
        }
        public double S
        {
            get { return S_b + 2 * S_o; }
        }
        public double V
        {
            get { return S_o * h; }
        }
    }
}
