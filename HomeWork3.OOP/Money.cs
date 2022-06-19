using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3.OOP
{
    public class Money
    {
        private long Rubles;
        private byte Pennies;

        public Money()
        {
            Rubles = 0;
            Pennies = 0;
        }

        public Money(long rubles, byte pennies)
        {
            Rubles = rubles;
            Pennies = (byte)(pennies % 100);
        }

        public override string ToString()
        {
            var formattedOutput = $"{Rubles},{Pennies:d2}";
            return formattedOutput;
        }

        public double ToDouble()
        {
            var number = Convert.ToDouble(this.ToString().Replace(",", "."));
            return number;
        }

        public static Money ToMoney(double number)
        {
            number = Math.Round(number, 2);
            var tempStr = number.ToString();
            var array = tempStr.Split('.');
            var rubles = Convert.ToInt64(array[0]);
            byte pennies;
            if (array.Length == 2)
            {
                while (array[1].Length < 2)
                {
                    array[1] += "0";
                }

                pennies = Convert.ToByte(array[1]);
            }
            else
            {
                pennies = (byte)0;
            }

            return new Money(rubles, pennies);
        }

        public static Money operator + (Money x, Money y)
        {
            return Money.ToMoney(x.ToDouble() + y.ToDouble());
        }

        public static Money operator - (Money x, Money y)
        {
            return Money.ToMoney(x.ToDouble() - y.ToDouble());
        }

        public static Money operator * (Money x, Money y)
        {
            return Money.ToMoney(x.ToDouble() * y.ToDouble());
        }

        public static Money operator * (Money x, Fractions y)
        {
            return Money.ToMoney(x.ToDouble() * y.ToDouble());
        }

        public static Money operator / (Money x, Money y)
        {
            return Money.ToMoney(x.ToDouble() / y.ToDouble());
        }

        public static Money operator / (Money x, Fractions y)
        {
            return Money.ToMoney(x.ToDouble() / y.ToDouble());
        }

        public static bool operator == (Money x, Money y)
        {
            return x.ToDouble() == y.ToDouble();
        }

        public static bool operator != (Money x, Money y)
        {
            return x.ToDouble() != y.ToDouble();
        }

        public static bool operator > (Money x, Money y)
        {
            return x.ToDouble() > y.ToDouble();
        }

        public static bool operator < (Money x, Money y)
        {
            return x.ToDouble() < y.ToDouble();
        }

        public static bool operator >= (Money x, Money y)
        {
            return x.ToDouble() > y.ToDouble();
        }

        public static bool operator <= (Money x, Money y)
        {
            return x.ToDouble() < y.ToDouble();
        }
    }
}
