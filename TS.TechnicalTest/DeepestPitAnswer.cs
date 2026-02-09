namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        // Step 1: If there are fewer than 3 points, we cannot form a pit -> return -1.
        //
        // Step 2: Scan left-to-right using an index.
        //
        // Step 3: For each scan:
        //   3.1) Find the start of a descent (P):
        //        Move forward while points[i] <= points[i+1].
        //        When it stops, i is the start of descent.
        //
        //   3.2) Walk down to the bottom (Q):
        //        Move forward while points[i] > points[i+1].
        //        If we did not move, there was no descent -> continue scanning.
        //
        //   3.3) Walk up to the first ridge (R):
        //        Move forward while points[i] < points[i+1].
        //        If we did not move up, there is no pit -> continue scanning.
        //
        //   3.4) Validate and calculate pit depth:
        //        Only count it if the start height is at/above ground (>= 0).
        //        depth = Min( (P - Q), (R - Q) )
        //        Track the biggest depth found.
        //
        // Step 4: Return the biggest depth found, or -1 if none.

        throw new NotImplementedException("Not completed yet");
    }
}
