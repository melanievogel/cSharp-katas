using System.Collections.Generic;

namespace CSharp_Katas._7Kyu
{
    public class TwoDimensionalArrayOperation
    {
        public static int Result(int[,] array)
        {
            int sum = 0;
            int product = 1;

            List<int> sumList = new List<int>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }

                sumList.Add(sum);
                sum = 0;
            }

            foreach (var v in sumList)
            {
                product *= v;
            }

            return product;
        }
    }
}
