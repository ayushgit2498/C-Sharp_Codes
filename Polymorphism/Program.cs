using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
//          Normal object creation     
            Car c1 = new Car(223, "red");
            c1.Repair();
            BMW bmw1 = new BMW(235, "M331", "blue");
            bmw1.Repair();
            Audi a442 = new Audi(235, "A09", "yellow");
            a442.Repair();
// ----------------------------------------------------------------------
//          Without Virtual and overriding keyword
            Car bmw11 = new BMW(235, "M331", "blue");
            bmw11.Repair();
            Car a443 = new Audi(235, "A09", "yellow");
            a443.Repair(); 
// ========================================================================
            Console.WriteLine("======================================================");
            Console.WriteLine("Now by using virtual and override keywords\n");

            Car c11 = new Car(2413, "orange");
            c11.ShowDetails();
            BMW b1 = new BMW(2000, "M10", "interstellar");
            b1.ShowDetails();
            Audi a1 = new Audi(2500, "A44", "Glacial Green");
            a1.ShowDetails();

            var cars = new List<Car>
            {
                new BMW(200, "M3", "interstellar"),
                new Audi(250, "A4", "Glacial Green")
            };
            foreach (var car in cars)
            {
                car.ShowDetails();
            }
// ========================================================================
            Console.WriteLine("======================================================");
            Console.WriteLine("Grandchild class\n");
            A4 a4new = new A4(12423, "grey", "A412");
            a4new.ShowDetails();
            Audi a241 = new Audi(11111, "white", "A413");
            a241.ShowDetails();
            Audi a242 = new A4(222222, "pink", "A414");
            a242.ShowDetails();
            
        }
    }
}

// Compile Time Polymorphism - 1.)Method Overloading 2.) Operator Overloading.Which function to call is determined at compile time.
// ========================================================================================================================================
// Run Time Polymorphism - Which function to call is determined at run time.
// 1.)If base and derived class consist of methods with same signature(eg ShowDetails) without using virtual and override keyword then
//  - when derived class object is created and assigned to derived refernce and showdetail method is 
//    called then showdetail method of derived class will be called.Derived class hides the method with same signature of base class and also 
//    data members with same name. Here we should use new keyword to avoid warnings in compiler.
// -  when base class object is used as reference and derived class object is assigned to it and now when showdetail method is called then 
//    showdetail method of base class will be called.This is because base class will have access to only its own members and not derived class members

// 2.)If base and derived class consist of methods with same signature(eg ShowDetails) and using virtual and override keyword then
//  - when derived class object is created and assigned to derived refernce and showdetail method is called then
//    showdetail method of derived class will be called.
// -  when base class object is used as reference and derived class object is assigned to it and now when showdetail method is called then 
//    showdetail method of derived class will be called.

// So when we make the method with the same signature in base class as virtual and override that method in derived class
// and assign the created object to base class refernce, now we if call the overrided method then according to the object 
// created that class's method will be called.

// ========================================================================================================================================

// Also note you cannot assign base class object to derived class refernce because base class does not contain the derived class additional 
// members and methods.

// We can restrict the overriding of the overriden method by adding the prefix 'sealed' keyword 
// Note that we can only seal the overrided methods.
// we can also seal an entire class so that it cannot be derived by any class.

// we can also use the combinations of new, virtual and override keywords.