// C# program to reverse nodes in k-group in a linked list
// LeetCode Problem: https://leetcode.com/problems/reverse-nodes-in-k-group/
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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode curr = head;
        int count = 0;
        while (curr != null && count < k)
        {
            curr = curr.next;
            count++;
        }
        if (count == k)
        {
            ListNode reversedHead = reverseLinkedList(head, k);
            head.next = ReverseKGroup(curr, k);
            return reversedHead;
        }
        return head;
    }
    private ListNode reverseLinkedList(ListNode head, int k)
    {
        ListNode prev = null;
        ListNode curr = head;
        while (k > 0)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
            k--;
        }
        return prev;
    }
}