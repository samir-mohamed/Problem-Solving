public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        var set1 = new HashSet<int>(nums1).Except(nums2).ToArray();
        var set2 = new HashSet<int>(nums2).Except(nums1).ToArray();
        return [set1, set2];
    }
}