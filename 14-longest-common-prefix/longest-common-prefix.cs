public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return "";
        }
        
        // Take the first string as the initial prefix
        string prefix = strs[0];
        
        // Iterate through the array of strings
        for (int i = 1; i < strs.Length; i++) {
            // Compare each character of the prefix with the corresponding character in the current string
            int j = 0;
            while (j < prefix.Length && j < strs[i].Length && prefix[j] == strs[i][j]) {
                j++;
            }
            
            // Update the prefix to be the common part
            prefix = prefix.Substring(0, j);
            
            // If the prefix becomes empty, there is no common prefix, so return immediately
            if (prefix == "") {
                return "";
            }
        }
        
        return prefix;
    }
}
