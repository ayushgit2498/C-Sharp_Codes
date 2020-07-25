using System;
using System.Text.RegularExpressions;

namespace AdvancedCSharpConcepts
{
    class RegularExpressionsPractice
    {        
        public void RegularExpressionsPracticeFunction()
        {
            string pattern = @"[\w._]+@\w+\.\w+";
            Regex regex = new Regex(pattern);
            string text = System.IO.File.ReadAllText(@"RegularExpressionsData.txt");
            Console.WriteLine(text);
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine("Number of hits are {0}", matches.Count);
            foreach (Match i in matches)
            {
                GroupCollection group = i.Groups;
                Console.WriteLine("{0} found at {1}.", group[0].Value, group[0].Index);
            }
        }
    }
}
