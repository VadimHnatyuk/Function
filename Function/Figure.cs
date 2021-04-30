using System;
using System.Collections.Generic;
using System.Text;

namespace Function
{
    abstract class Figure
    {
        public abstract double Square();
        public abstract double Perimetr();
        public abstract string Print();
    }
    class Rectangle : Figure
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public Rectangle(double weight,double height)
        {
            Weight = weight;
            Height = height;
        }
        public override double Perimetr()
        {
            return Weight * 2 + Height * 2;
        }
        public override double Square()
        {
            return Weight * Height ;
        }
        public override string Print()
        {
            return $"The figure is rectangle. Square={Square()},Perimetr={Perimetr()}";
        }
    }
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }
        public override string Print()
        {
            return $"The figure is Circle. Square={Square()},Perimetr={Perimetr()}";
        }
    }
        class Triangle : Figure
        {
            public double FirstSide { get; set; }
            public double SecondSide { get; set; }
            public double ThirdSide { get; set; }

            public Triangle(double x, double y, double z)
            {
                FirstSide = x;
                SecondSide = y;
                ThirdSide = z;
            }
            public override double Perimetr()
            {
                return FirstSide + SecondSide + ThirdSide;
            }
            public override double Square()
            {
                double p = Perimetr() / 2;
                return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
            }
            public override string Print()
            {
                return $"The figure is Triangle. Square={Square()},Perimetr={Perimetr()}";
            }

        }    
}
