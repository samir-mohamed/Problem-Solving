public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
        while(left < right) 
        {
            if (!char.IsLetterOrDigit(s[left]))
                left++;
            if (!char.IsLetterOrDigit(s[right]))
                right--;

            if(char.IsLetterOrDigit(s[left]) && char.IsLetterOrDigit(s[right]))
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

        }

        return true;
    }
}