using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneLibrary.Maths
{
    public class NumericPoint : NumericPoint<double>
    {
        public NumericPoint()
        {
        }
        public NumericPoint(object x, object y) : base(x, y)
        {
        }
    }
}
