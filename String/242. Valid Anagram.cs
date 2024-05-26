public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var charMap = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charMap.ContainsKey(c))
            {
                charMap[c]++;
            }
            else
            {
                charMap[c] = 1;
            }
        }

        foreach (char c in t)
        {
            if (!charMap.ContainsKey(c)) return false; // Character t not found in s
            if (--charMap[c] < 0) return false; // More of character c in t than in s
        }

        return true;
    }
}