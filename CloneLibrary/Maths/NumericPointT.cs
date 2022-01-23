using CloneLibrary.Extensions;
using System;

namespace CloneLibrary.Maths
{
    public class NumericPoint<T> : IComparable, ICloneable where T : IComparable
    {
        public T X { get; set; }
        public T Y { get; set; }

        public NumericPoint()
        {
        }
        public NumericPoint(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Set(T x,T y)
        {
            this.X = x;
            this.Y = y;
        }
        public NumericPoint<T> Swap() => new NumericPoint<T>() { X = Y, Y = X };
        public static NumericPoint<TValue> Create<TValue>(TValue x, TValue y) where TValue : IComparable => new NumericPoint<TValue>(x, y);
        public void CopyTo(NumericPoint<T> dest)
        {
            dest.X = this.X;
            dest.Y = this.Y;
        }
        public void CopyFrom(NumericPoint<T> from)
        {
            this.X = from.X;
            this.Y = from.Y;
        }
        public int CompareTo(object obj)
        {
            if(!(obj is NumericPoint<T>))
            {
                return 0;
            }
            NumericPoint<T> numericPoint = obj as NumericPoint<T>;
            T obj1 = X;
            int num = obj1.CompareTo((object)numericPoint.X);
            if((int) num > 0)
            {
                return num;
            }
            obj1 = Y;
            return obj1.CompareTo((object)numericPoint.Y);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return "{0},{1}".At((object)this.X,(object)this.Y);
        }

        public override bool Equals(object obj)
        {
            if(!(obj is NumericPoint<T>))
            {
                return false;
            }
            NumericPoint<T> numericPoint = obj as NumericPoint<T>;
            T obj1 = X;
            int num;
            if(obj1.Equals((object) numericPoint.X))
            {
                obj1 = Y;
                num = obj1.Equals((object)numericPoint.Y) ? 1 : 0;
            }
            else
            {
                num = 0;
            }

            return num != 0;
        }

        public override int GetHashCode()
        {
            T obj = X;
            int hashcode1 = obj.GetHashCode();
            obj = Y;
            int hashcode2 = obj.GetHashCode();

            return hashcode1 + hashcode2;
        }
    }
}