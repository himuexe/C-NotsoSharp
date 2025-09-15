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
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        ListNode slow=head , fast = head;
        bool hasCycle = false;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            if(slow==fast){
                hasCycle = true;
                break;
            }
        }
        if(!hasCycle)return null;
        slow = head;
        while(slow !=fast){
            slow=slow.next;
            fast=fast.next;
        }
        return slow;
    }
}