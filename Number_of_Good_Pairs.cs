/*
Given an array of integers nums.
A pair (i,j) is called good if nums[i] == nums[j] and i < j.
Return the number of good pairs.
*/

public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int res = 0;

        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] == nums[j])
                    res++;
            }
        }

        return res;
    }
}