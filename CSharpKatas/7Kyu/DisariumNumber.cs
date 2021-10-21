using System;

namespace CSharp_Katas._7Kyu
{
    public class DisariumNumber
    {
        public static string DisariumNumbers(int number)
        {
            double result = 0;

            var narr = number.ToString().ToCharArray();

            for (int i = 0; i < narr.Length; i++)
            {
                var numberAsChar = narr[i];
                var numberAsDouble = double.Parse(numberAsChar.ToString());
                var exponentAsDouble = Convert.ToDouble(i + 1);

                result += Math.Pow(numberAsDouble, exponentAsDouble);
            }

            if (result == number)
            {
                return "Disarium !!";
            }
            else
            {
                return "Not !!";
            }
        }
    }
}
