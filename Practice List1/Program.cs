using System;
/*You are given two non-empty linked lists representing two non-negative integers. 
 * The digits are stored in reverse order and each of their nodes contain a single digit. 
 * Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
 * */
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
    public ListNode()
    { next = null; }
}
public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;

        ListNode res = new ListNode(0);
        ListNode curr = res;
        int rem = 0;

        while (l1 != null || l2 != null)
        {
            int sum1 = 0, sum2 = 0;
            if (l1 != null)
                sum1 = l1.val;
            if (l2 != null)
                sum2 = l2.val;

            int sum = sum1 + sum2 + rem;
            rem = sum / 10;

            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
        }
        if (rem > 0)
        {
            //add ListNode
            curr.next = new ListNode(rem);
        }
        return res.next;
    }

    public static void Main()
    {
        ListNode l1 = new ListNode(2);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(3);

        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        //l2.next.next = new ListNode(4);

        ListNode list = AddTwoNumbers(l1, l2);
        while (list != null)
        {
            Console.WriteLine(list.val);
            list = list.next;
        }
    }
}