public class Solution {
    public void SortColors(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            var isSorted = true;
            for (int j = 0; j < nums.Length - 1 - i; j++)
                if (nums[j] > nums[j + 1])
                {
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    isSorted = false;
                }

            if (isSorted)
                break;
        }
    }
}