public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            int needed = target - nums[i];
            int indexOfPair = Array.IndexOf(
                nums,
                needed,
                i + 1
            );

            if (indexOfPair >= 0) {
                return new int[] {i, indexOfPair};
            }
        }
        return new int[]{};
    }
}
