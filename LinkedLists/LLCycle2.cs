// Concept --> Linked List Cycle Detection and Finding the Starting Node of the Cycle using Floyd's Tortoise and Hare Algorithm
// C# Program to detect the starting node of a cycle in a linked list
// LeetCode Problem --> https://leetcode.com/problems/linked-list-cycle-ii/
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
    public ListNode DetectCycle(ListNode head)
    {
        ListNode slow = head, fast = head;
        bool hasCycle = false;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                hasCycle = true;
                break;
            }
        }
        if (!hasCycle) return null;
        slow = head;
        while (slow != fast)
        {
            slow = slow.next;
            fast = fast.next;
        }
        return slow;
    }
}