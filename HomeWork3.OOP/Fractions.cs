using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP
{
     public class Fractions
    {
        private long WholePart;
        private ushort FractionPart;

        public Fractions()
        {
            WholePart = 0;
            FractionPart = 0;
        }

        public Fractions(long wholePart, ushort fractionPart)
        {
            WholePart = wholePart;
            FractionPart = (ushort)(fractionPart % 10000);
        }

        public override string ToString()
        {
            var formattedOutput = $"{WholePart}.{FractionPart:d4}";
            return formattedOutput;
        }

        public double ToDouble()
        {
            var number = Convert.ToDouble(this.ToString());
            return number;
        }

        public static Fractions ToFraction(double number)
        {
            number = Math.Round(number, 4);
            var tempStr = number.ToString();
            var array = tempStr.Split('.');
            var wholePart = Convert.ToInt64(array[0]);
            ushort fractionPart;
            if (array.Length == 2)
            {
                while (array[1].Length < 4)
                {
                    array[1] += "0";
                }

                fractionPart = Convert.ToUInt16(array[1]);
            }
            else
            {
                fractionPart = (ushort)0;
            }

            return new Fractions(wholePart, fractionPart);
        }

        public static Fractions operator + (Fractions x, Fractions y)
        {
            return Fractions.ToFraction(x.ToDouble() + y.ToDouble());
        }

        public static Fractions operator - (Fractions x, Fractions y)
        {
            return Fractions.ToFraction(x.ToDouble() - y.ToDouble());
        }

        public static Fractions operator * (Fractions x, Fractions y)
        {
            return Fractions.ToFraction(x.ToDouble() * y.ToDouble());
        }

        public static Fractions operator / (Fractions x, Fractions y)
        {
            return Fractions.ToFraction(x.ToDouble() / y.ToDouble());
        }

        public static bool operator == (Fractions x, Fractions y)
        {
            return (x.ToDouble() == y.ToDouble());
        }

        public static bool operator != (Fractions x, Fractions y)
        {
            return (x.ToDouble() != y.ToDouble());
        }

        public static bool operator > (Fractions x, Fractions y)
        {
            return (x.ToDouble() > y.ToDouble());
        }

        public static bool operator < (Fractions x, Fractions y)
        {
            return (x.ToDouble() < y.ToDouble());
        }

        public static bool operator >= (Fractions x, Fractions y)
        {
            return (x.ToDouble() > y.ToDouble());
        }

        public static bool operator <= (Fractions x, Fractions y)
        {
            return (x.ToDouble() < y.ToDouble());
        }
    }
}
