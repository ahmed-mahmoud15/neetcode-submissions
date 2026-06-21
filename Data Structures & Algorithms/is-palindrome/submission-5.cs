public class Solution {
    public bool IsPalindrome(string s) {
        var filtered =  s.Where(c => char.IsLetterOrDigit(c)).Select(c => char.ToUpperInvariant(c));
        return filtered.SequenceEqual(filtered.Reverse());
    }
}
