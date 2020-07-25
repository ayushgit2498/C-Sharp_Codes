using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
            WriteFile();
        }

        public static void ReadFile()
        {
            string text = System.IO.File.ReadAllText(@"/home/blazehunter/College/Languages&courses/C#/Projects/FileIO/details.txt");
            Console.WriteLine(text);

            string []lines = System.IO.File.ReadAllLines(@"details.txt");
            Console.WriteLine("The contents of the file are as follows:");
            foreach (string i in lines)
            {
                Console.WriteLine("\t" + i);               
            }
        }

        public static void WriteFile()
        {
            // Method 1
            string []scores = new string[4];
            scores[0] = "234";
            scores[1] = "235";
            scores[2] = "236";
            scores[3] = "237";

            File.WriteAllLines(@"scores.txt", scores);
            
            // Method 2
            Console.WriteLine("Please enter the filename");
            string fName = Console.ReadLine();
            Console.WriteLine("Please enter the text");
            string text = Console.ReadLine();
            File.WriteAllText(@"" + fName + ".txt", text);

            string []lines = new string[]
            {
                "First shot", "Second header", "Third Bicycle", "Fourth Tap In"
            };
            // Method 3
            using(StreamWriter file = new StreamWriter(@"myText.txt"))
            {
                foreach (string line in lines)
                {
                    if(line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Append text
            using(StreamWriter file = new StreamWriter(@"myText.txt", true))
            {
                file.WriteLine("Additional line");
            }
        }
    }
}
