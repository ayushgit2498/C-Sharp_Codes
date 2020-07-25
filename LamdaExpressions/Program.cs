using System;
using System.Collections.Generic;

namespace LamdaExpressions
{
    class Program
    {
        public delegate int SomeMath(int i);
        public delegate double SomeMoreMath(int i, int j);

        static void Main(string[] args)
        {
            DoSomething();
        }

        public static void DoSomething()
        {

            SomeMath square = new SomeMath(Square);
            Console.WriteLine("Square of {0} is {1}", 8, square(8));

            SomeMath cube = (x => x * x * x);
            Console.WriteLine("Cube of {0} is {1}", 8, cube(8));

            SomeMoreMath hypotenuse = (i, j) => Math.Sqrt(i * i + j * j);
            Console.WriteLine("Hypotenuse of {0} and {1} is {2}", 3, 4, hypotenuse(3,4));

            List<int> list = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine("Even Numbers");
            List<int> evenNumber = list.FindAll(delegate (int i){
                return(i % 2 == 0 ? true : false);
            });

            foreach (int i in evenNumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Even Numbers");
            List<int> oddNumbers = list.FindAll(i => {
                return i % 2 == 1;
            });
            oddNumbers.ForEach(i => {
                Console.WriteLine(i);
            });

            Console.WriteLine("Math Library Functions");
            MathLibraryFunctions();
        }

        public static int Square(int i)
        {
            return i * i;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Times10(int i)
        {
            return i * 10;
        }

        public static void MathLibraryFunctions()
        {
            Console.WriteLine(Math.Min(3,4));
            Console.WriteLine(Math.Max(3,4));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Abs(-1));
            Console.WriteLine(Math.Cos(90 * Math.PI / 180));

        }
    }
}
