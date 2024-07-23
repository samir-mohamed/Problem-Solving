public class Solution {
    public int ArraySign(int[] nums) {
        if (nums.Contains(0)) return 0;

        var negativeCount = 0;
        foreach(var num in nums)
            if(num < 0) negativeCount++;

        return negativeCount % 2 == 0 ? 1 : -1;
    }
}