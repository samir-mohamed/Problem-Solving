public class Solution {
    public bool IsAnagram(string s, string t) {
        if(t.Length != s.Length) return false;

        var dictionary = new Dictionary<char, int>();
        foreach (var ch in s)
            dictionary[ch] = dictionary.GetValueOrDefault(ch, 0) + 1;

        foreach (var ch in t)
        {
            if (dictionary.ContainsKey(ch))
                dictionary[ch]--;
            else return false;

            if (dictionary[ch] == 0)
                dictionary.Remove(ch);
        }

        return dictionary.Count == 0;
    }
}