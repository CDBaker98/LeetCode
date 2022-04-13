/*
Problem 5:
Given a string s, return the longest palindromic substring in s.
*/

public class Solution {
    public string LongestPalindrome(string s) {
        if (s == null || s.Length == 0) {
            return "";
        }

        int maxStart = 0, maxEnd = 0;

        for (int i = 0; i < s.Length; i++) {
            int start = i, end = i;

            while ((start > 0 && end < s.Length - 1 && s[start - 1] == s[end + 1])) {
                start--;
                end++;
            }

            if (end - start > maxEnd - maxStart) {
                maxStart = start;
                maxEnd = end;
            }

            if (i < s.Length - 1 && s[i] == s[i + 1]) {
                start = i; end = i + 1;

                while ((start > 0 && end < s.Length - 1 && s[start - 1] == s[end + 1])) {
                    start--;
                    end++;
                }

                if (end - start > maxEnd - maxStart) {
                    maxStart = start;
                    maxEnd = end;
                }
            }
        }

        return s.Substring(maxStart, maxEnd - maxStart + 1);
    }
}