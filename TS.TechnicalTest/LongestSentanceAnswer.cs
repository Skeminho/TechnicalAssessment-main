using System.Linq;

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

            // Split words by spaces (ignore extra spaces).
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            // Count only valid words (must contain at least one letter).
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Any(char.IsLetter))
                    count++;
            }

            // If this sentence has more words, keep it as the best so far.
            if (count > maxWords)
                maxWords = count;
        }

        // Step 5: Return that biggest count.
        return maxWords;
    }
}
