public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0)
        {
            return new List<IList<string>>();   
        }

        // Dictionary to hold the grouped anagrams
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            // Sort the string to use as key
            char[] characters = s.ToCharArray();
            Array.Sort(characters);
            string sorted = new string(characters);

            // If the sorted string is not already a key, add it
            if (!anagramGroups.ContainsKey(sorted)) 
            {
                anagramGroups[sorted] = new List<string>();
            }

            // Add the original string to the correct group
            anagramGroups[sorted].Add(s);
        }

        // Prepare the output format
        IList<IList<string>> result = new List<IList<string>>();
        foreach (var group in anagramGroups.Values)
        {
            result.Add(group);
        }

        return result;
    }
}