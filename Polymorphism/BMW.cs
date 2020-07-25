using System;

namespace Polymorphism
{
    class BMW : Car
    {   
        private string model;
        private string brand = "BMW";
        public string Model { get => model; set => model = value; }

        public BMW() {}

        public BMW(int HP, string color, string model) : base(HP, color)
        {
            this.Model = model;
        }

        public sealed override void ShowDetails()
        {
            Console.WriteLine("Brand:{0}.Model - {1}.Horse Power is {2}.The color of the car is {3}.",brand, Model, HP, Color);
        }

        public new void Repair()
        {
            Console.WriteLine("BMW {0} was repaired", model);
        }
    }
}
