public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> compareS = new Dictionary<char, int>();
        Dictionary<char, int> compareT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            // Increase value by 1 if char is already in dictionary
            compareS[s[i]] = compareS.GetValueOrDefault(s[i], 0) + 1;
            compareT[t[i]] = compareT.GetValueOrDefault(t[i], 0) + 1;
        }
        // If dictionaries are the same, return true
        return compareS.Count == compareT.Count && !compareS.Except(compareT).Any();
    }
}
