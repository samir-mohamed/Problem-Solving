public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var k = 0;
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dictionary.ContainsKey(nums[i]))
            {
                dictionary[nums[i]] = 1;
                nums[k++] = nums[i];
            }
            else if(dictionary[nums[i]] == 1)
            {
                dictionary[nums[i]]++;
                nums[k++] = nums[i];
            }
        }

        return k;
    }
}