using CloneLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CloneLibrary.Maths
{
    public class NumericPoint : NumericPoint<double>
    {
        public NumericPoint()
        {
        }
        public NumericPoint(double x, double y) : base(x, y)
        {
        }
        public NumericPoint(Point pt) : base(pt.X, pt.Y)
        {

        }
        public virtual NumericPoint Add(double dx, double dy)
        {
            this.X += dx;
            this.Y += dy;
            return this;
        }
        public virtual Point ToPoint() => new Point(this.X, this.Y);
        public virtual Size ToSize() => new Size(this.X, this.Y);
        public virtual NumericPoint ToFloorPoint() => new NumericPoint(Math.Floor(this.X), Math.Floor(this.Y));
        public virtual NumericPoint SwapXY() => new NumericPoint(this.Y, this.X);

        public static List<NumericPoint> ParseText(string text, char line_delim = '\n', char col_delim = ' ')
        {
            List<NumericPoint> points = new List<NumericPoint>();
            List<string> list = ((IEnumerable<string>) text.Split(line_delim)).Select<string, string>((Func<string, string>)( x => x.Trim())).ToList<string>();
            for (int index = 0; index < list.Count; ++index)
            {
                string text1 = list[index];
                if (!text1.IsNullOrEmpty())
                {
                    string[] strArray = text1.Split(col_delim);
                    if (strArray.Length >= 2)
                        points.AddXY(strArray[0].Trim().ToDouble(0.0), strArray[1].Trim().ToDouble(0.0));
                }
            }
            return points;
        }
        public static List<NumericPoint> JoinTwoArray(IEnumerable<double> x,IEnumerable<double> y)
        {
            List<NumericPoint> points = new List<NumericPoint>();
            IEnumerator<double> enumerator1 = x.GetEnumerator();
            IEnumerator<double> enumerator2 = y.GetEnumerator();
            while (enumerator1.MoveNext() && enumerator2.MoveNext())
                points.AddXY(enumerator1.Current, enumerator2.Current);
            return points;
        }
    }
}
