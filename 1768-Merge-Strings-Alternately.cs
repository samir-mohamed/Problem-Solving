public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var start1 = 0;
        var start2 = 0;
        var builder = new StringBuilder();
        while (start1 < word1.Length || start2 < word2.Length)
        {
            if (start1 < word1.Length)
                builder.Append(word1[start1++]);
            if (start2 < word2.Length)
                builder.Append(word2[start2++]);
        }

        return builder.ToString();
    }
}