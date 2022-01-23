using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneLibrary.Maths
{
    public class MathHelper
    {
        public Tuple<NumericPoint, NumericPoint> SelectClosest(
      IList<NumericPoint> set1,
      IList<NumericPoint> set2)
        {
            if (set1 == null || set2 == null)
                return (Tuple<NumericPoint, NumericPoint>)null;
            NumericPoint numericPoint1 = (NumericPoint)null;
            NumericPoint numericPoint2 = (NumericPoint)null;
            double num1 = double.MaxValue;
            for (int index1 = 0; index1 < set1.Count; ++index1)
            {
                NumericPoint a = set1[index1];
                for (int index2 = 0; index2 < set2.Count; ++index2)
                {
                    NumericPoint b = set2[index2];
                    double num2 = this.Distance(a, b);
                    if (num2 < num1)
                    {
                        num1 = num2;
                        numericPoint1 = a;
                        numericPoint2 = b;
                    }
                }
            }
            return Tuple.Create<NumericPoint, NumericPoint>(numericPoint1, numericPoint2);
        }

        public Tuple<NumericPoint, NumericPoint> SelectClosest(
          IList<NumericPoint> points)
        {
            if (points == null || points.Count <= 1)
                return (Tuple<NumericPoint, NumericPoint>)null;
            NumericPoint numericPoint1 = (NumericPoint)null;
            NumericPoint numericPoint2 = (NumericPoint)null;
            double num1 = double.MaxValue;
            int count = points.Count;
            int num2 = count - 1;
            for (int index1 = 0; index1 < num2; ++index1)
            {
                NumericPoint point1 = points[index1];
                for (int index2 = index1 + 1; index2 < count; ++index2)
                {
                    NumericPoint point2 = points[index2];
                    double num3 = this.Distance(point1, point2);
                    if (num3 < num1)
                    {
                        num1 = num3;
                        numericPoint1 = point1;
                        numericPoint2 = point2;
                    }
                }
            }
            return Tuple.Create<NumericPoint, NumericPoint>(numericPoint1, numericPoint2);
        }

        public Tuple<NumericPoint, NumericPoint> SelectClosest(
          params NumericPoint[] points)
        {
            return this.SelectClosest((IList<NumericPoint>)((IEnumerable<NumericPoint>)points).ToList<NumericPoint>());
        }

        public double AngleToRadian(double angle) => angle * Math.PI / 180.0;

        public double RadianToAngle(double radian) => radian * 180.0 / Math.PI;
        public double CalcAngle(NumericPoint a, NumericPoint b)
        {
            double y = b.X - a.X;
            return this.CalcAngle(b.Y - a.Y, y);
        }

        public double CalcAngle(NumericPoint pt) => this.CalcAngle(pt.Y, pt.X);

        public double CalcAngle(double x, double y)
        {
            double num = Math.Atan2(y, x) * 180.0 / Math.PI;
            if (num < 0.0)
                num += 360.0;
            return num;
        }

        public NumericPoint RadianToPoint(double radius, double radian)
        {
            NumericPoint numericPoint = new NumericPoint();
            numericPoint.X = radius * Math.Cos(radian);
            numericPoint.Y = radius * Math.Sin(radian);
            return numericPoint;
        }
        public double CalcAngle(double x0, double y0, double x1, double y1) => this.CalcAngle(x1 - x0, y1 - y0);

        public double Distance(NumericPoint a, NumericPoint b) => this.Distance(a.X, a.Y, b.X, b.Y);

        public double Distance(double x0, double y0, double x1, double y1)
        {
            double num1 = x1 - x0;
            double num2 = y1 - y0;
            return Math.Sqrt(num1 * num1 + num2 * num2);
        }

        public double DistanceSign(double a, double b, double c, double x, double y)
        {
            double num1 = a * x + b * y + c;
            double num2 = Math.Sqrt(a * a + b * b);
            return num2 == 0.0 ? 0.0 : num1 / num2;
        }

        public double Distance(double a, double b, double c, double x, double y) => Math.Abs(this.DistanceSign(a, b, c, x, y));
    }
}
