// Concept --> Search a key in a Linked List
// C# Program to search a key in a linked list
// GFG Problem --> https://practice.geeksforgeeks.org/problems/search-a-key-in-linked-list/1
// Time Complexity --> O(N)
/*
class Node
{
    public int data;
    public Node next;

    public Node(int x)
    {
        data = x;
        next = null;
    }
}
*/
class Solution
{
    public bool searchKey(Node head, int key)
    {
        // code here
        Node current = head;
        while (current != null)
        {
            if (current.data == key) return true;
            current = current.next;
        }
        return false;
    }
}
