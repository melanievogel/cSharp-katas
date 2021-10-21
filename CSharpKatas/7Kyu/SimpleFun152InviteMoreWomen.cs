using System.Linq;

namespace CSharp_Katas._7Kyu
{
    public class SimpleFun152InviteMoreWomen
    {
        public static bool InviteMoreWomen(int[] L)
        {
            return L.Where(w => w == -1).Count() >= L.Where(m => m == 1).Count() ? false : true;
        }
    }
}
