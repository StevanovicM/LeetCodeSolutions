public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1)
        {
            return intervals;
        }

        // Sort intervals by their start value
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        int[] currentInterval = intervals[0];
        merged.Add(currentInterval); // Add the first interval to the list as a starting point

        foreach (var interval in intervals)
        {
            int currentEnd = currentInterval[1];
            int nextStart = interval[0];
            int nextEnd = interval[1];

            if (currentEnd >= nextStart)
            {
                // There is an overlap
                currentInterval[1] = Math.Max(currentEnd, nextEnd); // Merge the intervals
            }
            else 
            {
                // No overlap
                currentInterval = interval; // Move to the next interval
                merged.Add(currentInterval); // And add it as a new one
            }
        }

        return merged.ToArray();
    }
}