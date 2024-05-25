public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            // Calculating the area
            int minHeight = Math.Min(height[left], height[right]);
            int width = right - left;
            int currentArea = minHeight * width;

            // Update max area found
            maxArea = Math.Max(maxArea, currentArea);

            // Move the pointer pointing to the shorter line
            if (height[left] < height[right])
            {
                left++;
            }
            else 
            {
                right--;
            }
        }

        return maxArea;
    }
}