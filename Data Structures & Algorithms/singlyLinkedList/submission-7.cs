#nullable enable

public class Node
{
    public int val;
    public Node? next;

    public Node(int val, Node? node = null) {
        this.val = val;
        this.next = node;
    }
}

public class LinkedList {
    private Node head;
    private Node tail;

    public LinkedList() {
        this.head = new Node(-1); //dummy node
        this.tail = this.head;
    }

    public int Get(int index) {
        if (index < 0) return -1;

        int count = 0;
        Node current = this.head.next;

        while (current != null) {
            if (count == index) return current.val;
            count++;
            current = current.next;
        }
        return -1;
    }

    public void InsertHead(int val)
    {
        Node newNode = new Node(val, head.next);
        head.next = newNode;

        if (tail == head)
        {
            tail = newNode;
        }
    }

    public void InsertTail(int val)
    {
        Node newNode = new Node(val);
        this.tail.next = newNode;
        this.tail = newNode;
    }

    public bool Remove(int index)
    {
        if (index < 0)
        {
            return false;
        }

        Node current = head;
        int i = 0;

        // Move to the node immediately before the node being removed
        while (i < index && current.next != null)
        {
            current = current.next;
            i++;
        }

        if (current.next == null)
        {
            return false;
        }

        if (current.next == tail)
        {
            tail = current;
        }

        current.next = current.next.next;
        return true;
    }

    public List<int> GetValues()
    {
        List<int> results = new List<int>();
        Node? current = head.next;

        while (current != null)
        {
            results.Add(current.val);
            current = current.next;
        }

        return results;
    }
}