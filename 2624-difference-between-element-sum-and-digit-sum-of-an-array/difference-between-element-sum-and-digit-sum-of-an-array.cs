public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int digit_Sum = 0;
        int element_Sum = 0;

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int[] dig_Array = new int[num.ToString().Length]; // Initialize the array

            while (num != 0) {
                for (int k = 0; k < dig_Array.Length; k++) {
                    dig_Array[k] = num % 10;
                    num /= 10;
                }
            }

            digit_Sum += nums[i];
            for (int j = 0; j < dig_Array.Length; j++) {
                element_Sum += dig_Array[j];
            }
        }

        int absolute_Difference = Math.Abs(digit_Sum - element_Sum); // Use Math.Abs to get the absolute difference
        return absolute_Difference;
    }
}
