using System.Linq;

namespace CSharp_Katas._7Kyu
{
    public class TwoToOne
    {
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
