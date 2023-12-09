namespace PreparingToAlgoritmsInteview;

// Решил сам, минут за 8
internal class PalindromeLinkedList_234
{
    public PalindromeLinkedList_234()
    {
        var listNode4 = new ListNode(1);
        var listNode3 = new ListNode(2, listNode4);
        var listNode2 = new ListNode(2, listNode3);
        var listNode1 = new ListNode(1, listNode2);

        var listNode6 = new ListNode(2);
        var listNode5 = new ListNode(1, listNode6);

        Console.WriteLine(IsPalindrome(listNode1));
        Console.WriteLine(IsPalindrome(listNode5));
    }

    public bool IsPalindrome(ListNode head)
    {
        var list = new List<string>();

        ListNode tail = head;

        while (tail is not null)
        {
            list.Add(tail.val.ToString());
            tail = tail.next;
        }
            
        for (int i = 0, j = list.Count - 1; i < j; i++, j--)
        {
            if (list[i] != list[j])
                return false;

            if (i == j)
                break;
        }

        return true;
    }
}