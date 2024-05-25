public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicate values for i

            int left = i + 1;
            int right = nums.Length - 1;
            
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                
                if (sum == 0) {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    // Skip duplicate values for left and right pointers
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    
                    left++;
                    right--;
                } else if (sum < 0) {
                    left++;  // Need a larger sum
                } else {
                    right--;  // Need a smaller sum
                }
            }
        }
        
        return result;
    }
}