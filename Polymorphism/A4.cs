using System;

namespace Polymorphism
{
    class A4 : Audi
    {   
        public A4(int HP, string color, string model) : base(HP, color, model){}

        public override void ShowDetails()
        {
            Console.WriteLine("Brand:A4.Model - {0}.Horse Power is {1}.The color of the car is {2}.", Model, HP, Color);
        }

    }
}
