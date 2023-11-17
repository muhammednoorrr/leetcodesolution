public class Solution {
    public char FindTheDifference(string s, string t) {
        var sum = 0;
        var len = s.Length;
        for(int i = 0; i < len; i++) {
            sum += t[i];
            sum -= s[i];
        }
        return (char)(sum + t[len]);
    }
}