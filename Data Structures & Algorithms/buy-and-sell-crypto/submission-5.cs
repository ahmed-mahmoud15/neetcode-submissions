public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int min = prices[0];
        int max = prices[0];

        foreach(int price in prices){
            if(price < min){
                min = price;
                max = 0;
            }else if(price > max){
                max = price;
            }
            result = Math.Max(result, max - min);
        }
        return result;
    }
}
