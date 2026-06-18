public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        
        Dictionary<char, int> anagram = new Dictionary<char, int>();
        foreach(char c in s){
            if(anagram.ContainsKey(c)){
                anagram[c]++;
            }else{
                anagram[c] = 1;
            }
        }

        foreach(char c in t){
            if(!anagram.ContainsKey(c)){
                return false;
            }
            if(anagram[c] == 0){
                return false;
            }
            anagram[c]--;
        }
        return true;
    }
}
