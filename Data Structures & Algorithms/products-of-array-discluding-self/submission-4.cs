public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

        int[] prefix = new int[n];
        prefix[0] = nums[0];
        for(int i = 1; i < n; i++){
            prefix[i] = prefix[i - 1] * nums[i];
        }

        int[] postfix = new int[n];
        postfix[n - 1] = nums[n - 1];
        for(int i = n - 2; i >= 0; i--){
            postfix[i] = postfix[i + 1] * nums[i];
        }

        int[] result = new int[n];
        result[0] = postfix[1];
        result[n - 1] = prefix[n - 2];

        for(int i = 1; i < n - 1; i++){
            result[i] = prefix[i - 1] * postfix[i + 1];
        }
        return result;
    }
}
