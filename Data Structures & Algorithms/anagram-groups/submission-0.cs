public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();
        // Loop through each string in array
        for (int i = 0; i < strs.Length; i++)
        {
            // Count number of times each character appears in string
            // strs[i] is made up of lowercase English letters => int[26]
            int[] counter = new int[26];
            // Loop through each character in string
            for (int j = 0; j < strs[i].Length; j++)
            {
                // Increase number each time a character appears
                counter[strs[i][j] - 'a']++;
            }
            string key = string.Join(",", counter);
            if (!result.ContainsKey(key))
            {
                result[key] = new List<string>();
            }
            // Add string to list if key is matching
            result[key].Add(strs[i]);
        }
        return result.Values.Select(x => x).ToList();
    }
}