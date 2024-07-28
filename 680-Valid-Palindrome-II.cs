public class Solution {
    public bool ValidPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        while (left < right && s[left] == s[right])
        {
            left++;
            right--;
        }

        if (left >= right)
            return true;

        return IsPalendrome(s, left + 1, right) || IsPalendrome(s, left, right - 1);
    }

    private static bool IsPalendrome(string s, int left, int right)
    {
        while (left < right)
            if (s[left++] != s[right--])
                return false;
        return true;
    }
}