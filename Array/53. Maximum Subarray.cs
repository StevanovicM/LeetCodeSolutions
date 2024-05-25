public class Solution {
    public int MaxSubArray(int[] nums) {
        return MaxSubArrayHelper(nums, 0, nums.Length - 1);
    }

    private int MaxSubArrayHelper(int[] nums, int left, int right)
    {
        if (left == right)
        {
            // Base case: only one element
            return nums[left];
        }

        int mid = left + (right - left) / 2;

        int leftSum = MaxSubArrayHelper(nums, left, mid);
        int rightSum = MaxSubArrayHelper(nums, mid + 1, right);
        int crossSum = MaxCrossingSum(nums, left, mid, right);

        return Math.Max(Math.Max(leftSum, rightSum), crossSum);
    }

    private int MaxCrossingSum(int[] nums, int left, int mid, int right)
    {
        int sum = 0;
        int leftMax = int.MinValue;
        int rightMax = int.MinValue;

        // Calculate max sum going from mid to left
        for (int i = mid; i >= left; i--)
        {
            sum += nums[i];
            if (sum > leftMax)
            {
                leftMax = sum;
            }
        }

        sum = 0; // reset sum for the right half

        // Calculate max sum going from mid + 1 to right
        for (int i = mid + 1; i <= right; i++)
        {
            sum += nums[i];
            if (sum > rightMax)
            {
                rightMax = sum;
            }
        }

        // The maximum crossing sum is the sum of the maximums of the left and right halves
        return leftMax + rightMax;
    }
}