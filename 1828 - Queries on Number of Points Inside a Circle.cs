/*
Problem 1828:
You are given an array points where points[i] = [xi, yi] is the coordinates of the ith point on a 2D plane.
Multiple points can have the same coordinates.
You are also given an array queries where queries[j] = [xj, yj, rj] describes a circle centered at (xj, yj) with a radius of rj.
For each query queries[j], compute the number of points inside the jth circle.
Points on the border of the circle are considered inside.
Return an array answer, where answer[j] is the answer to the jth query.
*/

public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int[] counts = new int[queries.Length];

        for (int i = 0; i < queries.Length; i++) {
            for (int j = 0; j < points.Length; j++) {
                if (Math.Pow(queries[i][0] - points[j][0], 2) + Math.Pow(queries[i][1] - points[j][1], 2) <= Math.Pow(queries[i][2], 2)) {
                    counts[i]++;
                }
            }
        }

        return counts;
    }
}
