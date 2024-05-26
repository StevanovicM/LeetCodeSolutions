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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // Initialize a dummy node to simplify edge cases where we might remove the head
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode fast = dummy;
        ListNode slow = dummy;

        // Move the fast pointer n steps ahead
        for (int i = 0; i <= n; i++)
        {
            fast = fast.next;
        }

        // Move both pointers until fast reaches the end
        while (fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        // Now slow is at the node before the node to be removed
        slow.next = slow.next.next;

        // Return the new head, which might be the original or the next if the head was removed
        return dummy.next;
    }
}