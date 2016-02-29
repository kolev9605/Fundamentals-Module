using System;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public long Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public long Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("Denominator cannot be 0");
                }
                denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long numeratorResult = f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator;
            long denominatorResult = f2.Denominator * f1.Denominator;
            return new Fraction(numeratorResult,denominatorResult);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long numeratorResult = f1.Numerator * f2.Denominator - f1.Denominator * f2.Numerator;
            long denominatorResult = f2.Denominator * f1.Denominator;
            return new Fraction(numeratorResult, denominatorResult);
        }

        public override string ToString()
        {
            return ((decimal)this.Numerator/this.Denominator).ToString();
        }
    }
}