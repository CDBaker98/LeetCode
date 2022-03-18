/*
Problem 66:
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
The digits are ordered from most significant to least significant in left-to-right order.
The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.
*/

public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 1;

        for (int i = digits.Length - 1; i >= 0; i--) {
            int temp = digits[i] + carry;

            digits[i] = temp % 10;
            carry = temp / 10;
        }

        if (carry == 1) {
            List<int> New = new List<int>();

            New.Add(carry);

            foreach (var n in digits)
                New.Add(n);

            return New.ToArray();
        }
        else
            return digits;
    }
}