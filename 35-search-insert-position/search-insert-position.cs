public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        
        while (left <= right) {
            int mid = left + (right - left) / 2;
            
            if (nums[mid] == target) {
                return mid; // Target found
            } else if (nums[mid] < target) {
                left = mid + 1; // Search in the right half
            } else {
                right = mid - 1; // Search in the left half
            }
        }
        
        return left; // If target not found, return insertion position
    }
}