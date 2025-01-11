public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int> merged = new List<int>();
        int i = 0, j = 0;
        
        while (i < nums1.Length && j < nums2.Length) {
            if (nums1[i] < nums2[j]) {
                merged.Add(nums1[i++]);
            } else {
                merged.Add(nums2[j++]);
            }
        }
        
        while (i < nums1.Length) merged.Add(nums1[i++]);
        while (j < nums2.Length) merged.Add(nums2[j++]);
        
        int mid = merged.Count / 2;
        if (merged.Count % 2 == 0) {
            return (merged[mid-1] + merged[mid]) / 2.0;
        } else {
            return merged[mid];
        }
    }
}