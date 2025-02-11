using System;

namespace PolynomialObject
{
    public class PolynomialMember : ICloneable
    {
        public double Degree { get; set; }
        public double Coefficient { get; set; }

        public PolynomialMember(double degree, double coefficient)
        {
            Degree = degree;
            Coefficient = coefficient;
        }

        public object Clone()
        {
            PolynomialMember clone = (PolynomialMember)this.MemberwiseClone();
            return clone;
        }
    }
}
