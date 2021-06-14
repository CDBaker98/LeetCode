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

        List<int> temp1 = new List<int>();
        List<int> temp2 = new List<int>();
        List<int> resultList = new List<int>();
        int count1 = 0, count2 = 0;

        while (l1 != null) {
            temp1.Insert(count1, l1.val);
            count1++;
            l1 = l1.next;
        }
        while (l2 != null) {
            temp2.Insert(count2, l2.val);
            count2++;
            l2 = l2.next;
        }

        int total = count1 + count2;
        int ind1 = 0, ind2 = 0;

        for (int i = 0; i < total; i++) {
            if (ind1 == count1) {
                resultList.Insert(i, temp2[ind2]);
                ind2++;
            }
            else if (ind2 == count2) {
                resultList.Insert(i, temp1[ind1]);
                ind1++;
            }
            else if (temp1[ind1] <= temp2[ind2]) {
                resultList.Insert(i, temp1[ind1]);
                ind1++;
            }
            else {
                resultList.Insert(i, temp2[ind2]);
                ind2++;
            }
        }

        ListNode res = new ListNode(resultList[0]);
        ListNode temp = res;

        for (int i = 1; i < total; i++) {
            temp.next = new ListNode(resultList[i]);
            temp = temp.next;
        }

        return res;
    }
}
