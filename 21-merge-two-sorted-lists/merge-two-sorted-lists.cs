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
    public ListNode MergeTwoLists(ListNode headA, ListNode headB) {
        //Base case is, we arrived at the end of one of the lists.
        if (headA == null)
            return headB;
        else if (headB == null)
            return headA;

        ListNode res = null;

        if (headA.val < headB.val)
        {
            res = headA;
            res.next = MergeTwoLists(headA.next, headB);
        }
        else
        {
            res = headB;
            res.next = MergeTwoLists(headA, headB.next);
        }

        return res;
    }
}