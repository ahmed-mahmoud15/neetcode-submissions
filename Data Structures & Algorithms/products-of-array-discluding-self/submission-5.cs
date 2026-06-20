public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int zeroCount = 0;

        foreach(int num in nums){
            if(num == 0){
                zeroCount++;
            }else{
                product *= num;
            }
        }

        if(zeroCount > 1){
            return new int[nums.Length];
        }

        int[] result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            if(zeroCount > 0){ // only one zero
                result[i] = (nums[i] == 0) ? product : 0;
            }else{
                result[i] = product / nums[i];
            }
        }
        return result;
    }
}
