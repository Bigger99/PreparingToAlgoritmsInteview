using System.Data;

namespace PreparingToAlgoritmsInteview;

// Решил сам, но решение не засчиталось ("Testcases passed, but took too long.")
internal class SortList_148
{
    public SortList_148()
    {
        var listNode4 = new ListNode(3);
        var listNode3 = new ListNode(1, listNode4);
        var listNode2 = new ListNode(2, listNode3);
        var listNode1 = new ListNode(4, listNode2);

        var listNode9 = new ListNode(0);
        var listNode8 = new ListNode(4, listNode9);
        var listNode7 = new ListNode(3, listNode8);
        var listNode6 = new ListNode(5, listNode7);
        var listNode5 = new ListNode(-1, listNode6);

        SortList(listNode1);
        SortList(listNode5);
    }

    public ListNode SortList(ListNode head)
    {
        ListNode dummy = new ListNode(0);
        ListNode temp = dummy;
        List<int> list = new();

        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }
        list.Sort();

        foreach (var item in list)
        {
            temp.next = new ListNode(item);
            temp = temp.next;
        }

        return dummy.next;

        //////////////////////////////////////////////// My first try //////////////////////////////////////////////////
        //var queue = new Queue<ListNode>();

        //while (head is not null)
        //{
        //    var temp = head;
        //    queue.Enqueue(head);
        //    head = head.next;
        //    temp.next = null;
        //}

        //if (!queue.TryDequeue(out var firstElem))
        //    return null;

        //head = firstElem;

        //while (queue.Count > 0)
        //{
        //    var nextNode = queue.Dequeue();
        //    var temp = head;

        //    while (temp is not null)
        //    {
        //        if (temp.val > nextNode.val)
        //        {
        //            nextNode.next = temp;
        //            head = nextNode;
        //            break;
        //        }
        //        else if (temp.next is null)
        //        {
        //            temp.next = nextNode;
        //            break;
        //        }
        //        else
        //        {
        //            if (temp.next.val > nextNode.val)
        //            {
        //                nextNode.next = temp.next;
        //                temp.next = nextNode;
        //                break;
        //            }
        //        }

        //        temp = temp.next;
        //    }    
        //}

        //return head;
    }
}
