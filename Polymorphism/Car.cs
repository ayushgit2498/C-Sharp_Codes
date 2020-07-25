using System;

namespace Polymorphism
{
    class Car
    {   
        private int hp;
        private string color;
        public int HP { get => hp; set => hp = value; }
        public string Color { get => color; set => color = value; }

        public Car() {}

        public Car(int HP, string color)
        {
            this.HP = HP;
            this.color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("Horse Power is {0}.The color of the car is {1}", hp, color);
        }

        public void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
