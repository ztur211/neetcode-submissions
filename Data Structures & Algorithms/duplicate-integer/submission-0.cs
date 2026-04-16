public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> uniqueNums = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (uniqueNums.ContainsValue(nums[i]))
            {
                return true;
            }
            uniqueNums.Add(i, nums[i]);
        }
        return false;
    }
}