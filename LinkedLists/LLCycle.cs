// Concept --> Linked List Cycle Detection using Floyd's Tortoise and Hare Algorithm
// C# Program to detect cycle in a linked list
// LeetCode Problem --> https://leetcode.com/problems/linked-list-cycle/
// Time Complexity --> O(N)
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) return true;
        }
        return false;
    }
}