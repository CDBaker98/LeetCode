/*
Problem 13:
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.
*/

public class Solution {
    public int RomanToInt(string s) {
        int len = s.Length;
        int[] arr = new int[len];
        int res = 0;

        for (int i = 0; i < len; i++) {
            if (s[i] == 'I')
                arr[i] = 1;
            else if (s[i] == 'V')
                arr[i] = 5;
            else if (s[i] == 'X')
                arr[i] = 10;
            else if (s[i] == 'L')
                arr[i] = 50;
            else if (s[i] == 'C')
                arr[i] = 100;
            else if (s[i] == 'D')
                arr[i] = 500;
            else if (s[i] == 'M')
                arr[i] = 1000;
        }

        for (int i = 0; i < len - 1; i++) {
            if (arr[i] < arr[i + 1]) {
                arr[i + 1] -= arr[i];
                arr[i] = 0;
            }
        }

        for (int i = 0; i < len; i++)
            if (arr[i] != 0)
                res += arr[i];

        return res;
    }
}