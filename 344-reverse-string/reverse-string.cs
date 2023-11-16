public class Solution {
    public void ReverseString(char[] s) {
              
        for(int i=0;i<s.Length/2; i++)
        {
            var temp = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = s[i];
            s[i] = temp;
        }  
    }
}