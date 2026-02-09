namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        // Step 1: If the input is empty, return 0.
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        // Step 2: Split the text into sentences using '.', '?', '!'.
        string[] sentences = s.Split(['.', '?', '!']);

        throw new NotImplementedException("Not completed yet");
    }
}
