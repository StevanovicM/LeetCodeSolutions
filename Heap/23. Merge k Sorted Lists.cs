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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) return null;

        // Priority queue sorted by node values
        var heap = new SortedSet<(int, int, ListNode)>(Comparer<(int, int, ListNode)>.Create((a, b) => {
            if (a.Item1 != b.Item1) return a.Item1.CompareTo(b.Item1);
            return a.Item2.CompareTo(b.Item2); // Tie-breaker using unique index
        }));

        // Initialize the heap with the head of each non-null list
        for (int i = 0; i < lists.Length; i++) 
        {
            if (lists[i] != null) 
            {
                heap.Add((lists[i].val, i, lists[i]));
            }
        }

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        // Process the nodes in the heap
        while (heap.Count > 0)
        {
            var (val, idx, node) = heap.Min;
            heap.Remove(heap.Min);

            // Append the smallest node to the result
            tail.next = node;
            tail = tail.next;

            // Insert the next node from the same list into the heap
            if (node.next != null)
            {
                heap.Add((node.next.val, idx, node.next));
            }
        }

        return dummy.next;
    }
}