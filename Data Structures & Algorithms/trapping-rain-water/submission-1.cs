public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int[] prefix = new int[n];
        int[] postfix = new int[n];

        for(int i = 1; i < n; i++){
            prefix[i] = Math.Max(prefix[i - 1], height[i - 1]);
        }
        for(int i = n - 2; i >= 0; i--){
            postfix[i] = Math.Max(postfix[i + 1], height[i + 1]);
        }

        int result = 0;

        for(int i = 0; i < n; i++){
            if(prefix[i] == 0 || postfix[i] == 0){
                continue;
            }
            int min = Math.Min(prefix[i], postfix[i]);
            if(min < height[i]){
                continue;
            }
            result += min - height[i];
        }
        return result;
    }
}
