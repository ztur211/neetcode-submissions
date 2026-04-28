public class Solution {
    public bool IsValid(string s) {
        Stack<char> check = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                check.Push(s[i]);
            } else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
            {
                if (check.Count == 0)
                {
                    return false;
                }
                if (
                    (check.Peek() == '(' && s[i] != ')') || 
                    (check.Peek() == '{' && s[i] != '}') || 
                    (check.Peek() == '[' && s[i] != ']'))
                {
                    return false;
                }
                check.Pop();
            }
        }
        if (check.Count == 0)
        {
            return true;
        } else {
            return false;
        }
    }
}
