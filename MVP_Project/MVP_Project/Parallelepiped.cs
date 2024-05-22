using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Project
{
    class Parallelepiped:IParallelepipedModel
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

        public double V()
        {
            return a * b * h;
        }

        public double S()
        {
            return (2 * (a + b) * h) + 2 * (a * b);
        }
    }
}
