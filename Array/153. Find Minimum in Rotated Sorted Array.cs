public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        int left = 0, right = nums.Length - 1;

        // If the last element is greater than the first element then there is no rotation.
        // e.g. 1 < 2 < 3 < 4 < 5 < 7. Already sorted array.
        // Hence the smallest element is first element. A[0]
        if (nums[right] > nums[left])
        {
            return nums[left];
        }

        // Binary search way
        while (right >= left)
        {
            int mid = left + (right - left) / 2;

            // Check if the mid element is greater than its next element
            if (nums[mid] > nums[mid + 1])
            {
                return nums[mid + 1];
            }

            // Check if the mid element is lesser than its previous element
            if (nums[mid - 1] > nums[mid])
            {
                return nums[mid];
            }

            // Decide whether we want to go to the left half or the right half
            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}