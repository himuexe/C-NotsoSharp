using System;

class LLBasic
{
    public class Node
    {
        public int data;
        public Node next;
        
        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }
    
    static Node head;
    
    public static Node AddToFront(int newData)
    {
        if (head == null)
        {
            head = new Node(newData);
            return head;
        }
        Node newNode = new Node(newData);
        newNode.next = head;
        head = newNode;
        return head;
    }
    
    public static Node AddToLast(int newData)
    {
        if (head == null)
        {
            head = new Node(newData);
            return head;
        }
        Node newNode = new Node(newData);
        Node current = head;
        while (current.next != null)
        {
            current = current.next;
        }
        current.next = newNode;
        return head;
    }
    public static Node RemoveFromFront()
    {
        if (head == null)
        {
            return null;
        }
        head = head.next;
        return head;
    }
    public static Node RemoveFromLast()
    {
        if (head == null || head.next == null)
        {
            head = null;
            return head;
        }
        Node current = head;
        while (current.next.next != null)
        {
            current = current.next;
        }
        current.next = null;
        return head;
    }
    public static Node AddAfter(Node prevNode, int newData)
    {
        if (prevNode == null)
        {
            Console.WriteLine("The given previous node cannot be null.");
            return head;
        }
        Node newNode = new Node(newData);
        newNode.next = prevNode.next;
        prevNode.next = newNode;
        return head;
    }
    public static Node RemoveAfter(Node prevNode)
    {
        if (prevNode == null || prevNode.next == null)
        {
            return head;
        }
        prevNode.next = prevNode.next.next;
        return head;
    }
    
    static void PrintList(Node head)
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }
    
    public static void Main(string[] args)
    {
        AddToFront(10);
        AddToFront(20);
        AddToFront(30);
        AddToLast(40);
        AddToLast(50);
        RemoveFromFront();
        RemoveFromLast();
        AddAfter(head.next, 25);
        RemoveAfter(head);
        PrintList(head);
    }
}