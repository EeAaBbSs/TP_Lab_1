using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_1
{
    public class Vector
    {
        public double A { get; set; }
        public double B { get; set; }

        public double Length()
        {
            return Math.Sqrt(A * A + B * B);
        }
        public Vector Norm()
        {
            Vector vector = new Vector();
            vector.A = A / Length();
            vector.B = B / Length();
            return vector;
        }
        public string Info()
        {
            return $"{A} и {B}";
        }
    }
}
