/*
Problem 3:
Given a string s, find the length of the longest substring without repeating characters.
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int res = 0;

        for (int i = 0; i < s.Length; i++) {
            int temp = 0;
            string sub = "";

            for (int j = i; j < s.Length && !sub.Contains(s[j]); j++) {
                sub += s[j];
                temp++;
            }

            if (temp > res) {
                res = temp;
            }
        }

        return res;
    }
}
