using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneLibrary.Maths
{
    public class MathHelper
    {
        public double DistanceSign(double a, double b, double c, double x, double y)
        {
            return 0.0;
        }
        public double Distance(double a, double b, double c, double x, double y) => Math.Abs(DistanceSign(a, b, c, x, y));
    }
}
