public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minBuy = prices[0];
        foreach(int sell in prices){
            maxProfit = Math.Max(maxProfit, sell - minBuy);
            minBuy = Math.Min(minBuy, sell);
        }
        return maxProfit;
    }
}
