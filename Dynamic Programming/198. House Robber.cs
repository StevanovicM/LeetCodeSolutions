public class Solution {
    public int Rob(int[] nums) {
        int last, now = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            last = now;
            now = Math.Max(last + i, now);
        }

        return now;
    }
}