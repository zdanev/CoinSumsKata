using System.Linq;

namespace CoinSumsKata
{
    public class Pense
    {
        public static readonly int[] Denominations = new int[]
        {
            1,
            2,
            5,
            10,
            20,
            50,
            100,
            200
        } ;

        public static int NumberOfCombinations(int amount, int startIndex = 0)
        {
            int result = 0;

            for (int i = startIndex; i < Denominations.Count(); i++)
            {
                if (Denominations[i] == amount) result = result + 1;

                if (Denominations[i] < amount)
                    result = result + NumberOfCombinations(amount - Denominations[i], i);
            }

            return result;
        }
    }
}