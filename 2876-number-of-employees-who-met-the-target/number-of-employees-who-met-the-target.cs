public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int count=0;
        foreach(var hr in hours){
            if(hr>= target){
                count++;
            }
        }
        return count;
    }
}