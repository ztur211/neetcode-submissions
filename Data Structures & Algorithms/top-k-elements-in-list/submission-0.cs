public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int max = 0;
        int[] result = new int[k];
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];
        int i = 0;
        int j = 0;

        // Add lists to each index in freq  
        for (i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }

        // Track number of times each value appears using key as number, value as counter
        for (i = 0; i < nums.Length; i++)
        {
            if (count.ContainsKey(nums[i]))
            {
                count[nums[i]]++;
            } else
            {
                count[nums[i]] = 1;
            }
        }

        // Add numbers into groups based on their counter
        foreach (var pair in count)
        {
            freq[pair.Value].Add(pair.Key);
        }

        // Loop through most common values till k number of items exist in result
        for (i = nums.Length; i > 0 && j < k; i--)
        {
            for (int l = 0; l < freq[i].Count; l++)
            {
                result[j++] = freq[i][l];
                if (j == k)
                {
                    return result;
                }
            }
        }
        return result;
    }
}
