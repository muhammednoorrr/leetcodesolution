public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        
        foreach (int num in nums) {
            if (numSet.Contains(num)) {
                numSet.Remove(num);
            } else {
                numSet.Add(num);
            }
        }
        
        // After the loop, the HashSet should contain the single number
        foreach (int result in numSet) {
            return result;
        }
        
        // Handle the case when there's no single number (not required in the given problem)
        return -1;
    }
}
