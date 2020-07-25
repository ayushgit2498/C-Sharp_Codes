using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mymethod("This method is called from main");
            // Console.WriteLine("Addition -> {0}", Add(Add(2,3), Add(20, 30)));
            // int n1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Your entered number is : {0}", n1);
            //ExceptionHandling();
            operators();
        }

        public static void Mymethod(string text)
        {
            Console.WriteLine(text);
        }

        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static void ExceptionHandling()
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = 10/n1;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception. Please enter the correct type next time.");
                //throw;    //throw is used to throw an error from a method.In this case we are throwing error to console.
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input out of range.");
                //throw;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The value was empty.");
            }
            finally
            {
                Console.WriteLine("This is always called whether or not an exception occurs.");
            }
        }

        public static void operators()
        {
            int num1 = 5;
            int num2 = 3;

            // Unary operators
            int n1 = -num1;
            Console.WriteLine(n1);

            bool isSunny = true;
            Console.WriteLine("opposite {0}", !isSunny);

            // Increment and Decrement operators
            n1++;
            Console.WriteLine(n1);
            n1--;
            Console.WriteLine(n1);

            // Arithmetic (Binary) operators
            int result;
            result = num1 + num2;
            Console.WriteLine(result);
            result = num1 - num2;
            Console.WriteLine(result);
            result = num1 * num2;
            Console.WriteLine(result);
            result = num1 / num2;
            Console.WriteLine(result);
            result = num1 % num2;
            Console.WriteLine(result);

            //Relational and Type operators
            bool isLower = num1 < num2;
            Console.WriteLine(isLower);
            bool isGreater = num1 > num2;
            Console.WriteLine(isGreater);

            // Equality operators

            bool isEqual = num1 == num2;
            Console.WriteLine(isEqual);
            bool isNotEqual = num1 != num2;
            Console.WriteLine(isNotEqual);

            // Conditional operators

            bool isLowerAndSunny = isSunny && isLower;
            Console.WriteLine(isLowerAndSunny);
            bool isGreaterAndSunny = isSunny || isGreater;
            Console.WriteLine(isGreaterAndSunny);
        }
    }
}
