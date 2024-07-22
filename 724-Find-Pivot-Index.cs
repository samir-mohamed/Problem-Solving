public class Solution {
    public int PivotIndex(int[] nums) {
        var leftSum = 0;
        var sum = nums.Sum();
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - leftSum - nums[i])
                return i;
            leftSum += nums[i];
        }

        return -1;
    }
}