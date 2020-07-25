using System;

namespace AdvancedCSharpConcepts
{
    enum Day {Sunday, Monday, Tuesday, Wednesday, Thrusday, Friday, Saturday};
    enum Months {Januray = 1, February, March, April, May, June, July = 12, August, September, October, November, December};
    // Whenever we aasign a value to a member of enum, it starts assigning the next numbers to the remanining elements
    // Enums are useful when we want to use a specified set of constants across multiple classes , hence keeping consistency.
    class Program
    {
        struct Game
        {
            public string name;
            public string company;
            public int rating;

            public void DisplayRelease()
            {
                Console.WriteLine("PES 2020 was released in October 2019.");
            }
        }

        static void Main(string[] args)
        {
            StructsPractice();
            EnumPractice();
            DateTimePractice dtp1 = new DateTimePractice();
            dtp1.DateTimeFunctions();
            NullablesPractice n1 = new NullablesPractice();
            n1.NullablesPracticeFunction();
            RegularExpressionsPractice rp1 = new RegularExpressionsPractice();
            rp1.RegularExpressionsPracticeFunction();
        }

        public static void StructsPractice()
        {
            Game game1;
            game1.name = "PES 2020";
            game1.company = "Konami";
            game1.rating  = 9;
            Console.WriteLine("The name of the game is {0}.{0} is developed by {1}.The rating of this game is {2}.", game1.name, game1.company, game1.rating);
            game1.DisplayRelease();
        }

        public static void EnumPractice()
        {
            Day d1 = Day.Sunday;
            Day d2 = Day.Monday;
            Day d3 = Day.Sunday;

            Console.WriteLine(d3 == d1);
            Console.WriteLine(d2);
            Console.WriteLine((int)d1); // (int)Day.Sunday
        }
    }
}
