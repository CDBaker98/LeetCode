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