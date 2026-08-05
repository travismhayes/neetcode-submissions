public class ListNode {
    public ListNode? prev;
    public ListNode? next;
    public int val;

    public ListNode(int val) {
        this.prev = null;
        this.next = null;
        this.val = val;
    }   
}

public class MyLinkedList {
    private ListNode head;
    private ListNode tail;

    public MyLinkedList() {
        head = new ListNode(-1);
        tail = new ListNode(-1);
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int index) {
        ListNode current = head.next;
        while (current != null && index > 0) {
            index--;
            current = current.next;
        }
        if (current != null && index == 0 && current != tail) {
            return current.val;
        }
        return -1;
    }
    
    public void AddAtHead(int val) {
        ListNode node = new ListNode(val);
        ListNode next = head.next;
        ListNode previous = head;

        next.prev = node;
        previous.next = node;
        node.next = next;
        node.prev = previous;
    }
    
    public void AddAtTail(int val) {
        ListNode node = new ListNode(val);
        ListNode next = tail;
        ListNode previous = tail.prev;

        next.prev = node;
        previous.next = node;
        node.next = next;
        node.prev = previous;
    }
    
    public void AddAtIndex(int index, int val) {
        ListNode current = head.next;
        while (current != null && index > 0) {
            index--;
            current = current.next;
        }
        if (current != null && index == 0) {
            ListNode node = new ListNode(val);
            ListNode next = current;
            ListNode previous = current.prev;

            next.prev = node;
            previous.next = node;
            node.next = next;
            node.prev = previous;
        }

    }
    
    public void DeleteAtIndex(int index) {
        ListNode current = head.next;
        while (current != null && index > 0) {
            index--;
            current = current.next;
        }
        if (current != null && index == 0 && current != tail) {
            ListNode next = current.next;
            ListNode previous = current.prev;
            next.prev = previous;
            previous.next = next;
        }

    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */