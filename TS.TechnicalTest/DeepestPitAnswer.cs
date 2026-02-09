namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        // Step 1: If there are fewer than 3 points, we cannot form a pit, return -1.
        if (points == null || points.Length < 3)
            return -1;

        int length = points.Length;
        int deepestPitDepth = -1;

        // Index that we move from left to right
        int currentIndex = 0;

        // We need at least 2 elements ahead to form P, Q, R
        while (currentIndex < length - 2)
        {
            // 1) Find start of descent (P)
            // Move forward until the next point is lower.
            while (currentIndex < length - 1 && points[currentIndex] <= points[currentIndex + 1])
            {
                currentIndex++;
            }

            int startOfDescentIndex = currentIndex;

            break; 
        }

        return deepestPitDepth;
    }
}
