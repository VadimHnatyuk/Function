using System;
using System.Collections.Generic;
using System.Text;

namespace Function
{
    
    abstract class Function
    {        
        public abstract double Y(double x);
    }
    class Line : Function
    {
        public double A { get; set; }
        public double B { get; set; }
        public string GetY(double x)
        {
            return $"Значення функції y={A}*x+{B} в точці {x}={Y(x)}";
        }

        public Line(double a,double b)
        {
            A = a;
            B = b;
        }  
        public override double Y(double x)
        {
            return A * x + B;
        }
    }
    class Kub : Function
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public string GetY(double x)
        {
            return $"Значення функції y={A}*x^2+{B}*x+{C} в точці {x}={Y(x)}";
        }
        public Kub(double a, double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Y(double x)
        {
            return x*x*A + B*x+C;
        }
    }
    class Hyperbola : Function
    {
        public double A { get; set; }
        public double B { get; set; }
        public string GetY(double x)
        {
            return $"Значення функції y={A}/x в точці {x}={Y(x)}";
        }

        public Hyperbola(double a)
        {
            A = a;      
        }
        public override double Y(double x)
        {
            return A/x;
        }
    }

}
