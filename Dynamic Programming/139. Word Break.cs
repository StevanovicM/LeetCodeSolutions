public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> wordDictSet = new HashSet<string>(wordDict);
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true; // Base case: empty string

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (dp[j] && wordDictSet.Contains(s.Substring(j, i - j)))
                {
                    dp[i] = true;
                    break; // No need to check further if we already found a valid split
                }
            }
        }

        return dp[s.Length];
    }
}