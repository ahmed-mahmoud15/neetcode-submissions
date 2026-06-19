public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int[]> list = new List<int[]>();
        for(int i = 0; i < nums.Length; i++){
            list.Add(new int[]{nums[i], i});
        }
        list.Sort( (a, b) => a[0].CompareTo(b[0]));
        int left = 0;
        int right = list.Count - 1;
        while(left < right){
            if(list[left][0] + list[right][0] == target){
                return new int[] {
                    Math.Min(list[left][1], list[right][1]),
                    Math.Max(list[left][1], list[right][1])
                };
            }
            if(list[left][0] + list[right][0] > target){
                right--;
            }else{
                left++;
            }
        }
        return new int[0];
    }
}
