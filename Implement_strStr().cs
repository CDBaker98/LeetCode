/*
Problem 28:
Implement strStr().
Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
*/

public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle == "") {
            return 0;
        }

        for (int i = 0; i <= (haystack.Length - needle.Length); i++) {
            string sub = haystack.Substring(i, needle.Length);

            if (sub == needle) {
                return i;
            }
        }

        return -1;
    }
}
