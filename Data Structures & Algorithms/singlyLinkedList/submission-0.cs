#nullable enable

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val, ListNode? next = null) {
        this.val = val;
        this.next = next;
    }
}

public class LinkedList
{
    // head is a dummy node
    public ListNode head;
    public ListNode tail;

    public LinkedList()
    {
        head = new ListNode(-1);
        tail = head;
    }

    public int Get(int index)
    {
        if (index < 0)
        {
            return -1;
        }

        ListNode? current = head.next;
        int i = 0;

        while (current != null)
        {
            if (i == index)
            {
                return current.val;
            }

            i++;
            current = current.next;
        }

        return -1;
    }

    public void InsertHead(int val)
    {
        ListNode newNode = new ListNode(val, head.next);
        head.next = newNode;

        if (tail == head)
        {
            tail = newNode;
        }
    }

    public void InsertTail(int val)
    {
        ListNode newNode = new ListNode(val);
        tail.next = newNode;
        tail = newNode;
    }

    public bool Remove(int index)
    {
        if (index < 0)
        {
            return false;
        }

        ListNode current = head;
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
        ListNode? current = head.next;

        while (current != null)
        {
            results.Add(current.val);
            current = current.next;
        }

        return results;
    }
}