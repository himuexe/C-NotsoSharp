using System;

class QueueLL
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class Queue
    {
        private Node head = null;
        private Node tail = null;
        
        public bool IsEmpty()
        {
            return tail == null && head == null;
        }
        
        public void Add(int data)
        {
            Node nn = new Node(data);
            if (tail == null)
            {
                tail = head = nn;
                return;
            }
            tail.next = nn;
            tail = nn;
        }
        
        public int Remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            int front = head.data;
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
            }
            return front;
        }
        
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return head.data;
        }
    }

    // Main method
    public static void Main(string[] args)
    {
        Console.WriteLine("Queue Implementation using Linked List");
        Console.WriteLine("=====================================\n");
        
        // Create a queue
        Queue queue = new Queue();
        
        // Test isEmpty on empty queue
        Console.WriteLine("Is queue empty? " + queue.IsEmpty());
        
        // Add elements to the queue
        Console.WriteLine("\nAdding elements to the queue:");
        queue.Add(10);
        queue.Add(20);
        queue.Add(30);
        queue.Add(40);
        queue.Add(50);
        
        // Peek at the front element
        Console.WriteLine("Front element: " + queue.Peek());
        
        // Remove elements from the queue
        Console.WriteLine("\nRemoving elements from the queue:");
        Console.WriteLine("Removed: " + queue.Remove());
        Console.WriteLine("Removed: " + queue.Remove());
        
        // Peek again after removals
        Console.WriteLine("Front element after removals: " + queue.Peek());
        
        // Add more elements
        Console.WriteLine("\nAdding more elements:");
        queue.Add(60);
        queue.Add(70);
        
        // Remove all elements
        Console.WriteLine("\nRemoving all remaining elements:");
        while (!queue.IsEmpty())
        {
            Console.WriteLine("Removed: " + queue.Remove());
        }
        
        // Try to remove from empty queue
        Console.WriteLine("\nTrying to remove from empty queue:");
        queue.Remove();
        
        Console.WriteLine("Is queue empty? " + queue.IsEmpty());
        
        // Test edge case - single element queue
        Console.WriteLine("\nTesting single element queue:");
        queue.Add(100);
        Console.WriteLine("Front element: " + queue.Peek());
        Console.WriteLine("Removed: " + queue.Remove());
        Console.WriteLine("Is queue empty? " + queue.IsEmpty());
    }
}