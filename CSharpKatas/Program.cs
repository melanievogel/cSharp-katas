using System;
using System.Linq;

namespace CSharp_Katas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /**
         *
         */
        public static string Longest(string s1, string s2)
        {
            var orderedDistinctEnum = $"{s1}{s2}".OrderBy(i => i).Distinct();
            var orderedDistinctString = string.Join(null, orderedDistinctEnum.ToArray());

            return orderedDistinctString;
        }
    }
}
