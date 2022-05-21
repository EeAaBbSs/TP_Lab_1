using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Lab_1
{
    public class TruncatedPyramid
    {
        private double s1, s2, h, c;
        public TruncatedPyramid(double s1, double s2, double h)
        {
            PyrS1 = s1;
            PyrS2 = s2;
            PyrH = h;
        }
        public TruncatedPyramid(double s1, double s2, float c)
        {
            PyrS1 = s1;
            PyrS2 = s2;
            PyrC = c;
        }
        public double PyrS1
        {
            get { return s1; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Позволяются только положительные значения!");
                }
                s1 = value;
            }
        }
        public double PyrS2
        {
            get { return s2; }
            set
            {
                if ((value <= 0.0) || (value == s1))
                {
                    throw new ArgumentException("Позволяются только положительные значения, и площади оснований не могут быть равны!");
                }
                s2 = value;
            }
        }
        public double PyrH
        {
            get { return h; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Позволяются только положительные значения!");
                }
                h = value;
            }
        }
        public double PyrC
        {
            get { return c; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Позволяются только положительные значения!");
                }
                c = value;
            }
        }
        public double Volume()
        {
            return Math.Round(1.0 / 3.0 * h * (s1 + s2 + Math.Sqrt(s1 * s2)), 2);
        }
        public double SideSurf()
        {
            return Math.Round(Math.Abs(s1 - s2) / Math.Cos(c * Math.PI / 180), 2);
        }
    }
}