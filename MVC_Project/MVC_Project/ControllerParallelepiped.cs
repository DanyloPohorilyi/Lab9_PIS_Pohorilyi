using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project
{
    class ControllerParallelepiped
    {
        public double V(double a, double b, double h)
        {
            var parallelepiped = new Parallelepiped(a, b, h);
            return parallelepiped.V;
        }
        public double S(double a, double b, double h)
        {
            var parallelepiped = new Parallelepiped(a, b, h);
            return parallelepiped.S;
        }
    }
}
