public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0, end = nums.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            // Check if the left side is sorted
            if (nums[start] <= nums[mid])
            {
                if (target >= nums[start] && target < nums[mid]) 
                {
                    end = mid - 1; // Target is in the left sorted half
                }
                else {
                    start = mid + 1; // Target is in the right half
                }
            }
            // If the left side is not sorted, then the right side must be sorted
            else {
                if (target > nums[mid] && target <= nums[end])
                {
                    start = mid + 1; // Target is in the right sorted half
                }
                else 
                {
                    end = mid - 1; // Target is in the left half
                }
            }
        }

        return -1; // Target is not found

    }
}