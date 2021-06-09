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