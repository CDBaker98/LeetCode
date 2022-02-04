/*
Problem 6:
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this:
    P   A   H   N
    A P L S I I G
    Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows.
*/

public class Solution {
    public string Convert(string s, int numRows) {
        string res = "";
        string[] arr = new string[numRows];
        int currRow = 0;
        bool incRow = true;

        for (int i = 0; i < s.Length; i++) {
            arr[currRow] += s[i];

            if (currRow == 0) {
                incRow = true;
            }
            else if (currRow == numRows - 1) {
                incRow = false;
            }
            if (incRow && currRow != numRows - 1) {
                currRow++;
            }
            else if (!incRow && currRow != 0) {
                currRow--;
            }
        }

        for (int j = 0; j < numRows; j++) {
            res += arr[j];
        }

        return res;
    }
}
