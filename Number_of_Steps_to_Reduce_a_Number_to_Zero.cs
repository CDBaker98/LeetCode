/*
Problem 1342:
Given a non-negative integer num, return the number of steps to reduce it to zero.
If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.*/

public class Solution {
    public int NumberOfSteps(int num) {
        int count = 0;

        while (num > 0) {
            if (num % 2 == 0) {
                num /= 2;
            }
            else {
                num -= 1;
            }

            count++;
        }

        return count;
    }
}
