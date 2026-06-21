public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while(left < right){
            while(left < right && !char.IsLetterOrDigit(s[left])){
                left++;
            }
            while(left < right && !char.IsLetterOrDigit(s[right])){
                right--;
            }
            if(char.ToUpperInvariant(s[left]) == char.ToUpperInvariant(s[right])){
                left++;
                right--;
            }else{
                return false;
            }
        }
        return true;
    }
}
