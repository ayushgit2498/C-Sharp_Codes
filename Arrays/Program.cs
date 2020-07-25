using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basics();
            // MultiDimensionalArrays();
            // Game g1 = new Game();
            // g1.Prepare();
            // g1.Start();
            // JaggedArray();

            // int []myArray = {1000, 2000, 3000, 4000, 5000};
            // // Arrays are passed by reference in c#
            // ArrayParameterTest(myArray);
            // foreach (int i in myArray)
            // {
            //     Console.WriteLine(i);
            // }
            ArrayListPractice();
        }

        static void Basics()
        {

            int []grades = new int[5];
            grades[0] = 10;
            grades[1] = 20;
            grades[2] = 30;
            grades[3] = 40;
            grades[4] = 50;

            // Second way of initializing array
            int []arr = {1, 2, 3, 4, 5, 6, 7};

            // Third way of initializing array
            int []years = new int[] {2002, 2006, 2010, 2014, 2018};

            // Console.WriteLine("The length of years array is {0}", years.Length);

            // Console.WriteLine("The years in which FIFA World Cup was held are as follows:");
            foreach(int i in years)
            {
                // Console.WriteLine(i);
            }
        }

        static void MultiDimensionalArrays()
        {
            // 2D arrays
            int [,] nums = new int[3,3];

            int [,]arr = {
                {1, 2},
                {3, 4}
            };

            // 3D arrays

            int [,,]days = new int[1,2,3];
            days[0,0,0] = 1;
            days[0,0,1] = 2;
            days[0,0,2] = 3;
            days[0,1,0] = 4;
            days[0,1,1] = 5;
            days[0,1,2] = 6;

            // array.Rank to retireve the number of dimensions of a N-Dimensional array
            // Console.WriteLine("The dimensions of this array is {0}", days.Rank);

            // Console.WriteLine(days.GetLength(0) + " " + days.GetLength(1) + " " + days.GetLength(2));
            // GetLength is used to retrieve dimensions
            for(int i = 0;i < days.GetLength(0); i++)
            {
                for(int j = 0; j < days.GetLength(1); j++)
                {
                    for(int k = 0; k < days.GetLength(2); k++)
                    {
                        // Console.WriteLine(days[i,j,k]);
                    }
                }
            }    
        }

        public static void JaggedArray()
        {
            // Jagged array can be used when you want columns of varying sizes.
            int [][]arr = new int[3][];
            arr[0] = new int[5] {0, 1, 2, 3, 4};
            arr[1] = new int[2] {2, 2};
            arr[2] = new int[1];
            arr[2][0] = 100;

            // Another method of declaring and initializing
            /*
            int [][]arr = new int[][]
            {
                new int[]{0, 1, 2, 3, 4, 5},
                new int[2]{2, 2},
                new int[1]{100}
            };
            */

            // Note: Normal N-Dimensional array accessed as [,,,,n].Jagged N-Dimensional array accessed as [][][][][n] 
            string temp;
            for(int  i = 0;i < arr.GetLength(0); i++)
            {
                temp = "";
                foreach (int j in arr[i])
                {
                    temp += j + " ";
                }
                Console.WriteLine(temp);
            }
        }

        static void ArrayParameterTest(int []myArray)
        {
            for(int i = 0;i < myArray.Length; i++)
            {
                myArray[i] += 1;
            }
        }
    
        static void ArrayListPractice()
        {
            ArrayList a1 = new ArrayList();
            // or
            // ArrayList a1 = new ArrayList(10);

            a1.Add(10);
            a1.Add(128.9);
            a1.Add(50);
            a1.Add(20);
            a1.Add(12.4);
            a1.Add(20);
            a1.Add("Testing");
            a1.Add(50.5);
            a1.Add(10);

            a1.Remove(20);
            a1.RemoveAt(0);
            a1.RemoveRange(0, 2);

            Console.WriteLine("The number of elements in the array is {0}", a1.Count);

            foreach (object i in a1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("============================================");

            double sum = 0;
            foreach (object i in a1)
            {
                // Casting of element is required when you use ArrayList for Arithmetic operations.
                if(i is int)
                {
                    sum += Convert.ToDouble(i);
                }else if(i is double)
                {
                    sum += (double)i;
                }else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("The sum is {0}", sum);

        }
    }


}
