public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0) return "";
        if(strs.Length == 1) return strs[0];

        var str = strs[0];
        for (int i = 1; i < strs.Length; i++)
            while (strs[i].IndexOf(str) != 0)
                str = str.Substring(0, str.Length - 1);

        return str;
    }
}