public class Solution {
    public int LengthOfLastWord(string s) {
        return s.Trim()
            .Split(' ')
            .Where(o => o.Length > 0)
            .Last()
            .Length;
    }
}