public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            var diff = target - numbers[i];
            if (dictionary.ContainsKey(diff))
                return [dictionary[diff] + 1, i + 1];
            else if (dictionary.ContainsKey(numbers[i]))
                continue;
            else
                dictionary.Add(numbers[i], i);
        }

        return [-1, -1];
    }
}