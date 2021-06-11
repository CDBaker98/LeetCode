/*
Problem 1365:
Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it.
That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
Return the answer in an array.
*/

public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] counts = new int[101];

        for (int i = 0; i < nums.Length; i++) {
            counts[nums[i]]++;
        }

        for (int i = 1; i < counts.Length; i++) {
            counts[i] += counts[i - 1];
        }

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                nums[i] = 0;
            }
            else {
                nums[i] = counts[nums[i] - 1];
            }
        }

        return nums;
    }
}
