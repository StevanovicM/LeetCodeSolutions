public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var numMap = new Dictionary<int, int>();
        var result = new int[2];

        for (var i = 0; i < nums.Length; i++) {
            var rightNum = target - nums[i];
            if (!numMap.ContainsKey(rightNum)) {
                numMap[nums[i]] = i;
                rightNum = 0;
            } else {
                result[0] = numMap[rightNum];
                result[1] = i;
                return result;
            }
        }

        return result;
    }
}