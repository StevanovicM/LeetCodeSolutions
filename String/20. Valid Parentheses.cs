public class Solution {
    public bool IsValid(string s) {
        // Using a stack to track open parentheses
        Stack<char> stack = new Stack<char>();

        // Dictionary to hold the matching pairs
        Dictionary<char, char> matchingBrackets = new Dictionary<char, char>()
        {
            { ')', '('},
            { ']', '['},
            { '}', '{'}
        };

        foreach (char ch in s)
        {
            if (matchingBrackets.ContainsKey(ch))
            {
                // If current char is a closing bracket and (stack is empty or top of the stack is not the matching opening bracket)
                if (stack.Count == 0 || stack.Pop() != matchingBrackets[ch])
                {
                    return false;
                }
            }
            else {
                // It's an opening bracket, push to stack
                stack.Push(ch);
            }
        }

        // If stack is empty, all opening brackets have been matched
        return stack.Count == 0;
    }
}