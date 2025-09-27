// C# program to reorder a linked list
// LeetCode Problem: https://leetcode.com/problems/reorder-list/
// Time Complexity: O(N)
public class Solution
{
    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null) return;

        ListNode mid = FindMiddleNode(head);
        ListNode secondHalf = ReverseList(mid.next);
        mid.next = null;

        MergeLists(head, secondHalf);
    }

    private ListNode FindMiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null && fast.next.next!=null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    private ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    private void MergeLists(ListNode first, ListNode second)
    {
        while (first != null && second != null)
        {
            ListNode firstNext = first.next;
            ListNode secondNext = second.next;

            first.next = second;
            second.next = firstNext;

            first = firstNext;
            second = secondNext;
        }
    }
}