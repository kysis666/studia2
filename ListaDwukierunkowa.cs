public class Node
{
    public int data;
    public Node next;
    public Node prev;
}

public class DoublyLinkedList
{
    public Node head;

    public static void Main(string[] args)
    {
        var list = new DoublyLinkedList();

        list.AddToFront(1);
        list.AddToFront(1);
        list.RemoveFirst();
        list.AddToEnd(2);
        list.AddToEnd(3);
        list.AddToFront(0);
        list.RemoveLast();

        list.Print();
    }

    public void AddToFront(int data)
    {
        Node newNode = new Node
        {
            data = data,
            next = head,
            prev = null
        };

        if (head != null)
        {
            head.prev = newNode;
        }

        head = newNode;
    }

    public void AddToEnd(int data)
    {
        Node newNode = new Node { data = data };

        if (head == null)
        {
            newNode.prev = null;
            head = newNode;
            return;
        }

        Node last = head;
        while (last.next != null)
        {
            last = last.next;
        }

        last.next = newNode;
        newNode.prev = last;
    }

    public void RemoveFirst()
    {
        if (head == null)
        {
            return;
        }

        head = head.next;
        head.prev = null;
    }

    public void RemoveLast()
    {
        if (head == null)
        {
            return;
        }

        if (head.next == null)
        {
            head = null;
            return;
        }

        Node last = head;
        while (last.next != null)
        {
            last = last.next;
        }

        last.prev.next = null;
    }

    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            Console.WriteLine();
            current = current.next;
        }
    }
}