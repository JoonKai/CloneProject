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
        
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}