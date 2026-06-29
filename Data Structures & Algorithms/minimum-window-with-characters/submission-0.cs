public class Solution {
    public string MinWindow(string s, string t) {
        if(t == ""){
            return "";
        }
        Dictionary<char, int> tCount = new Dictionary<char, int>();
        foreach(char c in t){
            tCount[c] = tCount.GetValueOrDefault(c, 0) + 1;
        }

        Dictionary<char, int> window = new Dictionary<char, int>();
        int have = 0;
        int need = tCount.Keys.Count;
        int start = -1;
        int end = -1;
        int resultLength = int.MaxValue;
        int left = 0;
        for(int right = 0; right < s.Length; right++){
            window[s[right]] = window.GetValueOrDefault(s[right], 0) + 1;
            if(tCount.ContainsKey(s[right]) && window[s[right]] == tCount[s[right]]){
                have++;
            }
            while(have == need){
                if(right - left + 1 < resultLength){
                    resultLength = right - left + 1;
                    start = left;
                    end = right;
                }

                window[s[left]]--;
                if(tCount.ContainsKey(s[left]) && window[s[left]] < tCount[s[left]]){
                    have--;
                }
                left++;
            }
        }
        return resultLength == int.MaxValue ? "" : s.Substring(start, resultLength);
    }
}
