public class Solution {
    public int[] FindErrorNums(int[] nums) {
        //take a set and take a list
        //initialize the list with nums
        //take a for loop and see if there are duplicates using set
        //or, there are missing using list
        var dm=new int[2];
        var set=new HashSet<int>();
        var list=new List<int>(nums);
        int duplicate=-1,missing=-1;
        for(int i=0;i<nums.Length;i++)
        {
            if(set.Add(nums[i])==false)
                duplicate=nums[i];
            if(list.Contains(i+1)==false)
                missing=i+1;
        }
        return new int[] {duplicate,missing};
    }
}