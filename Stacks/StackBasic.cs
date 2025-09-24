class StackBasic
{
    static class StackArray
    {
        private int[] elements;
        private int top;

        public StackArray(int size)
        {
            elements = new int[size];
            top = -1;
        }

        public void Push(int item)
        {
            if (top == elements.Length - 1)
            {
                throw new StackOverflowException("Stack is full");
            }
            elements[++top] = item;
        }

        public int Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return elements[top--];
        }

        public int Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return elements[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }
    static class StackLinkedList
    {
        private class Node
        {
            public int Data;
            public Node Next;
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;

        public StackLinkedList()
        {
            top = null;
        }

        public void Push(int item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int item = top.Data;
            top = top.Next;
            return item;
        }

        public int Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}