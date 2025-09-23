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
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
}