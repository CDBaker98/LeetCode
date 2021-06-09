public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> res = new List<bool>();
        int currMax = candies.Max();

        foreach (int i in candies) {
            if (i + extraCandies >= currMax)
                res.Add(true);
            else
                res.Add(false);
        }

        return res;
    }
}