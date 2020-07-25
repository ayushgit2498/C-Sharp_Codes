using System;

namespace DataTypes
{
    // https://www.dofactory.com/reference/csharp-coding-standards
    // class names like ClassActivity
    class Program
    {
        // constants are immutable values which are known at compile time
        // and do not change for the life of program
        // constants as fields

        const double PI = 3.14;
        const int months = 12;
        const string myBirthday = "02/04/1998";

        
        // method names like CalculateValue
        // method arguments like firstArgument
        static void Main(string[] args)
        {

            Console.WriteLine("My birthdate is {0}", myBirthday);
            // =====================================================================================================
            // local variables like itemCount
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;
            //float f1 = 3.5F;

            double d1 = 10.4;
            double d2 = 9.2;
            int res = (int)(d1 / d2);   //Explicit Conversion
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(res);
            // =====================================================================================================
            string test = "Ayush";
            string upperCase = test.ToUpper();
            string lowerCase = test.ToLower();
            Console.WriteLine(lowerCase);
            // =====================================================================================================


            // Implicit Conversion
            int i1 = 10;
            float myFloat = i1;
            double myDouble = myFloat;
            Console.WriteLine(myDouble);

            // Explicit Conversion
            double myDouble2 = 210.56;
            int i2 = (int)myDouble2;
            Console.WriteLine(i2);

            //Type Conversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString);

            // =====================================================================================================

            string string1 = "15";
            string string2 = "30";
            int n1 = int.Parse(string1);
            int n2 = int.Parse(string2);
            // double double1 = double.Parse(string1);
            Console.WriteLine(n1 + n2);
        }
    }
}
