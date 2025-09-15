public class Solution {
    public ListNode FindMid(ListNode head){
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null && fast.next.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
    
    public ListNode Reverse(ListNode head){
        ListNode prev = null;
        ListNode curr = head;
        while(curr != null){
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
    
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null) return true;

        ListNode mid = FindMid(head);
        ListNode secondHalf = mid.next;
        mid.next = null;

        ListNode rightHead = Reverse(secondHalf);
        ListNode leftHead = head;
        
        while (rightHead != null)
        {
            if (rightHead.val != leftHead.val) return false;
            rightHead = rightHead.next;
            leftHead = leftHead.next;
        }
        return true;
    }
}