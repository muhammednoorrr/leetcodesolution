public class Solution {
    public bool IsPalindrome(int x) {
        // Special cases: negative numbers and numbers ending in 0 (excluding 0 itself)
        if (x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }

        int reversedHalf = 0;

        // Reverse the second half of the number
        while (x > reversedHalf) {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }

        // If the length of the number is odd, we need to remove the last digit from reversedHalf
        return x == reversedHalf || x == reversedHalf / 10;
    }
}
