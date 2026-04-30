public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int left = 0;
        int right = 1;
        int counter = 0;

        while (right < prices.Length)
        {
            if (prices[right] > prices[left])
            {
                counter = prices[right] - prices[left];
                result = (counter > result) ? counter : result;
            }
            else
            {
                left = right;
            }
            right += 1;
        }
        return result;
    }
}
