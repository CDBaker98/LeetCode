/*
Problem 1281:
Given an integer number n, return the difference between the product of its digits and the sum of its digits.
*/

public class Solution {
    public int SubtractProductAndSum(int n) {
        List<int> temp = new List<int>();
        int prod = 1, sum = 0;

        temp.Insert(0, n);

        for (int i = 0; temp[i] % 10 != temp[i]; i++) {
            temp.Insert(i + 1, (temp[i] - temp[i] % 10) / 10);
            temp[i] = temp[i] % 10;
        }

        for (int i = 0; i < temp.Count; i++) {
            prod *= temp[i];
            sum += temp[i];
        }

        return (prod - sum);
    }
}
