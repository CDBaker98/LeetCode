/*
Problem 9:
Given an integer x, return true if x is palindrome integer.
An integer is a palindrome when it reads the same backward as forward.
For example, 121 is palindrome while 123 is not.
*/

public class Solution {
    public bool IsPalindrome(int x) {
        char[] xArr = x.ToString().ToCharArray();
        char[] xArrRev = x.ToString().ToCharArray();
        bool res = true;

        Array.Reverse(xArrRev);

        for (int i = 0; i < xArr.Length; i++) {
            if (xArr[i] != xArrRev[i]) {
                res = false;
            }
        }

        return res;
    }
}
