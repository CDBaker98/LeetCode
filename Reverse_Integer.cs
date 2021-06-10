/*
Given a signed 32-bit integer x, return x with its digits reversed.
If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
*/

public class Solution {
    public int Reverse(int x) {
        int res;
        char[] xArr = x.ToString().ToCharArray();

        if (xArr[0] == '-') {
            for (int i = 1; i < xArr.Length; i++) {
                xArr[i - 1] = xArr[i];
            }

            xArr[xArr.Length - 1] = '-';
        }

        Array.Reverse(xArr);

        try {
            res = int.Parse(xArr);

            return res;
        }
        catch (Exception) {
            return 0;
        }
    }
}