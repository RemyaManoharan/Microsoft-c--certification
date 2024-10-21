using System;
namespace TestProject
{
    public class Coins
    {
        public static int[] TwoCoins(int[] coins, int target)
        {

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = i + 1; j < coins.Length; j++)
                {
                    if (coins[i] + coins[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }



            }
            return new int[0];
        }
        public static void FindCoins()
        {
            int target = 60;
            int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
            int[] result = TwoCoins(coins, target);

            if (result.Length == 2)
            {
                Console.WriteLine($"Indices of coins that sum to {target}: {result[0]} and {result[1]}");
            }
            else
            {
                Console.WriteLine($"No two coins sum to {target}");
            }
        }
    }


}
    
    