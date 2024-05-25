public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];

        // Initialize the array with 1
        answer[0] = 1;

        // Fill in the left products
        for (int i = 1; i < n; i++)
        {
            answer[i] = nums[i - 1] * answer[i - 1];
        }

        // Multiply with the right products
        int right = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] = answer[i] * right;
            right *= nums[i];
        }

        return answer;
    }
}