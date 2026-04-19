public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            int i = 0;
            int[] result = new int[2];
            int compare = 0;
            // numsDict<i, nums[i]>
            Dictionary<int, int> numsDict = new Dictionary<int, int>();
            for (int j = 0; j < nums.Length; j++)
            {
                compare = target - nums[j];
                // Check if result is possible
                if (numsDict.ContainsValue(compare))
                {
                    result[0] = numsDict.FirstOrDefault(x => x.Value == compare).Key;
                    result[1] = j;
                } else {
                    // Add index and value of each nums[] till result is found
                    numsDict.Add(i, nums[i]);
                    i++;
                }
            }
            return result;
    }
}