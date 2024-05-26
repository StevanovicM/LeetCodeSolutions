public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // Initialize the dp array with a large value. Using amount + 1 because it's one more than the largest possible number of coins.
        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);

        // Base case: zero amount requires zero coins
        dp[0] = 0;

        // Build the dp array.
        for (int i = 1; i <= amount; i++)
        {
            foreach (int coin in coins)
            {
                if (i >= coin) {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        // If dp[amount] is still the initial large value, it means it's impossible to form the amount with the given coins.
        return dp[amount] > amount ? -1 : dp[amount];
    }
}