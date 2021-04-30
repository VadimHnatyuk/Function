using System;
using System.Collections.Generic;
using System.Text;

namespace Function
{
    abstract class Trans
    { 
        public string Name { get; set; }
        public int Number { get; set; }
        public int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("THE SPEED IS MUST BE >0");
                }
                else
                {
                    speed = value;
                }
            } 
        }
        public int Kg { get; set; }
        public string TransportName;
        public Trans(string name, int number, int speed, int kg)
        {
            Name = name;
            Number = number;
            Speed = speed;
            Kg = kg; 
        }
        public string Print()
        {
            return $"Name{Name},KG{Kg},Number{Number},Speed{Speed}= {TransportName} ";
        }
        public string Calc() 
        {
            return $"Вантажопідйомність={Kg}";
        }
    }
    class Auto: Trans
    {  
       public Auto(string name,int number,int speed,int kg):base(name,number,speed,kg)
        {
            TransportName = "Car";
        }     
    }
    class Moto : Trans
    {
        public bool Carriage;
        public Moto(string name, int number, int speed, int kg,bool carriage) : base(name, number, speed, kg)
        {
            TransportName = "Moto";
            if (carriage)
            {

                Kg = kg;
            }
            else
            {
                Kg = 0;
            }
        }
    }
    class Fura: Trans
    {
        public bool carriage;   
        public Fura(string name, int number, int speed, int kg, bool carriage) : base(name, number, speed, kg)
        {
            TransportName = "Fura";
            if (carriage)
            {

                Kg = kg*2;
            }
            else
            {
                Kg = kg;
            }
        }
    }
}

