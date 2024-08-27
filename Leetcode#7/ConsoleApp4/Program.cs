namespace ConsoleApp4
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // Create a dummy node to act as the start of the merged list
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            // Traverse through both lists
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Append the remaining nodes from list1 or list2
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            // Return the merged list, which starts from dummy.next
            return dummy.next;
        }
    }
}
