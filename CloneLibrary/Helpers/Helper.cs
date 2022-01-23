using CloneLibrary.Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneLibrary.Helpers
{
    public static class Helper
    {
        public static MathHelper Math { get; private set; }

        static Helper()
        {
            Math = new MathHelper();
        }
    }
}
