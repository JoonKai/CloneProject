using CloneLibrary.Maths;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneLibrary.Extensions
{
    public static class CodeExtension
    {
        public static string At(this string fmt, params object[] args)
        {
            if (args == null)
            {
                return fmt;
            }
            else
            {
                return string.Format((IFormatProvider)CultureInfo.GetCultureInfo("en-US"),fmt,args);
            }
        }
        public static bool IsNullOrEmpty(this string text) => text == null || text.Length == 0;
        public static void AddXY(this IList<NumericPoint> points, double x, double y)
        {
            if (points == null)
                return;
            NumericPoint numericPoint = new NumericPoint(x, y);
            points.Add(numericPoint);
        }
        public static double ToDouble(this string value, double default_value)
        {
            double result = 0.0;
            return double.TryParse(value, out result) ? result : default_value;
        }

        public static float ToFloat(this string value, float default_value)
        {
            float result = 0.0f;
            return float.TryParse(value, out result) ? result : default_value;
        }

        public static int ToInt(this string value, int default_value)
        {
            int result = 0;
            return int.TryParse(value, out result) ? result : default_value;
        }

        public static uint ToUInt(this string value, uint default_value)
        {
            uint result = 0;
            return uint.TryParse(value, out result) ? result : default_value;
        }
    }
}
