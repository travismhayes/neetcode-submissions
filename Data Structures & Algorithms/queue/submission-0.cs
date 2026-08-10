public class ListNode {
    public ListNode? next;
    public ListNode? prev;
    public int val;

    public ListNode(int val) {
        this.val = val;
        this.next = null;
        this.prev = null;
    }
}

class Deque {
    public ListNode? head;
    public ListNode? tail;

    public Deque() {
        this.head = null;
        this.tail = null;
    }

    public bool isEmpty() {
        return head == null;
    }

    public void append(int value) {
        ListNode node = new ListNode(value);
        if (head == null) {
            head = node;
            tail = node;
            return;
        }
        tail.next = node;
        node.prev = tail;
        tail = node;
    }

    public void appendleft(int value) {
        ListNode node = new ListNode(value);
        if (head == null) {
            head = node;
            tail = node;
            return;
        }
        node.next = head;
        head.prev = node;
        head = node;
    }

    public int pop() {
        //tail
        //empty
        if (head == null) {
            return -1;
        }
        //single
        int val = tail.val;
        tail = tail.prev;
        if (tail != null) {
            tail.next = null;
        } else {
            head = null;
        }
        return val;
    }

    public int popleft() {
        //head
        if (head == null) {
            return -1;
        }
        
        //single
        int val = head.val;
        head = head.next;
        if (head != null) {
            head.prev = null;
        } else {
            tail = null;
        }
        return val;
    }
}
