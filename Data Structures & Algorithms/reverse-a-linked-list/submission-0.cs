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
    public ListNode ReverseList(ListNode head) {
        ListNode curr = head;
        ListNode prev = null;
        ListNode temp;
        while (curr != null)
        {
            // Temp stores the next node
            temp = curr.next;
            // Pointer is reversed
            curr.next = prev;
            // Move prev forward
            prev = curr;
            // Move curr forward
            curr = temp;
        }
        return prev;
    }
}
