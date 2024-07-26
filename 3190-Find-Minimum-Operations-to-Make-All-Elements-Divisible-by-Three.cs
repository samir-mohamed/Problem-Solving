public class Solution {
    public int MinimumOperations(int[] nums) {
        var res = 0;
        for(int i=0; i<nums.Length; i++)
            res += nums[i] % 3 == 0 ? 0 : 1;
        
        return res;
    }
}