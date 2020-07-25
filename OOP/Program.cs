using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Ayush", "Gupta", "black", 22);
            h1.introduceMyself();

            Human h2 = new Human("Anushree", "Talele", "black");
            h2.introduceMyself();

            Human h3 = new Human("Aniket", "Patil");
            h3.introduceMyself();

            Human h4 = new Human("Amey");
            h4.introduceMyself();       

            Human h5 = new Human();

            Box b1 = new Box();
            b1.Height = 15;
            b1.Length = 25;
            b1.Width = 20;
            Console.WriteLine("Volume is {0}", b1.Volume);
        }
    }
}
