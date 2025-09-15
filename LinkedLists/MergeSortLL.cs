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
    private ListNode GetMid(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
       
        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null) return head;
       
        ListNode mid = GetMid(head);
        ListNode rightHead = mid.next;
        mid.next = null;
       
        ListNode left = SortList(head);
        ListNode right = SortList(rightHead);
       
        return Merge(left, right);
    }
    
    private ListNode Merge(ListNode head1, ListNode head2) {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;
       
        while (head1 != null && head2 != null) {
            if (head1.val <= head2.val) {
                current.next = head1;
                head1 = head1.next;
            } else {
                current.next = head2;
                head2 = head2.next;
            }
            current = current.next;
        }
       
        if (head1 != null) {
            current.next = head1;
        } else {
            current.next = head2;
        }
       
        return dummy.next;
    }
}