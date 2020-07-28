using System;

namespace Add_Two_Numbers
{
    class Program
    {
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

        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(8);

            ListNode l2 = new ListNode();
            Display(AddTwoNumbers(l1, l2));
        }

        public static void Display(ListNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode current = head;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                ListNode newNode = new ListNode();
                int l1val = l1 == null ? 0 : l1.val;
                int l2val = l2 == null ? 0 : l2.val;
                int sum = l1val + l2val + carry;
                int no = sum % 10;
                newNode.val = no;
                current.next = newNode;
                current = newNode;
                carry = sum / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            if(carry > 0)
            {
                ListNode newNode = new ListNode();
                newNode.val = carry;
                current.next = newNode;
            }
            return head.next;
        }
    }
}
