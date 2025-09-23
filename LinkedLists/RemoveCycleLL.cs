 // C# program to remove a cycle in a linked list if it exists
 // LeetCode Problem: https://leetcode.com/problems/linked-list-cycle-ii/
 // Time Complexity: O(N)
 void RemoveCycle(ListNode head) {
    if (head == null || head.next == null) return;
    
    ListNode slow = head;
    ListNode fast = head;
    bool hasCycle = false;
    
    while (fast != null && fast.next != null) {
        slow = slow.next;
        fast = fast.next.next;
        if (slow == fast) {
            hasCycle = true;
            break;
        }
    }
    
    if (!hasCycle) return;
    
    slow = head;
    while (slow.next != fast.next) {
        slow = slow.next;
        fast = fast.next;
    }
    
    fast.next = null;
}