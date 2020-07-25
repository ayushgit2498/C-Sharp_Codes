using System;

namespace OOP
{
    class Box
    {
        private int height;
        private int length;
        private int width;
        private int volume;

        // The data members are private 
        // Below are the auto - implemented property - enter "prop" + press double tap
        // or you can also generate the normal getter, setter methods. 
        public int Height { get {return height;} set {height = value;} }
        public int Length { get {return length;} set {length = value;} }
        public int Width { get {return width;} set {width = value;} }

        // Here we have made volume as read only property
        public int Volume { get {return volume  = height * length * width;} }

        // Another version is
        // public int Length { get => length; set => length = value; }


        // Destructor is called Finalizer in c#
        // Finalizer is called when object goes out of scope.
        // Finalizer is used for clean up.
        ~Box()
        {
            Console.WriteLine("Destructor called.");
        }
    }
}