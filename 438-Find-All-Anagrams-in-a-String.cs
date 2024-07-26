public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var dictionary = new Dictionary<char, int>();

        if(s.Length < p.Length)
            return new List<int>();

        var distinctP = p.Distinct().Count();

        foreach (var ch in p)
            dictionary[ch] = dictionary.GetValueOrDefault(ch, 0) + 1;

        var result = new List<int>();
        var matched = 0;
        var start = 0;
        for (int end = 0; end < s.Length; end++)
        {
            var rightChar = s[end];
            if (dictionary.ContainsKey(rightChar))
            {
                dictionary[rightChar]--;
                if (dictionary[rightChar] == 0)
                    matched++;
            }

            if (end > p.Length - 1)
            {
                var leftChar = s[start++];
                if (dictionary.ContainsKey(leftChar))
                {
                    if (dictionary[leftChar] == 0)
                        matched--;
                    dictionary[leftChar] += 1;
                }
            }

            if (matched == distinctP)
                result.Add(start);
        }

        return result;
    }
}