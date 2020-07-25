using System;

namespace AdvancedCSharpConcepts
{
    class NullablesPractice
    {        

        public void NullablesPracticeFunction()
        {
            // Nullable Type variables can be empty or filled.
            // Nullables are useful in the event that if a variable is not set and if that variable is used somewhere like in
            // database entry or a server variable , then the program will not crash and keep running.

            int ?num1 = null;
            // float ?num2;
            // double ?num3;

            bool ?isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("user is male");
            }
            else if(isMale == false)
            {
                Console.WriteLine("user is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            int num4;
            if(num1 == null)
            {
                num1 = 4;
                num4 = (int)num1;
            }
            else
            {
                num4 = 5;
            }
            Console.WriteLine(num1);

            // Shorter : The null coalescing operator ??
            num1 = null;
            num4 = num1 ?? 10; // if num1 is not null num4 = num1(Implicit conversion from nullable int to int is also done) else num4 = 10.
            Console.WriteLine(num4);
        }
           
    }
}
