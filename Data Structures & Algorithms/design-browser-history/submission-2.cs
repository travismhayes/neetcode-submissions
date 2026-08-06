public class ListNode {
    public ListNode? prev;
    public ListNode? next;
    public string val;

    public ListNode(string val) {
        this.prev = null;
        this.next = null;
        this.val = val;
    }
}


public class BrowserHistory {
    private ListNode current;

    public BrowserHistory(string homepage) {
        current = new ListNode(homepage);
    }
    
    public void Visit(string url) {
        ListNode node = new ListNode(url);
        current.next = node;
        node.prev = current;
        current = node;
    }
    
    public string Back(int steps) {
        while (current.prev != null && steps > 0) {
            steps--;
            current = current.prev;
        }

        return current.val;
    }
    
    public string Forward(int steps) {
        while (current.next != null && steps > 0) {
            steps--;
            current = current.next;
        }

        return current.val;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */