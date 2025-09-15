class DLLBasic
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
    public Node head;
    public Node tail;
    public Node AddFront(int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        if (head != null)
            head.prev = new_node;
        head = new_node;
        return head;
    }
    public Node AddEnd(int new_data)
    {
        Node new_node = new Node(new_data);
        if (head == null)
        {
            head = new_node;
            return head;
        }
        Node last = head;
        while (last.next != null)
            last = last.next;
        last.next = new_node;
        new_node.prev = last;
        return head;
    }
    public Node RemoveNode(int key)
    {
        Node temp = head;
        while (temp != null && temp.data != key)
            temp = temp.next;
        if (temp == null)
            return head;
        if (temp.prev != null)
            temp.prev.next = temp.next;
        else
            head = temp.next;
        if (temp.next != null)
            temp.next.prev = temp.prev;
        return head;
    }
    public void PrintList()
    {
        Node node = head;
        while (node != null)
        {
            System.Console.Write(node.data + " ");
            node = node.next;
        }
        System.Console.WriteLine();
    }
    public void PrintListReverse()
    {
        Node node = head;
        if (node == null) return;
        while (node.next != null)
            node = node.next;
        while (node != null)
        {
            System.Console.Write(node.data + " ");
            node = node.prev;
        }
        System.Console.WriteLine();
    }
}