public class Solution {
    public void MoveZeroes(int[] nums) {
        var i = 0;
        foreach (var num in nums)
            if (num != 0)
                nums[i++] = num;

        while (i < nums.Length)
            nums[i++] = 0;
    }
}