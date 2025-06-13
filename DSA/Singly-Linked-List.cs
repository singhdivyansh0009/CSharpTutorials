using System;

class Node {
    private int data;
    private Node next;

    public int Data {
        get { return data; }
        set { data = value; } 
    }

    public Node Next {
        get { return next; }
        set { next = value; }
    }

    public Node(int data) {
        this.data = data;
        this.next = null;
    }
}

class LinkedList {
    private Node Head = null;

    public void InsertBack(int val) {
        Node newNode = new Node(val);
        
        if (Head == null) {
            Head = newNode;
            return;
        }

        Node cur = Head;
        while (cur.Next != null) {
            cur = cur.Next;
        }
        cur.Next = newNode;
    }

    public void Print() {
        Node cur = Head;
        while (cur != null) {
            Console.WriteLine(cur.Data);
            cur = cur.Next;
        }
    }
     // 1 -> 2 -> 3 -> null
    
    public void Reverse() {
        if(Head == null || Head.Next == null) return;
        Node cur = Head;
        Node prev = null;
        while(cur != null){
            Node next = cur.Next;
            cur.Next = prev;
            prev = cur;
            cur = next;
        }
        Head = prev;
    }
}

public class Program {
    public static void Main(string[] args) {
        LinkedList L1 = new LinkedList();
        L1.InsertBack(10);
        L1.InsertBack(20);
        L1.InsertBack(30);
        L1.Print();
    }
}
