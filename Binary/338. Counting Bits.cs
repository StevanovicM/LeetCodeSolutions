public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];

        for (int i = 1; i <= n; i++)
        {
            // i >> 1 is equivalent to dividing i by 2.
            // i & 1 is 1 if i is odd, and 0 if it is even.
            result[i] = result[i >> 1] + (i & 1);
        }
        return result;
    }
}