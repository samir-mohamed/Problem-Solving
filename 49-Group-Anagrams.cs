public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dictionary = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            var sortedStr = new string(str.OrderBy(c => c).ToArray());
            if (dictionary.ContainsKey(sortedStr))
                dictionary[sortedStr].Add(str);
            else
                dictionary.Add(sortedStr, new List<string> { str });
        }

        return new List<IList<string>>(dictionary.Values);
    }
}