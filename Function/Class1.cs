using System;
using System.Collections.Generic;
using System.Text;

namespace Function
{
    class Class1
    {
        public double totalAmount;
        public static Class1 operator +(Class1 acc,double n)
        {
            return new Class1 { Amount = acc.Amount + n };
        }
        public static Class1 operator -(Class1 acc, double n)
        {
            return new Class1 { Amount = acc.Amount - n };
        }
        public static bool operator <(Class1 acc, double n)
        {
            return true;
        }
        public static bool operator >(Class1 acc, double n)
        {
            return false;
        }
        public double Amount { get { return totalAmount; }
            set { totalAmount = value; } }

        public Class1(double amount)
        {
            Amount = amount;

        }
        public Class1()
        {

        }
    }
}
