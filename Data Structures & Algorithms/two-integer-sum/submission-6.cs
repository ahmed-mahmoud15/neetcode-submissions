public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int other = target - nums[i];
            if(map.ContainsKey(other) && map[other] != i){
                return new int[] {map[other], i};
            }
            map[nums[i]] = i;
        }
        return new int[2];
    }
}
