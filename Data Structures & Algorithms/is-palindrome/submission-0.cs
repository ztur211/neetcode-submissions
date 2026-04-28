public class Solution {
    public bool IsPalindrome(string s) {
        int j = s.Length - 1;
        for (int i = 0; i < j; i++)
        {
            // Check that i is still less than j after i or j changes
            while (i < j && char.IsLetterOrDigit(s[i]) == false)
            {
                i++;
            }
            while (i < j && char.IsLetterOrDigit(s[j]) == false)
            {
                j--;
            }
            // Ignore case
            if (char.ToLower(s[i]) == char.ToLower(s[j]))
            {
                j--;
            } else {
                return false;
            }
        }
        return true;
    }
}
