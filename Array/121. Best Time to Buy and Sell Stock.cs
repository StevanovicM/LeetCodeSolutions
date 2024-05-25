public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0) return 0;

        int minPrice = int.MaxValue; // Initialize minPrice to a very high value
        int maxProfit = 0; // Start with no profit

        foreach(int price in prices)
        {
            if (price < minPrice)
            {
                // Find the new minimum price so far
                minPrice = price;
            }
            else if (price - minPrice > maxProfit)
            {
                // Calculate profit if we sell at current price and check if it's the maximum profit so far
                maxProfit = price - minPrice;
            }
        }

        return maxProfit;
    }
}