/*
You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
Return the wealth that the richest customer has.
*/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int MaxSum = -1;

        foreach (int[] i in accounts) {
            int sum = i.Sum();

            if (sum > MaxSum) {
                MaxSum = sum;
            }
        }

        return MaxSum;
    }
}