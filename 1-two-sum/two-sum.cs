public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (numDict.ContainsKey(complement)) {
                return new int[] { numDict[complement], i };
            }

            numDict[nums[i]] = i;
        }

        // If no solution is found, you may throw an exception or return null based on your requirements
        throw new ArgumentException("No solution found");
    }
}
