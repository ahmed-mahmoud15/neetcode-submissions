public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        foreach(int num in nums){
            countMap[num] = countMap.GetValueOrDefault(num, 0) + 1;
        }
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var entry in countMap){
            pq.Enqueue(entry.Key, -entry.Value);
        }
        int[] result = new int[k];
        for(int i = 0; i < k; i++){
            result[i] = pq.Dequeue();
        }
        return result;
    }
}
