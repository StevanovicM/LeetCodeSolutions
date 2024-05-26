public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLength = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        int left = 0;

        for(int right = 0; right < n; right++)
        {
            char currentChar = s[right];

            if (map.ContainsKey(currentChar))
            {
                // Update the left pointer to skip the repeating character
                left = Math.Max(left, map[currentChar] + 1);
            }

            // Update or add the current character's position to the map
            map[currentChar] = right;

            // Calculate the current length of the substring
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}