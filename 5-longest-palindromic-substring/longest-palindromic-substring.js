/**
 * @param {string} s
 * @return {string}
 */

function expendAroundCenter(s, left, right) {
    while(left >= 0 && right < s.length && s[left] === s[right]) {
        left--;
        right++;
    }
    return s.substring(left + 1, right);
}
var longestPalindrome = function(s) {
    if(s.length === 0) return ""; 

    let longest = "";

    for(let i = 0; i < s.length; i++) {
        let odd = expendAroundCenter(s, i, i);
        let even = expendAroundCenter(s, i, i+1);

        if(odd.length > longest.length) longest = odd;
        if(even.length > longest.length) longest = even;
    }

    return longest;

};