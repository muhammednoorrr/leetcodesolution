/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    let n = s.length;
    let maxLength = 0;
    let lastIndex = new Map();
    
    let start = 0;
    for (let end = 0; end < n; end++) {
        let currentChar = s[end];
        start = Math.max(start, lastIndex.get(currentChar) || 0);
        maxLength = Math.max(maxLength, end - start + 1);
        lastIndex.set(currentChar, end + 1);
    }
    
    return maxLength;
};