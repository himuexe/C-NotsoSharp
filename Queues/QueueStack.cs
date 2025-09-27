using System;
using System.Collections.Generic;

class QueueStack
{
    public class Queue
    {
        private Stack<int> s1 = new Stack<int>();
        private Stack<int> s2 = new Stack<int>();
        
        public bool IsEmpty()
        {
            return s1.Count == 0;
        }
        
        public void Add(int data)
        {
            while (s1.Count != 0)
            {
                s2.Push(s1.Pop());
            }
            s1.Push(data);
            while (s2.Count != 0)
            {
                s1.Push(s2.Pop());
            }
        }
        
        public int Remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            return s1.Pop();
        }
        
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            return s1.Peek();
        }
    }

    // Main method
    public static void Main(string[] args)
    {
        Console.WriteLine("Queue Implementation using Two Stacks");
        Console.WriteLine("====================================\n");
        
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
        
        // Peek after adding new elements
        Console.WriteLine("Front element after adding new elements: " + queue.Peek());
        
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
        
        // Test the FIFO behavior
        Console.WriteLine("\nTesting FIFO behavior:");
        queue.Add(100);
        queue.Add(200);
        queue.Add(300);
        
        Console.WriteLine("First removed should be 100: " + queue.Remove());
        Console.WriteLine("Second removed should be 200: " + queue.Remove());
        Console.WriteLine("Third removed should be 300: " + queue.Remove());
        
        Console.WriteLine("Is queue empty? " + queue.IsEmpty());
    }
}