public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        List<int> lesserNums = new List<int>();
        int count;
        for (int i = 0; i < nums.Length; i++) {
            count = 0; // Reset count for each element
            for (int j = 0; j < nums.Length; j++) {
                if (nums[j] < nums[i]) {
                    count += 1;
                }
            }
            lesserNums.Add(count);
        }
        return lesserNums.ToArray();
    }
}
