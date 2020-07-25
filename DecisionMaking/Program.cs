using System;

namespace DecisionMaking
{
    class Program
    {

        static int temperature;
        static string username = "blazehunter";
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string n1 = Console.ReadLine();
            if (int.TryParse(n1, out temperature)){}
            else
            {
                Console.WriteLine("You didn't give the input in correct format.Temperature set to 0.");
                temperature = 0;
            }
            Console.WriteLine(temperature);
            if (temperature < 10)
            {
                Console.WriteLine("cold");
            }else if (temperature == 10)
            {
                Console.WriteLine("warm");
            }else
            {
                Console.WriteLine("Hot");
            }

            SwitchPractice();
            TernaryOperator();
            Console.ReadKey();
        }

        public static void SwitchPractice()
        {
            //string username = "blazehunter";

            switch (username)
            {
                case "blazehunter":
                Console.WriteLine("Welcome blazehunter");
                break;

                case "root":
                Console.WriteLine("Welcome root user");
                break;

                default:
                Console.WriteLine("Unknown user");
                break;
            }
        }

        public static void TernaryOperator()
        {
            //int temperature = 190;
            string stateOfMatter;

            stateOfMatter = temperature <= 0 ? "Solid" : temperature >= 100 ? "Gas" : "Liquid";
            Console.WriteLine("State of water is {0}", stateOfMatter);
        }
    }
}
