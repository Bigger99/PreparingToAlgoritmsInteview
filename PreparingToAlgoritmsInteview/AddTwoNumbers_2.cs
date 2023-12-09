namespace PreparingToAlgoritmsInteview;

// Не смог решить сам, подсмотрел
internal class AddTwoNumbers_2
{
    public AddTwoNumbers_2()
    {
        var listNode3 = new ListNode(3);
        var listNode2 = new ListNode(4, listNode3);
        var listNode1 = new ListNode(2, listNode2);

        var listNode6 = new ListNode(4);
        var listNode5 = new ListNode(6, listNode6);
        var listNode4 = new ListNode(5, listNode5);

        AddTwoNumbers(listNode1, listNode4);
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var newList = new ListNode();
        var newNode = newList;
        var temp1 = l1;
        var temp2 = l2;
        var carry = 0;

        while (temp1 is not null || temp2 is not null)
        {
            var val1 = temp1 is null ? 0 : temp1.val;
            var val2 = temp2 is null ? 0 : temp2.val;
            var sum = val1 + val2 + carry;
            carry = sum / 10;
            newNode.next = new ListNode(sum % 10);
            newNode = newNode.next;

            if (sum % 10 == 0)
            {
                newList.val = sum;
                newList.val = sum;
            }

            temp1 = temp1?.next;
            temp2 = temp2?.next;
        }

        if (carry > 0)
        {
            newNode.next = new ListNode(carry);
        }

        return newList.next;
    }
}

//// Realized LinkedList
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