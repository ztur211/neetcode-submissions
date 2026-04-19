public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int numsLength = nums.Length;
        int[] ans = new int[2 * numsLength];
        for (int i = 0; i < numsLength; i++)
        {
            ans[i] = nums[i];
            ans[i + numsLength] = nums[i];
        }
        return ans;
    }
}