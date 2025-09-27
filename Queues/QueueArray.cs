using System;

class QueueArray
{
    class Queue
    {
        static int[] arr;
        static int size;
        static int rear;
        
        public Queue(int n)
        {
            arr = new int[n];
            size = n;
            rear = -1;
        }
        
        public bool IsEmpty()
        {
            return rear == -1;
        }
        
        public void Add(int data)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            rear++;
            arr[rear] = data;
        }
        
        public int Remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int front = arr[0];
            for (int i = 0; i < rear; i++)
            {
                arr[i] = arr[i + 1];
            }
            rear--;
            return front;
        }
        
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            return arr[0];
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Queue Implementation using Array");
        Console.WriteLine("================================\n");
        Queue queue = new(5);
        Console.WriteLine("Is queue empty? " + queue.IsEmpty());
        Console.WriteLine("\nAdding elements to the queue:");
        queue.Add(10);
        queue.Add(20);
        queue.Add(30);
        queue.Add(40);
        queue.Add(50);
        Console.WriteLine("Trying to add 60 to full queue:");
        queue.Add(60);
        Console.WriteLine("\nFront element: " + queue.Peek());
        Console.WriteLine("\nRemoving elements from the queue:");
        Console.WriteLine("Removed: " + queue.Remove());
        Console.WriteLine("Removed: " + queue.Remove());
        Console.WriteLine("Front element after removals: " + queue.Peek());
        Console.WriteLine("\nAdding more elements:");
        queue.Add(60);
        queue.Add(70);
        Console.WriteLine("\nRemoving all remaining elements:");
        while (!queue.IsEmpty())
        {
            Console.WriteLine("Removed: " + queue.Remove());
        }
        Console.WriteLine("\nTrying to remove from empty queue:");
        queue.Remove();
        
        Console.WriteLine("Is queue empty? " + queue.IsEmpty());
    }
}