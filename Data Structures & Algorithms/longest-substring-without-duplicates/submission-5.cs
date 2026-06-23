public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> window = new Dictionary<char, int>();
        int left = 0;
        int result = 0;
        for(int right = 0; right < s.Length; right++){
            if(window.ContainsKey(s[right])){
                left = Math.Max(left, window[s[right]] + 1);
            }
            window[s[right]] = right;
            result = Math.Max(result, right - left + 1);
        }
        return result;
    }
}
