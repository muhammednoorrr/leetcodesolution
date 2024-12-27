public class Solution {
    public string AddBinary(string a, string b) {
        int carry = 0;
            string result = "";
//add zeros to shortest number's left for iterarion
            if (a.Length < b.Length)
                a = a.PadLeft(b.Length, '0');
            else
                b = b.PadLeft(a.Length, '0');
//start from end and calculate the current indices with carry

            for(int i = a.Length - 1; i >= 0; i--)
            {
                var tempA = char.GetNumericValue(a[i]);
                var tempB = char.GetNumericValue(b[i]);
//then get mod 2 for binary sum
                result = ((carry+ tempA + tempB)%2)+result;
//you need to calculate the carry for next iteration with 
//total sum is bigger or equal then 2 if its correct assign to 1
                carry = (carry + tempA + tempB) >= 2 ? 1 : 0;
                    
            }
//if carry has 1 then return result with carry, else just return result.
            return carry != 0 ? carry+result:result ;
    }
}