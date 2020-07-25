using System;

namespace Polymorphism
{
    class Audi : Car
    {   
        private string model;
        protected string brand = "Audi";
        public string Model { get => model; set => model = value; }

        public Audi() {}

        public Audi(int HP, string color, string model) : base(HP, color)
        {
            this.Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Brand:{0}.Model - {1}.Horse Power is {2}.The color of the car is {3}.",brand, Model, HP, Color);
        }

        public new  void Repair()
        {
            Console.WriteLine("Audi {0} was repaired", model);
        }
    }
}
