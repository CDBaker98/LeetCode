/*
Problem 228:
You are given a sorted unique integer array nums.

Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

Each range [a,b] in the list should be output as:
    "a->b" if a != b
    "a" if a == b
*/

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        IList<string> res = new List<string>();

        if (nums.Length == 0) {
            return res;
        }

        string temp = nums[0].ToString();
        int i = 0;
        bool range = false;

        for (i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1] + 1) {
                if (!range) {
                    temp += "->";
                    range = true;
                }
            }
            else {
                if (range) {
                    temp += nums[i - 1].ToString();
                }

                res.Add(temp);
                range = false;
                temp = nums[i].ToString();
            }
        }

        if (temp.Contains("->")) {
            temp += nums[nums.Length - 1];
        }

        res.Add(temp);
        return res;
    }
}