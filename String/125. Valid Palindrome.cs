public class Solution {
    public bool IsPalindrome(string s) {
        // Building the simplified version of the string
        StringBuilder cleanStr = new StringBuilder();
        foreach (char ch in s)
        {
            if (char.IsLetterOrDigit(ch))
            {
                cleanStr.Append(char.ToLower(ch));
            }
        }

        // Convert StringBuilder to string
        string filteredStr = cleanStr.ToString();

        // Check if the filtered string is a palindrome
        int left = 0;
        int right = filteredStr.Length - 1;
        while (left < right)
        {
            if (filteredStr[left] != filteredStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}