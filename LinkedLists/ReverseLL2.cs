// C# program to reverse a linked list between given positions
// LeetCode Problem: https://leetcode.com/problems/reverse-linked-list-ii/
// Time Complexity: O(N)
public class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head == null || left == right) return head;

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;

        // Move prev to the node before the left position
        for (int i = 1; i < left; i++)
        {
            prev = prev.next;
        }

        ListNode curr = prev.next;
        ListNode next = null;

        // Reverse the segment from left to right
        for (int i = 0; i < right - left; i++)
        {
            next = curr.next;
            curr.next = next.next;
            next.next = prev.next;
            prev.next = next;
        }

        return dummy.next;
    }
}