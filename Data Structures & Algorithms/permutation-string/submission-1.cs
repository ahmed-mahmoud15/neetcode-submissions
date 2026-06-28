public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length){
            return false;
        }
        int[] countS1 = new int[26];
        foreach(char c in s1){
            countS1[c - 'a']++;
        }
        int k = s1.Length;
        int[] window = new int[26];
        for(int i = 0; i < k; i++){
            window[s2[i] - 'a']++;
        }
        int left = 0;
        if(window.SequenceEqual(countS1)){
            return true;
        }
        for(int right = k; right < s2.Length; right++){
            window[s2[left] - 'a']--;
            left++;
            window[s2[right] - 'a']++;
            if(window.SequenceEqual(countS1)){
                return true;
            }
        }
        return false;
    }
}
