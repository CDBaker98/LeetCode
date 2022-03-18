/*
Problem 2:
You are given two non-empty linked lists representing two non-negative integers.
The digits are stored in reverse order, and each of their nodes contains a single digit.
Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode res = new ListNode(l1.val + l2.val);
        ListNode temp = res;
        l1 = l1.next;
        l2 = l2.next;

        while (l1 != null || l2 != null) {
            if (l1 == null) {
                temp.next = new ListNode(l2.val);
                l2 = l2.next;
                temp = temp.next;
            }
            else if (l2 == null) {
                temp.next = new ListNode(l1.val);
                l1 = l1.next;
                temp = temp.next;
            }
            else {
                temp.next = new ListNode(l1.val + l2.val);
                l1 = l1.next;
                l2 = l2.next;
                temp = temp.next;
            }
        }

        temp = res;
        while (temp != null) {
            if (temp.val % 10 != temp.val) {
                if (temp.next == null) {
                    temp.next = new ListNode(1);
                }
                else {
                    temp.next.val++;
                }

                temp.val -= 10;
            }

            temp = temp.next;
        }

        return res;
    }
}
