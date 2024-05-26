public class Solution {
    public int GetSum(int a, int b) {
        while (b != 0) {
            // Temporary variable to hold carry
            int carry = (a & b) <<  1;

            // Perform adition without carry
            a = a ^ b;

            // Move carry to b and add in next step
            b = carry;
        }

        return a;
    }
}