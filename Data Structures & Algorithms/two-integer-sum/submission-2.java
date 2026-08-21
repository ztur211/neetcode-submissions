class Solution {
    public int[] twoSum(int[] nums, int target) {

        HashMap<Integer, Integer> hashMap = new HashMap<Integer, Integer>();

        for (int i = 0; i < nums.length; i++) {
            int sum = target - nums[i];
            if (hashMap.containsKey(sum)) {
                return new int[]{hashMap.get(sum), i}; // Always smallest index first
            }
            hashMap.put(nums[i], i);
        }
        return null;
    }
}
