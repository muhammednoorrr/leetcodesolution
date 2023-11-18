public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] newone = new int[nums.Length];
        for(int i = 0,j=0;i<nums.Length-n;i++,j++)
        {  
            newone[j] = nums[i];
            newone[++j]= nums[n+i];
        }

        return newone;
    }
}