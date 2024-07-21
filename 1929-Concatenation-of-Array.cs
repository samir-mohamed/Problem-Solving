public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var ans = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length * 2; i++)
            ans[i] = nums[i % nums.Length];
        return ans;
            }
}