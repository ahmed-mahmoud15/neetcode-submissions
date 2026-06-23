public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int left = 0;
        int right = 1;

        while(right < prices.Length){
            if(prices[right] > prices[left]){
                result = Math.Max(result, prices[right] - prices[left]);
            }else{
                left = right;
            }
            right++;
        }
        return result;
    }
}
