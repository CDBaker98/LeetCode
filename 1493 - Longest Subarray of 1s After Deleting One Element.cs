/*
Problem 1493:
Given a binary array nums, you should delete one element from it.
Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.
*/

public class Solution {
    public int LongestSubarray(int[] nums) {
        if (nums.Contains(0) == false) { return nums.Length - 1; }
        
        int res = 0;
        int curr = 0;
        int next = 0;

        for (int i=0; i<nums.Length; i++) {
            if (nums[i] == 0) {
                res = Math.Max(res, curr);
                curr = next;
                next = 0;
            }
            else {
                curr++;
                next++;
            }
        }

        return Math.Max(res, curr);
    }
}