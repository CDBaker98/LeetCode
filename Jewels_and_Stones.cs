/*
Problem 771:
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have.
Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
Letters are case sensitive, so "a" is considered a different type of stone from "A".
*/

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;

        foreach (char c in jewels) {
            count += stones.Where(x => x == c).Count();
        }

        return count;
    }
}
