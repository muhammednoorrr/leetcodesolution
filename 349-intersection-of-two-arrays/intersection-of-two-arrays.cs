public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var set1 = nums1.ToHashSet();
        var set2 = nums2.ToHashSet();

        set1.IntersectWith(set2);

        return set1.ToArray();
    }
}