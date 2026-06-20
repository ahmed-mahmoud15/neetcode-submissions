public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach(int num in nums){
            set.Add(num);
        }

        int streak = 0;
        foreach(int num in set){
            int count = 1;
            while(set.Contains(num - count)){
                count++;
            }
            streak = Math.Max(count, streak);
        }
        return streak;
    }
}
