// C# program to reverse a Doubly Linked List
// GeeksforGeeks Problem: https://practice.geeksforgeeks.org/problems/reverse
// Time Complexity: O(N)
/*
public class Node {
    public int data;
    public Node next;
    public Node prev;

    public Node(int val) {
        data = val;
        next = null;
        prev = null;
    }
}
*/
public class Solution
{
    public Node reverse(Node head)
    {
        // code here
        if (head == null || head.next == null)
            return head;

        Node current = head;
        Node temp = null;

        while (current != null)
        {
            // Swap next and prev pointers
            temp = current.prev;
            current.prev = current.next;
            current.next = temp;

            // Move to the next node in the original list
            current = current.prev; // because we swapped, move to prev
        }

        // After the loop, temp will be at the new head
        if (temp != null)
            head = temp.prev; // because we swapped, move to prev

        return head;
    }
}