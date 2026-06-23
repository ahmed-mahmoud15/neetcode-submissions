public class Solution {
    public int CharacterReplacement(string s, int k) {
        int result = 0;
        for (int i = 0; i < 26; i++) {
            char currentTarget = (char)('A' + i);
            int replacements = 0;
            int left = 0;
            for (int right = 0; right < s.Length; right++) {
                if (s[right] != currentTarget) {
                    replacements++;
                }
                while (replacements > k) {
                    if (s[left] != currentTarget) {
                        replacements--;
                    }
                    left++;
                }
                result = Math.Max(result, right - left + 1);
            }
        }
        return result;
    }
}