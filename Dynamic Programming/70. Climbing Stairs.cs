public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) {
            return 1;
        }

        int first = 1;
        int second = 1;

        for (int i = 2; i <= n; i++)
        {
            int third = first + second;
            first = second;
            second = third;
        }

        return second;
    }
}