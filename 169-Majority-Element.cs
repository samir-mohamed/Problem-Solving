public class Solution {
    public int MajorityElement(int[] nums) {
        var maxApperence = nums.Length / 2;
        var dictionary = new Dictionary<int, int>();
        foreach (var num in nums)
            dictionary[num] = dictionary.GetValueOrDefault(num, 0) + 1;

        foreach (var item in dictionary)
            if (item.Value > maxApperence)
                return item.Key;

        return -1;
    }
}