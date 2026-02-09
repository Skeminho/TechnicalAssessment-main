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

        // Step 4: Track the biggest word count we see.
        int maxWords = 0;

        // Step 3: For each sentence, we will count its valid words.
        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i];

        }

        // Step 5: Return that biggest count.
        return maxWords;
    }
}
