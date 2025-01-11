/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        //Convert both ListNodes to strings
        string strL1 = "";
        string strL2 = "";
        MakeStrings(l1,l2,ref strL1, ref strL2);

        //We add two values from rows to the third row(the amount is reversed)
        string easyAnswer = Sum(strL1, strL2);

        //Create an integer array 
        int[] answer = new int[easyAnswer.Length];
        //Add a value to it element by element 
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = Convert.ToInt32(easyAnswer[i].ToString());
        }
        //Reverse it
        Array.Reverse(answer);

        //Write the resulting value in the ListNode form
        int counter = 0;
        ListNode solution = NewListnode(answer, counter);
    return solution;
    }

    public void MakeStrings(ListNode l1, ListNode l2, ref string strL1, ref string strL2) {
        ListNode temp1 = l1;
        ListNode temp2 = l2;
        do
        {
            if (temp1 != null)
            {
                strL1 += Convert.ToString(temp1.val);
                temp1 = temp1.next;
            }
            if (temp2 != null)
            {
                strL2 += Convert.ToString(temp2.val);
                temp2 = temp2.next;
            }
        }
        while (temp1 != null || temp2 != null);
    }

    string Sum(string strL1, string strL2) {

        char[] ch1 = strL1.ToCharArray();
        char[] ch2 = strL2.ToCharArray();

        Array.Reverse(ch1);
        Array.Reverse(ch2);

        int[] int1 = new int[ch1.Length];
        int[] int2 = new int[ch2.Length];
  
        for (int i = 0; i < int1.Length; i++)
        {
            int1[i] = Convert.ToInt32(ch1[i].ToString());
        }
        for (int i = 0; i < int2.Length; i++)
        {
            int2[i] = Convert.ToInt32(ch2[i].ToString());
        }
        string summ = "";

        int maxLength = int1.Length>int2.Length? int1.Length:int2.Length;
        int counter = 1;
        do
        {
            int firstOperand = 0, secondOperand = 0;
            if ((int1.Length - counter) >= 0)
                firstOperand = int1[int1.Length - counter];
            if ((ch2.Length - counter) >= 0)
                secondOperand = int2[int2.Length - counter];
             int sum = firstOperand + secondOperand;

            if (sum > 9)
            {
                summ += (sum % 10).ToString();
                if (int1.Length - (counter + 1) >= 0)
                    int1[int1.Length - (counter + 1)]++;

                else if (int2.Length - (counter + 1) >= 0)
                    int2[int2.Length - (counter + 1)]++;
            else
                summ += "1";
            }
            else
                summ += sum.ToString();
            counter++;
        }
        while (!(counter > int1.Length) || !(counter > int2.Length));
        char[] toReverse = summ.ToCharArray();

        Array.Reverse(toReverse);

        return new string(toReverse);
    }

    ListNode NewListnode(int[] answer, int counter) {
        if ((counter + 1) <= answer.Length){
            return new ListNode(answer[counter], NewListnode(answer, counter+1));
        }
    return null;
    }
}