public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> result = new List<int>();
        if (matrix == null || matrix.Length == 0) return result;

        int top = 0;
        int bottom = matrix.Length  - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while(top <= bottom && left <= right)
        {
            // Traverse from left to right along the top row
            for (int i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);
            }
            top++;

            // Traverse downwards along the right column
            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;

            if (top <= bottom)
            {
                // Traverse from right to left along the bottom row
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }

            if (left <= right)
            {
                // Traverse upward along the left column
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }

        return result;
    }
}