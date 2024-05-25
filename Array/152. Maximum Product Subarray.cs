public class Solution {
    public int MaxProduct(int[] nums) {
       if (nums.Length == 0) return 0;

        int maxProduct = nums[0];
        int minProduct = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < 0) {
                // Swap max and min because multiplying by a negative makes the small large and the large small
                int temp = maxProduct;
                maxProduct = minProduct;
                minProduct = temp;
            }

            // Calculate the maximum and minimum products up to the current element
            maxProduct = Math.Max(nums[i], maxProduct * nums[i]);
            minProduct = Math.Min(nums[i], minProduct * nums[i]);

            // Update the result with the largest product found so far
            result = Math.Max(result, maxProduct);
        }

        return result;
    }
}