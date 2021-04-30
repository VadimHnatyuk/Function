using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {

            //Line l = new Line(3, 2);
            //Console.WriteLine(l.GetY(100));
            //Kub k = new Kub(2, 6, 8);
            //Console.WriteLine(k.GetY(5));
            //Hyperbola h = new Hyperbola(6);
            //Console.WriteLine(h.GetY(5));
            //Console.WriteLine();
            //Rectangle r = new Rectangle(2, 6);
            //Console.WriteLine(r.Print());
            //Circle c = new Circle(6);
            //Console.WriteLine(c.Print());
            //Triangle t = new Triangle(9, 8, 7);
            //Console.WriteLine(t.Print());

            Class1 c = new Class1(145);
            Class1 g = new Class1(250);

            bool p = c > 100;
            Console.WriteLine(p);
            Auto a = new Auto("Fiat",1585,95,150);
            Console.WriteLine(a.Print());

            Moto m = new Moto("Delta", 1863, 20, 400,true);
            Console.WriteLine(m.Print());
            Console.WriteLine(m.Calc());

            Fura f = new Fura("Iveco", 1584, 70, 1200, true);
            Console.WriteLine(f.Print());
            Console.WriteLine(f.Calc());


        }
    }
}
