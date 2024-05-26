public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] charCount = new int[26]; // Frequency array for A-Z
        int maxFreq = 0, maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            charCount[s[right] - 'A']++; // Increment the frequency of the current character
            maxFreq = Math.Max(maxFreq, charCount[s[right] - 'A']); // Update the max frequency

            // Window size minus the most frequent element gives us the number of chars to change
            while (right - left + 1 - maxFreq > k)
            {
                charCount[s[left] - 'A']--; // Reduce count of the character going out of the window
                left++; // Shrink the window from the left
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}