public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ');
        if (words.Length != pattern.Length)
            return false;

        var patternDictionary = new Dictionary<char, string>();
        var wordsDictionary = new Dictionary<string, char>();
        for (int i = 0; i < pattern.Length; i++)
        {
            var p = pattern[i];
            var w = words[i];
            if (patternDictionary.ContainsKey(p) && patternDictionary[p] != w)
                return false;
            if (wordsDictionary.ContainsKey(w) && wordsDictionary[w] != p)
                return false;

            patternDictionary[p] = w;
            wordsDictionary[w] = p;
        }

        return true;
    }
}