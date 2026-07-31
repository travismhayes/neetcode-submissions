public class ListNode {
    public int value;
    public ListNode? next;

    public ListNode(int val, ListNode? next = null) {
        this.value = val;
        this.next = next;
    }
}

public class LinkedList {
    // need head and tails properties
    private ListNode? head;
    private ListNode? tail;

    public LinkedList() {
        this.head = new ListNode(-1);
        this.tail = this.head;
    }

    public int Get(int index) {
        int count = 0;
        ListNode current = this.head.next;  // skip the dummy

        while (current != null) {
            if (index == count)
                return current.value;
            count++;
            current = current.next;
        }
        return -1;
    }

    public void InsertHead(int val) {
        ListNode newNode = new ListNode(val);
        // assign new node after dummy and update remeferences
        newNode.next = head.next;
        head.next = newNode;
        // edge case list empty prior to insert.
        if (newNode.next == null) {
            tail = newNode;
        }
    }

    public void InsertTail(int val) {
        this.tail.next = new ListNode(val);
        this.tail = this.tail.next;
    }

    public bool Remove(int index) {
        // find the node before the node we want to remove
        int i = 0;
        ListNode current = this.head;  // start at dummy
        while (i < index && current != null) {
            i++;
            current = current.next;
        }

        if (current != null && current.next != null) {
            if (current.next == this.tail) {
                this.tail = current;
            }
            current.next = current.next.next;
            return true;
        }

        return false;
    }

    public List<int> GetValues() {
        List<int> results = new List<int>();

        ListNode current = this.head.next;

        while (current != null) {
            results.Add(current.value);
            current = current.next;
        }

        return results;
    }
}