using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview
        static void Main(string[] args)
        {
            int []numbers = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            OddNumbers(numbers);
            UniversityManager um1 = new UniversityManager();
            um1.MaleStudents();
            um1.FemaleStudents();
            um1.SortStudentsByAge();
            um1.AllStudentsFromSPPU();
            Console.WriteLine("Enter University ID");
            int id = int.Parse(Console.ReadLine());
            um1.AllStudentsFromUniversity(id);
            um1.StudentAndUniversityNameCollection();
        }

        static void OddNumbers(int []numbers)
        {
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 orderby number descending select number;
            Console.WriteLine(oddNumbers);
            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }

}
