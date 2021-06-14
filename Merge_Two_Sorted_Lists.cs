/*
Problem 21:
Merge two sorted linked lists and return it as a sorted list.
The list should be made by splicing together the nodes of the first two lists.
*/

public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 is null) {
            return l2;
        }
        if (l2 is null) {
            return l1;
        }

        ListNode res;

        if (l1.val <= l2.val) {
            res = new ListNode(l1.val);
            l1 = l1.next;
        }
        else {
            res = new ListNode(l2.val);
            l2 = l2.next;
        }

        ListNode temp = res;

        while (l1 != null || l2 != null) {
            if (l1 == null) {
                temp.next = new ListNode(l2.val);
                temp = temp.next;
                l2 = l2.next;
            }
            else if (l2 == null) {
                temp.next = new ListNode(l1.val);
                temp = temp.next;
                l1 = l1.next;
            }
            else if (l1.val <= l2.val) {
                temp.next = new ListNode(l1.val);
                temp = temp.next;
                l1 = l1.next;
            }
            else {
                temp.next = new ListNode(l2.val);
                temp = temp.next;
                l2 = l2.next;
            }
        }

        return res;
    }
}
