namespace MiddleOfTheLinkedList;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static ListNode MiddleNode(ListNode head)
    {
        if (head.next == null)
        {
            return head;
        }

        ListNode slow = head;
        ListNode fast = head;

        while (fast.next != null)
        {
            if (fast.next.next == null)
            {
                slow = slow.next;
                break;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
