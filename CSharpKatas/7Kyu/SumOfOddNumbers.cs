namespace CSharp_Katas._7Kyu
{
    public class SumOfOddNumbers
    {
        /*
         *              1
         *             3 5
         *            7 9 11
         *         13 15 17 19
         *        ...
         */
        public static long RowSumOddNumbers(long row)
        {
            var firstNumberOfRowN = row * (row - 1) + 1;
            var lastNumberOfRowN = firstNumberOfRowN + (row * 2);

            long r = 0;
            for (long i = firstNumberOfRowN; i < lastNumberOfRowN; i++)
            {
                if (i % 2 != 0)
                {
                    r += i;
                }
            }
            return r;
        }
    }
}
