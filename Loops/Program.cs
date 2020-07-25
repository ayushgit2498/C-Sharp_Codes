using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop");
            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Do While loop");
            string text = "";
            int length = 0;
            do
            {
                string temp = Console.ReadLine();
                text += temp;
                length += temp.Length;
            }while(length < 20);
            Console.WriteLine(text);

            int counter = 0;
            string input = "";
            Console.WriteLine("Press enter to increase the count by 1.Press anything else to stop.");
            input = Console.ReadLine();
            while(input.Equals(""))
            {
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine("The counter is : {0}", counter);

            string in1;
            int range;
            Console.WriteLine("Please enter the count of even numbers you want.");
            while(true)
            {
                in1 = Console.ReadLine();
                if(int.TryParse(in1, out range))
                {
                    break;
                }else
                {
                    Console.WriteLine("Please enter an Integer number only.");
                }
            }
            Console.WriteLine("Printing even numbers");
            int track = 0;
            for(int i = 0;; i++)
            {
                if(track == range)
                    break;
                if(i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                track ++;

            }
        }
    }
}
