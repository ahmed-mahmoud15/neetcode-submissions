public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs){
            sb.Append(str.Length);
            sb.Append('|');
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while(i < s.Length){
            int len = 0;
            while(s[i] != '|'){
                len = 10 * len + (s[i] - '0');
                i++;
            }
            i++;
            result.Add(new string(s.Substring(i, len)));
            i += len;
        }
        return result;
   }
}
