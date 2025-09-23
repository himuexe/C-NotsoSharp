// C# program to remove Nth node from end of linked list
// LeetCode Problem: https://leetcode.com/problems/remove-nth-node-from-end-of-list/
// Time Complexity: O(N)
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
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int size = 0;
        ListNode curr = head;
        while (curr != null)
        {
            curr = curr.next;
            size++;
        }
        if (n == size)
        {
            head = head.next;
            return head;
        }
        curr = head;
        for (int i = 0; i < size - n - 1; i++)
        {
            curr = curr.next;
        }
        curr.next = curr.next.next;
        return head;
    }
}